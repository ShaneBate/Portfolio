using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dapper;
using AtlantaCrime.Model;
using System.Globalization;
using System.Text;

namespace AtlantaCrime.Pages
{
    public partial class Landing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = Database.GetConnection())
            {
                var crimes = Crime.SelectAll();
                crimes.Sort((j, i) => DateTime.ParseExact(i.occur_date, "MM/dd/yyyy", CultureInfo.InvariantCulture).CompareTo(DateTime.ParseExact(j.occur_date, "MM/dd/yyyy", CultureInfo.InvariantCulture)));
                var currentCrime = crimes.Take(5);
                StringBuilder htmlTable = new StringBuilder();
                htmlTable.AppendLine("<table class='table table-hover'>");
                htmlTable.AppendLine("<tr>");
                htmlTable.AppendLine("<th><h4>Crime</h4></th><th><h4>Area</h4></th><th><h4>Date</h4></th><th><h4>Time</h4></th>");
                htmlTable.AppendLine("</tr>");
                
                foreach (var crime in currentCrime)
                {
                    htmlTable.AppendLine("<tr>");
                    htmlTable.AppendLine("<td>");
                    htmlTable.AppendLine(crime.uc2Literal);
                    htmlTable.AppendLine("</td>");
                    htmlTable.AppendLine("<td>");
                    htmlTable.AppendLine(crime.neighborhood);
                    htmlTable.AppendLine("</td>");
                    htmlTable.AppendLine("<td>");
                    htmlTable.AppendLine(crime.occur_date);
                    htmlTable.AppendLine("</td>");
                    htmlTable.AppendLine("<td>");
                    var convertedtime = Convert.ToDateTime(crime.occur_time);
                    string tmp = convertedtime.ToString("hh:mm tt", CultureInfo.CreateSpecificCulture("en-US"));
                    htmlTable.AppendLine(tmp);
                    htmlTable.AppendLine("</td>");
                    htmlTable.AppendLine("</tr>");
                }
                
                htmlTable.AppendLine("</table>");

                litTable.Text = htmlTable.ToString();

            }

        }
    }
}
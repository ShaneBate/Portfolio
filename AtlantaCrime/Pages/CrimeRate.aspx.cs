using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using AtlantaCrime.Model;
using Dapper;
using System.Text;

namespace AtlantaCrime.Pages
{
    public partial class CrimeRate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (var db = Database.GetConnection())
                {
                    var crimes = Crime.SelectAll();
                    List<string> tmp = new List<string>();
                    foreach (var crime in crimes)
                    {

                        if (!tmp.Contains(crime.neighborhood))
                        {
                            tmp.Add(crime.neighborhood);
                        }
                    }
                    ddlhood.DataSource = tmp;
                    ddlhood.DataBind();
                }
            }
            
        }

        protected void ddlhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmpNeighborhood = ddlhood.SelectedItem.Text;
            StringBuilder neighborhoodgraph = new StringBuilder();
            neighborhoodgraph.Append("<p>");
            neighborhoodgraph.Append(tmpNeighborhood);
            neighborhoodgraph.Append("<p>");

            lblregion.Text = neighborhoodgraph.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SQLite;

namespace AtlantaCrime.Model
{
    public class Crime
    {
        public long MI_PRINX { get; set; }
        public long offense_id { get; set; }
        public string rpt_date { get; set; }
        public string occur_date{ get; set; }
        public string occur_time { get; set; }
        public string poss_date { get; set; }
        public string poss_time { get; set; }
        public string apt_office_prefix { get; set; }
        public string apt_office_num { get; set; }
        public string location { get; set; }
        public string minOfucr { get; set; }
        public string minOfibr_code { get; set; }
        public string dispo_code { get; set; }
        public long maxOfnum_victims { get; set; }
        public string shift { get; set; }
        public string AvgDay { get; set; }
        public string loc_type { get; set; }
        public string uc2Literal { get; set; }
        public string neighborhood { get; set; }
        public string npu { get; set; }
        public string x { get; set; }
        public string y { get; set; }

        public static List<Crime> SelectAll()
        {
            using (var db = Database.GetConnection())
            {
                var query = "SELECT * FROM COBRA";
                var results = db.Query<Crime>(query);
                return results.ToList();
            }
        }
    }
}
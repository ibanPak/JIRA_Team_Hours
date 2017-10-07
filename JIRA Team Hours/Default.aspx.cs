using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JIRA_Team_Hours;
using Newtonsoft.Json.Converters;
using Newtonsoft;
using Newtonsoft.Json;
using static JIRA_Team_Hours.Class1;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;

namespace JIRA_Team_Hours
{
    public class KeyValue
    {
        public string Key
        {
            get; set;
        }

        public string Value
        {
            get; set;
        }
    }

    public class SpValue
    {
        public string TotalHoursBurnt
        {
            get; set;
        }

        public string TotalHoursRemaining
        {
            get; set;
        }

        public string Response
        {
            get; set;
        }

    }


    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var db = new TestEntities();
                var userlist = db.Database.SqlQuery<KeyValue>("select cast(username as varchar(100)) as [Key], cast(Id as varchar(50)) as Value from jira_team (nolock)").ToList();
                var sprintlist = db.Database.SqlQuery<KeyValue>("select cast(Sprint as varchar(100)) as [Key] , cast(Id as varchar(50)) as Value from [JIRASprint] (nolock)").ToList();

                var users = new List<ListItem>();
                foreach (var u in userlist)
                {
                    users.Add(new ListItem { Text = u.Key, Value = u.Value });
                }
                DdlUser.DataSource = users;
                DdlUser.DataBind();

                var sprints = new List<ListItem>();
                foreach (var s in sprintlist)
                {
                    sprints.Add(new ListItem { Text = s.Key, Value = s.Value });
                }
                DdlSprint.DataSource = sprints;
                DdlSprint.DataBind();
            }
            
        }

        public static T DeserializeObject<T>(string jsonObj)
        {
            return JsonConvert.DeserializeObject<T>(jsonObj,
                new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, Formatting = Formatting.Indented });
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new TestEntities();
            db.Database.CommandTimeout = 400;
            var val = db.Database.SqlQuery<SpValue>("EXEC [dbo].[JiraMySprintHours]"+DdlSprint.SelectedItem+ ","+"'"+DdlUser.SelectedItem+"'").FirstOrDefault();
            //Burnt.Text = val.TotalHoursBurnt.ToString();
            //Remaining.Text = val.TotalHoursRemaining.ToString();
             
            var val2 = db.Database.SqlQuery<SpValue>("select response from dbo.JIRA_JSON (nolock)").FirstOrDefault();
            
            //Response1.Text = val2.Response.ToString();
            var issues = JObject.Parse(val2.Response)["issues"];
            Burnt.Text = ((from i in issues select (float)i["fields"]["timespent"]).Sum()/3600).ToString();
            Remaining.Text = ((from i in issues select (float)i["fields"]["timeestimate"]).Sum()/3600).ToString();
        }

    }

}
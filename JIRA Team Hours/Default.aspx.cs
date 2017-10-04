using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JIRA_Team_Hours;

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
                //DdlUser.DataTextField = "Text";
                //DdlUser.DataValueField = "Value";
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            var db = new TestEntities();
            db.Database.CommandTimeout = 400;
            var val = db.Database.SqlQuery<SpValue>("EXEC [dbo].[JiraMySprintHours]"+DdlSprint.SelectedItem+ ","+"'"+DdlUser.SelectedItem+"'").FirstOrDefault();
            Burnt.Text = val.TotalHoursBurnt.ToString();
            Remaining.Text = val.TotalHoursRemaining.ToString();

        }


    }
}
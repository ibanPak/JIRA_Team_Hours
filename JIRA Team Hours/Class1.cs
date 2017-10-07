using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace JIRA_Team_Hours
{
    public class Class1
    {
        public class StatusCategory
        {
            public string self { get; set; }
            public int id { get; set; }
            public string key { get; set; }
            public string colorName { get; set; }
            public string name { get; set; }
        }

        public class Status
        {
            public string self { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public StatusCategory statusCategory { get; set; }
        }

        public class Priority
        {
            public string self { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Issuetype
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
            public int avatarId { get; set; }
        }

        public class Fields2
        {
            public string summary { get; set; }
            public Status status { get; set; }
            public Priority priority { get; set; }
            public Issuetype issuetype { get; set; }
        }

        public class Parent
        {
            public string id { get; set; }
            public string key { get; set; }
            public string self { get; set; }
            public Fields2 fields { get; set; }
        }

        public class Resolution
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string name { get; set; }
        }

        public class Priority2
        {
            public string self { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class AvatarUrls
        {
            public string __invalid_name__48x48 { get; set; }
            public string __invalid_name__24x24 { get; set; }
            public string __invalid_name__16x16 { get; set; }
            public string __invalid_name__32x32 { get; set; }
        }

        public class Assignee
        {
            public string self { get; set; }
            public string name { get; set; }
            public string key { get; set; }
            public string accountId { get; set; }
            public string emailAddress { get; set; }
            public AvatarUrls avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
        }

        public class StatusCategory2
        {
            public string self { get; set; }
            public int id { get; set; }
            public string key { get; set; }
            public string colorName { get; set; }
            public string name { get; set; }
        }

        public class Status2
        {
            public string self { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public string id { get; set; }
            public StatusCategory2 statusCategory { get; set; }
        }

        public class Customfield11300
        {
            public string self { get; set; }
            public string value { get; set; }
            public string id { get; set; }
        }

        public class AvatarUrls2
        {
            public string __invalid_name__48x48 { get; set; }
            public string __invalid_name__24x24 { get; set; }
            public string __invalid_name__16x16 { get; set; }
            public string __invalid_name__32x32 { get; set; }
        }

        public class Creator
        {
            public string self { get; set; }
            public string name { get; set; }
            public string key { get; set; }
            public string accountId { get; set; }
            public string emailAddress { get; set; }
            public AvatarUrls2 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
        }

        public class AvatarUrls3
        {
            public string __invalid_name__48x48 { get; set; }
            public string __invalid_name__24x24 { get; set; }
            public string __invalid_name__16x16 { get; set; }
            public string __invalid_name__32x32 { get; set; }
        }

        public class Reporter
        {
            public string self { get; set; }
            public string name { get; set; }
            public string key { get; set; }
            public string accountId { get; set; }
            public string emailAddress { get; set; }
            public AvatarUrls3 avatarUrls { get; set; }
            public string displayName { get; set; }
            public bool active { get; set; }
            public string timeZone { get; set; }
        }

        public class Aggregateprogress
        {
            public int progress { get; set; }
            public int total { get; set; }
            public int percent { get; set; }
        }

        public class Progress
        {
            public int progress { get; set; }
            public int total { get; set; }
            public int percent { get; set; }
        }

        public class Votes
        {
            public string self { get; set; }
            public int votes { get; set; }
            public bool hasVoted { get; set; }
        }

        public class Issuetype2
        {
            public string self { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public string iconUrl { get; set; }
            public string name { get; set; }
            public bool subtask { get; set; }
            public int avatarId { get; set; }
        }

        public class AvatarUrls4
        {
            public string __invalid_name__48x48 { get; set; }
            public string __invalid_name__24x24 { get; set; }
            public string __invalid_name__16x16 { get; set; }
            public string __invalid_name__32x32 { get; set; }
        }

        public class Project
        {
            public string self { get; set; }
            public string id { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public AvatarUrls4 avatarUrls { get; set; }
        }

        public class Watches
        {
            public string self { get; set; }
            public int watchCount { get; set; }
            public bool isWatching { get; set; }
        }

        public class Fields
        {
            public Parent parent { get; set; }
            public List<object> fixVersions { get; set; }
            public object customfield_13101 { get; set; }
            public string customfield_11200 { get; set; }
            public Resolution resolution { get; set; }
            public object customfield_12800 { get; set; }
            public object customfield_10500 { get; set; }
            public object customfield_10900 { get; set; }
            public DateTime lastViewed { get; set; }
            public object customfield_12000 { get; set; }
            public object customfield_10100 { get; set; }
            public object customfield_12400 { get; set; }
            public Priority2 priority { get; set; }
            public List<object> labels { get; set; }
            public object customfield_11700 { get; set; }
            public int timeestimate { get; set; }
            public int aggregatetimeoriginalestimate { get; set; }
            public List<object> versions { get; set; }
            public List<object> issuelinks { get; set; }
            public Assignee assignee { get; set; }
            public Status2 status { get; set; }
            public Customfield11300 customfield_11300 { get; set; }
            public object customfield_11301 { get; set; }
            public object customfield_11302 { get; set; }
            public object customfield_10601 { get; set; }
            public object customfield_12900 { get; set; }
            public int aggregatetimeestimate { get; set; }
            public Creator creator { get; set; }
            public List<object> subtasks { get; set; }
            public Reporter reporter { get; set; }
            public object customfield_12101 { get; set; }
            public object customfield_12100 { get; set; }
            public Aggregateprogress aggregateprogress { get; set; }
            public object customfield_12103 { get; set; }
            public object customfield_12102 { get; set; }
            public object customfield_12105 { get; set; }
            public object customfield_10201 { get; set; }
            public object customfield_12500 { get; set; }
            public object customfield_10202 { get; set; }
            public object customfield_12104 { get; set; }
            public object customfield_11800 { get; set; }
            public Progress progress { get; set; }
            public Votes votes { get; set; }
            public Issuetype2 issuetype { get; set; }
            public int timespent { get; set; }
            public Project project { get; set; }
            public object customfield_11000 { get; set; }
            public int aggregatetimespent { get; set; }
            public object customfield_10700 { get; set; }
            public DateTime resolutiondate { get; set; }
            public int workratio { get; set; }
            public Watches watches { get; set; }
            public DateTime created { get; set; }
            public object customfield_10020 { get; set; }
            public object customfield_12200 { get; set; }
            public object customfield_10021 { get; set; }
            public object customfield_12202 { get; set; }
            public object customfield_12201 { get; set; }
            public object customfield_10300 { get; set; }
            public object customfield_12600 { get; set; }
            public object customfield_10016 { get; set; }
            public object customfield_10017 { get; set; }
            public object customfield_10018 { get; set; }
            public object customfield_11900 { get; set; }
            public object customfield_10019 { get; set; }
            public object customfield_11902 { get; set; }
            public DateTime customfield_11901 { get; set; }
            public DateTime updated { get; set; }
            public int timeoriginalestimate { get; set; }
            public string description { get; set; }
            public object customfield_13000 { get; set; }
            public object customfield_11100 { get; set; }
            public object customfield_10012 { get; set; }
            public object customfield_10013 { get; set; }
            public object customfield_10014 { get; set; }
            public object customfield_10015 { get; set; }
            public object customfield_10401 { get; set; }
            public object customfield_10402 { get; set; }
            public string customfield_12700 { get; set; }
            public List<string> customfield_10007 { get; set; }
            public object customfield_10403 { get; set; }
            public object customfield_10008 { get; set; }
            public object customfield_10404 { get; set; }
            public object customfield_10800 { get; set; }
            public object customfield_10405 { get; set; }
            public object customfield_10406 { get; set; }
            public object customfield_10407 { get; set; }
            public object customfield_10408 { get; set; }
            public string summary { get; set; }
            public string customfield_10000 { get; set; }
            public object customfield_10001 { get; set; }
            public object customfield_12300 { get; set; }
            public object customfield_10002 { get; set; }
            public object customfield_10003 { get; set; }
            public object customfield_10400 { get; set; }
            public object environment { get; set; }
            public object duedate { get; set; }
        }

        public class Issue
        {
            public string expand { get; set; }
            public string id { get; set; }
            public string self { get; set; }
            public string key { get; set; }
            public Fields fields { get; set; }
        }

        public class RootObject
        {
            public string expand { get; set; }
            public int startAt { get; set; }
            public int maxResults { get; set; }
            public int total { get; set; }
            public List<Issue> issues { get; set; }
        }

    }  

}

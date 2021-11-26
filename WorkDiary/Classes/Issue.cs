using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WorkDiary.Classes
{
    public class Issue
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _problem;
        public string Problem
        {
            get { return _problem; }
            set { _problem = value; }
        }

        private List<string> _text;
        public List<string> Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private List<Action> _actions;
        public List<Action> Actions
        {
            get { return _actions; }
            set { _actions = value; }
        }

        private List<Link> _links;
        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }

        private List<string> _answer;
        public List<string> Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        private DateTime _dateStart;
        public DateTime DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }

        private DateTime? _dateEnd;
        public DateTime? DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }

        private List<int> _tagsIds;
        public List<int> TagsIds
        {
            get
            {
                if (Tags != null && Tags.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Tag tag in Tags)
                        ids.Add(tag.Id);
                    return ids;
                }
                return _tagsIds;
            }
            set { _tagsIds = value; }
        }

        private List<Tag> _tags;
        [XmlIgnore]
        public List<Tag> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        private List<int> _linkedIssuesIds;
        public List<int> LinkedIssuesIds
        {
            get
            {
                if (LinkedIssues != null && LinkedIssues.Count > 0)
                {
                    List<int> ids = new List<int>();
                    foreach (Issue linkedIssue in LinkedIssues)
                        ids.Add(linkedIssue.Id);
                    return ids;
                }
                return _linkedIssuesIds;
            }
            set { _linkedIssuesIds = value; }
        }

        private List<Issue> _linkedIssues;
        [XmlIgnore]
        public List<Issue> LinkedIssues
        {
            get { return _linkedIssues; }
            set { _linkedIssues = value; }
        }

        private List<Contact> _contacts;
        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }

        public Issue()
        {
            DateStart = DateTime.Now;
            Tags = new List<Tag>();
            Actions = new List<Action>();
            Contacts = new List<Contact>();
            Answer = new List<string>();
            Text = new List<string>();
            LinkedIssues = new List<Issue>();
            Links = new List<Link>();
        }

        public static int CompareByDate(Issue a, Issue b)
        {
            if (a.DateStart == b.DateStart)
                return b.Id - a.Id;
            return DateTime.Compare(b.DateStart, a.DateStart);
        }
    }
}
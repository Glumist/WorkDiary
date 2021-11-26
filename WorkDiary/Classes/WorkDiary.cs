using System.Collections.Generic;

namespace WorkDiary.Classes
{
    public class WorkDiary
    {
        private static string fileName = "WorkDiary.xml";
        private static WorkDiary _workDiary;

        private List<Tag> _tags;
        public List<Tag> Tags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        private List<Person> _persons;
        public List<Person> Persons
        {
            get { return _persons; }
            set { _persons = value; }
        }

        private List<Channel> _channels;
        public List<Channel> Channels
        {
            get { return _channels; }
            set { _channels = value; }
        }

        private List<Issue> _issues;
        public List<Issue> Issues
        {
            get { return _issues; }
            set { _issues = value; }
        }

        private WorkDiary()
        {
            Tags = new List<Tag>();
            Persons = new List<Person>();
            Channels = new List<Channel>();
            Issues = new List<Issue>();
        }

        public static WorkDiary GetInstance()
        {
            if (_workDiary == null)
                _workDiary = Load();
            return _workDiary;
        }

        public bool Save()
        {
            try
            {
                XmlHelper.SerializeAndSave(fileName, this);
                return Check();
            }
            catch
            {
                return false;
            }
        }

        private bool Check()
        {
            try
            {
                WorkDiary toCheck = fileName.LoadAndDeserialize<WorkDiary>();
                if (toCheck.Tags.Count != Tags.Count)
                    return false;
                if (toCheck.Persons.Count != Persons.Count)
                    return false;
                if (toCheck.Channels.Count != Channels.Count)
                    return false;
                if (toCheck.Issues.Count != Issues.Count)
                    return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private static WorkDiary Load()
        {
            WorkDiary result;
            try
            {
                result = fileName.LoadAndDeserialize<WorkDiary>();
            }
            catch
            {
                return new WorkDiary();
            }

            result.Tags.Sort(Tag.CompareByName);
            result.Persons.Sort(Person.CompareByName);
            result.Channels.Sort(Channel.CompareByName);
            result.Issues.Sort(Issue.CompareByDate);

            SetIssuesTags(result.Issues, result.Tags);
            SetIssuesContacts(result.Issues, result.Persons, result.Channels);
            SetIssuesLinkedIssues(result.Issues);

            return result;
        }

        private static void SetIssuesTags(List<Issue> issues, List<Tag> tags)
        {
            foreach (Issue issue in issues)
            {
                List<int> ids = new List<int>(issue.TagsIds);
                foreach (int tagId in ids)
                    foreach (Tag tag in tags)
                        if (tag.Id == tagId)
                        {
                            issue.Tags.Add(tag);
                            break;
                        }
            }
        }

        private static void SetIssuesContacts(List<Issue> issues, List<Person> persons, List<Channel> channels)
        {
            foreach (Issue issue in issues)
                foreach (Contact contact in issue.Contacts)
                {
                    foreach (Person person in persons)
                        if (person.Id == contact.PersonId)
                        {
                            contact.Person = person;
                            break;
                        }
                    foreach (Channel channel in channels)
                        if (channel.Id == contact.ChannelId)
                        {
                            contact.Channel = channel;
                            break;
                        }
                }
        }

        private static void SetIssuesLinkedIssues(List<Issue> issues)
        {
            foreach (Issue issue in issues)
            {
                List<int> ids = new List<int>(issue.LinkedIssuesIds);
                foreach (int linkedIssueId in ids)
                    foreach (Issue issue2 in issues)
                        if (issue2.Id == linkedIssueId)
                        {
                            issue.LinkedIssues.Add(issue2);
                            break;
                        }
            }
        }

        public void Add(Tag tag)
        {
            int lastId = -1;
            foreach (Tag t in Tags)
                if (t.Id > lastId)
                    lastId = t.Id;

            tag.Id = lastId + 1;

            Tags.Add(tag);
            Tags.Sort(Tag.CompareByName);
        }

        public void Add(Person person)
        {
            int lastId = -1;
            foreach (Person p in Persons)
                if (p.Id > lastId)
                    lastId = p.Id;

            person.Id = lastId + 1;

            Persons.Add(person);
            Persons.Sort(Person.CompareByName);
        }

        public void Add(Channel channel)
        {
            int lastId = -1;
            foreach (Channel c in Channels)
                if (c.Id > lastId)
                    lastId = c.Id;

            channel.Id = lastId + 1;

            Channels.Add(channel);
            Channels.Sort(Channel.CompareByName);
        }

        public void Add(Issue issue)
        {
            int lastId = -1;
            foreach (Issue i in Issues)
                if (i.Id > lastId)
                    lastId = i.Id;

            issue.Id = lastId + 1;

            Issues.Add(issue);
            Issues.Sort(Issue.CompareByDate);
        }

        public void UpdateLists()
        {
            List<Tag> tagsToDelete = new List<Tag>();
            foreach (Tag tag in Tags)
                if (!Issues.Exists(i => i.Tags.Contains(tag)))
                    tagsToDelete.Add(tag);
            tagsToDelete.ForEach(t => Tags.Remove(t));

            List<Person> personsToDelete = new List<Person>();
            foreach (Person person in Persons)
                if (!Issues.Exists(i => i.Contacts.Exists(c => c.Person == person)))
                    personsToDelete.Add(person);
            personsToDelete.ForEach(p => Persons.Remove(p));

            List<Channel> channelsToDelete = new List<Channel>();
            foreach (Channel channel in Channels)
                if (!Issues.Exists(i => i.Contacts.Exists(c => c.Channel == channel)))
                    channelsToDelete.Add(channel);
            channelsToDelete.ForEach(c => Channels.Remove(c));
        }
    }
}
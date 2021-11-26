using System;
using System.Xml.Serialization;

namespace WorkDiary.Classes
{
    public class Contact
    {
        private int _personId;
        public int PersonId
        {
            get
            {
                if (Person != null)
                    return Person.Id;
                return _personId;
            }
            set { _personId = value; }
        }

        private Person _person;
        [XmlIgnore]
        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        private int _channelId;
        public int ChannelId
        {
            get
            {
                if (Channel != null)
                    return Channel.Id;
                return _channelId;
            }
            set { _channelId = value; }
        }

        private Channel _channel;
        [XmlIgnore]
        public Channel Channel
        {
            get { return _channel; }
            set { _channel = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public static int CompareByDate(Contact a, Contact b)
        {
            if (a.Date == b.Date)
                return Channel.CompareByName(a.Channel, b.Channel);
            return DateTime.Compare(b.Date, a.Date);
        }
    }
}
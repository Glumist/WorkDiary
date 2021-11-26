using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WorkDiary.Classes
{
    public class Action
    {
        private List<string> _text;
        public List<string> Text
        {
            get { return _text; }
            set { _text = value; }
        }

        [XmlIgnore]
        public string TextString
        {
            get
            {
                string result = "";
                Text.ForEach(t => result += (result.Length > 0 ? Environment.NewLine : "") + t);
                return result;
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public static int CompareByDate(Action a, Action b)
        {
            return DateTime.Compare(b.Date, a.Date);
        }
    }
}
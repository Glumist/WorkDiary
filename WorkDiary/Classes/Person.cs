namespace WorkDiary.Classes
{
    public class Person
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public static int CompareByName(Person a, Person b)
        {
            return string.Compare(a.Name, b.Name);
        }
    }
}

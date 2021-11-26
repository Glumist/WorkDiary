using System;
using System.Windows.Forms;
using WorkDiary.Classes;

namespace WorkDiary.Forms
{
    public partial class FormContact : Form
    {
        public Contact EditedContact;

        public FormContact()
        {
            InitializeComponent();

            Init();

            EditedContact = new Contact();
            dtpDate.Value = DateTime.Now;
        }

        public FormContact(Contact contact)
        {
            InitializeComponent();

            Init();

            EditedContact = contact;
            dtpDate.Value = contact.Date;
            cbPerson.SelectedItem = contact.Person;
            cbChannel.SelectedItem = contact.Channel;
        }

        private void Init()
        {
            cbPerson.Items.Clear();
            foreach (Person person in WorkDiary.Classes.WorkDiary.GetInstance().Persons)
                cbPerson.Items.Add(person);

            cbChannel.Items.Clear();
            foreach (Channel channel in WorkDiary.Classes.WorkDiary.GetInstance().Channels)
                cbChannel.Items.Add(channel);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string person = cbPerson.Text.Trim();
            if (string.IsNullOrWhiteSpace(person))
            {
                MessageBox.Show("Не заполнено поле С кем");
                return;
            }

                EditedContact.Date = dtpDate.Value;
            if (cbPerson.SelectedItem != null)
                EditedContact.Person = cbPerson.SelectedItem as Person;
            else
                EditedContact.Person = new Person() { Name = person };

            string channel = cbChannel.Text.Trim();
            if (cbChannel.SelectedItem != null)
                EditedContact.Channel = cbChannel.SelectedItem as Channel;
            else if (!string.IsNullOrWhiteSpace(channel))
                EditedContact.Channel = new Channel() { Name = channel };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

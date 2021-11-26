using System;
using System.Windows.Forms;
using WorkDiary.Classes;

namespace WorkDiary.Forms
{
    public partial class FormTag : Form
    {
        public Tag SelectedTag;

        public FormTag()
        {
            InitializeComponent();

            cbChoice.Items.Clear();
            foreach (Tag tag in WorkDiary.Classes.WorkDiary.GetInstance().Tags)
                cbChoice.Items.Add(tag);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string text = cbChoice.Text.Trim();
            if (cbChoice.SelectedItem != null)
                SelectedTag = cbChoice.SelectedItem as Tag;
            else if (!string.IsNullOrWhiteSpace(text))
                SelectedTag = new Tag() { Name = text };
            else
            {
                Close();
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
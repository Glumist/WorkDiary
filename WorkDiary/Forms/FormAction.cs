using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WorkDiary.Forms
{
    public partial class FormAction : Form
    {
        public Classes.Action EditedAction;

        public FormAction()
        {
            InitializeComponent();

            EditedAction = new Classes.Action();
            dtpDate.Value = DateTime.Now;
            tbText.Text = "";
        }

        public FormAction(Classes.Action action)
        {
            InitializeComponent();

            EditedAction = action;
            dtpDate.Value = action.Date;

            tbText.Text = "";
            action.Text.ForEach(t => tbText.Text += (tbText.Text.Length > 0 ? Environment.NewLine : "") + t);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedAction.Date = dtpDate.Value;

            List<string> text = new List<string>();
            foreach (String line in tbText.Lines)
                text.Add(line.Trim());
            EditedAction.Text = text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
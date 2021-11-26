using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkDiary.Classes;

namespace WorkDiary.Forms
{
    public partial class FormIssueSelect : Form
    {
        public Issue SelectedIssue;
        private Issue _currentIssue;

        public FormIssueSelect(Issue currentIssue)
        {
            InitializeComponent();

            _currentIssue = currentIssue;

            dtpStart.Value = DateTime.Today.AddDays(-7);
            dgvIssues.AutoGenerateColumns = false;

            RefreshTable();
        }

        private void RefreshTable()
        {
            List<Issue> issues = new List<Issue>(Classes.WorkDiary.GetInstance().Issues);

            issues.Remove(_currentIssue);

            if (!string.IsNullOrWhiteSpace(tbFilter.Text))
                issues.RemoveAll(i => !i.Problem.ToLower().Contains(tbFilter.Text.ToLower()));

            DateTime start = DateTime.MinValue;
            if (dtpStart.Checked)
                start = dtpStart.Value.Date;

            DateTime end = DateTime.MaxValue;
            if (dtpEnd.Checked)
                end = dtpEnd.Value.Date.AddDays(1);

            if (dtpStart.Checked || dtpEnd.Checked)
                issues.RemoveAll(i => i.DateStart > end ||
                    (i.DateStart < start
                        && !i.Actions.Exists(a => a.Date >= start && a.Date < end)
                        && !i.Contacts.Exists(c => c.Date >= start && c.Date < end)
                    )
                );

            dgvIssues.AutoGenerateColumns = false;
            dgvIssues.DataSource = issues;
        }

        private void filterField_Changed(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (dgvIssues.SelectedRows.Count > 0 && dgvIssues.SelectedRows[0].Index != -1)
            {
                SelectedIssue = dgvIssues.SelectedRows[0].DataBoundItem as Issue;

                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
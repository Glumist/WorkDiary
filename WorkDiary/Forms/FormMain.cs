using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WorkDiary.Classes;

namespace WorkDiary.Forms
{
    public partial class FormMain : Form
    {
        WorkDiary.Classes.WorkDiary _workDiary;
        private readonly Tag TAGS_ALL = new Tag() { Name = "Все" };

        public FormMain()
        {
            InitializeComponent();

            dgvTags.AutoGenerateColumns = false;
            dgvIssues.AutoGenerateColumns = false;

            ucIssue.IssueSaved += UcIssue_IssueSaved;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            _workDiary = WorkDiary.Classes.WorkDiary.GetInstance();
            RefreshTags();
            tscbFilter.SelectedIndex = 0;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ucIssue.Changed)
            {
                DialogResult result = MessageBox.Show("Имеются несохраненные данные. Сохранить?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    ucIssue.Save();
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            (new FormAbout()).ShowDialog();
        }

        private void Save()
        {
            if (!_workDiary.Save())
                MessageBox.Show("Ошибка при сохранении!");
        }

        #region Tags

        private void RefreshTags()
        {
            List<Tag> selectedTags = GetSelectedTags();

            List<Tag> tags = new List<Tag>();
            tags.Add(TAGS_ALL);

            _workDiary.Tags.ForEach(t => tags.Add(t));

            dgvTags.DataSource = tags;

            if (selectedTags != null)
                SelectTags(selectedTags);
        }

        private List<Tag> GetSelectedTags()
        {
            if (dgvTags.SelectedRows.Count == 0 || dgvTags.SelectedRows[0].Index == -1)
                return null;

            List<Tag> result = new List<Tag>();
            foreach (DataGridViewRow row in dgvTags.SelectedRows)
                result.Add(row.DataBoundItem as Tag);

            return result;
        }

        private void SelectTags(List<Tag> tags)
        {
            bool first = true;
            foreach (DataGridViewRow row in dgvTags.Rows)
            {
                Tag rowTag = row.DataBoundItem as Tag;

                if (tags.Contains(rowTag))
                {
                    row.Selected = true;
                    if (first)
                    {
                        dgvTags.FirstDisplayedScrollingRowIndex = row.Index;
                        first = false;
                    }
                }
            }
        }

        private void dgvTags_SelectionChanged(object sender, EventArgs e)
        {
            RefreshIssuesTable();
        }

        #endregion

        #region Issues

        private void RefreshIssuesTable()
        {
            List<Issue> issues = new List<Issue>(_workDiary.Issues);

            if (!string.IsNullOrWhiteSpace(tstbFilter.Text))
                issues.RemoveAll(i => !i.Problem.ToLower().Contains(tstbFilter.Text.ToLower()));

            List<Tag> tags = GetSelectedTags();
            if (tags != null)
                if (!tags.Contains(TAGS_ALL))
                    foreach (Tag tag in tags)
                        issues.RemoveAll(i => !i.Tags.Contains(tag));

            if (tscbFilter.SelectedIndex != 3)
            {
                DateTime start = DateTime.MinValue;
                if (tscbFilter.SelectedIndex == 0)
                    start = DateTime.Today.AddDays(-7);
                else if (tscbFilter.SelectedIndex == 1)
                    start = DateTime.Today.AddMonths(-1);
                else if (tscbFilter.SelectedIndex == 2)
                    start = DateTime.Today.AddYears(-1);

                issues.RemoveAll(i => i.DateStart < start && !i.Actions.Exists(a => a.Date >= start) && !i.Contacts.Exists(c => c.Date >= start));
            }

            dgvIssues.DataSource = issues;
            dgvIssues.ClearSelection();
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            ucIssue.SetIssue(issue);
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            Issue issue = GetSelectedIssue();
            if (issue == null)
                return;

            if (MessageBox.Show("Вы дейтсвительно хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            _workDiary.Issues.Remove(issue);
            Save();
            RefreshIssuesTable();
        }

        private void tstbFilter_TextChanged(object sender, EventArgs e)
        {
            RefreshIssuesTable();
        }

        private void tscbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshIssuesTable();
        }

        private void dgvIssues_SelectionChanged(object sender, EventArgs e)
        {
            Issue selectedIssue = GetSelectedIssue();
            if (selectedIssue != null)
                ucIssue.SetIssue(selectedIssue);
            else
                ucIssue.ClearIssue();
        }

        private Issue GetSelectedIssue()
        {
            if (dgvIssues.SelectedRows.Count == 0 || dgvIssues.SelectedRows[0].Index == -1)
                return null;

            return dgvIssues.SelectedRows[0].DataBoundItem as Issue;
        }

        private void SelectIssue(Issue issue)
        {
            foreach (DataGridViewRow row in dgvIssues.Rows)
            {
                Issue rowIssue = row.DataBoundItem as Issue;

                if (rowIssue == issue)
                {
                    row.Selected = true;
                    dgvIssues.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        #endregion

        private void UcIssue_IssueSaved(object sender, Issue issue)
        {
            if (!_workDiary.Issues.Contains(issue))
                _workDiary.Add(issue);
            else
                _workDiary.Issues.Sort(Issue.CompareByDate);

            _workDiary.UpdateLists();
            Save();
            RefreshTags();
            RefreshIssuesTable();
            SelectIssue(issue);
        }
    }
}
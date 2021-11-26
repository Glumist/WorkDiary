using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WorkDiary.Classes;

namespace WorkDiary.Forms
{
    public partial class UcIssue : UserControl
    {
        public Issue EditedIssue;
        public bool Changed = false;

        private List<Classes.Action> actions;
        private List<Tag> tags;
        private List<Contact> contacts;
        private List<Issue> linkedIssues;
        private List<Link> links;

        public UcIssue()
        {
            InitializeComponent();

            dgvActions.AutoGenerateColumns = false;
            dgvTags.AutoGenerateColumns = false;
            dgvContacts.AutoGenerateColumns = false;
            dgvLinkedIssues.AutoGenerateColumns = false;
            dgvLinks.AutoGenerateColumns = false;

            ClearIssue();
        }

        private bool CheckSave()
        {
            if (Changed)
            {
                DialogResult dialogResult = MessageBox.Show("Имеются несохраненные данные. Сохранить?", "Сохранение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    Save();
                else if (dialogResult == DialogResult.Cancel)
                    return false;
            }
            return true;
        }

        public void SetIssue(Issue issue)
        {
            if (!CheckSave())
                return;

            actions = new List<Classes.Action>(issue.Actions);
            tags = new List<Tag>(issue.Tags);
            contacts = new List<Contact>(issue.Contacts);
            linkedIssues = new List<Issue>(issue.LinkedIssues);
            links = new List<Link>(issue.Links);

            EditedIssue = issue;

            tbProblem.Text = issue.Problem;
            tbText.Text = "";
            issue.Text.ForEach(t => tbText.Text += (tbText.Text.Length > 0 ? Environment.NewLine : "") + t);
            tbAnswer.Text = "";
            issue.Answer.ForEach(t => tbAnswer.Text += (tbAnswer.Text.Length > 0 ? Environment.NewLine : "") + t);
            dtpStart.Value = issue.DateStart;
            dtpEnd.Checked = issue.DateEnd.HasValue;
            if (issue.DateEnd.HasValue)
                dtpEnd.Value = issue.DateEnd.Value;

            dgvActions.DataSource = new List<Classes.Action>(actions);
            dgvTags.DataSource = new List<Tag>(tags);
            dgvContacts.DataSource = new List<Contact>(contacts);
            dgvLinkedIssues.DataSource = new List<Issue>(linkedIssues);
            dgvLinks.DataSource = new List<Link>(links);

            Changed = false;
        }

        public void ClearIssue()
        {
            if (!CheckSave())
                return;

            Changed = false;
            SetIssue(new Issue());
        }

        private void fieldValue_Changed(object sender, EventArgs e)
        {
            Changed = true;
        }

        public void Save()
        {
            EditedIssue.Problem = tbProblem.Text;
            EditedIssue.DateStart = dtpStart.Value.Date;
            EditedIssue.DateEnd = dtpEnd.Checked? (DateTime?)dtpEnd.Value.Date : null;

            List<string> text = new List<string>();
            foreach (String line in tbText.Lines)
                text.Add(line.Trim());
            EditedIssue.Text = text;

            List<string> answer = new List<string>();
            foreach (String line in tbAnswer.Lines)
                answer.Add(line.Trim());
            EditedIssue.Answer = answer;

            EditedIssue.Actions = actions;
            EditedIssue.Links = links;

            foreach (Contact contact in contacts)
            {
                if (!Classes.WorkDiary.GetInstance().Persons.Contains(contact.Person))
                    Classes.WorkDiary.GetInstance().Add(contact.Person);
                if (!Classes.WorkDiary.GetInstance().Channels.Contains(contact.Channel))
                    Classes.WorkDiary.GetInstance().Add(contact.Channel);
            }
            EditedIssue.Contacts = contacts;

            foreach (Tag tag in tags)
                if (!Classes.WorkDiary.GetInstance().Tags.Contains(tag))
                    Classes.WorkDiary.GetInstance().Add(tag);
            EditedIssue.Tags = tags;

            foreach (Issue issue in EditedIssue.LinkedIssues)
                if (!linkedIssues.Contains(issue))
                    issue.LinkedIssues.Remove(EditedIssue);
            foreach (Issue issue in linkedIssues)
                if (!EditedIssue.LinkedIssues.Contains(issue))
                    issue.LinkedIssues.Add(EditedIssue);
            EditedIssue.LinkedIssues = linkedIssues;

            Changed = false;

            OnIssueSaved(EditedIssue);
        }

        #region Menu 

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tsmiActionAdd_Click(object sender, EventArgs e)
        {
            FormAction form = new FormAction();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            actions.Add(form.EditedAction);
            actions.Sort(Classes.Action.CompareByDate);
            dgvActions.DataSource = new List<Classes.Action>(actions);

            fieldValue_Changed(sender, e);
        }

        private void tsmiActionEdit_Click(object sender, EventArgs e)
        {
            Classes.Action selectedAction = GetSelectedAction();
            if (selectedAction == null)
                return;

            FormAction form = new FormAction(selectedAction);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            actions.Sort(Classes.Action.CompareByDate);
            dgvActions.DataSource = new List<Classes.Action>(actions);

            SelectAction(selectedAction);

            fieldValue_Changed(sender, e);
        }

        private void tsmiActionDelete_Click(object sender, EventArgs e)
        {
            Classes.Action selectedAction = GetSelectedAction();
            if (selectedAction == null)
                return;

            actions.Remove(selectedAction);
            dgvActions.DataSource = new List<Classes.Action>(actions);

            fieldValue_Changed(sender, e);
        }

        private void tsmiTagAdd_Click(object sender, EventArgs e)
        {
            FormTag form = new FormTag();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            tags.Add(form.SelectedTag);
            tags.Sort(Classes.Tag.CompareByName);
            dgvTags.DataSource = new List<Tag>(tags);

            fieldValue_Changed(sender, e);
        }

        private void tsmiTagDelete_Click(object sender, EventArgs e)
        {
            if (dgvTags.SelectedRows.Count == 0 || dgvTags.SelectedRows[0].Index == -1)
                return;

            Tag selectedTag = dgvTags.SelectedRows[0].DataBoundItem as Tag;

            tags.Remove(selectedTag);
            dgvTags.DataSource = new List<Tag>(tags);

            fieldValue_Changed(sender, e);
        }

        private void tsmiContactAdd_Click(object sender, EventArgs e)
        {
            FormContact form = new FormContact();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            contacts.Add(form.EditedContact);
            contacts.Sort(Classes.Contact.CompareByDate);
            dgvContacts.DataSource = new List<Contact>(contacts);

            fieldValue_Changed(sender, e);
        }

        private void tsmiContactEdit_Click(object sender, EventArgs e)
        {
            Contact selectedContact = GetSelectedContact();
            if (selectedContact == null)
                return;

            FormContact form = new FormContact(selectedContact);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            contacts.Sort(Contact.CompareByDate);
            dgvContacts.DataSource = new List<Contact>(contacts);

            SelectContact(selectedContact);

            fieldValue_Changed(sender, e);
        }

        private void tsmiContactDelete_Click(object sender, EventArgs e)
        {
            Contact selectedContact = GetSelectedContact();
            if (selectedContact == null)
                return;

            contacts.Remove(selectedContact);
            dgvContacts.DataSource = new List<Contact>(contacts);

            fieldValue_Changed(sender, e);
        }

        private void tsmiLinkedIssueAdd_Click(object sender, EventArgs e)
        {
            FormIssueSelect form = new FormIssueSelect(EditedIssue);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            linkedIssues.Add(form.SelectedIssue);
            linkedIssues.Sort(Issue.CompareByDate);
            dgvLinkedIssues.DataSource = new List<Issue>(linkedIssues);

            fieldValue_Changed(sender, e);
        }

        private void tsmiLinkedIssueDelete_Click(object sender, EventArgs e)
        {
            Issue selectedIssue = GetSelectedIssue();
            if (selectedIssue == null)
                return;

            linkedIssues.Remove(selectedIssue);
            dgvLinkedIssues.DataSource = new List<Issue>(linkedIssues);

            fieldValue_Changed(sender, e);
        }

        private void tsmiLinkAdd_Click(object sender, EventArgs e)
        {
            FormLink form = new FormLink();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            links.Add(form.EditedLink);
            links.Sort(Link.CompareByDefinition);
            dgvLinks.DataSource = new List<Link>(links);

            fieldValue_Changed(sender, e);
        }

        private void tsmiLinkEdit_Click(object sender, EventArgs e)
        {
            Link selectedLink = GetSelectedLink();
            if (selectedLink == null)
                return;

            FormLink form = new FormLink(selectedLink);
            if (form.ShowDialog() != DialogResult.OK)
                return;

            links.Sort(Link.CompareByDefinition);
            dgvLinks.DataSource = new List<Link>(links);

            SelectLink(selectedLink);

            fieldValue_Changed(sender, e);
        }

        private void tsmiLinkDelete_Click(object sender, EventArgs e)
        {
            Link selectedLink = GetSelectedLink();
            if (selectedLink == null)
                return;

            links.Remove(selectedLink);
            dgvLinks.DataSource = new List<Link>(links);

            fieldValue_Changed(sender, e);
        }

        #endregion

        #region Tables

        private Classes.Action GetSelectedAction()
        {
            if (dgvActions.SelectedRows.Count == 0 || dgvActions.SelectedRows[0].Index == -1)
                return null;

            return dgvActions.SelectedRows[0].DataBoundItem as Classes.Action;
        }

        private void SelectAction(Classes.Action action)
        {
            foreach (DataGridViewRow row in dgvActions.Rows)
                if (row.DataBoundItem == action)
                {
                    row.Selected = true;
                    dgvActions.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
        }

        private Contact GetSelectedContact()
        {
            if (dgvContacts.SelectedRows.Count == 0 || dgvContacts.SelectedRows[0].Index == -1)
                return null;

            return dgvContacts.SelectedRows[0].DataBoundItem as Contact;
        }

        private void SelectContact(Contact contact)
        {
            foreach (DataGridViewRow row in dgvContacts.Rows)
                if (row.DataBoundItem == contact)
                {
                    row.Selected = true;
                    dgvContacts.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
        }

        private Issue GetSelectedIssue()
        {
            if (dgvLinkedIssues.SelectedRows.Count == 0 || dgvLinkedIssues.SelectedRows[0].Index == -1)
                return null;

            return dgvLinkedIssues.SelectedRows[0].DataBoundItem as Issue;
        }

        private void dgvLinkedIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Issue selectedIssue = GetSelectedIssue();
            if (selectedIssue == null)
                return;

            SetIssue(selectedIssue);
        }

        private void SelectIssue(Issue issue)
        {
            foreach (DataGridViewRow row in dgvLinkedIssues.Rows)
                if (row.DataBoundItem == issue)
                {
                    row.Selected = true;
                    dgvLinkedIssues.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
        }

        private Link GetSelectedLink()
        {
            if (dgvLinks.SelectedRows.Count == 0 || dgvLinks.SelectedRows[0].Index == -1)
                return null;

            return dgvLinks.SelectedRows[0].DataBoundItem as Link;
        }

        private void dgvLinks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Link selectedLink = GetSelectedLink();
            if (selectedLink == null)
                return;

            System.Diagnostics.Process.Start(selectedLink.Address);
        }

        private void SelectLink(Link link)
        {
            foreach (DataGridViewRow row in dgvLinks.Rows)
                if (row.DataBoundItem == link)
                {
                    row.Selected = true;
                    dgvLinks.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
        }

        #endregion

        public event EventHandler<Issue> IssueSaved;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnIssueSaved(Issue issue)
        {
            if (IssueSaved != null)
                IssueSaved(this, issue);
        }
    }
}

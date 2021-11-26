namespace WorkDiary.Forms
{
    partial class UcIssue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpActions = new System.Windows.Forms.TabPage();
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.colActionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msActions = new System.Windows.Forms.MenuStrip();
            this.tpTags = new System.Windows.Forms.TabPage();
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.colTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msTags = new System.Windows.Forms.MenuStrip();
            this.tpContacts = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colContactDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msContacts = new System.Windows.Forms.MenuStrip();
            this.tpLinkedIssues = new System.Windows.Forms.TabPage();
            this.dgvLinkedIssues = new System.Windows.Forms.DataGridView();
            this.colIssueStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msLinkedIssues = new System.Windows.Forms.MenuStrip();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tpLinks = new System.Windows.Forms.TabPage();
            this.dgvLinks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msLinks = new System.Windows.Forms.MenuStrip();
            this.tsmiActionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTagAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTagDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContactAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContactEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContactDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLinkedIssueAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLinkedIssueDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLinkAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLinkDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLinkEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            this.msActions.SuspendLayout();
            this.tpTags.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            this.msTags.SuspendLayout();
            this.tpContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.msContacts.SuspendLayout();
            this.tpLinkedIssues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkedIssues)).BeginInit();
            this.msLinkedIssues.SuspendLayout();
            this.msMain.SuspendLayout();
            this.tpLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).BeginInit();
            this.msLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проблема";
            // 
            // tbProblem
            // 
            this.tbProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProblem.Location = new System.Drawing.Point(22, 70);
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(726, 26);
            this.tbProblem.TabIndex = 1;
            this.tbProblem.TextChanged += new System.EventHandler(this.fieldValue_Changed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата начала";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(22, 134);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 26);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.ValueChanged += new System.EventHandler(this.fieldValue_Changed);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(228, 134);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowCheckBox = true;
            this.dtpEnd.Size = new System.Drawing.Size(200, 26);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.fieldValue_Changed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата окончания";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание";
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(22, 196);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(726, 172);
            this.tbText.TabIndex = 7;
            this.tbText.TextChanged += new System.EventHandler(this.fieldValue_Changed);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnswer.Location = new System.Drawing.Point(22, 405);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAnswer.Size = new System.Drawing.Size(726, 172);
            this.tbAnswer.TabIndex = 9;
            this.tbAnswer.TextChanged += new System.EventHandler(this.fieldValue_Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Решение";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpActions);
            this.tabControl1.Controls.Add(this.tpTags);
            this.tabControl1.Controls.Add(this.tpContacts);
            this.tabControl1.Controls.Add(this.tpLinkedIssues);
            this.tabControl1.Controls.Add(this.tpLinks);
            this.tabControl1.Location = new System.Drawing.Point(22, 584);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(726, 896);
            this.tabControl1.TabIndex = 10;
            // 
            // tpActions
            // 
            this.tpActions.Controls.Add(this.dgvActions);
            this.tpActions.Controls.Add(this.msActions);
            this.tpActions.Location = new System.Drawing.Point(4, 29);
            this.tpActions.Name = "tpActions";
            this.tpActions.Padding = new System.Windows.Forms.Padding(3);
            this.tpActions.Size = new System.Drawing.Size(718, 863);
            this.tpActions.TabIndex = 0;
            this.tpActions.Text = "Действия";
            this.tpActions.UseVisualStyleBackColor = true;
            // 
            // dgvActions
            // 
            this.dgvActions.AllowUserToAddRows = false;
            this.dgvActions.AllowUserToDeleteRows = false;
            this.dgvActions.AllowUserToResizeRows = false;
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActionDate,
            this.colActionText});
            this.dgvActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvActions.Location = new System.Drawing.Point(3, 35);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.ReadOnly = true;
            this.dgvActions.RowHeadersVisible = false;
            this.dgvActions.RowTemplate.Height = 28;
            this.dgvActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActions.Size = new System.Drawing.Size(712, 825);
            this.dgvActions.TabIndex = 4;
            // 
            // colActionDate
            // 
            this.colActionDate.DataPropertyName = "Date";
            this.colActionDate.HeaderText = "Дата";
            this.colActionDate.Name = "colActionDate";
            this.colActionDate.ReadOnly = true;
            // 
            // colActionText
            // 
            this.colActionText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActionText.DataPropertyName = "TextString";
            this.colActionText.HeaderText = "Действие";
            this.colActionText.Name = "colActionText";
            this.colActionText.ReadOnly = true;
            // 
            // msActions
            // 
            this.msActions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionAdd,
            this.tsmiActionEdit,
            this.tsmiActionDelete});
            this.msActions.Location = new System.Drawing.Point(3, 3);
            this.msActions.Name = "msActions";
            this.msActions.Size = new System.Drawing.Size(712, 32);
            this.msActions.TabIndex = 5;
            this.msActions.Text = "menuStrip2";
            // 
            // tpTags
            // 
            this.tpTags.Controls.Add(this.dgvTags);
            this.tpTags.Controls.Add(this.msTags);
            this.tpTags.Location = new System.Drawing.Point(4, 29);
            this.tpTags.Name = "tpTags";
            this.tpTags.Padding = new System.Windows.Forms.Padding(3);
            this.tpTags.Size = new System.Drawing.Size(718, 863);
            this.tpTags.TabIndex = 1;
            this.tpTags.Text = "Тэги";
            this.tpTags.UseVisualStyleBackColor = true;
            // 
            // dgvTags
            // 
            this.dgvTags.AllowUserToAddRows = false;
            this.dgvTags.AllowUserToDeleteRows = false;
            this.dgvTags.AllowUserToResizeRows = false;
            this.dgvTags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTagName});
            this.dgvTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTags.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTags.Location = new System.Drawing.Point(3, 35);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.ReadOnly = true;
            this.dgvTags.RowHeadersVisible = false;
            this.dgvTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTags.RowTemplate.Height = 28;
            this.dgvTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTags.ShowEditingIcon = false;
            this.dgvTags.Size = new System.Drawing.Size(712, 825);
            this.dgvTags.TabIndex = 1;
            // 
            // colTagName
            // 
            this.colTagName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTagName.DataPropertyName = "Name";
            this.colTagName.HeaderText = "Тэг";
            this.colTagName.Name = "colTagName";
            this.colTagName.ReadOnly = true;
            // 
            // msTags
            // 
            this.msTags.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msTags.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTagAdd,
            this.tsmiTagDelete});
            this.msTags.Location = new System.Drawing.Point(3, 3);
            this.msTags.Name = "msTags";
            this.msTags.Size = new System.Drawing.Size(712, 32);
            this.msTags.TabIndex = 2;
            this.msTags.Text = "menuStrip3";
            // 
            // tpContacts
            // 
            this.tpContacts.Controls.Add(this.dgvContacts);
            this.tpContacts.Controls.Add(this.msContacts);
            this.tpContacts.Location = new System.Drawing.Point(4, 29);
            this.tpContacts.Name = "tpContacts";
            this.tpContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tpContacts.Size = new System.Drawing.Size(718, 863);
            this.tpContacts.TabIndex = 2;
            this.tpContacts.Text = "Контакты";
            this.tpContacts.UseVisualStyleBackColor = true;
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactDate,
            this.colContactPerson,
            this.colContactChannel});
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContacts.Location = new System.Drawing.Point(3, 35);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.RowTemplate.Height = 28;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(712, 825);
            this.dgvContacts.TabIndex = 4;
            // 
            // colContactDate
            // 
            this.colContactDate.DataPropertyName = "Date";
            this.colContactDate.HeaderText = "Дата";
            this.colContactDate.Name = "colContactDate";
            this.colContactDate.ReadOnly = true;
            // 
            // colContactPerson
            // 
            this.colContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactPerson.DataPropertyName = "Person";
            this.colContactPerson.HeaderText = "Имя";
            this.colContactPerson.Name = "colContactPerson";
            this.colContactPerson.ReadOnly = true;
            // 
            // colContactChannel
            // 
            this.colContactChannel.DataPropertyName = "Channel";
            this.colContactChannel.HeaderText = "Канал";
            this.colContactChannel.Name = "colContactChannel";
            this.colContactChannel.ReadOnly = true;
            // 
            // msContacts
            // 
            this.msContacts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msContacts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiContactAdd,
            this.tsmiContactEdit,
            this.tsmiContactDelete});
            this.msContacts.Location = new System.Drawing.Point(3, 3);
            this.msContacts.Name = "msContacts";
            this.msContacts.Size = new System.Drawing.Size(712, 32);
            this.msContacts.TabIndex = 6;
            this.msContacts.Text = "menuStrip4";
            // 
            // tpLinkedIssues
            // 
            this.tpLinkedIssues.Controls.Add(this.dgvLinkedIssues);
            this.tpLinkedIssues.Controls.Add(this.msLinkedIssues);
            this.tpLinkedIssues.Location = new System.Drawing.Point(4, 29);
            this.tpLinkedIssues.Name = "tpLinkedIssues";
            this.tpLinkedIssues.Padding = new System.Windows.Forms.Padding(3);
            this.tpLinkedIssues.Size = new System.Drawing.Size(718, 863);
            this.tpLinkedIssues.TabIndex = 3;
            this.tpLinkedIssues.Text = "Связанные";
            this.tpLinkedIssues.UseVisualStyleBackColor = true;
            // 
            // dgvLinkedIssues
            // 
            this.dgvLinkedIssues.AllowUserToAddRows = false;
            this.dgvLinkedIssues.AllowUserToDeleteRows = false;
            this.dgvLinkedIssues.AllowUserToResizeRows = false;
            this.dgvLinkedIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinkedIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIssueStartDate,
            this.colIssueProblem});
            this.dgvLinkedIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinkedIssues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLinkedIssues.Location = new System.Drawing.Point(3, 35);
            this.dgvLinkedIssues.Name = "dgvLinkedIssues";
            this.dgvLinkedIssues.ReadOnly = true;
            this.dgvLinkedIssues.RowHeadersVisible = false;
            this.dgvLinkedIssues.RowTemplate.Height = 28;
            this.dgvLinkedIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinkedIssues.Size = new System.Drawing.Size(712, 825);
            this.dgvLinkedIssues.TabIndex = 4;
            this.dgvLinkedIssues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinkedIssues_CellDoubleClick);
            // 
            // colIssueStartDate
            // 
            this.colIssueStartDate.DataPropertyName = "DateStart";
            this.colIssueStartDate.HeaderText = "Дата";
            this.colIssueStartDate.Name = "colIssueStartDate";
            this.colIssueStartDate.ReadOnly = true;
            // 
            // colIssueProblem
            // 
            this.colIssueProblem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colIssueProblem.DataPropertyName = "Problem";
            this.colIssueProblem.HeaderText = "Проблема";
            this.colIssueProblem.Name = "colIssueProblem";
            this.colIssueProblem.ReadOnly = true;
            // 
            // msLinkedIssues
            // 
            this.msLinkedIssues.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msLinkedIssues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLinkedIssueAdd,
            this.tsmiLinkedIssueDelete});
            this.msLinkedIssues.Location = new System.Drawing.Point(3, 3);
            this.msLinkedIssues.Name = "msLinkedIssues";
            this.msLinkedIssues.Size = new System.Drawing.Size(712, 32);
            this.msLinkedIssues.TabIndex = 5;
            this.msLinkedIssues.Text = "menuStrip3";
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(768, 33);
            this.msMain.TabIndex = 11;
            this.msMain.Text = "menuStrip1";
            // 
            // tpLinks
            // 
            this.tpLinks.Controls.Add(this.dgvLinks);
            this.tpLinks.Controls.Add(this.msLinks);
            this.tpLinks.Location = new System.Drawing.Point(4, 29);
            this.tpLinks.Name = "tpLinks";
            this.tpLinks.Padding = new System.Windows.Forms.Padding(3);
            this.tpLinks.Size = new System.Drawing.Size(718, 863);
            this.tpLinks.TabIndex = 4;
            this.tpLinks.Text = "Ссылки";
            this.tpLinks.UseVisualStyleBackColor = true;
            // 
            // dgvLinks
            // 
            this.dgvLinks.AllowUserToAddRows = false;
            this.dgvLinks.AllowUserToDeleteRows = false;
            this.dgvLinks.AllowUserToResizeRows = false;
            this.dgvLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLinks.Location = new System.Drawing.Point(3, 35);
            this.dgvLinks.Name = "dgvLinks";
            this.dgvLinks.ReadOnly = true;
            this.dgvLinks.RowHeadersVisible = false;
            this.dgvLinks.RowTemplate.Height = 28;
            this.dgvLinks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinks.Size = new System.Drawing.Size(712, 825);
            this.dgvLinks.TabIndex = 5;
            this.dgvLinks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinks_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Definition";
            this.dataGridViewTextBoxColumn1.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // msLinks
            // 
            this.msLinks.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msLinks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLinkAdd,
            this.tsmiLinkEdit,
            this.tsmiLinkDelete});
            this.msLinks.Location = new System.Drawing.Point(3, 3);
            this.msLinks.Name = "msLinks";
            this.msLinks.Size = new System.Drawing.Size(712, 32);
            this.msLinks.TabIndex = 6;
            this.msLinks.Text = "menuStrip3";
            // 
            // tsmiActionAdd
            // 
            this.tsmiActionAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiActionAdd.Image = global::WorkDiary.Properties.Resources.IconPlus;
            this.tsmiActionAdd.Name = "tsmiActionAdd";
            this.tsmiActionAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiActionAdd.Text = "Добавить";
            this.tsmiActionAdd.Click += new System.EventHandler(this.tsmiActionAdd_Click);
            // 
            // tsmiActionEdit
            // 
            this.tsmiActionEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiActionEdit.Image = global::WorkDiary.Properties.Resources.IconEdit;
            this.tsmiActionEdit.Name = "tsmiActionEdit";
            this.tsmiActionEdit.Size = new System.Drawing.Size(36, 28);
            this.tsmiActionEdit.Text = "Редактировать";
            this.tsmiActionEdit.Click += new System.EventHandler(this.tsmiActionEdit_Click);
            // 
            // tsmiActionDelete
            // 
            this.tsmiActionDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiActionDelete.Image = global::WorkDiary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiActionDelete.Name = "tsmiActionDelete";
            this.tsmiActionDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiActionDelete.Text = "Удалить";
            this.tsmiActionDelete.Click += new System.EventHandler(this.tsmiActionDelete_Click);
            // 
            // tsmiTagAdd
            // 
            this.tsmiTagAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTagAdd.Image = global::WorkDiary.Properties.Resources.IconPlus;
            this.tsmiTagAdd.Name = "tsmiTagAdd";
            this.tsmiTagAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiTagAdd.Text = "Добавить";
            this.tsmiTagAdd.Click += new System.EventHandler(this.tsmiTagAdd_Click);
            // 
            // tsmiTagDelete
            // 
            this.tsmiTagDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTagDelete.Image = global::WorkDiary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiTagDelete.Name = "tsmiTagDelete";
            this.tsmiTagDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiTagDelete.Text = "Удалить";
            this.tsmiTagDelete.Click += new System.EventHandler(this.tsmiTagDelete_Click);
            // 
            // tsmiContactAdd
            // 
            this.tsmiContactAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiContactAdd.Image = global::WorkDiary.Properties.Resources.IconPlus;
            this.tsmiContactAdd.Name = "tsmiContactAdd";
            this.tsmiContactAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiContactAdd.Text = "Добавить";
            this.tsmiContactAdd.Click += new System.EventHandler(this.tsmiContactAdd_Click);
            // 
            // tsmiContactEdit
            // 
            this.tsmiContactEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiContactEdit.Image = global::WorkDiary.Properties.Resources.IconEdit;
            this.tsmiContactEdit.Name = "tsmiContactEdit";
            this.tsmiContactEdit.Size = new System.Drawing.Size(36, 28);
            this.tsmiContactEdit.Text = "Редактировать";
            this.tsmiContactEdit.Click += new System.EventHandler(this.tsmiContactEdit_Click);
            // 
            // tsmiContactDelete
            // 
            this.tsmiContactDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiContactDelete.Image = global::WorkDiary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiContactDelete.Name = "tsmiContactDelete";
            this.tsmiContactDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiContactDelete.Text = "Удалить";
            this.tsmiContactDelete.Click += new System.EventHandler(this.tsmiContactDelete_Click);
            // 
            // tsmiLinkedIssueAdd
            // 
            this.tsmiLinkedIssueAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiLinkedIssueAdd.Image = global::WorkDiary.Properties.Resources.IconPlus;
            this.tsmiLinkedIssueAdd.Name = "tsmiLinkedIssueAdd";
            this.tsmiLinkedIssueAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiLinkedIssueAdd.Text = "Добавить";
            this.tsmiLinkedIssueAdd.Click += new System.EventHandler(this.tsmiLinkedIssueAdd_Click);
            // 
            // tsmiLinkedIssueDelete
            // 
            this.tsmiLinkedIssueDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiLinkedIssueDelete.Image = global::WorkDiary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiLinkedIssueDelete.Name = "tsmiLinkedIssueDelete";
            this.tsmiLinkedIssueDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiLinkedIssueDelete.Text = "Удалить";
            this.tsmiLinkedIssueDelete.Click += new System.EventHandler(this.tsmiLinkedIssueDelete_Click);
            // 
            // tsmiLinkAdd
            // 
            this.tsmiLinkAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiLinkAdd.Image = global::WorkDiary.Properties.Resources.IconPlus;
            this.tsmiLinkAdd.Name = "tsmiLinkAdd";
            this.tsmiLinkAdd.Size = new System.Drawing.Size(36, 28);
            this.tsmiLinkAdd.Text = "Добавить";
            this.tsmiLinkAdd.Click += new System.EventHandler(this.tsmiLinkAdd_Click);
            // 
            // tsmiLinkDelete
            // 
            this.tsmiLinkDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiLinkDelete.Image = global::WorkDiary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiLinkDelete.Name = "tsmiLinkDelete";
            this.tsmiLinkDelete.Size = new System.Drawing.Size(36, 28);
            this.tsmiLinkDelete.Text = "Удалить";
            this.tsmiLinkDelete.Click += new System.EventHandler(this.tsmiLinkDelete_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::WorkDiary.Properties.Resources.IconSave;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(134, 29);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLinkEdit
            // 
            this.tsmiLinkEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiLinkEdit.Image = global::WorkDiary.Properties.Resources.IconEdit;
            this.tsmiLinkEdit.Name = "tsmiLinkEdit";
            this.tsmiLinkEdit.Size = new System.Drawing.Size(36, 28);
            this.tsmiLinkEdit.Text = "Редактировать";
            this.tsmiLinkEdit.Click += new System.EventHandler(this.tsmiLinkEdit_Click);
            // 
            // UcIssue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMain);
            this.Name = "UcIssue";
            this.Size = new System.Drawing.Size(768, 1498);
            this.tabControl1.ResumeLayout(false);
            this.tpActions.ResumeLayout(false);
            this.tpActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            this.msActions.ResumeLayout(false);
            this.msActions.PerformLayout();
            this.tpTags.ResumeLayout(false);
            this.tpTags.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            this.msTags.ResumeLayout(false);
            this.msTags.PerformLayout();
            this.tpContacts.ResumeLayout(false);
            this.tpContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.msContacts.ResumeLayout(false);
            this.msContacts.PerformLayout();
            this.tpLinkedIssues.ResumeLayout(false);
            this.tpLinkedIssues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkedIssues)).EndInit();
            this.msLinkedIssues.ResumeLayout(false);
            this.msLinkedIssues.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tpLinks.ResumeLayout(false);
            this.tpLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinks)).EndInit();
            this.msLinks.ResumeLayout(false);
            this.msLinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpActions;
        private System.Windows.Forms.TabPage tpTags;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.TabPage tpContacts;
        private System.Windows.Forms.DataGridView dgvActions;
        private System.Windows.Forms.MenuStrip msActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionDelete;
        private System.Windows.Forms.DataGridView dgvTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTagName;
        private System.Windows.Forms.MenuStrip msTags;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagDelete;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.ToolStripMenuItem tsmiContactAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiContactEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiContactDelete;
        private System.Windows.Forms.MenuStrip msContacts;
        private System.Windows.Forms.TabPage tpLinkedIssues;
        private System.Windows.Forms.DataGridView dgvLinkedIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueProblem;
        private System.Windows.Forms.MenuStrip msLinkedIssues;
        private System.Windows.Forms.ToolStripMenuItem tsmiLinkedIssueAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiLinkedIssueDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactChannel;
        private System.Windows.Forms.TabPage tpLinks;
        private System.Windows.Forms.DataGridView dgvLinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.MenuStrip msLinks;
        private System.Windows.Forms.ToolStripMenuItem tsmiLinkAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiLinkDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiLinkEdit;
    }
}

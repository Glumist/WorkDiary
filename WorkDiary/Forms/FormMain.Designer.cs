namespace WorkDiary.Forms
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pLeft = new System.Windows.Forms.Panel();
            this.dgvTags = new System.Windows.Forms.DataGridView();
            this.colTagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msIssue = new System.Windows.Forms.MenuStrip();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiFilterIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvIssues = new System.Windows.Forms.DataGridView();
            this.colIssueStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIssueProblem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pMain = new System.Windows.Forms.Panel();
            this.ucIssue = new WorkDiary.Forms.UcIssue();
            this.pLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).BeginInit();
            this.msIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).BeginInit();
            this.msMain.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.dgvTags);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(327, 1108);
            this.pLeft.TabIndex = 0;
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
            this.dgvTags.Location = new System.Drawing.Point(0, 0);
            this.dgvTags.Name = "dgvTags";
            this.dgvTags.ReadOnly = true;
            this.dgvTags.RowHeadersVisible = false;
            this.dgvTags.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTags.RowTemplate.Height = 28;
            this.dgvTags.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTags.ShowEditingIcon = false;
            this.dgvTags.Size = new System.Drawing.Size(327, 1108);
            this.dgvTags.TabIndex = 0;
            this.dgvTags.SelectionChanged += new System.EventHandler(this.dgvTags_SelectionChanged);
            // 
            // colTagName
            // 
            this.colTagName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTagName.DataPropertyName = "Name";
            this.colTagName.HeaderText = "Тэги";
            this.colTagName.Name = "colTagName";
            this.colTagName.ReadOnly = true;
            // 
            // msIssue
            // 
            this.msIssue.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msIssue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiDelete,
            this.tscbFilter,
            this.tstbFilter,
            this.tsmiFilterIcon});
            this.msIssue.Location = new System.Drawing.Point(327, 0);
            this.msIssue.Name = "msIssue";
            this.msIssue.Size = new System.Drawing.Size(897, 37);
            this.msIssue.TabIndex = 2;
            this.msIssue.Text = "menuStrip1";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiAdd.Image = global::WorkDiary.Properties.Resources.IconPlus;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(36, 33);
            this.tsmiAdd.Text = "Добавить";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiDelete.Image = global::WorkDiary.Properties.Resources.action_delete_sharp_thick;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(36, 33);
            this.tsmiDelete.Text = "Удалить";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tscbFilter
            // 
            this.tscbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbFilter.Items.AddRange(new object[] {
            "За неделю",
            "За месяц",
            "За год",
            "Все"});
            this.tscbFilter.Name = "tscbFilter";
            this.tscbFilter.Size = new System.Drawing.Size(180, 33);
            this.tscbFilter.SelectedIndexChanged += new System.EventHandler(this.tscbFilter_SelectedIndexChanged);
            // 
            // tstbFilter
            // 
            this.tstbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(200, 33);
            this.tstbFilter.TextChanged += new System.EventHandler(this.tstbFilter_TextChanged);
            // 
            // tsmiFilterIcon
            // 
            this.tsmiFilterIcon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiFilterIcon.Image = global::WorkDiary.Properties.Resources.IconFilter;
            this.tsmiFilterIcon.Name = "tsmiFilterIcon";
            this.tsmiFilterIcon.Size = new System.Drawing.Size(36, 33);
            // 
            // dgvIssues
            // 
            this.dgvIssues.AllowUserToAddRows = false;
            this.dgvIssues.AllowUserToDeleteRows = false;
            this.dgvIssues.AllowUserToResizeRows = false;
            this.dgvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIssueStartDate,
            this.colIssueProblem});
            this.dgvIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIssues.Location = new System.Drawing.Point(327, 37);
            this.dgvIssues.Name = "dgvIssues";
            this.dgvIssues.ReadOnly = true;
            this.dgvIssues.RowHeadersVisible = false;
            this.dgvIssues.RowTemplate.Height = 28;
            this.dgvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssues.Size = new System.Drawing.Size(897, 1071);
            this.dgvIssues.TabIndex = 3;
            this.dgvIssues.SelectionChanged += new System.EventHandler(this.dgvIssues_SelectionChanged);
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
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1818, 33);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiAbout.Image = global::WorkDiary.Properties.Resources.iconInfo;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(161, 29);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.dgvIssues);
            this.pMain.Controls.Add(this.msIssue);
            this.pMain.Controls.Add(this.pLeft);
            this.pMain.Controls.Add(this.ucIssue);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 33);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1818, 1108);
            this.pMain.TabIndex = 1;
            // 
            // ucIssue
            // 
            this.ucIssue.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucIssue.Location = new System.Drawing.Point(1224, 0);
            this.ucIssue.Name = "ucIssue";
            this.ucIssue.Size = new System.Drawing.Size(594, 1108);
            this.ucIssue.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1818, 1141);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msIssue;
            this.Name = "FormMain";
            this.Text = "Work Diary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTags)).EndInit();
            this.msIssue.ResumeLayout(false);
            this.msIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssues)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.DataGridView dgvTags;
        private UcIssue ucIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTagName;
        private System.Windows.Forms.MenuStrip msIssue;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilterIcon;
        private System.Windows.Forms.DataGridView dgvIssues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIssueProblem;
        private System.Windows.Forms.ToolStripComboBox tscbFilter;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    }
}


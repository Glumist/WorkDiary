namespace WorkDiary.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBox_Version = new System.Windows.Forms.TextBox();
            this.textBox_AuthorName = new System.Windows.Forms.TextBox();
            this.textBox_AuthorEmail = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Version
            // 
            this.textBox_Version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Version.Location = new System.Drawing.Point(192, 30);
            this.textBox_Version.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Version.Name = "textBox_Version";
            this.textBox_Version.ReadOnly = true;
            this.textBox_Version.Size = new System.Drawing.Size(210, 19);
            this.textBox_Version.TabIndex = 16;
            this.textBox_Version.TabStop = false;
            this.textBox_Version.Text = "1.1.0";
            // 
            // textBox_AuthorName
            // 
            this.textBox_AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AuthorName.Location = new System.Drawing.Point(192, 69);
            this.textBox_AuthorName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_AuthorName.Name = "textBox_AuthorName";
            this.textBox_AuthorName.ReadOnly = true;
            this.textBox_AuthorName.Size = new System.Drawing.Size(210, 19);
            this.textBox_AuthorName.TabIndex = 15;
            this.textBox_AuthorName.TabStop = false;
            this.textBox_AuthorName.Text = "Александр \'Glum\' Торбин";
            // 
            // textBox_AuthorEmail
            // 
            this.textBox_AuthorEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AuthorEmail.Location = new System.Drawing.Point(192, 107);
            this.textBox_AuthorEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_AuthorEmail.Multiline = true;
            this.textBox_AuthorEmail.Name = "textBox_AuthorEmail";
            this.textBox_AuthorEmail.ReadOnly = true;
            this.textBox_AuthorEmail.Size = new System.Drawing.Size(150, 48);
            this.textBox_AuthorEmail.TabIndex = 14;
            this.textBox_AuthorEmail.TabStop = false;
            this.textBox_AuthorEmail.Text = "glumist@gmail.com\r\n@Glumist";
            // 
            // button_Ok
            // 
            this.button_Ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_Ok.Location = new System.Drawing.Point(150, 167);
            this.button_Ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(112, 35);
            this.button_Ok.TabIndex = 13;
            this.button_Ok.Text = "OK";
            this.button_Ok.UseVisualStyleBackColor = true;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Email.Location = new System.Drawing.Point(26, 107);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(138, 20);
            this.label_Email.TabIndex = 12;
            this.label_Email.Text = "Адрес для связи";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Author.Location = new System.Drawing.Point(26, 69);
            this.label_Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(56, 20);
            this.label_Author.TabIndex = 11;
            this.label_Author.Text = "Автор";
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_Version.Location = new System.Drawing.Point(26, 30);
            this.label_Version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(64, 20);
            this.label_Version.TabIndex = 10;
            this.label_Version.Text = "Версия";
            // 
            // FormAbout
            // 
            this.AcceptButton = this.button_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.button_Ok;
            this.ClientSize = new System.Drawing.Size(420, 233);
            this.Controls.Add(this.textBox_Version);
            this.Controls.Add(this.textBox_AuthorName);
            this.Controls.Add(this.textBox_AuthorEmail);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Version;
        private System.Windows.Forms.TextBox textBox_AuthorName;
        private System.Windows.Forms.TextBox textBox_AuthorEmail;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Version;
    }
}
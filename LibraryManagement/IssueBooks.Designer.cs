namespace LibraryManagement
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnrollment = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnREFRE = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStDep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStSem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gunaDateTimePickerBIDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBName = new Guna.UI.WinForms.GunaComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(511, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue Books";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnREFRE);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtEnrollment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 536);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(94, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(51, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Enrollment No";
            // 
            // txtEnrollment
            // 
            this.txtEnrollment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollment.Location = new System.Drawing.Point(24, 226);
            this.txtEnrollment.Multiline = true;
            this.txtEnrollment.Name = "txtEnrollment";
            this.txtEnrollment.Size = new System.Drawing.Size(294, 41);
            this.txtEnrollment.TabIndex = 2;
            this.txtEnrollment.TextChanged += new System.EventHandler(this.txtEnrollment_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(59, 292);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(213, 50);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnREFRE
            // 
            this.btnREFRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnREFRE.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREFRE.Location = new System.Drawing.Point(33, 381);
            this.btnREFRE.Name = "btnREFRE";
            this.btnREFRE.Size = new System.Drawing.Size(112, 50);
            this.btnREFRE.TabIndex = 6;
            this.btnREFRE.Text = "Refresh";
            this.btnREFRE.UseVisualStyleBackColor = true;
            this.btnREFRE.Click += new System.EventHandler(this.btnREFRE_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(192, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.comboBName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnIssueBook);
            this.panel3.Controls.Add(this.gunaDateTimePickerBIDate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtStEmail);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtStContact);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtStSem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtStDep);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtStName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(343, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 536);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student Name";
            // 
            // txtStName
            // 
            this.txtStName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStName.Location = new System.Drawing.Point(223, 28);
            this.txtStName.Multiline = true;
            this.txtStName.Name = "txtStName";
            this.txtStName.ReadOnly = true;
            this.txtStName.Size = new System.Drawing.Size(328, 41);
            this.txtStName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department";
            // 
            // txtStDep
            // 
            this.txtStDep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStDep.Location = new System.Drawing.Point(223, 92);
            this.txtStDep.Multiline = true;
            this.txtStDep.Name = "txtStDep";
            this.txtStDep.ReadOnly = true;
            this.txtStDep.Size = new System.Drawing.Size(328, 41);
            this.txtStDep.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Semister";
            // 
            // txtStSem
            // 
            this.txtStSem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStSem.Location = new System.Drawing.Point(223, 151);
            this.txtStSem.Multiline = true;
            this.txtStSem.Name = "txtStSem";
            this.txtStSem.ReadOnly = true;
            this.txtStSem.Size = new System.Drawing.Size(328, 41);
            this.txtStSem.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Student Contact";
            // 
            // txtStContact
            // 
            this.txtStContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStContact.Location = new System.Drawing.Point(223, 208);
            this.txtStContact.Multiline = true;
            this.txtStContact.Name = "txtStContact";
            this.txtStContact.ReadOnly = true;
            this.txtStContact.Size = new System.Drawing.Size(328, 41);
            this.txtStContact.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Student Email";
            // 
            // txtStEmail
            // 
            this.txtStEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStEmail.Location = new System.Drawing.Point(223, 264);
            this.txtStEmail.Multiline = true;
            this.txtStEmail.Name = "txtStEmail";
            this.txtStEmail.ReadOnly = true;
            this.txtStEmail.Size = new System.Drawing.Size(328, 41);
            this.txtStEmail.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Books Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(26, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Book Issue Date";
            // 
            // gunaDateTimePickerBIDate
            // 
            this.gunaDateTimePickerBIDate.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerBIDate.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePickerBIDate.CustomFormat = null;
            this.gunaDateTimePickerBIDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePickerBIDate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerBIDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePickerBIDate.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerBIDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.gunaDateTimePickerBIDate.Location = new System.Drawing.Point(223, 381);
            this.gunaDateTimePickerBIDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePickerBIDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePickerBIDate.Name = "gunaDateTimePickerBIDate";
            this.gunaDateTimePickerBIDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePickerBIDate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerBIDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePickerBIDate.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePickerBIDate.Size = new System.Drawing.Size(328, 41);
            this.gunaDateTimePickerBIDate.TabIndex = 6;
            this.gunaDateTimePickerBIDate.Text = "2/2/2023";
            this.gunaDateTimePickerBIDate.Value = new System.DateTime(2023, 2, 2, 1, 7, 21, 65);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIssueBook.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Location = new System.Drawing.Point(363, 434);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(152, 53);
            this.btnIssueBook.TabIndex = 8;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(49, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(463, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "Maximum 3 Books Can be Issued to 1 Student";
            // 
            // comboBName
            // 
            this.comboBName.BackColor = System.Drawing.Color.Transparent;
            this.comboBName.BaseColor = System.Drawing.Color.White;
            this.comboBName.BorderColor = System.Drawing.Color.Silver;
            this.comboBName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBName.FocusedColor = System.Drawing.Color.Empty;
            this.comboBName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBName.ForeColor = System.Drawing.Color.Black;
            this.comboBName.FormattingEnabled = true;
            this.comboBName.Location = new System.Drawing.Point(224, 327);
            this.comboBName.Name = "comboBName";
            this.comboBName.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboBName.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBName.Size = new System.Drawing.Size(327, 38);
            this.comboBName.TabIndex = 13;
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(982, 667);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBooks";
            this.Load += new System.EventHandler(this.IssueBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEnrollment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnREFRE;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStContact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStSem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIssueBook;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePickerBIDate;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaComboBox comboBName;
    }
}
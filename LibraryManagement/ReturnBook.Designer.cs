namespace LibraryManagement
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgViewReturnBook = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchEnroll = new System.Windows.Forms.TextBox();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookIssueDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Date_Return_Field = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewReturnBook)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSearchStudent);
            this.panel1.Controls.Add(this.txtSearchEnroll);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 519);
            this.panel1.TabIndex = 0;
            // 
            // DgViewReturnBook
            // 
            this.DgViewReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewReturnBook.Location = new System.Drawing.Point(383, 12);
            this.DgViewReturnBook.Name = "DgViewReturnBook";
            this.DgViewReturnBook.RowTemplate.Height = 28;
            this.DgViewReturnBook.Size = new System.Drawing.Size(929, 518);
            this.DgViewReturnBook.TabIndex = 1;
            this.DgViewReturnBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgViewReturnBook_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.Date_Return_Field);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBookIssueDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBookname);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(383, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 281);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Enrollment No";
            // 
            // txtSearchEnroll
            // 
            this.txtSearchEnroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEnroll.Location = new System.Drawing.Point(30, 228);
            this.txtSearchEnroll.Multiline = true;
            this.txtSearchEnroll.Name = "txtSearchEnroll";
            this.txtSearchEnroll.Size = new System.Drawing.Size(314, 36);
            this.txtSearchEnroll.TabIndex = 2;
            this.txtSearchEnroll.TextChanged += new System.EventHandler(this.txtSearchEnroll_TextChanged);
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(74, 285);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(225, 54);
            this.btnSearchStudent.TabIndex = 3;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(30, 434);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 51);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(230, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 51);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBookname
            // 
            this.txtBookname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookname.Location = new System.Drawing.Point(233, 27);
            this.txtBookname.Multiline = true;
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(327, 41);
            this.txtBookname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 35);
            this.label4.TabIndex = 2;
            this.label4.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Issue Date";
            // 
            // txtBookIssueDate
            // 
            this.txtBookIssueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookIssueDate.Location = new System.Drawing.Point(233, 99);
            this.txtBookIssueDate.Multiline = true;
            this.txtBookIssueDate.Name = "txtBookIssueDate";
            this.txtBookIssueDate.Size = new System.Drawing.Size(327, 41);
            this.txtBookIssueDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Book Return Date";
            // 
            // Date_Return_Field
            // 
            this.Date_Return_Field.BaseColor = System.Drawing.Color.White;
            this.Date_Return_Field.BorderColor = System.Drawing.Color.Silver;
            this.Date_Return_Field.CustomFormat = null;
            this.Date_Return_Field.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Date_Return_Field.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Date_Return_Field.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Date_Return_Field.ForeColor = System.Drawing.Color.Black;
            this.Date_Return_Field.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_Return_Field.Location = new System.Drawing.Point(233, 169);
            this.Date_Return_Field.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Date_Return_Field.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Date_Return_Field.Name = "Date_Return_Field";
            this.Date_Return_Field.OnHoverBaseColor = System.Drawing.Color.White;
            this.Date_Return_Field.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Date_Return_Field.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Date_Return_Field.OnPressedColor = System.Drawing.Color.Black;
            this.Date_Return_Field.Size = new System.Drawing.Size(327, 41);
            this.Date_Return_Field.TabIndex = 7;
            this.Date_Return_Field.Text = "2/2/2023";
            this.Date_Return_Field.Value = new System.DateTime(2023, 2, 2, 1, 7, 21, 65);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(631, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(631, 99);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 50);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1316, 877);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DgViewReturnBook);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewReturnBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtSearchEnroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgViewReturnBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookIssueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDateTimePicker Date_Return_Field;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
    }
}
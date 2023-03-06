namespace LibraryManagement
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboDep = new System.Windows.Forms.ComboBox();
            this.comboSem = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.txtStEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnroll = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.comboDep);
            this.panel2.Controls.Add(this.comboSem);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnRef);
            this.panel2.Controls.Add(this.btnSaveInfo);
            this.panel2.Controls.Add(this.txtStEmail);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtStContact);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEnroll);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtStName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(399, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 544);
            this.panel2.TabIndex = 5;
            // 
            // comboDep
            // 
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Items.AddRange(new object[] {
            "IT",
            "CIVIL",
            "ENGE",
            "MEDICAL"});
            this.comboDep.Location = new System.Drawing.Point(270, 189);
            this.comboDep.Name = "comboDep";
            this.comboDep.Size = new System.Drawing.Size(282, 28);
            this.comboDep.TabIndex = 9;
            // 
            // comboSem
            // 
            this.comboSem.FormattingEnabled = true;
            this.comboSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboSem.Location = new System.Drawing.Point(270, 250);
            this.comboSem.Name = "comboSem";
            this.comboSem.Size = new System.Drawing.Size(282, 28);
            this.comboSem.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(431, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 60);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.Color.Cyan;
            this.btnRef.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRef.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRef.ForeColor = System.Drawing.Color.Black;
            this.btnRef.Location = new System.Drawing.Point(136, 452);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(116, 60);
            this.btnRef.TabIndex = 6;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.BackColor = System.Drawing.Color.Cyan;
            this.btnSaveInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInfo.Location = new System.Drawing.Point(282, 452);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(131, 60);
            this.btnSaveInfo.TabIndex = 7;
            this.btnSaveInfo.Text = "Save Info";
            this.btnSaveInfo.UseVisualStyleBackColor = false;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // txtStEmail
            // 
            this.txtStEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStEmail.Location = new System.Drawing.Point(270, 368);
            this.txtStEmail.Multiline = true;
            this.txtStEmail.Name = "txtStEmail";
            this.txtStEmail.Size = new System.Drawing.Size(282, 43);
            this.txtStEmail.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Student Email";
            // 
            // txtStContact
            // 
            this.txtStContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStContact.Location = new System.Drawing.Point(270, 309);
            this.txtStContact.Multiline = true;
            this.txtStContact.Name = "txtStContact";
            this.txtStContact.Size = new System.Drawing.Size(282, 43);
            this.txtStContact.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department";
            // 
            // txtEnroll
            // 
            this.txtEnroll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnroll.Location = new System.Drawing.Point(270, 112);
            this.txtEnroll.Multiline = true;
            this.txtEnroll.Name = "txtEnroll";
            this.txtEnroll.Size = new System.Drawing.Size(282, 43);
            this.txtEnroll.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Semister";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enrollment No";
            // 
            // txtStName
            // 
            this.txtStName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStName.Location = new System.Drawing.Point(270, 42);
            this.txtStName.Multiline = true;
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(282, 43);
            this.txtStName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 97);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Student";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(399, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 544);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.TextBox txtStEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnroll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboSem;
        private System.Windows.Forms.ComboBox comboDep;
    }
}
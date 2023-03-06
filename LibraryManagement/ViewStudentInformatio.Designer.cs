namespace LibraryManagement
{
    partial class ViewStudentInformatio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInformatio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.DGViewStudents = new System.Windows.Forms.DataGridView();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.txtEnrollment = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDep = new Guna.UI.WinForms.GunaComboBox();
            this.comboSem = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewStudents)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 168);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPhone.Location = new System.Drawing.Point(495, 194);
            this.txtSearchPhone.Multiline = true;
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(282, 42);
            this.txtSearchPhone.TabIndex = 2;
            this.txtSearchPhone.TextChanged += new System.EventHandler(this.txtSearchPhone_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(817, 194);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 42);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DGViewStudents
            // 
            this.DGViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGViewStudents.Location = new System.Drawing.Point(-7, 237);
            this.DGViewStudents.Name = "DGViewStudents";
            this.DGViewStudents.RowTemplate.Height = 28;
            this.DGViewStudents.Size = new System.Drawing.Size(1296, 435);
            this.DGViewStudents.TabIndex = 4;
            this.DGViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGViewStudents_CellClick);
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelUpdate.Controls.Add(this.comboSem);
            this.panelUpdate.Controls.Add(this.comboDep);
            this.panelUpdate.Controls.Add(this.btnCancel);
            this.panelUpdate.Controls.Add(this.btnDelete);
            this.panelUpdate.Controls.Add(this.btnUpdate);
            this.panelUpdate.Controls.Add(this.txtEmail);
            this.panelUpdate.Controls.Add(this.txtContact);
            this.panelUpdate.Controls.Add(this.txtEnrollment);
            this.panelUpdate.Controls.Add(this.txtSname);
            this.panelUpdate.Controls.Add(this.label9);
            this.panelUpdate.Controls.Add(this.label6);
            this.panelUpdate.Controls.Add(this.label8);
            this.panelUpdate.Controls.Add(this.label7);
            this.panelUpdate.Controls.Add(this.label5);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Location = new System.Drawing.Point(0, 697);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(1275, 414);
            this.panelUpdate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enrollment No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSname.Location = new System.Drawing.Point(276, 37);
            this.txtSname.Multiline = true;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(327, 41);
            this.txtSname.TabIndex = 1;
            // 
            // txtEnrollment
            // 
            this.txtEnrollment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnrollment.Location = new System.Drawing.Point(276, 114);
            this.txtEnrollment.Multiline = true;
            this.txtEnrollment.Name = "txtEnrollment";
            this.txtEnrollment.Size = new System.Drawing.Size(327, 41);
            this.txtEnrollment.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(636, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 35);
            this.label7.TabIndex = 0;
            this.label7.Text = "Student Semester";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(636, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 35);
            this.label8.TabIndex = 0;
            this.label8.Text = "Student Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(636, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 35);
            this.label9.TabIndex = 0;
            this.label9.Text = "Student Email";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(860, 115);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(327, 41);
            this.txtContact.TabIndex = 1;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(860, 188);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 41);
            this.txtEmail.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(759, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 49);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(898, 258);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 49);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1036, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 49);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "StdPhone";
            // 
            // comboDep
            // 
            this.comboDep.BackColor = System.Drawing.Color.Transparent;
            this.comboDep.BaseColor = System.Drawing.Color.White;
            this.comboDep.BorderColor = System.Drawing.Color.Silver;
            this.comboDep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDep.FocusedColor = System.Drawing.Color.Empty;
            this.comboDep.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDep.ForeColor = System.Drawing.Color.Black;
            this.comboDep.FormattingEnabled = true;
            this.comboDep.Location = new System.Drawing.Point(276, 192);
            this.comboDep.Name = "comboDep";
            this.comboDep.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboDep.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboDep.Size = new System.Drawing.Size(327, 38);
            this.comboDep.TabIndex = 12;
            // 
            // comboSem
            // 
            this.comboSem.BackColor = System.Drawing.Color.Transparent;
            this.comboSem.BaseColor = System.Drawing.Color.White;
            this.comboSem.BorderColor = System.Drawing.Color.Silver;
            this.comboSem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSem.FocusedColor = System.Drawing.Color.Empty;
            this.comboSem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSem.ForeColor = System.Drawing.Color.Black;
            this.comboSem.FormattingEnabled = true;
            this.comboSem.Location = new System.Drawing.Point(860, 44);
            this.comboSem.Name = "comboSem";
            this.comboSem.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboSem.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboSem.Size = new System.Drawing.Size(327, 38);
            this.comboSem.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(650, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "View Students";
            // 
            // ViewStudentInformatio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1275, 1050);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.DGViewStudents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearchPhone);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStudentInformatio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentInformatio";
            this.Load += new System.EventHandler(this.ViewStudentInformatio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGViewStudents)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView DGViewStudents;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEnrollment;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox comboSem;
        private Guna.UI.WinForms.GunaComboBox comboDep;
        private System.Windows.Forms.Label label1;
    }
}
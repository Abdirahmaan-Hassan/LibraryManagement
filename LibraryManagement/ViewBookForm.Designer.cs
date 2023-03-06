namespace LibraryManagement
{
    partial class ViewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewVB = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpadate = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtbookPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbookquantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBpubli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBauthorN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVB)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 168);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(495, 194);
            this.textBoxBookName.Multiline = true;
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(282, 42);
            this.textBoxBookName.TabIndex = 3;
            this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(817, 194);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 42);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridViewVB
            // 
            this.dataGridViewVB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVB.Location = new System.Drawing.Point(0, 256);
            this.dataGridViewVB.Name = "dataGridViewVB";
            this.dataGridViewVB.RowTemplate.Height = 28;
            this.dataGridViewVB.Size = new System.Drawing.Size(1296, 435);
            this.dataGridViewVB.TabIndex = 5;
            this.dataGridViewVB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVB_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpadate);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.txtbookPrice);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtbookquantity);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBpubli);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBauthorN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtbookname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 697);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 414);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1086, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 49);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(955, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 49);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpadate
            // 
            this.btnUpadate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpadate.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpadate.Location = new System.Drawing.Point(825, 324);
            this.btnUpadate.Name = "btnUpadate";
            this.btnUpadate.Size = new System.Drawing.Size(110, 49);
            this.btnUpadate.TabIndex = 5;
            this.btnUpadate.Text = "Upadte";
            this.btnUpadate.UseVisualStyleBackColor = true;
            this.btnUpadate.Click += new System.EventHandler(this.btnUpadate_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(919, 31);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(327, 41);
            this.txtDate.TabIndex = 3;
            // 
            // txtbookPrice
            // 
            this.txtbookPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookPrice.Location = new System.Drawing.Point(919, 127);
            this.txtbookPrice.Multiline = true;
            this.txtbookPrice.Name = "txtbookPrice";
            this.txtbookPrice.Size = new System.Drawing.Size(327, 41);
            this.txtbookPrice.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(654, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 35);
            this.label7.TabIndex = 1;
            this.label7.Text = "Book Price:";
            // 
            // txtbookquantity
            // 
            this.txtbookquantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookquantity.Location = new System.Drawing.Point(921, 235);
            this.txtbookquantity.Multiline = true;
            this.txtbookquantity.Name = "txtbookquantity";
            this.txtbookquantity.Size = new System.Drawing.Size(327, 41);
            this.txtbookquantity.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(654, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 35);
            this.label8.TabIndex = 1;
            this.label8.Text = "Book Quantity:";
            // 
            // txtBpubli
            // 
            this.txtBpubli.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBpubli.Location = new System.Drawing.Point(304, 235);
            this.txtBpubli.Multiline = true;
            this.txtBpubli.Name = "txtBpubli";
            this.txtBpubli.Size = new System.Drawing.Size(327, 41);
            this.txtBpubli.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 35);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book Publication:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(654, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 35);
            this.label6.TabIndex = 1;
            this.label6.Text = "Book Purchase Date:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBauthorN
            // 
            this.txtBauthorN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBauthorN.Location = new System.Drawing.Point(304, 127);
            this.txtBauthorN.Multiline = true;
            this.txtBauthorN.Name = "txtBauthorN";
            this.txtBauthorN.Size = new System.Drawing.Size(327, 41);
            this.txtBauthorN.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Author Name:";
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(304, 25);
            this.txtbookname.Multiline = true;
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(327, 41);
            this.txtbookname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Book Name:";
            // 
            // ViewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1275, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewVB);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ViewBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBookForm";
            this.Load += new System.EventHandler(this.ViewBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridViewVB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBauthorN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBpubli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbookPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbookquantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpadate;
        private System.Windows.Forms.TextBox txtDate;
    }
}
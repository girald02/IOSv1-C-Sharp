
namespace IOSv1
{
    partial class uploadCCL_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uploadCCL_frm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_invoiceNo = new System.Windows.Forms.Label();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.lbl_blNo = new System.Windows.Forms.Label();
            this.txtBlNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboOrigin = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.txtTransdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTmpRefNo = new System.Windows.Forms.TextBox();
            this.lbl_tmpRefNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(93, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(215, 26);
            this.txtFileName.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(18, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 508);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(614, 674);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(747, 674);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "FileName:";
            // 
            // lbl_invoiceNo
            // 
            this.lbl_invoiceNo.AutoSize = true;
            this.lbl_invoiceNo.Location = new System.Drawing.Point(15, 61);
            this.lbl_invoiceNo.Name = "lbl_invoiceNo";
            this.lbl_invoiceNo.Size = new System.Drawing.Size(72, 13);
            this.lbl_invoiceNo.TabIndex = 8;
            this.lbl_invoiceNo.Text = "INVOICE NO:";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoice.Location = new System.Drawing.Point(93, 53);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(215, 26);
            this.txtInvoice.TabIndex = 9;
            // 
            // lbl_blNo
            // 
            this.lbl_blNo.AutoSize = true;
            this.lbl_blNo.Location = new System.Drawing.Point(15, 94);
            this.lbl_blNo.Name = "lbl_blNo";
            this.lbl_blNo.Size = new System.Drawing.Size(42, 13);
            this.lbl_blNo.TabIndex = 10;
            this.lbl_blNo.Text = "BL NO:";
            // 
            // txtBlNo
            // 
            this.txtBlNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlNo.Location = new System.Drawing.Point(93, 86);
            this.txtBlNo.Name = "txtBlNo";
            this.txtBlNo.Size = new System.Drawing.Size(215, 26);
            this.txtBlNo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ETA (Port)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cboOrigin);
            this.groupBox1.Controls.Add(this.cboModel);
            this.groupBox1.Controls.Add(this.txtTransdate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTmpRefNo);
            this.groupBox1.Controls.Add(this.lbl_tmpRefNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBlNo);
            this.groupBox1.Controls.Add(this.lbl_blNo);
            this.groupBox1.Controls.Add(this.txtInvoice);
            this.groupBox1.Controls.Add(this.lbl_invoiceNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 722);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "::::::::::::";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(18, 674);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 31);
            this.button3.TabIndex = 26;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 26);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // cboOrigin
            // 
            this.cboOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigin.FormattingEnabled = true;
            this.cboOrigin.Location = new System.Drawing.Point(659, 50);
            this.cboOrigin.Name = "cboOrigin";
            this.cboOrigin.Size = new System.Drawing.Size(215, 26);
            this.cboOrigin.TabIndex = 24;
            this.cboOrigin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboModel
            // 
            this.cboModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(659, 82);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(215, 26);
            this.cboModel.TabIndex = 23;
            // 
            // txtTransdate
            // 
            this.txtTransdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransdate.Location = new System.Drawing.Point(659, 115);
            this.txtTransdate.Name = "txtTransdate";
            this.txtTransdate.Size = new System.Drawing.Size(215, 26);
            this.txtTransdate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "TRANSDATE:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "MODEL:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ORIGIN:";
            // 
            // txtTmpRefNo
            // 
            this.txtTmpRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTmpRefNo.Location = new System.Drawing.Point(659, 18);
            this.txtTmpRefNo.Name = "txtTmpRefNo";
            this.txtTmpRefNo.Size = new System.Drawing.Size(215, 26);
            this.txtTmpRefNo.TabIndex = 15;
            this.txtTmpRefNo.TextChanged += new System.EventHandler(this.txtTmpRefNo_TextChanged);
            // 
            // lbl_tmpRefNo
            // 
            this.lbl_tmpRefNo.AutoSize = true;
            this.lbl_tmpRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tmpRefNo.Location = new System.Drawing.Point(546, 24);
            this.lbl_tmpRefNo.Name = "lbl_tmpRefNo";
            this.lbl_tmpRefNo.Size = new System.Drawing.Size(104, 16);
            this.lbl_tmpRefNo.TabIndex = 14;
            this.lbl_tmpRefNo.Text = "TMP REF NO.";
            // 
            // uploadCCL_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 746);
            this.Controls.Add(this.groupBox1);
            this.Name = "uploadCCL_frm";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.menu_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_invoiceNo;
        private System.Windows.Forms.TextBox txtInvoice;
        private System.Windows.Forms.Label lbl_blNo;
        private System.Windows.Forms.TextBox txtBlNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTransdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTmpRefNo;
        private System.Windows.Forms.Label lbl_tmpRefNo;
        private System.Windows.Forms.ComboBox cboOrigin;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
    }
}
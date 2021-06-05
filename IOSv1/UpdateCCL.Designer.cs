
namespace IOSv1
{
    partial class updateCCL_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updateCCL_frm));
            this.chkPartOff = new System.Windows.Forms.CheckBox();
            this.chkStandard = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtContainerNo = new System.Windows.Forms.TextBox();
            this.txtTmpRefNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPartOff
            // 
            this.chkPartOff.AutoSize = true;
            this.chkPartOff.Location = new System.Drawing.Point(23, 34);
            this.chkPartOff.Name = "chkPartOff";
            this.chkPartOff.Size = new System.Drawing.Size(81, 24);
            this.chkPartOff.TabIndex = 0;
            this.chkPartOff.Text = "Part-off";
            this.chkPartOff.UseVisualStyleBackColor = true;
            // 
            // chkStandard
            // 
            this.chkStandard.AutoSize = true;
            this.chkStandard.Location = new System.Drawing.Point(135, 34);
            this.chkStandard.Name = "chkStandard";
            this.chkStandard.Size = new System.Drawing.Size(94, 24);
            this.chkStandard.TabIndex = 1;
            this.chkStandard.Text = "Standard";
            this.chkStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnContinue);
            this.groupBox1.Controls.Add(this.txtContainerNo);
            this.groupBox1.Controls.Add(this.txtTmpRefNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkPartOff);
            this.groupBox1.Controls.Add(this.chkStandard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Browse Container Content List";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(288, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.DarkCyan;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(176, 153);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(106, 38);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // txtContainerNo
            // 
            this.txtContainerNo.Location = new System.Drawing.Point(153, 97);
            this.txtContainerNo.Name = "txtContainerNo";
            this.txtContainerNo.Size = new System.Drawing.Size(241, 26);
            this.txtContainerNo.TabIndex = 5;
            // 
            // txtTmpRefNo
            // 
            this.txtTmpRefNo.Location = new System.Drawing.Point(153, 65);
            this.txtTmpRefNo.Name = "txtTmpRefNo";
            this.txtTmpRefNo.Size = new System.Drawing.Size(241, 26);
            this.txtTmpRefNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTAINER NO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(22, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "TMP REF NO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateCCL_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(443, 233);
            this.Controls.Add(this.groupBox1);
            this.Name = "updateCCL_frm";
            this.Text = "Update CCL";
            this.Load += new System.EventHandler(this.updateCCL_frm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPartOff;
        private System.Windows.Forms.CheckBox chkStandard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtContainerNo;
        private System.Windows.Forms.TextBox txtTmpRefNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
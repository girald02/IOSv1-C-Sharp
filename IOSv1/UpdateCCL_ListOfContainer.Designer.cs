
namespace IOSv1
{
    partial class UpdateCCL_ListOfContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCCL_ListOfContainer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_tmpref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_blno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_contents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTotalContainer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_tmpref,
            this.col_cont,
            this.col_blno,
            this.col_trans,
            this.col_contents});
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 380);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // col_tmpref
            // 
            this.col_tmpref.HeaderText = "TMP Reference";
            this.col_tmpref.Name = "col_tmpref";
            this.col_tmpref.ReadOnly = true;
            // 
            // col_cont
            // 
            this.col_cont.HeaderText = "Container";
            this.col_cont.Name = "col_cont";
            this.col_cont.ReadOnly = true;
            // 
            // col_blno
            // 
            this.col_blno.HeaderText = "BL No";
            this.col_blno.Name = "col_blno";
            this.col_blno.ReadOnly = true;
            // 
            // col_trans
            // 
            this.col_trans.HeaderText = "Transdate";
            this.col_trans.Name = "col_trans";
            this.col_trans.ReadOnly = true;
            // 
            // col_contents
            // 
            this.col_contents.HeaderText = "Contents";
            this.col_contents.Name = "col_contents";
            this.col_contents.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 2;
            // 
            // txtTotalContainer
            // 
            this.txtTotalContainer.Location = new System.Drawing.Point(102, 432);
            this.txtTotalContainer.Name = "txtTotalContainer";
            this.txtTotalContainer.Size = new System.Drawing.Size(81, 20);
            this.txtTotalContainer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. of Container";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(398, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(479, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // UpdateCCL_ListOfContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalContainer);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateCCL_ListOfContainer";
            this.Text = "List of Container ";
            this.Load += new System.EventHandler(this.UpdateCCL_ListOfContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtTotalContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tmpref;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cont;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_blno;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_trans;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_contents;
    }
}
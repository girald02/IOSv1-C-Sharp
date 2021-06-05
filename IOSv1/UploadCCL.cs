using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using CsvHelper;
using MySql.Data.MySqlClient;


namespace IOSv1
{
    public partial class uploadCCL_frm : Form
    {
        MySqlConnection con = new MySqlConnection("datasource= localhost; database=importsys_db;port=3306; username = root; password= "); //open connection
        MySqlCommand cmd;
        MySqlDataAdapter sqlAdpt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public uploadCCL_frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //txtFileName.Text = openFileDialog1.FileName;
                txtFileName.Text = Path.GetFileName(openFileDialog1.FileName);
                try
                {
                    // your code here 
                    string CSVFilePathName = openFileDialog1.FileName;
                    string[] Lines = File.ReadAllLines(CSVFilePathName);
                    string[] Fields;
                    Fields = Lines[0].Split(new char[] { ',' });
                    int Cols = Fields.GetLength(0);
                    DataTable dt = new DataTable();

                    if (Cols < 5)
                    {
                        MessageBox.Show("Please select the correct CSV PATH!");
                    }
                    else
                    {
                        btnSave.Enabled = true;
                        //1st row must be column names; force lower case to ensure matching later on.
                        for (int i = 0; i < Cols; i++)
                            dt.Columns.Add(Fields[i].ToLower(), typeof(string));
                        DataRow Row;
                        for (int i = 1; i < Lines.GetLength(0); i++)
                        {
                            Fields = Lines[i].Split(new char[] { ',' });
                            Row = dt.NewRow();
                            for (int f = 0; f < Cols; f++)
                                Row[f] = Fields[f];
                            dt.Rows.Add(Row);
                        }
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error is " + ex.ToString());
                    throw;
                }
            }
        }

        private void menu_frm_Load(object sender, EventArgs e)
        {
            //DEFAULT
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ReadOnly = true;
            txtFileName.Enabled = false;
            this.ActiveControl = txtInvoice;
            btnSave.Enabled = false;

            //STYLE COMBOBOX
            this.cboOrigin.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboModel.DropDownStyle = ComboBoxStyle.DropDownList;

            //AUTO LOAD DATA
            txtTransdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            txtTransdate.Enabled = false;

            //
            // COMBO BOX - [Origin]
            //
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM origin ORDER BY or_desc ASC;", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboOrigin.Items.Add(reader["or_desc"]);
                }

                con.Close();
                reader.Dispose();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            //
            // COMBO BOX - [Model]
            //
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `model` ORDER BY `mode_code` ASC;", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cboModel.Items.Add(reader["mode_code"]);
                }

                con.Close();
                reader.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void txtTmpRefNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connectionString = new MySqlConnection("datasource= localhost; database=importsys_db;port=3306; username = root; password= "); //open connection
                connectionString.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT tmpRefNo FROM h_module WHERE tmpRefNo ='" + txtTmpRefNo.Text + "'", connectionString);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Sorry "+ txtTmpRefNo.Text +" exist!");
                    txtTmpRefNo.Text = "";
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }
                con.Close();
                reader.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //
            //TextBox Data
            //
            string invoiceNo = txtInvoice.Text;
            string blNo = txtBlNo.Text;
            string tmpRefNo = txtTmpRefNo.Text;
            string origin = cboOrigin.Text;
            string model = cboModel.Text;
            string transDate = txtTransdate.Text;
            string eta = dateTimePicker1.Text;

            //
            //IF STATEMENT
            //
            if (txtFileName.Text == "")
            {
                MessageBox.Show("Please upload CSV First!");
            }
            else if(invoiceNo == "" || blNo == "" || blNo == "" || tmpRefNo == "" || origin == "" || model == "" || transDate == "" || eta == "")
            {
                MessageBox.Show("Please complete all the required fields");
                lbl_tmpRefNo.BackColor = Color.Crimson;
                lbl_invoiceNo.BackColor = Color.Crimson;
                lbl_blNo.BackColor = Color.Crimson;
            }
            else
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    cmd = new MySqlCommand("INSERT INTO `d_module`(`seal`, `cont`, `renban`, `csize`, `lot`, `caseno`, `data1`, `data2`, `tmpRefNo`) " +
                                           "VALUES (@seal,@cont,@renban,@csize,@lot,@caseno,@data1,@data2,@tmpRefNo)", con);
                    con.Open();

                    if (r.Cells[0].Value == null)
                    {
                        MessageBox.Show("Saved successfully!");
                        this.Close();
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@seal", r.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@cont", r.Cells[1].Value);
                        cmd.Parameters.AddWithValue("@renban", r.Cells[2].Value);
                        cmd.Parameters.AddWithValue("@csize", r.Cells[3].Value);
                        cmd.Parameters.AddWithValue("@lot", r.Cells[4].Value);
                        cmd.Parameters.AddWithValue("@caseno", r.Cells[5].Value);
                        cmd.Parameters.AddWithValue("@data1", r.Cells[6].Value);
                        cmd.Parameters.AddWithValue("@data2", r.Cells[7].Value);
                        cmd.Parameters.AddWithValue("@tmpRefNo", tmpRefNo.ToString());

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }//end else
                }//end foreach

                cmd = new MySqlCommand("INSERT INTO `h_module`( `tmpRefNo`, `invoiceNo`, `blno`, `origin`, `model` , `transdate`, `eta`) " +
                                         "VALUES (@tmpRefNo, @invoiceNo, @blno, @origin, @model, @transdate, @eta)", con);

                cmd.Parameters.AddWithValue("@tmpRefNo", tmpRefNo);
                cmd.Parameters.AddWithValue("@invoiceNo", invoiceNo);
                cmd.Parameters.AddWithValue("@blno", blNo);
                cmd.Parameters.AddWithValue("@origin", tmpRefNo);
                cmd.Parameters.AddWithValue("@model", model);
                cmd.Parameters.AddWithValue("@transdate", transDate);
                cmd.Parameters.AddWithValue("@eta", eta);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }


        public void clear()
        {
            txtBlNo.Text = "";
            txtFileName.Text = "";
            txtInvoice.Text = "";
            txtTmpRefNo.Text = "";
            cboOrigin.SelectedIndex = -1;
            cboModel.SelectedIndex = -1;
            dataGridView1.Columns.Clear();
        }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;


namespace IOSv1
{
    public partial class UpdateCCL_ListOfContainer : Form
    {

        //arraylist to getter and setter data  
        private static ArrayList arr_tmpReference = new ArrayList();
        private static ArrayList arr_container = new ArrayList();
        private static ArrayList arr_blno = new ArrayList();
        private static ArrayList arr_transdate = new ArrayList();
        public static string txtRefno = "";
        public static string txtContainer = "";

        public UpdateCCL_ListOfContainer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];

                txtRefno = row.Cells["col_tmpref"].Value.ToString();
                txtContainer = row.Cells["col_cont"].Value.ToString();
                this.Hide();

                updateCCL_frm frm = new updateCCL_frm();
                frm.Show();
            }
        }

        private void UpdateCCL_ListOfContainer_Load(object sender, EventArgs e)
        {
            //
            //AUTO LOAD
            //
            txtTotalContainer.Enabled = false;

            //
            //TRY CATCH
            //
            try
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; database=importsys_db;port=3306; username = root; password= "); //open connection
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT d_module.tmpRefNo, d_module.cont , h_module.blno , h_module.transdate " +
                                                    "FROM d_module " +
                                                    "INNER JOIN h_module " +
                                                    "ON d_module.tmpRefNo = h_module.tmpRefNo", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                     arr_tmpReference.Add(reader["tmpRefNo"].ToString());
                     arr_container.Add(reader["cont"].ToString());
                     arr_blno.Add(reader["blno"].ToString());
                     arr_transdate.Add(reader["transdate"].ToString());
                }

                cmd.Dispose();
                con.Close(); // always close connection 
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            dataGridView1.Rows.Clear(); //Clear DataGrid

            for (int i = 0; i < arr_tmpReference.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = arr_tmpReference[i];
                newRow.Cells[1].Value = arr_container[i];
                newRow.Cells[2].Value = arr_blno[i];
                newRow.Cells[3].Value = arr_transdate[i];
                dataGridView1.Rows.Add(newRow);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string totalNo = "";
                MySqlConnection con = new MySqlConnection("datasource= localhost; database=importsys_db;port=3306; username = root; password= "); //open connection

                for (int i = 0; i < arr_tmpReference.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = arr_tmpReference[i];
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(cont) AS totalContainer FROM d_module WHERE tmpRefNo='" + newRow.Cells[0].Value + "'", con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        totalNo = reader["totalContainer"].ToString();
                    }

                    cmd.Dispose();
                    con.Close(); // always close connection 
                }

                txtTotalContainer.Text = totalNo;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}

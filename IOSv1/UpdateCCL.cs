using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOSv1
{
    public partial class updateCCL_frm : Form
    {
        public updateCCL_frm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //
            //TEXTBOX
            //
            string tmpRefNo = txtTmpRefNo.Text;
            string containerNo = txtContainerNo.Text;

            //
            //VALIDATION    
            //
            if(tmpRefNo == "" || containerNo == "")
            {
                MessageBox.Show("Please complete all the required fields");
            }
            else
            {
                //Do Something
                MessageBox.Show("Reference No:" + tmpRefNo + " \n" + "Container:" + containerNo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCCL_ListOfContainer frm = new UpdateCCL_ListOfContainer();
            frm.Show();
            this.Hide();
        }

        private void updateCCL_frm_Load(object sender, EventArgs e)
        {
            if (txtTmpRefNo.Text == "" || txtContainerNo.Text == "")
            {
                txtTmpRefNo.Text = UpdateCCL_ListOfContainer.txtRefno.ToString();
                txtContainerNo.Text = UpdateCCL_ListOfContainer.txtContainer.ToString();
            }
            else
            {
                txtTmpRefNo.Text = UpdateCCL_ListOfContainer.txtRefno.ToString();
                txtContainerNo.Text = UpdateCCL_ListOfContainer.txtContainer.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131_ExeCRUDWinForm_
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            // TODO: This line of code loads data into the 'hRDataSet.empdetails' table. You can move, or remove it, as needed.
            this.datapegawaiTableAdapter.Fill(this.caffeDataSet.datapegawai);
            //This line of code loads data into the hRDataSet.Empdetails table. this would appear in form 1 load event
            this.datapegawaiTableAdapter.Fill(this.caffeDataSet.datapegawai);
            txidpegawai.Enabled = false;
            txnamapegawai.Enabled = false;
            txphonenumber.Enabled = false;
            txjeniskelamin.Enabled = false;
            txalamat.Enabled = false;
            btnsave.Enabled = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            dt = caffeDataSet.Tables["datapegawai"];
            dr = dt.NewRow();
            dr[0] = txidpegawai.Text;
            dr[1] = txnamapegawai.Text;
            dr[2] = txphonenumber.Text;
            dr[3] = txjeniskelamin.Text;
            dr[4] = txalamat.Text;
            dt.Rows.Add(dr);
            datapegawaiTableAdapter.Update(caffeDataSet);
            txidpegawai.Text = System.Convert.ToString(dr[0]);
            txidpegawai.Enabled = false;
            txnamapegawai.Enabled = false;
            txphonenumber.Enabled = false;
            txjeniskelamin.Enabled = false;
            txalamat.Enabled = false;
            this.datapegawaiTableAdapter.Fill(this.caffeDataSet.datapegawai);
            btadd.Enabled = true;
            btnsave.Enabled = false;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            btnsave.Enabled = true;
            txidpegawai.Enabled = true;
            txnamapegawai.Enabled = true;
            txphonenumber.Enabled = true;
            txjeniskelamin.Enabled = true;
            txalamat.Enabled = true;
            txidpegawai.Text = "";
            txnamapegawai.Text = "";
            txphonenumber.Text = "";
            txjeniskelamin.Text = "";
            txalamat.Text = "";
            int ctr, len;
            string codeval;
            dt = caffeDataSet.Tables["datapegawai"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            Code = dr["idpegawai"].ToString();
            codeval = Code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 0) && (ctr < 9))
            {
                ctr = ctr + 1;
                idpegawai.Text = "C00" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                idpegawai.Text = "C0" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                idpegawai.Text = "C" + ctr;
            }
            btadd.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataTable dt;
            DataRow dr;
            string Code;

            Code = txidpegawai.Text;
            dr = caffeDataSet.Tables["datapegawai"].Rows.Find(Code);
            dr.Delete();
            datapegawaiTableAdapter.Update(caffeDataSet);
        }
    }
}
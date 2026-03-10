using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOAppp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);

                conn.Open();

                lblstatus().Text = "Status : Database Connected";

                MessageBox.Show("Koneksi ke database berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal : " + ex.Message)
            }
        }

        private void btnDisconnect(object sender, EventArgs e)
        {

        }

        private void lblstatus(object sender, EventArgs e)
        {

        }
    }
}

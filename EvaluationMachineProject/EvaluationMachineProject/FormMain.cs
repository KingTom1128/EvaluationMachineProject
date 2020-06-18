using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationMachineProject
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            string connString = "Data Source = .; Initial Catalog = EvaluationMachineProject; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            string sql = String.Format("select Id from Problem");
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                string id = (string)dr[0];
                cmbNumber.Items.Add(id);
            }
            dr.Close();
            conn.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }

        private void cmbNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = "Data Source = .; Initial Catalog = EvaluationMachineProject; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            string sql = String.Format("select * from Problem where Id = '{0}'", cmbNumber.Text);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                textTestInput.Text = (string)dr["TestInput"];
                textTestOuput.Text = (string)dr["Testoutput"];
                textDesc.Text = (string)dr["Desc"];
            }
            dr.Close();
            conn.Close();
        }
    }
}

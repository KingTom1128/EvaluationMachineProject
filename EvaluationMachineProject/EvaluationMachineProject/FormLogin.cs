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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            string username = textUserName.Text.Trim();
            string password = textPassword.Text;
            int type = 0;
            if (radioUser.Checked)
            {
                type = 0;
            }
            if (radioManager.Checked)
            {
                type = 1;
            }
            string connString = "Data Source = .; Initial Catalog = EvaluationMachineProject; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connString);
            string sql = String.Format("select count(*) from Person where UserName = '{0}' and Password = '{1}' and Type = '{2}'", username, password, type);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            int count = (int)comm.ExecuteScalar();
            if (count == 1)
            {
                this.DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("登陆失败");
            }
            conn.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            radioUser.Checked = true;
        }
    }
}

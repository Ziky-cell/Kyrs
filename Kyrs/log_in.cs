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

namespace Kyrs
{
    public partial class log_in : Form
    {

        DataBese dataBase = new DataBese();
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            pictureBox3.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string guerystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}' ";

            SqlCommand command = new SqlCommand(guerystring, dataBase.GetConnection());
            
            adapter.SelectCommand= command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Desktop desktop = new Desktop();
                this.Hide();
                desktop.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            sign_up la = new sign_up();
            this.Hide();
            la.ShowDialog();
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;


         
        }
    }
}

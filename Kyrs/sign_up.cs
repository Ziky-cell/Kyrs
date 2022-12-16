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
    public partial class sign_up : Form
    {
            DataBese dataBese = new DataBese();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Сheckгser())
            {
                return;
            }
            var login = textBox_login2.Text;
            var password = textBox_password2.Text;

            string guerystring = $"insert into register ( login_user, password_user) values('{login}', '{password}')";


            SqlCommand command = new SqlCommand(guerystring, dataBese.GetConnection());

            dataBese.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!","Успех!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBese.closeConnection();

        }

        private Boolean Сheckгser()
        {
            var loginUser = textBox_login2.Text;
            var passUser = textBox_password2.Text;


            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string guerystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}'and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(guerystring, dataBese.GetConnection());

            adapter.SelectCommand=command;
            adapter.Fill(table);

            if(table.Rows.Count > 0) 
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }


        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox_password2.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }
        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox_password2.PasswordChar = '*';
            pictureBox2.Visible = false;

        }





        private void button1_Click(object sender, EventArgs e)
        {
            textBox_login2.Text = "";
            textBox_password2.Text = "";
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

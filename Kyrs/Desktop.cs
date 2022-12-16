using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 addfrm = new Form1();
            addfrm.Show();
        }

        private void Desktop_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 addfrm = new Form2();
            addfrm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 addfrm = new Form3();
            addfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

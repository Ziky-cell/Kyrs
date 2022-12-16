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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kyrs
{
    public partial class Add_Form2 : Form
    {
        DataBese dataBase = new DataBese();
        public Add_Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var surname = textBox_surname.Text;
            var name = textBox_name.Text;
            var patronymic = textBox_patronymic.Text;
            int age;
            var driverClass = textBox_BriverClass.Text;
            var modelAuto = textBox_ModelAuto.Text;

            if (int.TryParse(textBox_age.Text, out age))
            {
                var addQuery = $"insert into driver_db (surname, name, patronymic, age, driverClass, modelAuto) values ('{surname}', '{name}', '{patronymic}', '{age}', '{driverClass}', '{modelAuto}')";

                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();


                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Возраст должен иметь числовой формат ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }
    }
}

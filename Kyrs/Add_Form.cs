using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kyrs
{

    public partial class Add_Form : Form
    {
        DataBese dataBase = new DataBese();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var model = textBox_model2.Text;
            var LoadCapacity = textBox_load2.Text;
            int VehicleInventoryNumbers;

            if(int.TryParse(textBox52.Text, out VehicleInventoryNumbers))
            {
                var addQuery = $"insert into avto_db (model, LoadCapacity, VehicleInventoryNumbers) values ('{model}', '{LoadCapacity}', '{VehicleInventoryNumbers}')";

                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();


                MessageBox.Show("Запись успешно создана", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Инвентарный номер автомобиля должен иметь числовой формат ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }

        private void Add_Form_Load(object sender, EventArgs e)
        {

        }
    }
}

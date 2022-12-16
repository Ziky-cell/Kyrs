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
    enum RowState3
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        ModifiedNew2,
        Deleted
    }
    public partial class Form3 : Form
    {
        DataBese dataBase = new DataBese();

        int selectedRow;
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("modelAuto", "Модель авто");
            dataGridView1.Columns.Add("DriverFullName", "Полное ФИО водителя:");
            dataGridView1.Columns.Add("CarMileagePerDayInKm", "Пробег автомобиля в День В Км:");
            dataGridView1.Columns.Add("FreightInTonKilometers", "Груз В Тонно Километрах:");
            dataGridView1.Columns.Add("FuelConsumptionInLiters", "Расход топлива в Литрах:");
            dataGridView1.Columns.Add("ISNew", String.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetInt32(5), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from MachineConsumment_db";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_modelAuto.Text = row.Cells[1].Value.ToString();
                textBox_DriverFullName.Text = row.Cells[2].Value.ToString();
                textBox_CarMileagePerDayInKm.Text = row.Cells[3].Value.ToString();
                textBox_FreightInTonKilometers.Text = row.Cells[4].Value.ToString();
                textBox_FuelConsumptionInLiters.Text = row.Cells[5].Value.ToString();
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)//Обновление
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)//Новая запись
        {
            Add_Form3 addfrm = new Add_Form3();
            addfrm.Show();
        }






        private void Search(DataGridView dgw)//поиск
        {
            dgw.Rows.Clear();

            string searchString = $"select * from MachineConsumment_db where concat (id, modelAuto, DriverFullName, CarMileagePerDayInKm, FreightInTonKilometers, FuelConsumptionInLiters) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();

        }

        private void textBox_search_TextChanged(object sender, EventArgs e)//поиск
        {
            Search(dataGridView1);
        }





        private void deleteRow()//удалить
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[6].Value = RowState.Deleted;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }





        private new void Update()//сохранить
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[6].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from MachineConsumment_db where id = {id} ";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var modelAuto = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var DriverFullName = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var CarMileagePerDayInKm = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var FreightInTonKilometers = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var FuelConsumptionInLiters = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    


                    var changeQuery = $"update MachineConsumment_db set modelAuto = '{modelAuto}', DriverFullName = '{DriverFullName}', CarMileagePerDayInKm = '{CarMileagePerDayInKm}', FreightInTonKilometers = '{FreightInTonKilometers}', FuelConsumptionInLiters = '{FuelConsumptionInLiters}' where id = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }

            dataBase.closeConnection();
        }

        private void button4_Click(object sender, EventArgs e)//сохранить
        {
            Update();
        }








        private void Change()//изменить
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var modelAuto = textBox_modelAuto.Text;
            var DriverFullName = textBox_DriverFullName.Text;
            var CarMileagePerDayInKm = textBox_CarMileagePerDayInKm.Text;
            var FreightInTonKilometers = textBox_FreightInTonKilometers.Text;
            int FuelConsumptionInLiters;
            


            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_FuelConsumptionInLiters.Text, out FuelConsumptionInLiters))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, modelAuto, DriverFullName, CarMileagePerDayInKm, FreightInTonKilometers, FuelConsumptionInLiters);

                    dataGridView1.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                }
                else
                {

                    MessageBox.Show("Должно быть число");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//изменить
        {
            Change();
            ClearFields();
        }







        private void ClearFields()// очистка
        {
            textBox_ID.Text = "";
            textBox_modelAuto.Text = "";
            textBox_DriverFullName.Text = "";
            textBox_CarMileagePerDayInKm.Text = "";
            textBox_FreightInTonKilometers.Text = "";
            textBox_FuelConsumptionInLiters.Text = "";
          
        }

        private void btnClear_Click(object sender, EventArgs e)// очистка
        {
            ClearFields();
        }











        private void button5_Click(object sender, EventArgs e)//Главное меню
        {

            Desktop desktop = new Desktop();
            this.Hide();
            desktop.ShowDialog();
            this.Show();
        }





        private void button6_Click(object sender, EventArgs e)//Завершение работы
        {
            Application.Exit();
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}

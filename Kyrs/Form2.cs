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
    enum RowState2
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        ModifiedNew2,
        Deleted
    }
    public partial class Form2 : Form
    {
        DataBese dataBase = new DataBese();

        int selectedRow;
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("patronymic", "Отчество");
            dataGridView1.Columns.Add("age", "Возраст");
            dataGridView1.Columns.Add("BriverClass", "Класс водителя");
            dataGridView1.Columns.Add("ModelAuto", "Модель его автомобиля");
            dataGridView1.Columns.Add("ISNew", String.Empty);

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetInt32(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from driver_db";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
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
                textBox_surname.Text = row.Cells[1].Value.ToString();
                textBox_name.Text = row.Cells[2].Value.ToString();
                textBox_patronymic.Text = row.Cells[3].Value.ToString();
                textBox_age.Text = row.Cells[4].Value.ToString();
                textBox_BriverClass.Text = row.Cells[5].Value.ToString();
                textBox_ModelAuto.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)//Обновление
        {
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)//Новая запись
        {
            Add_Form2 addfrm = new Add_Form2();
            addfrm.Show();
        }







        private void Search(DataGridView dgw)//поиск
        {
            dgw.Rows.Clear();

            string searchString = $"select * from driver_db where concat (id, surname, name, patronymic, age, driverClass, modelAuto) like '%" + textBox_search.Text + "%'";

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
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void button2_Click(object sender, EventArgs e)//удалить
        {
            deleteRow();
            ClearFields();
        }






        private new void Update()//сохранить
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                    continue;

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from driver_db where id = {id} ";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var surname = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var name = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var patronymic = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var age = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var BriverClass = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var ModelAuto = dataGridView1.Rows[index].Cells[6].Value.ToString();


                    var changeQuery = $"update driver_db set surname = '{surname}', name = '{name}', patronymic = '{patronymic}', age = '{age}', driverClass = '{BriverClass}', modelAuto = '{ModelAuto}' where id = '{id}'";

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
            var surname = textBox_surname.Text;
            var name = textBox_name.Text;
            var patronymic = textBox_patronymic.Text;
            int age;
            var BriverClass = textBox_BriverClass.Text;
            var ModelAuto = textBox_ModelAuto.Text;
           

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_age.Text, out age))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, surname, name, patronymic, age, BriverClass, ModelAuto);

                    dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
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
            textBox_surname.Text = "";
            textBox_name.Text = "";
            textBox_patronymic.Text = "";
            textBox_age.Text = "";
            textBox_BriverClass.Text = "";
            textBox_ModelAuto.Text = "";
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


        private void but_search_Click(object sender, EventArgs e)
        {

        }

        private void textBox_age_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}

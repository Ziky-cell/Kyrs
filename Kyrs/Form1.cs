using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kyrs
{

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        ModifiedNew2,
        Deleted
    }

    public partial class Form1 : Form
    {

        DataBese dataBase = new DataBese();

        int selectedRow;
        

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id","id");
            dataGridView1.Columns.Add("model", "Модель");
            dataGridView1.Columns.Add("load", "Грузоподъемности");
            dataGridView1.Columns.Add("rooms", "Инвентарных номерах автомобилей");
            dataGridView1.Columns.Add("ISNew", String.Empty);

        }

        private void ReadSingleRow(DataGridView dgw,IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1),record.GetInt32(2), record.GetInt32(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from avto_db";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);

           

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
               DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_ID.Text = row.Cells[0].Value.ToString();
                textBox_model.Text = row.Cells[1].Value.ToString();
                textBox_load.Text = row.Cells[2].Value.ToString();
                textBox5.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)//Обновление
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)//Новая запись
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)//поиск
        {
            dgw.Rows.Clear();

            string searchString = $"select * from avto_db where concat (id, model, LoadCapacity, VehicleInventoryNumbers) like '%" +  textBox_search.Text + "%'";

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





        private new void Update()//сохранить
        {
            dataBase.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                    continue;

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from avto_db where id = {id} ";

                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();

                }
                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var model = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var load = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var rooms = dataGridView1.Rows[index].Cells[3].Value.ToString();


                    var changeQuery = $"update avto_db set model = '{model}', LoadCapacity = '{load}', VehicleInventoryNumbers = '{rooms}' where id = '{id}'";

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





        private void deleteRow()//удалить
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void button2_Click(object sender, EventArgs e)//удалить
        {
            deleteRow();
            ClearFields();
        }





        private void Change()//изменить
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_ID.Text;
            var model = textBox_model.Text;
            var load = textBox_load.Text;
            int rooms;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if(int.TryParse(textBox5.Text, out rooms))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, model,load,rooms);

                    dataGridView1.Rows[selectedRowIndex].Cells[4].Value = RowState.Modified;
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
            textBox_model.Text = "";
            textBox_load.Text = "";
            textBox5.Text = "";
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

    }
}

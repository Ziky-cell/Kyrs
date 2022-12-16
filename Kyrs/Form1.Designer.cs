namespace Kyrs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_ID = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_rooms = new System.Windows.Forms.Label();
            this.label_load = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_load = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.but_search = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_ID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, -8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel_ID);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 585);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авто";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(621, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 144);
            this.panel3.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 58);
            this.button5.TabIndex = 1;
            this.button5.Text = "Выход в главное меню:";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Главное меню";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(402, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 193);
            this.panel2.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 33);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изминить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Новая запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(398, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Управление записями:";
            // 
            // panel_ID
            // 
            this.panel_ID.Controls.Add(this.label2);
            this.panel_ID.Controls.Add(this.label_rooms);
            this.panel_ID.Controls.Add(this.label_load);
            this.panel_ID.Controls.Add(this.label_model);
            this.panel_ID.Controls.Add(this.label1);
            this.panel_ID.Controls.Add(this.textBox5);
            this.panel_ID.Controls.Add(this.textBox_load);
            this.panel_ID.Controls.Add(this.textBox_model);
            this.panel_ID.Controls.Add(this.textBox_ID);
            this.panel_ID.Location = new System.Drawing.Point(6, 366);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(372, 214);
            this.panel_ID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Запись:";
            // 
            // label_rooms
            // 
            this.label_rooms.AutoSize = true;
            this.label_rooms.Location = new System.Drawing.Point(32, 127);
            this.label_rooms.Name = "label_rooms";
            this.label_rooms.Size = new System.Drawing.Size(194, 13);
            this.label_rooms.TabIndex = 7;
            this.label_rooms.Text = "Инвентарных номерах автомобилей:";
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.Location = new System.Drawing.Point(119, 101);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(107, 13);
            this.label_load.TabIndex = 6;
            this.label_load.Text = "Грузоподъемности:";
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Location = new System.Drawing.Point(174, 74);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(49, 13);
            this.label_model.TabIndex = 5;
            this.label_model.Text = "Модель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(232, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox_load
            // 
            this.textBox_load.Location = new System.Drawing.Point(232, 98);
            this.textBox_load.Name = "textBox_load";
            this.textBox_load.Size = new System.Drawing.Size(100, 20);
            this.textBox_load.TabIndex = 2;
            // 
            // textBox_model
            // 
            this.textBox_model.Location = new System.Drawing.Point(232, 72);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(100, 20);
            this.textBox_model.TabIndex = 1;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(232, 46);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 301);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.but_search);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 53);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Запрос Автомобили:";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(682, 17);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(100, 20);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(602, 15);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(75, 23);
            this.but_search.TabIndex = 1;
            this.but_search.Text = "поиск";
            this.but_search.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(521, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "обновление ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(440, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистка";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(22, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Завершение работы";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 607);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_rooms;
        private System.Windows.Forms.Label label_load;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox_load;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
    }
}


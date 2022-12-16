namespace Kyrs
{
    partial class Add_Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_FreightInTonKilometers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_FuelConsumptionInLiters = new System.Windows.Forms.TextBox();
            this.label_rooms = new System.Windows.Forms.Label();
            this.label_load = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.textBox_CarMileagePerDayInKm = new System.Windows.Forms.TextBox();
            this.textBox_DriverFullName = new System.Windows.Forms.TextBox();
            this.textBox_modelAuto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Груз В Тонно Километрах:";
            // 
            // textBox_FreightInTonKilometers
            // 
            this.textBox_FreightInTonKilometers.Location = new System.Drawing.Point(189, 131);
            this.textBox_FreightInTonKilometers.Name = "textBox_FreightInTonKilometers";
            this.textBox_FreightInTonKilometers.Size = new System.Drawing.Size(100, 20);
            this.textBox_FreightInTonKilometers.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Расход топлива в Литрах:";
            // 
            // textBox_FuelConsumptionInLiters
            // 
            this.textBox_FuelConsumptionInLiters.Location = new System.Drawing.Point(189, 157);
            this.textBox_FuelConsumptionInLiters.Name = "textBox_FuelConsumptionInLiters";
            this.textBox_FuelConsumptionInLiters.Size = new System.Drawing.Size(100, 20);
            this.textBox_FuelConsumptionInLiters.TabIndex = 41;
            // 
            // label_rooms
            // 
            this.label_rooms.AutoSize = true;
            this.label_rooms.Location = new System.Drawing.Point(5, 110);
            this.label_rooms.Name = "label_rooms";
            this.label_rooms.Size = new System.Drawing.Size(178, 13);
            this.label_rooms.TabIndex = 40;
            this.label_rooms.Text = "Пробег автомобиля в День В Км:";
            // 
            // label_load
            // 
            this.label_load.AutoSize = true;
            this.label_load.Location = new System.Drawing.Point(55, 84);
            this.label_load.Name = "label_load";
            this.label_load.Size = new System.Drawing.Size(128, 13);
            this.label_load.TabIndex = 39;
            this.label_load.Text = "Полное ФИО водителя:";
            this.label_load.Click += new System.EventHandler(this.label_load_Click);
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Location = new System.Drawing.Point(108, 58);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(75, 13);
            this.label_model.TabIndex = 38;
            this.label_model.Text = "Модель авто:";
            // 
            // textBox_CarMileagePerDayInKm
            // 
            this.textBox_CarMileagePerDayInKm.Location = new System.Drawing.Point(189, 103);
            this.textBox_CarMileagePerDayInKm.Name = "textBox_CarMileagePerDayInKm";
            this.textBox_CarMileagePerDayInKm.Size = new System.Drawing.Size(100, 20);
            this.textBox_CarMileagePerDayInKm.TabIndex = 37;
            this.textBox_CarMileagePerDayInKm.TextChanged += new System.EventHandler(this.textBox_patronymic_TextChanged);
            // 
            // textBox_DriverFullName
            // 
            this.textBox_DriverFullName.Location = new System.Drawing.Point(189, 77);
            this.textBox_DriverFullName.Name = "textBox_DriverFullName";
            this.textBox_DriverFullName.Size = new System.Drawing.Size(100, 20);
            this.textBox_DriverFullName.TabIndex = 36;
            // 
            // textBox_modelAuto
            // 
            this.textBox_modelAuto.Location = new System.Drawing.Point(189, 51);
            this.textBox_modelAuto.Name = "textBox_modelAuto";
            this.textBox_modelAuto.Size = new System.Drawing.Size(100, 20);
            this.textBox_modelAuto.TabIndex = 35;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Очистка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 33;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Создание записи:";
            // 
            // Add_Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 294);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_FreightInTonKilometers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_FuelConsumptionInLiters);
            this.Controls.Add(this.label_rooms);
            this.Controls.Add(this.label_load);
            this.Controls.Add(this.label_model);
            this.Controls.Add(this.textBox_CarMileagePerDayInKm);
            this.Controls.Add(this.textBox_DriverFullName);
            this.Controls.Add(this.textBox_modelAuto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Add_Form3";
            this.Text = "Add_Form3";
            this.Load += new System.EventHandler(this.Add_Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_FreightInTonKilometers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_FuelConsumptionInLiters;
        private System.Windows.Forms.Label label_rooms;
        private System.Windows.Forms.Label label_load;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.TextBox textBox_CarMileagePerDayInKm;
        private System.Windows.Forms.TextBox textBox_DriverFullName;
        private System.Windows.Forms.TextBox textBox_modelAuto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
namespace Kyrs
{
    partial class Add_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_model2 = new System.Windows.Forms.TextBox();
            this.textBox_load2 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание записи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Грузоподъемности:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Инвентарных номерах автомобилей:";
            // 
            // textBox_model2
            // 
            this.textBox_model2.Location = new System.Drawing.Point(212, 105);
            this.textBox_model2.Name = "textBox_model2";
            this.textBox_model2.Size = new System.Drawing.Size(149, 20);
            this.textBox_model2.TabIndex = 4;
            // 
            // textBox_load2
            // 
            this.textBox_load2.Location = new System.Drawing.Point(212, 131);
            this.textBox_load2.Name = "textBox_load2";
            this.textBox_load2.Size = new System.Drawing.Size(149, 20);
            this.textBox_load2.TabIndex = 5;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(212, 157);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(149, 20);
            this.textBox52.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Очистка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 249);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox52);
            this.Controls.Add(this.textBox_load2);
            this.Controls.Add(this.textBox_model2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Form";
            this.Text = "Add_Form";
            this.Load += new System.EventHandler(this.Add_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_model2;
        private System.Windows.Forms.TextBox textBox_load2;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
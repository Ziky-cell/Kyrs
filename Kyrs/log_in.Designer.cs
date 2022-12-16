namespace Kyrs
{
    partial class log_in
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(99, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(111, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Логин:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(191, 250);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(130, 38);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Войти";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(176, 190);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(165, 41);
            this.textBox_password.TabIndex = 10;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(176, 145);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(165, 39);
            this.textBox_login.TabIndex = 9;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(129, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 92);
            this.panel1.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(327, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "очистка";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Регистрация";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kyrs.Properties.Resources.login_black;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 92);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(347, 191);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 28);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Location = new System.Drawing.Point(347, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 314);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "log_in";
            this.Text = "log_in";
            this.Load += new System.EventHandler(this.log_in_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
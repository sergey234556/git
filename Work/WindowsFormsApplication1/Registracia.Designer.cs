namespace WindowsFormsApplication1
{
    partial class Registracia
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
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.MaskedTextBox();
            this.Ch_Password = new System.Windows.Forms.MaskedTextBox();
            this.Otshestvo = new System.Windows.Forms.MaskedTextBox();
            this.Ima = new System.Windows.Forms.MaskedTextBox();
            this.Familia = new System.Windows.Forms.MaskedTextBox();
            this.Nomer_fil = new System.Windows.Forms.MaskedTextBox();
            this.podpiska = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dolshnost = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(278, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 42);
            this.button1.TabIndex = 69;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("SimSun-ExtB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 67);
            this.label11.TabIndex = 61;
            this.label11.Text = "Регистрация";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 42);
            this.button5.TabIndex = 60;
            this.button5.Text = "Зарегистрироваться";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 669);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 42);
            this.panel1.TabIndex = 73;
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Location = new System.Drawing.Point(46, 370);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(281, 22);
            this.Password.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("SimSun-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(41, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 74;
            this.label12.Text = "Логин";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("SimSun-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(41, 341);
            this.label10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 25);
            this.label10.TabIndex = 75;
            this.label10.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("SimSun-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(45, 396);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 76;
            this.label9.Text = "Пароль повторно";
            // 
            // Login
            // 
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(46, 315);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(281, 22);
            this.Login.TabIndex = 77;
            // 
            // Ch_Password
            // 
            this.Ch_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ch_Password.Location = new System.Drawing.Point(42, 424);
            this.Ch_Password.Margin = new System.Windows.Forms.Padding(4);
            this.Ch_Password.Name = "Ch_Password";
            this.Ch_Password.PasswordChar = '*';
            this.Ch_Password.Size = new System.Drawing.Size(285, 22);
            this.Ch_Password.TabIndex = 79;
            // 
            // Otshestvo
            // 
            this.Otshestvo.Location = new System.Drawing.Point(40, 127);
            this.Otshestvo.Name = "Otshestvo";
            this.Otshestvo.Size = new System.Drawing.Size(285, 22);
            this.Otshestvo.TabIndex = 80;
            // 
            // Ima
            // 
            this.Ima.Location = new System.Drawing.Point(40, 191);
            this.Ima.Name = "Ima";
            this.Ima.Size = new System.Drawing.Size(285, 22);
            this.Ima.TabIndex = 81;
            // 
            // Familia
            // 
            this.Familia.Location = new System.Drawing.Point(40, 250);
            this.Familia.Name = "Familia";
            this.Familia.Size = new System.Drawing.Size(285, 22);
            this.Familia.TabIndex = 82;
            // 
            // Nomer_fil
            // 
            this.Nomer_fil.Location = new System.Drawing.Point(39, 562);
            this.Nomer_fil.Name = "Nomer_fil";
            this.Nomer_fil.Size = new System.Drawing.Size(285, 22);
            this.Nomer_fil.TabIndex = 83;
            this.Nomer_fil.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // podpiska
            // 
            this.podpiska.Location = new System.Drawing.Point(43, 493);
            this.podpiska.Name = "podpiska";
            this.podpiska.Size = new System.Drawing.Size(281, 22);
            this.podpiska.TabIndex = 84;
            this.podpiska.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Отчество";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Подписка на рассылку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Номер филиала";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 89;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 601);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 91;
            this.label6.Text = "Должность";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Dolshnost
            // 
            this.Dolshnost.Location = new System.Drawing.Point(33, 636);
            this.Dolshnost.Name = "Dolshnost";
            this.Dolshnost.Size = new System.Drawing.Size(285, 22);
            this.Dolshnost.TabIndex = 90;
            this.Dolshnost.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(216, 464);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 92;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Registracia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 711);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Dolshnost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.podpiska);
            this.Controls.Add(this.Nomer_fil);
            this.Controls.Add(this.Familia);
            this.Controls.Add(this.Ima);
            this.Controls.Add(this.Otshestvo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Ch_Password);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registracia";
            this.ShowIcon = false;
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registracia_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox Login;
        private System.Windows.Forms.MaskedTextBox Ch_Password;
        private System.Windows.Forms.MaskedTextBox Otshestvo;
        private System.Windows.Forms.MaskedTextBox Ima;
        private System.Windows.Forms.MaskedTextBox Familia;
        private System.Windows.Forms.MaskedTextBox Nomer_fil;
        private System.Windows.Forms.MaskedTextBox podpiska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Dolshnost;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
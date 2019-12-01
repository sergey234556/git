using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Registracia : Form
    {
        public Registracia()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Login.Text == "" || Password.Text == "" || Ch_Password.Text == "") // если одно из поле пустое
            {
                MessageBox.Show("Поля не заполнены!\nЗаполните все поля!", "Заполните поля!");
            }
            else
            {
                if (Login.Text.Length > 16 || Password.Text.Length > 16) // если одно из поле пустое
                {
                    MessageBox.Show("Логин и Пароль должны быть не больше 16 символов!", "Ограничение ввода!");
                }
                else
                {
                    if (Password.Text != Ch_Password.Text)// проверка на соответствие полей паролей
                    {
                        MessageBox.Show("Пароли не совпадают!", "Пароли неверны!");
                    }
                    else
                    {
                        Int32 logchk; // проверка на уникальность логина
                        AuthRegConnect.cmd.CommandText = "select count(*) from [dbo].[Accunt]" +
                                    "where (Logen ='" + Login.Text + "')"; // возвращает запрос на проверку занятости введенного логина  
                        AuthRegConnect.sql.Open();
                        logchk = (int)AuthRegConnect.cmd.ExecuteScalar();
                        AuthRegConnect.sql.Close();
                        if (logchk == 1)
                        {
                            MessageBox.Show("Данный логин уже существует!", "Существующий логин!");
                        }
                        else
                        {
                            try
                            {
                                if (logchk == 0)
                                {
                                    AuthRegConnect.Accunt_Insert(Otshestvo.Text, Ima.Text, Familia.Text, Login.Text, Password.Text, podpiska.Text, Convert.ToInt32(Nomer_fil.Text), Convert.ToInt32 (Dolshnost.Text));
                                    MessageBox.Show("Регистрация успешно завершена!", "Успешно!");
                                    this.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                        }
                    }
                }
               
            }
        }

        private void Registracia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Avtorizacia avtorizacia = new Avtorizacia();
            avtorizacia.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            podpiska.Visible = true;

        }
    }

    
}

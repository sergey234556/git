using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Avtorizacia : Form
    {
        public int role;
        int x = 0;

        public Avtorizacia()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registracia registr = new Registracia();
            registr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AuthRegConnect.sql.Open();

                // Проверка наличия учетной записи с указанным логином
                SqlCommand CheckLoginCmd = new SqlCommand(@"SELECT Count(*) FROM [Accunt] WHERE Logen=@Logen COLLATE Cyrillic_General_CS_AS", AuthRegConnect.sql);
                CheckLoginCmd.Parameters.AddWithValue("@Logen", login.Text);
                int LoginCount = (int)CheckLoginCmd.ExecuteScalar();

                // Если учетная запись существует
                if (LoginCount > 0)
                {
                    // Проверяем в соответствии с учетной записью заданный пароль
                    SqlCommand CheckPasswordCmd = new SqlCommand(@"SELECT Count(*) FROM [Accunt]
                                            WHERE Logen=@Logen and Parol=@Parol COLLATE Cyrillic_General_CS_AS", AuthRegConnect.sql);
                    CheckPasswordCmd.Parameters.AddWithValue("@Logen", login.Text);
                    CheckPasswordCmd.Parameters.AddWithValue("@Parol", password.Text);
                    int PasswordCount = (int)CheckPasswordCmd.ExecuteScalar();
                    // Если пароль соответствует
                    if (PasswordCount > 0)
                    {

                        SqlCommand DolchnostCmd = new SqlCommand(@"SELECT Dolchnost FROM [Accunt]
                                            WHERE Logen=@Logen", AuthRegConnect.sql);
                        DolchnostCmd.Parameters.AddWithValue("@Logen", login.Text);
                        int Dolchnoststr = (int)DolchnostCmd.ExecuteScalar();
                        if (Dolchnoststr > 0)
                        {
                            

                            if (role == 1)
                            {
                                MessageBox.Show(Dolchnoststr.ToString());
                                this.Hide();
                                AuthRegConnect.logCon = true;
                                Menu menu = new Menu();
                                menu.Show();

                            }

                            if (role == 2)
                            {
                                MessageBox.Show(Dolchnoststr.ToString());
                                this.Hide();
                                AuthRegConnect.logCon = true;
                                Razrabotchik menu = new Razrabotchik();
                                menu.Show();

                            }

                            if (role == 3)
                            {
                                MessageBox.Show(Dolchnoststr.ToString());
                                this.Hide();
                                AuthRegConnect.logCon = true;
                                Analitik menu = new Analitik();
                                menu.Show();

                            }

                            if (role == 4)
                            {
                                MessageBox.Show(Dolchnoststr.ToString());
                                this.Hide();
                                AuthRegConnect.logCon = true;
                                kassir menu = new kassir();
                                menu.Show();
                                kassir s = new kassir();
                                s.a = role;
                            }

                            if (role == 5)
                            {
                                MessageBox.Show(Dolchnoststr.ToString());
                                this.Hide();
                                AuthRegConnect.logCon = true;
                                Klient menu = new Klient();
                                menu.Show();
                                kassir s = new kassir();
                                s.a = role;


                            }
                            if (role == 6)
                            {
                                MessageBox.Show(Dolchnoststr.ToString());
                                this.Hide();
                                AuthRegConnect.logCon = true;
                                Menu menu = new Menu();
                                menu.Show();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Роль указана не првильно");
                            AuthRegConnect.logCon = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль не подходит!");
                        AuthRegConnect.logCon = false;
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин!");
                    AuthRegConnect.logCon = false;
                }
                
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); AuthRegConnect.logCon = false; }
            finally
            {
                AuthRegConnect.sql.Close();
            }
        
        }

        private void Avtorizacia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (x == 1)//условия показа пароля
            {
                password.UseSystemPasswordChar = false;
                x = 0;
            }
            else
            {
                password.UseSystemPasswordChar = true;
                x = 1;
            }
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            {
                case "Администратор":
                    role = 1;
                    break;
                case "Разработчик":
                    role = 2;
                    break;
                case "Аналитик":
                    role = (3);
                    break;
                case "Кассир":
                    role = (4);
                    break;
                case "Клиент":
                    role = (5);
                    break;
                case "Тестировщик":
                    role = (6);
                    break;
            }
        }
    }
}

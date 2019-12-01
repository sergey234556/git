using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Registracia : Form
    {
        public Registracia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelvhod.Visible = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelreg.Visible = true;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelreg.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelvhod.Visible = false;
            panelreg.Visible = false;
            //panelinf.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panelinf.Visible = true;
            panel1.Visible = false;
            panelreg.Visible = false;

            panelvhod.Visible = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelvhod.Visible = false;
            panelreg.Visible = false;
            //panelinf.Visible = false;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelvhod.Visible = false;
            panelreg.Visible = false;
            //panelinf.Visible = false;
        }

        private void panelvhod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel5_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelvhod.Visible = false;
            panelreg.Visible = false;
            //panelinf.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panelreg.Visible = true;
            //panel1.Visible = false;
            ////panelinf.Visible = false;
            //SQLconnect.Open();

            // // Проверка наличия учетной записи с указанным логином 
            // SqlCommand CheckLoginCmd = new SqlCommand(@"SELECT Count(*) FROM Authoriz 
            // WHERE Login_User=@Login COLLATE Cyrillic_General_CS_AS", SQLconnect); 
            // CheckLoginCmd.Parameters.AddWithValue("@Login", Login.Text); 
            // int LoginCount = (int)CheckLoginCmd.ExecuteScalar(); 

            // // Если учетная запись существует 
            // if (LoginCount > 0) 
            // { 
            // // Проверяем в соответствии с учетной записью заданный пароль 
            // SqlCommand CheckPasswordCmd = new SqlCommand(@"SELECT Count(*) FROM Authoriz 
            // WHERE Login_User=@Login and Password_User=@Password COLLATE Cyrillic_General_CS_AS", SQLconnect); 
            // CheckPasswordCmd.Parameters.AddWithValue("@Login", Login.Text); 
            // CheckPasswordCmd.Parameters.AddWithValue("@Password", Pass.Password); 
            // int PasswordCount = (int)CheckPasswordCmd.ExecuteScalar(); 

            // // Если пароль соответствует 
            // if (PasswordCount > 0) 
            // {  
            // MainGrid.Children.Clear(); 
            // MainGrid.Children.Add(new UserControl3()); 

            // } 
            // else // Если пароль не подходит 
            // { 
            // MessageBox.Show("Неверный пароль!", "Ошибка аутентификации"); 
            // } 
            // } 
            // else 
            // MessageBox.Show("Неверный логин!", "Ошибка аутентификации"); 
            //} 
            // catch (Exception ex) 
            // { 
            // MessageBox.Show(ex.Message); 
            // MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка подключения"); 
            // } 
            // finally 
            // { 
            //SQLconnect.Close(); 
            // 

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        public static int Kolvo; 
        public static int[] Check = new int[9];
        public static string[] GetFKID = new string[3];

        object[] labels = new object[7];
        object[] textcomboboxes = new object[7];
        Int32 ID_table;

        public Menu()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;

        }

        private void DataGridLoaded(string query) // Вывод таблицы в DataGrid
        {
            try
            {
                AuthRegConnect.sql.Open();
                SqlCommand command = new SqlCommand(query, AuthRegConnect.sql);
                DataTable datatbl = new DataTable();
                datatbl.Load(command.ExecuteReader());
                dataGridView1.DataSource = datatbl.DefaultView;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                AuthRegConnect.sql.Close();
            }
        }


        private void Menu_Load(object sender, EventArgs e)
        {
            Registry_Col("Read");
        }

        private void ClearPanel()
        {
            dataGridView1.DataSource = "";
            for (int i = 0; i <7; i++)
            {
                panel2.Controls.Remove(labels[i] as Label);
                if ((textcomboboxes[i] as MaskedTextBox) != null)
                panel2.Controls.Remove(textcomboboxes[i] as MaskedTextBox);
                if ((textcomboboxes[i] as ComboBox) != null)
                    panel2.Controls.Remove(textcomboboxes[i] as ComboBox);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Выбор таблицы для отображения
        {
            ClearPanel();
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            {
                case "Информация о покупках":
                    DataGridLoaded(AuthRegConnect.qrInormacia_o_pokypkah);
                    for (int i = 0; i < 4; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i].HeaderText;
                        label.Width = 150;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }

                    break;
                case "Документы":
                    DataGridLoaded(AuthRegConnect.qrAccunt);
                    for (int i = 0; i < 4; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Width = 150;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);

                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(500 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }

                    break;
                case "Точка отправки":
                    DataGridLoaded(AuthRegConnect.qrPlan_deistvi);
                    for (int i = 0; i < 3; i++)
                    {
                        Label label = new Label();
                        label.Location = new Point(500, 38 + 40 * i);
                        label.Text = dataGridView1.Columns[i + 1].HeaderText;
                        label.Width = 150;
                        label.Visible = true;
                        labels[i] = label;
                        panel2.Controls.Add(label);
                        
                        MaskedTextBox textbox = new MaskedTextBox();
                        textbox.Location = new Point(510 + label.Width + 20, 38 + 40 * i);
                        textbox.Mask = "";
                        textbox.Visible = true;
                        panel2.Controls.Add(textbox);
                        textcomboboxes[i] = textbox;
                    }
                    break;
            }
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string[] SelectedValues = new string[9];
            try
            {
                ID_table = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                for (int k = 1; k < dataGridView1.Columns.Count; k++)
                {
                    SelectedValues[k - 1] = dataGridView1.CurrentRow.Cells[k].Value.ToString();
                }

                for (int z = 0; z <= dataGridView1.Columns.Count; z++)
                {
                    (textcomboboxes[z] as MaskedTextBox).Text = SelectedValues[z];
                }

            }
            catch  {/* MessageBox.Show(ex.ToString());*/ }
        }

        private void button8_Click(object sender, EventArgs e)//добавления 
        {
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            {
                case "Должности":
                    AuthRegConnect.Dolchinosti_Insert((textcomboboxes[0] as MaskedTextBox).Text, (textcomboboxes[1] as MaskedTextBox).Text, (textcomboboxes[2] as MaskedTextBox).Text, (textcomboboxes[3] as MaskedTextBox).Text);
                    break;
                case "Документы":
                    AuthRegConnect.Documenta_Insert((textcomboboxes[0] as MaskedTextBox).Text, (textcomboboxes[1] as MaskedTextBox).Text, (textcomboboxes[2] as MaskedTextBox).Text, (textcomboboxes[3] as MaskedTextBox).Text);
                    break;
                case "Точка отправки":
                    AuthRegConnect.tochka_otpravki_Insert((textcomboboxes[0] as MaskedTextBox).Text, (textcomboboxes[1] as MaskedTextBox).Text, (textcomboboxes[2] as MaskedTextBox).Text);
                    break;
            }
            MessageBox.Show("Успешно добавлено!");
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)//изменения
        {
            ////this.Hide();
            ////Izme nef = new Izme();
            ////nef.Show();
            //switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            //{
            //    case "Должности":
            //        AuthRegConnect.Dolchinosti_Update(ID_table,(textcomboboxes[0] as MaskedTextBox).Text, (textcomboboxes[1] as MaskedTextBox).Text, (textcomboboxes[2] as MaskedTextBox).Text, (textcomboboxes[3] as MaskedTextBox).Text);
            //        break;
            //    case "Документы":
            //        AuthRegConnect.Documenta_Update(ID_table,(textcomboboxes[0] as MaskedTextBox).Text, (textcomboboxes[1] as MaskedTextBox).Text, (textcomboboxes[2] as MaskedTextBox).Text, (textcomboboxes[3] as MaskedTextBox).Text);
            //        break;
            //    case "Точка отправки":
            //        AuthRegConnect.tochka_otpravki_Update(ID_table,(textcomboboxes[0] as MaskedTextBox).Text, (textcomboboxes[1] as MaskedTextBox).Text, (textcomboboxes[2] as MaskedTextBox).Text);
            //        break;
            //}
            //MessageBox.Show("Успешно изменено!");
            //comboBox1_SelectedIndexChanged(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)//удаление
        {
            switch (comboBox1.Items[comboBox1.SelectedIndex].ToString())
            {
                case "Должности":
                    AuthRegConnect.Dolchinosti_Delete(ID_table);
                    break;
                case "Документы":
                    AuthRegConnect.Documenta_Delete(ID_table);
                    break;
                case "Точка отправки":
                    AuthRegConnect.tochka_otpravki_Delete(ID_table);
                    break;
            }
            MessageBox.Show("Успешно удалено!");
            comboBox1_SelectedIndexChanged(sender,e);
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthRegConnect.col = Color.Red;
            Registry_Col("Write");
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthRegConnect.col = Color.Green;
            Registry_Col("Write");
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthRegConnect.col = Color.Blue;
            Registry_Col("Write");
        }

        private void желтыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthRegConnect.col = Color.Yellow;
            Registry_Col("Write");
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthRegConnect.col = Color.FromName("ActiveCaption");
            Registry_Col("Write");
        }

        private void подключениеКБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConnectionForm connectionForm = new ConnectionForm();
            connectionForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WordExcelPdf nef = new WordExcelPdf();
            nef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            panel2.Visible = false;
            panel2.Enabled = false;
        }

        public void Registry_Col(string tip)//получение параметров
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("Sergey");
            if (tip == "Read")
            { 
                AuthRegConnect.col = Color.FromName(key.GetValue("Color").ToString());
                panel1.BackColor = AuthRegConnect.col;
                panel2.BackColor = AuthRegConnect.col;
            }
            else
            {
                key.SetValue("Color", AuthRegConnect.col.Name);
                panel1.BackColor = AuthRegConnect.col;
                panel2.BackColor = AuthRegConnect.col;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Enabled = false;
            panel2.Visible = true;
            panel2.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}

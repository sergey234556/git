using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class ConnectionForm : Form
    {
        public string DS,IC;
        private Int32 status;
        public static string cds, cui, cpw;
        public event Action<DataTable> dtServers;
        public event Action<DataTable> dtDatabases;
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            switch (AuthRegConnect.logCon)
            {
                case (true):
                    cbDataSource.Text = DS;
                    cbInitialCatalog.Text = IC;
                    cbDataSource.Enabled = true;
                    cbInitialCatalog.Enabled = true;
                    tbUserID.Enabled = true;
                    tbPassword.Enabled = true;
                    btCheck.Enabled = true;
                    break;
                case (false):
                    status = 1;
                    Thread threadMessage = new Thread(tsslMessage);
                    threadMessage.Start();
                    dtServers += dtservers;
                    Thread thread = new Thread(Servers_Get);
                    thread.Start();
                    break;
            }
        }

        public void Servers_Get()
        {
            SqlDataSourceEnumerator sourceEnumerator = SqlDataSourceEnumerator.Instance;
            dtServers(sourceEnumerator.GetDataSources());
        }

        private void dtservers(DataTable table)
        {
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbDataSource.Items.Add(r[0] + @"\" + r[1]);
                }
                status = 0;
                cbDataSource.Enabled = true;
                tbUserID.Enabled = true;
                tbPassword.Enabled = true;
                btCheck.Enabled = true;
            };
            Invoke(action);
        }

        private void tsslMessage()
        {
            tsslStatus.Visible = true;
            switch (status)
            {
                case (1):
                    tsslStatus.Text = "Поиск серверов";
                    break;
                case (2):
                    tsslStatus.Text = "Поиск источников данных";
                    break;
            }
            do
            {
                Thread.Sleep(750);
                switch (status)
                {
                    case (1):
                        if (tsslStatus.Text == "Поиск серверов...")
                            tsslStatus.Text = "Поиск серверов";
                        else tsslStatus.Text += ".";
                        break;
                    case (2):
                        if (tsslStatus.Text == "Поиск источников данных...")
                            tsslStatus.Text = "Поиск источников данных";
                        else tsslStatus.Text += ".";
                        break;

                }
            } while (status != 0);
            tsslStatus.Text = "-";
            tsslStatus.Visible = false;
            Thread.CurrentThread.Abort();
        }

        public void Databases_get()
        {
            SqlConnection sql = new SqlConnection("Data Source = " + cds + "; Initial Catalog = master; Persist Security Info = true; " +
                    "User ID = " + cui + "; Password = \"" + cpw + "\"");
            try
            {
                SqlCommand command = new SqlCommand("select name from sys.databases " +
                    "where name not in ('master','tempbd','model','msdb')", sql);
                DataTable table = new DataTable();
                sql.Open();
                table.Load(command.ExecuteReader());
                dtDatabases(table);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            cds = cbDataSource.Text;
            cui = tbUserID.Text;
            cpw = tbPassword.Text;
            dtDatabases += databases;
            status = 2;
            Thread threadMessage = new Thread(tsslMessage);
            Thread thread = new Thread(Databases_get);
            threadMessage.Start();
            thread.Start();
        }

        private void databases(DataTable table)
        {
            Action action = () =>
            {
                foreach (DataRow r in table.Rows)
                {
                    cbInitialCatalog.Items.Add(r[0]);
                }
                status = 0;
                cbInitialCatalog.Enabled = true;
                btConnect.Enabled = true;
            };
            Invoke(action);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source = " + cds + "; Initial Catalog = master; Persist Security Info = true; " +
                    "User ID = " + cui + "; Password = \"" + cpw + "\"");
            AuthRegConnect.logCon = true;
            Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Подключение не было установлено!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Menu menu = new Menu();
            menu.Show();
        }
    }
}

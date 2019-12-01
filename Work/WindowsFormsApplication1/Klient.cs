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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kassir menu = new kassir();
            menu.Show();
        }
    }
}

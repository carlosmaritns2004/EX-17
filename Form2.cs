using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            this.ForeColor = Color.Blue;
            this.Text = "OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 pagina1 = new Form1();
            pagina1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}

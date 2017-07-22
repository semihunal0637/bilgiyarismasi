using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_Girişi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yarisma form2 = new yarisma();
            form2.Show();
            this.Hide();
        }
    }
}

using ConsoleClientForWSA.WebServici2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleClientForWSA
{
    public partial class Form1 : Form

    {
        WebService1 obj = new WebService1();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {

            WebService1 webservice1 = new WebService1();

        }

        private void buttonFtoC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salut!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kvira4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double simaghle = double.Parse(textBox1.Text); 
            double fudze = double.Parse(textBox2.Text);   

            Memkvidre memkvidre = new Memkvidre(simaghle, fudze);

            memkvidre.Gamotvla(label1);
        }
    }
}

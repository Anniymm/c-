using kvira1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvirano1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Tvitmfrinavi tvitmfrinavi = new Tvitmfrinavi();
            double baki = double.Parse(textBox1.Text);
            double mandzili = double.Parse(textBox2.Text);
            tvitmfrinavi.Minicheba(baki, mandzili);
            tvitmfrinavi.Gamotana(label1);
            tvitmfrinavi.Mandzili(label2);
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Matarebeli matarebeli = new Matarebeli();
            int vagonebi = int.Parse(textBox3.Text);
            int mgzavrebi = int.Parse(textBox4.Text);
            double Fasi = double.Parse(textBox5.Text);
            int GayiduliBiletebi = int.Parse(textBox6.Text);
            matarebeli.Miniwheba(vagonebi, mgzavrebi, Fasi, GayiduliBiletebi);
            matarebeli.Gamotanis(label3);
            matarebeli.Gamotvla(label4);

        }

    }
}

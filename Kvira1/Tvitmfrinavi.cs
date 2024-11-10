using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kvirano1
{
    internal class Tvitmfrinavi
    {
        private double baki;
        private double mandzili;

        public void Minicheba(double baki1, double mandzili1)
        {
            baki = baki1;
            mandzili = mandzili1;
        }

        public void Gamotana(Label label_1)
        {
            label_1.Text = $"Baki:{baki}, Mandzili:{mandzili}";

        }
        public void Mandzili(Label label_2)
        {
            double result = baki * mandzili;
            label_2.Text = result.ToString();
        }
    }
}

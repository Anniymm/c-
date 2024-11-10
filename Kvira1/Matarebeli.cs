using System;
using System.Windows.Forms;

namespace kvira1
{
    internal class Matarebeli
    {
        private int vagonebi;
        private int mgzavrebi;
        public double Fasi;
        public int GayiduliBiletebi;

        public void Miniwheba(int vagonebi1, int mgzavrebi1, double fasi1, int gayiduliBiletebi1)
        {
            vagonebi = vagonebi1;
            mgzavrebi = mgzavrebi1;
            Fasi = fasi1;
            GayiduliBiletebi = gayiduliBiletebi1;
        }

        public void Gamotanis(Label label3)
        {
            label3.Text = $"{vagonebi}, {mgzavrebi}, {Fasi}, {GayiduliBiletebi}";
        }

        public void Gamotvla(Label label4)
        {
            double resulti = Fasi * GayiduliBiletebi;
            label4.Text = resulti.ToString();
        }
    }
}

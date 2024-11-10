using System;
using System.Windows.Forms;
// No2
namespace kvira4
{
    class Martkutxedi
    {
        protected double fudze;
    }

    class Memkvidre : Martkutxedi
    {
        private double simaghle; 

        public Memkvidre(double simaghle, double fudze)
        {
            this.simaghle = simaghle;
            this.fudze = fudze; 
        }

        public void Gamotvla(Label label1)
        {
            double fartobi = simaghle * fudze; 
            label1.Text = fartobi.ToString(); 
        }
    }
}

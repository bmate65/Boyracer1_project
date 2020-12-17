using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boyracer1
{
    public partial class market : Form
    {
        public market()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form2 = new mainscreen();
            form2.Show();
            this.Hide();
        }

        class autók
        {
            public string név;
            public int ár;
            public int erő;
            public int hely;
            public int menőség;

            public autók(string n, int á, int e, int h, int m)
            {
                név = n;
                ár = á;
                erő = e;
                hely = h;
                menőség = m;
            }
            public string toString()
            {
                return "Márka: " + név + " ár: " + ár + "Ft, erő: " + erő + "HP, hely: " + hely + "Liter, menőség: " + menőség;
            }
        
        }
       
        //Market képernyő (form)
        private void market_Load(object sender, EventArgs e)
        {

            


            //golf ár
            autók Golf_2 = new autók("VolksWagen Golf II 1.6 D",50000,54,340,4);
            

            //golf kiir
            Golf2.Text = Golf_2.toString();

            //Audi_80 ár
            autók Audi_80 = new autók("Audi 80 1.9 D", 65000, 68, 560, 6);
            //kiir
            Audi80.Text = Audi_80.toString();


        }

        private void Golf2_Click(object sender, EventArgs e)
        {
            
        }

        private void Audi80_Click(object sender, EventArgs e)
        {
            kép.BackgroundImage = Image.FromFile(@"C:\Users\bmate\Documents\Visual Studio 2015\Projects\Boyracer1\Boyracer1\bin\media\Audi_80.jpg");
        }
    }
}

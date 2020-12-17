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
    public partial class mainscreen : Form
    {

        //egyenleg
        
        public mainscreen()
        {
            InitializeComponent();
        }

        



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text="Pénz:"+pénz ;
            
        }

        private void market_Click(object sender, EventArgs e)
        {
            var form3 = new market();
            form3.Show();
            this.Hide();
        }
        int pénz = 100000;
        

       
    }
}

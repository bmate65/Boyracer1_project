using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Boyracer1
{
    public partial class Startscreen : Form
    {

        //Zene:
        
            
        
    

        public Startscreen()
        {
            InitializeComponent();
        }

        private void Startscreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var form2 = new mainscreen();
            form2.Show();
            this.Hide();
            {


                System.Media.SoundPlayer player = new SoundPlayer(Properties.Resources.zene);
                
                player.PlayLooping();
                    

                
            }
            
        }
    }
}

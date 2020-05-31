using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysterium
{
    public partial class MysteriumChoose : Form
    {
        Game StartGame = new Game();
        int[] Difficulty = { 1/*Easy*/, 2 /*Normal*/, 3/*Hard*/ };
        public MysteriumChoose()
        {
            InitializeComponent();
            
        }








        
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            else
            {
              //  MessageBox.Show("Please make sure you have choosen all the options of your journey!", "From the beyond")
            }
        }

        private void SpelersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpelersCB.SelectedIndex = StartGame();
        }



    






    }
}

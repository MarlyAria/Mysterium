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
        Game game;
        public bool StoryCrime; //to choose between playing with object or story cards

        public MysteriumChoose()
        {
            InitializeComponent();
            game = new Game(GhostStateCB.SelectedIndex, PlayerCB.SelectedIndex);
            comboBox1.Text = comboBox1.Items[0].ToString();
            PlayerCB.Text = PlayerCB.Items[2].ToString();
            GhostStateCB.Text = GhostStateCB.Items[1].ToString();
                       
        }

        public void DrawCrime()
        {
            Random random = new Random();

            if (StoryCrime == false)
            {
                Crime crime = new Crime((CharacterCard)random.Next(1, 31),
                                    (LocationCard)random.Next(1, 31),
                                    (ObjectCard)random.Next(1, 32));

            }
            else
            {
                CrimeStory crime = new CrimeStory((CharacterCard)random.Next(1, 31),
                                        (LocationCard)random.Next(1, 31),
                                        (StoryCard)random.Next(1, 20));
            }


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

        private void PlayerCB_SelectedIndexChanged(object sender, EventArgs e)
        {
                PlayerCB.SelectedIndex = game.Player;
        }

        private void GhostStateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GhostStateCB.SelectedIndex = game.Difficulty;
        }

        private void checkBoxHiddenSigns_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHiddenSigns.Checked)
            {
                Promo1CB.Checked = true;
                Promo2CB.Checked = true;
                Promo3CB.Checked = true;

            }
        }

        private void checkBoxSecretLies_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSecretLies.Checked)
                Promo5CB.Checked = true;
        }
    }
}

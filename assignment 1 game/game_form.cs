using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1_game
{

    public partial class Form1 : Form
    {
        logic_ game_object = new logic_();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;//disabling the spin button//
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disbaling the shootaway button//
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;//enabling the spin button//
            btn_load.Enabled = false;//disabling the load button//


            //code to display image in picture box on button click

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("assignment_1_game.Resources.tenor.gif");
            Bitmap bmp_object = new Bitmap(mystream);
            pic_b.Image = bmp_object;

            //Sound code
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(assignment_1_game.Properties.Resources.loading);
            Sound_Object.Play();
            //code for logic//
            game_object.load_data = 1;
        }


        private void btn_spin_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;//disabling the spin button//
            btn_shoot.Enabled = true;//enabling the shoot button//


            //code to display image in picture box on button click

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("assignment_1_game.Resources.tumblr_p62l5fYZty1ucpcboo2_540-758282.gif");
            Bitmap bmp_object = new Bitmap(mystream);
            pic_b.Image = bmp_object;

            //code for logic//
            Random Rnd_obj = new Random();
            game_object.spin_data = Rnd_obj.Next(1, 7);

            MessageBox.Show("Bullet Position after spining the chamber is " + game_object.spin_data.ToString());
        }




        private void btn_shoot_Click(object sender, EventArgs e)
        {
            btn_shootaway.Enabled = true;//enabling the shootaway button//
            btn_shoot.Enabled = false;//disabling the shoot button//


            //code to display image in picture box on button click

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("assignment_1_game.Resources.shooting.gif");
            Bitmap bmp_object = new Bitmap(mystream);
            pic_b.Image = bmp_object;

            //Sound code
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(assignment_1_game.Properties.Resources.shooting1);
            Sound_Object.Play();

            {
                //code for logic//
                game_object.shoot_data = game_object.shoot_method();
                if (game_object.shoot_data == 1)
                {

                    MessageBox.Show("Bullet shot on your head. You are dead");
                }
                else


                
                        {
                            MessageBox.Show("emply shoot");
                        }
            }
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;//enabling the load button//
            btn_spin.Enabled = false;//disabling the spin button//
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disabling the shootaway button//


            //code to display image in picture box on button click

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("assignment_1_game.Resources.ml_pia_logo.png");
            Bitmap bmp_object = new Bitmap(mystream);
            pic_b.Image = bmp_object;
        }

        private void btn_shootaway_Click(object sender, EventArgs e)
        {
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disabling the shootaway button//

            //code for logic//
            if (game_object.chances <= 2)
            {
                game_object.shoot_data = game_object.shoot_method();
                if (game_object.shoot_data == 1)
                {

                    MessageBox.Show("Wow!! you are safe. you win the game");
                    btn_shoot.Enabled = false;
                    btn_shootaway.Enabled = false;
                }
                else
                {
                    game_object.chances++;
                    if (game_object.chances == 2)
                    {
                        MessageBox.Show("Your 2 chances are finished. you lose the game");
                    }
                    else
                    {
                        MessageBox.Show("emply shoot");
                    }
                }

            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            game_rules rules_obj = new game_rules ();
            rules_obj.Show();
            this.Hide();

        }
    }
}

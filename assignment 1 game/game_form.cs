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
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;//enabling the load button//
            btn_spin.Enabled = false;//disabling the spin button//
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disabling the shootaway button//


            //code to display image in picture box on button click

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream mystream = myAssembly.GetManifestResourceStream("assignment_1_game.Resources.ml_pia_logo");
            Bitmap bmp_object = new Bitmap(mystream);
            pic_b.Image = bmp_object;
        }

        private void btn_shootaway_Click(object sender, EventArgs e)
        {
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disabling the shootaway button//
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

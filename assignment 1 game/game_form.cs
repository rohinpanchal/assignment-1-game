using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;//disabling the spin button//
            btn_shoot.Enabled = true;//enabling the shoot button//
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            btn_shootaway.Enabled = true;//enabling the shootaway button//
            btn_shoot.Enabled = false;//disabling the shoot button//
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;//enabling the load button//
            btn_spin.Enabled = false;//disabling the spin button//
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disabling the shootaway button//
        }

        private void btn_shootaway_Click(object sender, EventArgs e)
        {
            btn_shoot.Enabled = false;//disabling the shoot button//
            btn_shootaway.Enabled = false;//disabling the shootaway button//
        }
    }
}

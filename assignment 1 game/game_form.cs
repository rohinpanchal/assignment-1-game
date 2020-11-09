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
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = true;
            btn_load.Enabled = false;
            
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            btn_spin.Enabled = false;
            btn_shoot.Enabled = true;
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            btn_shootaway.Enabled = true;
            btn_shoot.Enabled = false;
        }

        private void btn_playagain_Click(object sender, EventArgs e)
        {
            btn_load.Enabled = true;
            btn_spin.Enabled = false;
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
        }

        private void btn_shootaway_Click(object sender, EventArgs e)
        {
            btn_shoot.Enabled = false;
            btn_shootaway.Enabled = false;
        }
    }
}

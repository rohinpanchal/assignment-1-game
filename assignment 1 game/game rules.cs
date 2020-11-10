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
    public partial class game_rules : Form
    {
        public game_rules()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 game_obj = new Form1();
            game_obj.Show();
            this.Close();
        }

        private void lbl_rule1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

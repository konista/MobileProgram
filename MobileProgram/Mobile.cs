using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileProgram
{
    public partial class Mobile : Form
    {
        public Coding w_coding;
        public Game w_game;
        public object[] codes;
        public Mobile()
        {
            InitializeComponent();
            w_coding = new Coding(this);
            w_game = new Game(this);
        }

        private void BTN_Program_Click(object sender, EventArgs e)
        {
            w_coding.Show();
        }

        private void BTN_Go_Click(object sender, EventArgs e)
        {
            if (LB_Level.SelectedIndex < 0)
            {
                MessageBox.Show("先选择关卡");
                return;
            }
            w_game.Show();
            w_game.Init_Game(LB_Level.SelectedItem.ToString());
            w_game.Run();
        }

        private void LB_Level_DoubleClick(object sender, EventArgs e)
        {
            w_game.Show();
            w_game.Init_Game(LB_Level.SelectedItem.ToString());
        }
    }
}

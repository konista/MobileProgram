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
    public partial class Coding : Form
    {
        Mobile w_mobile;
        public Coding()
        {
            InitializeComponent();
        }

        public Coding(Mobile parent)
        {
            InitializeComponent();
            w_mobile = parent;
            Init_Function();
        }

        private void Init_Function()
        {
            LB_Function.Items.Add("MoveUp");
            LB_Function.Items.Add("MoveDown");
            LB_Function.Items.Add("MoveLeft");
            LB_Function.Items.Add("MoveRight");
            LB_Function.Items.Add("TurnLeft");
            LB_Function.Items.Add("TurnRight");
            LB_Function.Items.Add("Attack");
            LB_Function.Items.Add("Hide");
            LB_Function.Items.Add("Show");
        }
        private void Btn_Clean_Click(object sender, EventArgs e)
        {
            LB_Code.Items.Clear();
        }

        private void BTN_Select_Click(object sender, EventArgs e)
        {
            if (LB_Function.SelectedIndex < 0) { return; }
            LB_Code.Items.Add(LB_Function.SelectedItem);
        }

        private void BTN_DELETE_Click(object sender, EventArgs e)
        {
            int index = LB_Code.SelectedIndex;
            if (index < 0) { return; }
            LB_Code.Items.RemoveAt(index);
            if (index < LB_Code.Items.Count)
            {
                LB_Code.SelectedIndex = index;
            }
            
        }

        private void BTN_Up_Click(object sender, EventArgs e)
        {
            int index = LB_Code.SelectedIndex;
            if (index <= 0)
            {
                return;
            }
            object item = LB_Code.SelectedItem;
            LB_Code.Items.RemoveAt(index);
            LB_Code.Items.Insert(index - 1, item);
            LB_Code.SelectedIndex = index - 1;
        }

        private void BTN_Down_Click(object sender, EventArgs e)
        {
            int index = LB_Code.SelectedIndex;
            if (index == LB_Code.Items.Count - 1 || index < 0)
            {
                return;
            }
            object item = LB_Code.SelectedItem;
            LB_Code.Items.RemoveAt(index);
            LB_Code.Items.Insert(index + 1, item);
            LB_Code.SelectedIndex = index + 1;
        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            w_mobile.codes = new object[LB_Code.Items.Count];
            LB_Code.Items.CopyTo(w_mobile.codes, 0);
            this.Hide();
        }

        private void Coding_FormClosing(object sender, FormClosingEventArgs e)
        {
            w_mobile.codes = new object[LB_Code.Items.Count];
            LB_Code.Items.CopyTo(w_mobile.codes, 0);
            this.Hide();
            e.Cancel = true;
        }
    }
}

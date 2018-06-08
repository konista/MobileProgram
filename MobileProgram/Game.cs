using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
namespace MobileProgram
{
    public partial class Game : Form
    {
        public Mobile w_mobile;
        private Bitmap bg_bmp, block_0, block_1, block_2, block_lyc, block_baba, block_mama, block_lyc_up, block_lyc_down, block_lyc_left, block_lyc_right, block_lyc_dead;
        private int row, col;
        private string ahead = "right";
        private Graphics graphics;
        private string[][] map = new string[20][];
        private bool success = false;
       
        public Game(Mobile parent)
        {
            InitializeComponent();
            w_mobile = parent;
            this.SetClientSizeCore(801, 801);
            row = 0;
            col = 0;
            bg_bmp = new Bitmap(this.Width, this.Height);  //创建画布
            block_0 = new Bitmap("../../img/block_0.bmp");
            block_1 = new Bitmap("../../img/block_1.bmp");
            block_2 = new Bitmap("../../img/block_2.bmp");
            block_lyc_up = new Bitmap("../../img/block_lyc_up.bmp");
            block_lyc_down = new Bitmap("../../img/block_lyc_down.bmp");
            block_lyc_left = new Bitmap("../../img/block_lyc_left.bmp");
            block_lyc_right = new Bitmap("../../img/block_lyc_right.bmp");
            block_lyc_dead = new Bitmap("../../img/block_lyc_dead.bmp");
            block_lyc = block_lyc_down;
            block_baba = new Bitmap("../../img/block_baba.bmp");
            block_mama = new Bitmap("../../img/block_mama.bmp");
            graphics = Graphics.FromImage(bg_bmp);//创建画图对象
            Init_Map();
        }

        private void Init_Map()
        {
            for (int i = 0; i <= 800; i += 40)
            {
                graphics.DrawLine(new Pen(Color.Red), new Point(i, 0), new Point(i, 800));//竖线
            }
            for (int j = 0; j <= 800; j += 40)
            {
                graphics.DrawLine(new Pen(Color.Red), new Point(0, j), new Point(800, j));//横线
            }
        }

        private void Draw_Block(IntPtr hbitmap, int x, int y)
        {
            graphics.DrawImage(Image.FromHbitmap(hbitmap), x * 40 + 1, y * 40 + 1);
        }

        public void Init_Game(string level)
        {
            string filename = "../../level/" + level + ".csv";
            try
            {
                FileStream aFile = new FileStream(filename, FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                string strLine = sr.ReadLine();
                int i = 0;
                while (strLine != null)
                {
                    map[i] = strLine.Split(',');
                    strLine = sr.ReadLine();
                    i++;
                }
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IOException has been thrown!");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    switch (map[i][j])
                    {
                        case "0":
                            Draw_Block(block_0.GetHbitmap(), j, i);
                            break;
                        case "1":
                            Draw_Block(block_1.GetHbitmap(), j, i);
                            break;
                        case "2":
                            Draw_Block(block_2.GetHbitmap(), j, i);
                            break;
                        case "5":
                            Draw_Block(block_lyc.GetHbitmap(), j, i);
                            row = i;
                            col = j;
                            break;
                        case "8":
                            Draw_Block(block_baba.GetHbitmap(), j, i);
                            break;
                        case "9":
                            Draw_Block(block_mama.GetHbitmap(), j, i);
                            break;
                    }
                }
            }
        }

       

        private bool Go_Step(object fun)
        {
            bool dead = false;
            switch (fun.ToString())
            {
                case "MoveUp":
                    block_lyc = block_lyc_up;
                    if (row > 0)
                    {
                        if (map[row - 1][col] == "0")
                        {
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col, row - 1);
                            row -= 1;
                        }
                        else if (map[row - 1][col] == "2")
                        {
                            block_lyc = block_lyc_dead;
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col, row - 1);
                            dead = true;
                        }
                        else if (map[row - 1][col] == "9")
                        {
                            success = true;
                        }

                    }
                    ahead = "up";
                    break;
                case "MoveDown":
                    block_lyc = block_lyc_down;
                    if (row < 19)
                    {
                        if (map[row + 1][col] == "0")
                        {
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col, row + 1);
                            row += 1;
                        }
                        else if (map[row + 1][col] == "2")
                        {
                            block_lyc = block_lyc_dead;
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col, row + 1);
                            dead = true;
                        }
                        else if (map[row + 1][col] == "9")
                        {
                            success = true;
                        }
                    }
                    ahead = "down";
                    break;
                case "MoveLeft":
                    block_lyc = block_lyc_left;
                    if (col > 0)
                    {
                        if (map[row][col - 1] == "0")
                        {
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col - 1, row);
                            col -= 1;
                        }
                        else if (map[row][col - 1] == "2")
                        {
                            block_lyc = block_lyc_dead;
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col - 1, row);
                            dead = true;
                        }
                        else if (map[row][col - 1] == "9")
                        {
                            success = true;
                        }
                    }
                    ahead = "left";
                    break;
                case "MoveRight":
                    block_lyc = block_lyc_right;
                    if (col < 19)
                    {
                        if (map[row][col + 1] == "0")
                        {
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col + 1, row);
                            col += 1;
                        }
                        else if (map[row][col + 1] == "2")
                        {
                            block_lyc = block_lyc_dead;
                            Draw_Block(block_0.GetHbitmap(), col, row);
                            Draw_Block(block_lyc.GetHbitmap(), col + 1, row);
                            dead = true;
                        }
                        else if (map[row][col + 1] == "9")
                        {
                            success = true;
                        }
                    }
                    ahead = "right";
                    break;
                case "TurnLeft":
                    switch (ahead)
                    {
                        case "right":
                            ahead = "up";
                            block_lyc = block_lyc_up;
                            break;
                        case "up":
                            ahead = "left";
                            block_lyc = block_lyc_left;
                            break;
                        case "left":
                            ahead = "down";
                            block_lyc = block_lyc_down;
                            break;
                        case "down":
                            ahead = "right";
                            block_lyc = block_lyc_right;
                            break;
                    }
                    Draw_Block(block_lyc.GetHbitmap(), col, row);
                    break;
                case "TurnRight":
                    switch (ahead)
                    {
                        case "right":
                            ahead = "down";
                            block_lyc = block_lyc_down;
                            break;
                        case "down":
                            ahead = "left";
                            block_lyc = block_lyc_left;
                            break;
                        case "left":
                            ahead = "up";
                            block_lyc = block_lyc_up;
                            break;
                        case "up":
                            ahead = "right";
                            block_lyc = block_lyc_right;
                            break;
                    }
                    Draw_Block(block_lyc.GetHbitmap(), col, row);
                    break;
                case "Attack":
                    int att_row = row;
                    int att_col = col;
                    switch (ahead)
                    {
                        case "right":
                            att_col += 1;
                            break;
                        case "down":
                            att_row += 1;
                            break;
                        case "left":
                            att_col -= 1;
                            break;
                        case "up":
                            att_row -= 1;
                            break;
                    }
                    if (att_row < 0 || att_col < 0)
                    {
                        break;
                    }
                    else
                    {
                        if (map[att_row][att_col] == "1")
                        {
                            Draw_Block(block_0.GetHbitmap(), att_col, att_row);
                            map[att_row][att_col] = "0";
                        }
                    }
                    break;
                case "Hide":
                    break;
            }
            return dead;
        }

        public void Run()
        {
            System.Threading.Thread t = new System.Threading.Thread(Go);
            t.Start();
        }

        private void Go()
        {
            bool dead = false;
            foreach (string fun in w_mobile.codes)
            {
                dead = Go_Step(fun);
                if (dead || success)
                {
                    break;
                }
                this.BeginInvoke(new Action(Refresh));
                System.Threading.Thread.Sleep(500);
            }
            if (dead || !success)
            {
                MessageBox.Show("失败乃成功之母！");
                this.Hide();
            }
            if (success)
            {
                MessageBox.Show("小牛牛成功找到了羊妈妈！");
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawImage(bg_bmp, new Point(0, 0)); //最重要的一步，要不然效果不会出来
            g.Dispose();
        }
    }
}

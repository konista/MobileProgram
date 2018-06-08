namespace MobileProgram
{
    partial class Mobile
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Program = new System.Windows.Forms.Button();
            this.BTN_Go = new System.Windows.Forms.Button();
            this.LB_Level = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTN_Program
            // 
            this.BTN_Program.Location = new System.Drawing.Point(175, 79);
            this.BTN_Program.Name = "BTN_Program";
            this.BTN_Program.Size = new System.Drawing.Size(257, 60);
            this.BTN_Program.TabIndex = 0;
            this.BTN_Program.Text = "开始编程";
            this.BTN_Program.UseVisualStyleBackColor = true;
            this.BTN_Program.Click += new System.EventHandler(this.BTN_Program_Click);
            // 
            // BTN_Go
            // 
            this.BTN_Go.Location = new System.Drawing.Point(778, 79);
            this.BTN_Go.Name = "BTN_Go";
            this.BTN_Go.Size = new System.Drawing.Size(257, 60);
            this.BTN_Go.TabIndex = 2;
            this.BTN_Go.Text = "开始运行";
            this.BTN_Go.UseVisualStyleBackColor = true;
            this.BTN_Go.Click += new System.EventHandler(this.BTN_Go_Click);
            // 
            // LB_Level
            // 
            this.LB_Level.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Level.FormattingEnabled = true;
            this.LB_Level.ItemHeight = 19;
            this.LB_Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.LB_Level.Location = new System.Drawing.Point(459, 79);
            this.LB_Level.Name = "LB_Level";
            this.LB_Level.Size = new System.Drawing.Size(300, 460);
            this.LB_Level.TabIndex = 3;
            this.LB_Level.DoubleClick += new System.EventHandler(this.LB_Level_DoubleClick);
            // 
            // Mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 565);
            this.Controls.Add(this.LB_Level);
            this.Controls.Add(this.BTN_Go);
            this.Controls.Add(this.BTN_Program);
            this.Name = "Mobile";
            this.Text = "移动代码";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Program;
        private System.Windows.Forms.Button BTN_Go;
        private System.Windows.Forms.ListBox LB_Level;
    }
}


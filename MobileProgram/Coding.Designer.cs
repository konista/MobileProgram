namespace MobileProgram
{
    partial class Coding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Function = new System.Windows.Forms.ListBox();
            this.BTN_DELETE = new System.Windows.Forms.Button();
            this.BTN_Select = new System.Windows.Forms.Button();
            this.LB_Code = new System.Windows.Forms.ListBox();
            this.BTN_Up = new System.Windows.Forms.Button();
            this.BTN_Down = new System.Windows.Forms.Button();
            this.Btn_Clean = new System.Windows.Forms.Button();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Function
            // 
            this.LB_Function.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Function.FormattingEnabled = true;
            this.LB_Function.ItemHeight = 19;
            this.LB_Function.Location = new System.Drawing.Point(12, 12);
            this.LB_Function.Name = "LB_Function";
            this.LB_Function.Size = new System.Drawing.Size(225, 479);
            this.LB_Function.TabIndex = 0;
            // 
            // BTN_DELETE
            // 
            this.BTN_DELETE.Location = new System.Drawing.Point(440, 259);
            this.BTN_DELETE.Name = "BTN_DELETE";
            this.BTN_DELETE.Size = new System.Drawing.Size(87, 29);
            this.BTN_DELETE.TabIndex = 1;
            this.BTN_DELETE.Text = "删除";
            this.BTN_DELETE.UseVisualStyleBackColor = true;
            this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
            // 
            // BTN_Select
            // 
            this.BTN_Select.Location = new System.Drawing.Point(440, 189);
            this.BTN_Select.Name = "BTN_Select";
            this.BTN_Select.Size = new System.Drawing.Size(87, 29);
            this.BTN_Select.TabIndex = 2;
            this.BTN_Select.Text = "添加";
            this.BTN_Select.UseVisualStyleBackColor = true;
            this.BTN_Select.Click += new System.EventHandler(this.BTN_Select_Click);
            // 
            // LB_Code
            // 
            this.LB_Code.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Code.FormattingEnabled = true;
            this.LB_Code.ItemHeight = 19;
            this.LB_Code.Location = new System.Drawing.Point(725, 12);
            this.LB_Code.Name = "LB_Code";
            this.LB_Code.Size = new System.Drawing.Size(225, 479);
            this.LB_Code.TabIndex = 3;
            // 
            // BTN_Up
            // 
            this.BTN_Up.Location = new System.Drawing.Point(970, 115);
            this.BTN_Up.Name = "BTN_Up";
            this.BTN_Up.Size = new System.Drawing.Size(55, 44);
            this.BTN_Up.TabIndex = 4;
            this.BTN_Up.Text = "上调";
            this.BTN_Up.UseVisualStyleBackColor = true;
            this.BTN_Up.Click += new System.EventHandler(this.BTN_Up_Click);
            // 
            // BTN_Down
            // 
            this.BTN_Down.Location = new System.Drawing.Point(970, 289);
            this.BTN_Down.Name = "BTN_Down";
            this.BTN_Down.Size = new System.Drawing.Size(55, 44);
            this.BTN_Down.TabIndex = 5;
            this.BTN_Down.Text = "下调";
            this.BTN_Down.UseVisualStyleBackColor = true;
            this.BTN_Down.Click += new System.EventHandler(this.BTN_Down_Click);
            // 
            // Btn_Clean
            // 
            this.Btn_Clean.Location = new System.Drawing.Point(440, 335);
            this.Btn_Clean.Name = "Btn_Clean";
            this.Btn_Clean.Size = new System.Drawing.Size(87, 29);
            this.Btn_Clean.TabIndex = 6;
            this.Btn_Clean.Text = "清空";
            this.Btn_Clean.UseVisualStyleBackColor = true;
            this.Btn_Clean.Click += new System.EventHandler(this.Btn_Clean_Click);
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(970, 467);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(87, 29);
            this.BTN_Save.TabIndex = 7;
            this.BTN_Save.Text = "完成";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // Coding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 508);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.Btn_Clean);
            this.Controls.Add(this.BTN_Down);
            this.Controls.Add(this.BTN_Up);
            this.Controls.Add(this.LB_Code);
            this.Controls.Add(this.BTN_Select);
            this.Controls.Add(this.BTN_DELETE);
            this.Controls.Add(this.LB_Function);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Coding";
            this.Text = "Coding";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Coding_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Function;
        private System.Windows.Forms.Button BTN_DELETE;
        private System.Windows.Forms.Button BTN_Select;
        private System.Windows.Forms.ListBox LB_Code;
        private System.Windows.Forms.Button BTN_Up;
        private System.Windows.Forms.Button BTN_Down;
        private System.Windows.Forms.Button Btn_Clean;
        private System.Windows.Forms.Button BTN_Save;
    }
}
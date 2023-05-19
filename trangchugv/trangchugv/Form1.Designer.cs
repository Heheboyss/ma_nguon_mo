namespace trangchugv
{
    partial class frmtrangchugv
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnqlsvgv = new Button();
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            quảnLýTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            pnlqlsvgv = new Panel();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnqlsvgv);
            panel1.Location = new Point(0, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 464);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(4, 200);
            button3.Name = "button3";
            button3.Size = new Size(170, 39);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 148);
            button2.Name = "button2";
            button2.Size = new Size(168, 46);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnqlsvgv
            // 
            btnqlsvgv.Location = new Point(3, 98);
            btnqlsvgv.Name = "btnqlsvgv";
            btnqlsvgv.Size = new Size(171, 44);
            btnqlsvgv.TabIndex = 0;
            btnqlsvgv.Text = "Quản lý sinh viên";
            btnqlsvgv.UseVisualStyleBackColor = true;
            btnqlsvgv.Click += btnqlsvgv_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1292, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(87, 24);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đổiMậtKhẩuToolStripMenuItem, quảnLýTàiKhoảnToolStripMenuItem, thoátToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(151, 24);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(207, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            quảnLýTàiKhoảnToolStripMenuItem.Size = new Size(207, 26);
            quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(207, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // pnlqlsvgv
            // 
            pnlqlsvgv.Location = new Point(166, 31);
            pnlqlsvgv.Name = "pnlqlsvgv";
            pnlqlsvgv.Size = new Size(1122, 497);
            pnlqlsvgv.TabIndex = 3;
            // 
            // frmtrangchugv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 497);
            Controls.Add(pnlqlsvgv);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmtrangchugv";
            Text = "Trang chủ";
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button btnqlsvgv;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Panel pnlqlsvgv;
    }
}
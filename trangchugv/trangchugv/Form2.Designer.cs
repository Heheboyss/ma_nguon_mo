namespace trangchugv
{
    partial class frmqlsvgv
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
            dgvmain = new DataGridView();
            cbbtkmasv = new ComboBox();
            cbbtkten = new ComboBox();
            cbbtkmalop = new ComboBox();
            btntk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnthoatqlsv = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvmain).BeginInit();
            SuspendLayout();
            // 
            // dgvmain
            // 
            dgvmain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmain.Location = new Point(12, 185);
            dgvmain.Name = "dgvmain";
            dgvmain.RowHeadersWidth = 51;
            dgvmain.RowTemplate.Height = 29;
            dgvmain.Size = new Size(1080, 253);
            dgvmain.TabIndex = 0;
            dgvmain.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cbbtkmasv
            // 
            cbbtkmasv.FormattingEnabled = true;
            cbbtkmasv.Items.AddRange(new object[] { "(nope)", "20099" });
            cbbtkmasv.Location = new Point(35, 93);
            cbbtkmasv.Name = "cbbtkmasv";
            cbbtkmasv.Size = new Size(151, 28);
            cbbtkmasv.TabIndex = 1;
            // 
            // cbbtkten
            // 
            cbbtkten.FormattingEnabled = true;
            cbbtkten.Items.AddRange(new object[] { "(nope)", "cac" });
            cbbtkten.Location = new Point(325, 93);
            cbbtkten.Name = "cbbtkten";
            cbbtkten.Size = new Size(151, 28);
            cbbtkten.TabIndex = 2;
            // 
            // cbbtkmalop
            // 
            cbbtkmalop.FormattingEnabled = true;
            cbbtkmalop.Items.AddRange(new object[] { "(nope)", "72dcht" });
            cbbtkmalop.Location = new Point(637, 93);
            cbbtkmalop.Name = "cbbtkmalop";
            cbbtkmalop.Size = new Size(151, 28);
            cbbtkmalop.TabIndex = 3;
            // 
            // btntk
            // 
            btntk.Location = new Point(893, 150);
            btntk.Name = "btntk";
            btntk.Size = new Size(94, 29);
            btntk.TabIndex = 5;
            btntk.Text = "Tìm kiếm";
            btntk.UseVisualStyleBackColor = true;
            btntk.Click += btntk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 6;
            label1.Text = "Tìm kiếm theo mã sv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 51);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 7;
            label2.Text = "Tìm kiếm theo tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(637, 51);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 8;
            label3.Text = "Tìm kiếm theo mã lớp:";
            // 
            // btnthoatqlsv
            // 
            btnthoatqlsv.Location = new Point(993, 150);
            btnthoatqlsv.Name = "btnthoatqlsv";
            btnthoatqlsv.Size = new Size(94, 29);
            btnthoatqlsv.TabIndex = 9;
            btnthoatqlsv.Text = "Thoát";
            btnthoatqlsv.UseVisualStyleBackColor = true;
            btnthoatqlsv.Click += btnthoatqlsv_Click;
            // 
            // frmqlsvgv
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 450);
            Controls.Add(btnthoatqlsv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btntk);
            Controls.Add(cbbtkmalop);
            Controls.Add(cbbtkten);
            Controls.Add(cbbtkmasv);
            Controls.Add(dgvmain);
            Name = "frmqlsvgv";
            Text = "Quản lý sinh viên";
            Load += frmqlsvgv_Load;
            ((System.ComponentModel.ISupportInitialize)dgvmain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvmain;
        private ComboBox cbbtkmasv;
        private ComboBox cbbtkten;
        private ComboBox cbbtkmalop;
        private Button btntk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnthoatqlsv;
    }
}
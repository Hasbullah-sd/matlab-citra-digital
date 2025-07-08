namespace InventarisBarang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.NavigatorPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MaximizedBtnm = new FontAwesome.Sharp.IconButton();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.ProdukNavBtn = new FontAwesome.Sharp.IconButton();
            this.PembelianNavBtn = new FontAwesome.Sharp.IconButton();
            this.BarangNavBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.HelpBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.PrintReportNavBtn = new FontAwesome.Sharp.IconButton();
            this.DashboardBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.HelpBtn);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.PrintReportNavBtn);
            this.panel2.Controls.Add(this.DashboardBtn);
            this.panel2.Location = new System.Drawing.Point(44, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 797);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(251, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard ";
            // 
            // NavigatorPanel
            // 
            this.NavigatorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.NavigatorPanel.Location = new System.Drawing.Point(215, 118);
            this.NavigatorPanel.Name = "NavigatorPanel";
            this.NavigatorPanel.Size = new System.Drawing.Size(5, 62);
            this.NavigatorPanel.TabIndex = 7;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InventarisBarang.Properties.Resources.portof;
            this.pictureBox2.Location = new System.Drawing.Point(561, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventarisBarang.Properties.Resources.Gambar_1_Grafik;
            this.pictureBox1.Location = new System.Drawing.Point(227, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // MaximizedBtnm
            // 
            this.MaximizedBtnm.BackColor = System.Drawing.Color.Transparent;
            this.MaximizedBtnm.FlatAppearance.BorderSize = 0;
            this.MaximizedBtnm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizedBtnm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.MaximizedBtnm.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MaximizedBtnm.IconColor = System.Drawing.Color.DimGray;
            this.MaximizedBtnm.IconSize = 21;
            this.MaximizedBtnm.Location = new System.Drawing.Point(1036, 12);
            this.MaximizedBtnm.Name = "MaximizedBtnm";
            this.MaximizedBtnm.Rotation = 0D;
            this.MaximizedBtnm.Size = new System.Drawing.Size(33, 33);
            this.MaximizedBtnm.TabIndex = 6;
            this.MaximizedBtnm.UseVisualStyleBackColor = false;
            this.MaximizedBtnm.Click += new System.EventHandler(this.MaximizedBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(59)))), ((int)(((byte)(44)))));
            this.CloseBtn.IconSize = 21;
            this.CloseBtn.Location = new System.Drawing.Point(1075, 12);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rotation = 0D;
            this.CloseBtn.Size = new System.Drawing.Size(33, 33);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ProdukNavBtn
            // 
            this.ProdukNavBtn.BackColor = System.Drawing.Color.White;
            this.ProdukNavBtn.FlatAppearance.BorderSize = 0;
            this.ProdukNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProdukNavBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ProdukNavBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdukNavBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ProdukNavBtn.IconChar = FontAwesome.Sharp.IconChar.Industry;
            this.ProdukNavBtn.IconColor = System.Drawing.Color.Teal;
            this.ProdukNavBtn.IconSize = 51;
            this.ProdukNavBtn.Location = new System.Drawing.Point(582, 100);
            this.ProdukNavBtn.Name = "ProdukNavBtn";
            this.ProdukNavBtn.Rotation = 0D;
            this.ProdukNavBtn.Size = new System.Drawing.Size(104, 80);
            this.ProdukNavBtn.TabIndex = 4;
            this.ProdukNavBtn.Text = "Produk";
            this.ProdukNavBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ProdukNavBtn.UseVisualStyleBackColor = false;
            this.ProdukNavBtn.Click += new System.EventHandler(this.ProdukNavBtn_Click);
            // 
            // PembelianNavBtn
            // 
            this.PembelianNavBtn.BackColor = System.Drawing.Color.White;
            this.PembelianNavBtn.FlatAppearance.BorderSize = 0;
            this.PembelianNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PembelianNavBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PembelianNavBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PembelianNavBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PembelianNavBtn.IconChar = FontAwesome.Sharp.IconChar.TruckLoading;
            this.PembelianNavBtn.IconColor = System.Drawing.Color.Crimson;
            this.PembelianNavBtn.IconSize = 51;
            this.PembelianNavBtn.Location = new System.Drawing.Point(422, 100);
            this.PembelianNavBtn.Name = "PembelianNavBtn";
            this.PembelianNavBtn.Rotation = 0D;
            this.PembelianNavBtn.Size = new System.Drawing.Size(104, 80);
            this.PembelianNavBtn.TabIndex = 3;
            this.PembelianNavBtn.Text = "Pembelian";
            this.PembelianNavBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PembelianNavBtn.UseVisualStyleBackColor = false;
            this.PembelianNavBtn.Click += new System.EventHandler(this.PembelianNavBtn_Click);
            // 
            // BarangNavBtn
            // 
            this.BarangNavBtn.BackColor = System.Drawing.Color.White;
            this.BarangNavBtn.FlatAppearance.BorderSize = 0;
            this.BarangNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarangNavBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BarangNavBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarangNavBtn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BarangNavBtn.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.BarangNavBtn.IconColor = System.Drawing.Color.DarkOrange;
            this.BarangNavBtn.IconSize = 51;
            this.BarangNavBtn.Location = new System.Drawing.Point(260, 100);
            this.BarangNavBtn.Name = "BarangNavBtn";
            this.BarangNavBtn.Rotation = 0D;
            this.BarangNavBtn.Size = new System.Drawing.Size(104, 80);
            this.BarangNavBtn.TabIndex = 2;
            this.BarangNavBtn.Text = "Form Barang";
            this.BarangNavBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BarangNavBtn.UseVisualStyleBackColor = false;
            this.BarangNavBtn.Click += new System.EventHandler(this.BarangNavBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButton1.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton1.IconSize = 37;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(-3, 479);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(177, 49);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Logout";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.White;
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.HelpBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HelpBtn.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.HelpBtn.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.HelpBtn.IconSize = 37;
            this.HelpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpBtn.Location = new System.Drawing.Point(-1, 434);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Rotation = 0D;
            this.HelpBtn.Size = new System.Drawing.Size(177, 49);
            this.HelpBtn.TabIndex = 3;
            this.HelpBtn.Text = "Bantuan ";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButton2.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconButton2.IconSize = 37;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 390);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(177, 49);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Settings";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // PrintReportNavBtn
            // 
            this.PrintReportNavBtn.BackColor = System.Drawing.Color.White;
            this.PrintReportNavBtn.FlatAppearance.BorderSize = 0;
            this.PrintReportNavBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReportNavBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.PrintReportNavBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReportNavBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PrintReportNavBtn.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.PrintReportNavBtn.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.PrintReportNavBtn.IconSize = 26;
            this.PrintReportNavBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintReportNavBtn.Location = new System.Drawing.Point(-3, 153);
            this.PrintReportNavBtn.Name = "PrintReportNavBtn";
            this.PrintReportNavBtn.Rotation = 0D;
            this.PrintReportNavBtn.Size = new System.Drawing.Size(174, 62);
            this.PrintReportNavBtn.TabIndex = 1;
            this.PrintReportNavBtn.Text = "Print Report";
            this.PrintReportNavBtn.UseVisualStyleBackColor = false;
            this.PrintReportNavBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.Color.White;
            this.DashboardBtn.FlatAppearance.BorderSize = 0;
            this.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DashboardBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.DashboardBtn.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.DashboardBtn.IconSize = 27;
            this.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Location = new System.Drawing.Point(-3, 85);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Rotation = 0D;
            this.DashboardBtn.Size = new System.Drawing.Size(174, 62);
            this.DashboardBtn.TabIndex = 0;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(913, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NavigatorPanel);
            this.Controls.Add(this.MaximizedBtnm);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ProdukNavBtn);
            this.Controls.Add(this.PembelianNavBtn);
            this.Controls.Add(this.BarangNavBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private FontAwesome.Sharp.IconButton DashboardBtn;
        private FontAwesome.Sharp.IconButton PrintReportNavBtn;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton BarangNavBtn;
        private FontAwesome.Sharp.IconButton PembelianNavBtn;
        private FontAwesome.Sharp.IconButton ProdukNavBtn;
        private FontAwesome.Sharp.IconButton MaximizedBtnm;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NavigatorPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private FontAwesome.Sharp.IconButton HelpBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


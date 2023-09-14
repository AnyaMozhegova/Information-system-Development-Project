
namespace WindowsFormsApp1
{
    partial class MenuSeller
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IbITitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.imageHome = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RosyBrown;
            this.panelMenu.Controls.Add(this.iconButton2);
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.iconButton5);
            this.panelMenu.Controls.Add(this.iconButton4);
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 736);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.imageHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.iconButton8);
            this.panel1.Controls.Add(this.iconButton7);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.IbITitle);
            this.panel1.Controls.Add(this.iconCurrent);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 70);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // IbITitle
            // 
            this.IbITitle.AutoSize = true;
            this.IbITitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IbITitle.ForeColor = System.Drawing.Color.LemonChiffon;
            this.IbITitle.Location = new System.Drawing.Point(59, 27);
            this.IbITitle.Name = "IbITitle";
            this.IbITitle.Size = new System.Drawing.Size(95, 29);
            this.IbITitle.TabIndex = 1;
            this.IbITitle.Text = "Домой";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.MistyRose;
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1265, 666);
            this.panelDesktop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(230, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Магазин для разумных владельцев.";
            // 
            // iconButton8
            // 
            this.iconButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.iconButton8.IconColor = System.Drawing.Color.Salmon;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.Location = new System.Drawing.Point(1086, 0);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(54, 46);
            this.iconButton8.TabIndex = 7;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // iconButton7
            // 
            this.iconButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.iconButton7.IconColor = System.Drawing.Color.Salmon;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.Location = new System.Drawing.Point(1146, 0);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(58, 46);
            this.iconButton7.TabIndex = 6;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.ArrowRightToBracket;
            this.iconButton6.IconColor = System.Drawing.Color.Red;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.Location = new System.Drawing.Point(1210, 0);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(55, 46);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // iconCurrent
            // 
            this.iconCurrent.BackColor = System.Drawing.Color.RosyBrown;
            this.iconCurrent.ForeColor = System.Drawing.Color.Aquamarine;
            this.iconCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrent.IconColor = System.Drawing.Color.Aquamarine;
            this.iconCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrent.IconSize = 53;
            this.iconCurrent.Location = new System.Drawing.Point(0, 0);
            this.iconCurrent.Name = "iconCurrent";
            this.iconCurrent.Size = new System.Drawing.Size(53, 56);
            this.iconCurrent.TabIndex = 0;
            this.iconCurrent.TabStop = false;
            // 
            // iconButton5
            // 
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.SystemColors.Info;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconButton5.IconColor = System.Drawing.Color.Aquamarine;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 50;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(0, 263);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton5.Size = new System.Drawing.Size(220, 70);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Закрытие смены";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.Info;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton4.IconColor = System.Drawing.Color.Aquamarine;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 50;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 193);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(220, 70);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Клиенты";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.SystemColors.Info;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.iconButton3.IconColor = System.Drawing.Color.Aquamarine;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 123);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton3.Size = new System.Drawing.Size(220, 70);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Товары";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // imageHome
            // 
            this.imageHome.BackColor = System.Drawing.SystemColors.Window;
            this.imageHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageHome.Image = global::WindowsFormsApp1.Properties.Resources._317ea17b97a9ab4b476194c79a32e228;
            this.imageHome.Location = new System.Drawing.Point(0, 0);
            this.imageHome.Name = "imageHome";
            this.imageHome.Size = new System.Drawing.Size(220, 123);
            this.imageHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageHome.TabIndex = 0;
            this.imageHome.TabStop = false;
            this.imageHome.Click += new System.EventHandler(this.imageHome_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Info;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconButton1.IconColor = System.Drawing.Color.Aquamarine;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 333);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 70);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Новые заказы";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Info;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.iconButton2.IconColor = System.Drawing.Color.Aquamarine;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 50;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 403);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(220, 70);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Выданные заказы";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // MenuSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 736);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSeller";
            this.Text = "MenuClient";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox imageHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.Label IbITitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrent;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
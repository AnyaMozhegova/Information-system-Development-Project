
namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Logins = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.buttonOpen);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Logins);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 503);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(77, 477);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(217, 17);
            this.register.TabIndex = 6;
            this.register.Text = "У Вас нет аккаунта?";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.FlatAppearance.BorderSize = 0;
            this.buttonOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(57, 418);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(250, 46);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Войти\r\n";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(112, 315);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(195, 57);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 315);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Logins
            // 
            this.Logins.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logins.Location = new System.Drawing.Point(112, 204);
            this.Logins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logins.Multiline = true;
            this.Logins.Name = "Logins";
            this.Logins.Size = new System.Drawing.Size(195, 64);
            this.Logins.TabIndex = 2;
            this.Logins.TextChanged += new System.EventHandler(this.Logins_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 204);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 144);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Exit.Location = new System.Drawing.Point(333, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 37);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 503);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Logins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label register;
    }
}
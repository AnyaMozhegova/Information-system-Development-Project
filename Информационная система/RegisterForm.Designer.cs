
namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.ClientPassport = new System.Windows.Forms.TextBox();
            this.ClientPassword = new System.Windows.Forms.TextBox();
            this.ClientLogin = new System.Windows.Forms.TextBox();
            this.ClientPhone = new System.Windows.Forms.TextBox();
            this.ClientPatronymic = new System.Windows.Forms.TextBox();
            this.ClientAdress = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.ClientEmail = new System.Windows.Forms.TextBox();
            this.ClientFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1035, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.ClientPassport);
            this.panel1.Controls.Add(this.ClientPassword);
            this.panel1.Controls.Add(this.ClientLogin);
            this.panel1.Controls.Add(this.ClientPhone);
            this.panel1.Controls.Add(this.ClientPatronymic);
            this.panel1.Controls.Add(this.ClientAdress);
            this.panel1.Controls.Add(this.ClientName);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.ClientEmail);
            this.panel1.Controls.Add(this.ClientFirstName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 594);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Паспорт";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Логин";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Телефон";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Почта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(949, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "!!!!!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.ForeColor = System.Drawing.Color.Black;
            this.register.Location = new System.Drawing.Point(446, 577);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(162, 17);
            this.register.TabIndex = 13;
            this.register.Text = "Авторизоваться";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // ClientPassport
            // 
            this.ClientPassport.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPassport.Location = new System.Drawing.Point(665, 436);
            this.ClientPassport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientPassport.Multiline = true;
            this.ClientPassport.Name = "ClientPassport";
            this.ClientPassport.Size = new System.Drawing.Size(304, 64);
            this.ClientPassport.TabIndex = 12;
            this.ClientPassport.TextChanged += new System.EventHandler(this.ClientPassport_TextChanged);
            this.ClientPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientPassport_KeyPress);
            this.ClientPassport.Validated += new System.EventHandler(this.ClientPassport_Validated);
            // 
            // ClientPassword
            // 
            this.ClientPassword.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPassword.Location = new System.Drawing.Point(665, 304);
            this.ClientPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientPassword.Multiline = true;
            this.ClientPassword.Name = "ClientPassword";
            this.ClientPassword.Size = new System.Drawing.Size(304, 64);
            this.ClientPassword.TabIndex = 11;
            this.ClientPassword.TextChanged += new System.EventHandler(this.ClientPassword_TextChanged);
            this.ClientPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientPassword_KeyPress);
            this.ClientPassword.Validated += new System.EventHandler(this.ClientPassword_Validated);
            // 
            // ClientLogin
            // 
            this.ClientLogin.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientLogin.Location = new System.Drawing.Point(665, 193);
            this.ClientLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientLogin.Multiline = true;
            this.ClientLogin.Name = "ClientLogin";
            this.ClientLogin.Size = new System.Drawing.Size(304, 64);
            this.ClientLogin.TabIndex = 10;
            this.ClientLogin.TextChanged += new System.EventHandler(this.ClientLogin_TextChanged);
            this.ClientLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientLogin_KeyPress);
            this.ClientLogin.Validated += new System.EventHandler(this.ClientLogin_Validated);
            // 
            // ClientPhone
            // 
            this.ClientPhone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPhone.Location = new System.Drawing.Point(340, 436);
            this.ClientPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientPhone.Multiline = true;
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.Size = new System.Drawing.Size(255, 64);
            this.ClientPhone.TabIndex = 9;
            this.ClientPhone.TextChanged += new System.EventHandler(this.ClientPhone_TextChanged);
            this.ClientPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientPhone_KeyPress);
            this.ClientPhone.Validated += new System.EventHandler(this.ClientPhone_Validated);
            // 
            // ClientPatronymic
            // 
            this.ClientPatronymic.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientPatronymic.Location = new System.Drawing.Point(45, 436);
            this.ClientPatronymic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientPatronymic.Multiline = true;
            this.ClientPatronymic.Name = "ClientPatronymic";
            this.ClientPatronymic.Size = new System.Drawing.Size(255, 64);
            this.ClientPatronymic.TabIndex = 8;
            this.ClientPatronymic.TextChanged += new System.EventHandler(this.ClientPatronymic_TextChanged);
            this.ClientPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientPatronymic_KeyPress);
            this.ClientPatronymic.Validated += new System.EventHandler(this.ClientPatronymic_Validated);
            // 
            // ClientAdress
            // 
            this.ClientAdress.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientAdress.Location = new System.Drawing.Point(340, 308);
            this.ClientAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientAdress.Multiline = true;
            this.ClientAdress.Name = "ClientAdress";
            this.ClientAdress.Size = new System.Drawing.Size(255, 64);
            this.ClientAdress.TabIndex = 7;
            this.ClientAdress.TextChanged += new System.EventHandler(this.ClientAdress_TextChanged);
            this.ClientAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientAdress_KeyPress);
            this.ClientAdress.Validated += new System.EventHandler(this.ClientAdress_Validated);
            // 
            // ClientName
            // 
            this.ClientName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.Location = new System.Drawing.Point(45, 304);
            this.ClientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientName.Multiline = true;
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(255, 64);
            this.ClientName.TabIndex = 6;
            this.ClientName.TextChanged += new System.EventHandler(this.ClientName_TextChanged);
            this.ClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientName_KeyPress);
            this.ClientName.Validated += new System.EventHandler(this.ClientName_Validated);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(352, 529);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(354, 46);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = " Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // ClientEmail
            // 
            this.ClientEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientEmail.Location = new System.Drawing.Point(340, 193);
            this.ClientEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.Size = new System.Drawing.Size(255, 39);
            this.ClientEmail.TabIndex = 4;
            this.ClientEmail.TextChanged += new System.EventHandler(this.ClientEmail_TextChanged);
            this.ClientEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientEmail_KeyPress);
            this.ClientEmail.Validated += new System.EventHandler(this.ClientEmail_Validated);
            // 
            // ClientFirstName
            // 
            this.ClientFirstName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientFirstName.Location = new System.Drawing.Point(45, 193);
            this.ClientFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientFirstName.Multiline = true;
            this.ClientFirstName.Name = "ClientFirstName";
            this.ClientFirstName.Size = new System.Drawing.Size(255, 64);
            this.ClientFirstName.TabIndex = 2;
            this.ClientFirstName.TextChanged += new System.EventHandler(this.ClientFirstName_TextChanged);
            this.ClientFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientFirstName_KeyPress);
            this.ClientFirstName.Validated += new System.EventHandler(this.ClientFirstName_Validated);
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
            this.panel2.Size = new System.Drawing.Size(1035, 144);
            this.panel2.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Exit.Location = new System.Drawing.Point(998, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(37, 37);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "X";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 594);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox ClientEmail;
        private System.Windows.Forms.TextBox ClientFirstName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.TextBox ClientLogin;
        private System.Windows.Forms.TextBox ClientPhone;
        private System.Windows.Forms.TextBox ClientPatronymic;
        private System.Windows.Forms.TextBox ClientAdress;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ClientPassport;
        private System.Windows.Forms.TextBox ClientPassword;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
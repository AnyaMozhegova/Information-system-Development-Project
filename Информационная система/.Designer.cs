
namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.Windows.Forms.Label label4;
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gradient1 = new WindowsFormsApp1.Gradient();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textclientcode = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textS = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SurName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gradient1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 307);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 20);
            label4.TabIndex = 3;
            label4.Text = "Еmail";
            label4.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.gradient1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 754);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 422);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(860, 282);
            this.dataGridView2.TabIndex = 19;
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.btnUpdate);
            this.gradient1.Controls.Add(this.btnCancel);
            this.gradient1.Controls.Add(this.btnEdit);
            this.gradient1.Controls.Add(this.btnDelete);
            this.gradient1.Controls.Add(this.btnSave);
            this.gradient1.Controls.Add(this.groupBox1);
            this.gradient1.Controls.Add(this.search);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.btnAdd);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1456, 754);
            this.gradient1.TabIndex = 20;
            this.gradient1.TopColor = System.Drawing.Color.LightSkyBlue;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.MistyRose;
            this.btnUpdate.Location = new System.Drawing.Point(1262, 611);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 60);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Location = new System.Drawing.Point(1091, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 60);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btnEdit.Location = new System.Drawing.Point(926, 607);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 69);
            this.btnEdit.TabIndex = 30;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(1262, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 60);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MistyRose;
            this.btnSave.Location = new System.Drawing.Point(926, 522);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 69);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxGender);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textclientcode);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textS);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.SurName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(926, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 425);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 369);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Пол";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxGender.Location = new System.Drawing.Point(145, 200);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(277, 22);
            this.textBoxGender.TabIndex = 14;
            this.textBoxGender.TextChanged += new System.EventHandler(this.textBoxGender_TextChanged);
            this.textBoxGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGender_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 13;
            // 
            // textclientcode
            // 
            this.textclientcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textclientcode.Location = new System.Drawing.Point(145, 364);
            this.textclientcode.Name = "textclientcode";
            this.textclientcode.Size = new System.Drawing.Size(277, 22);
            this.textclientcode.TabIndex = 12;
            this.textclientcode.TextChanged += new System.EventHandler(this.textclientcode_TextChanged);
            this.textclientcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textclientcode_KeyPress);
            // 
            // textPhone
            // 
            this.textPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPhone.Location = new System.Drawing.Point(145, 247);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(277, 22);
            this.textPhone.TabIndex = 11;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEmail.Location = new System.Drawing.Point(145, 307);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(277, 22);
            this.textEmail.TabIndex = 9;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEmail_KeyPress);
            // 
            // textS
            // 
            this.textS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textS.Location = new System.Drawing.Point(145, 148);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(277, 22);
            this.textS.TabIndex = 8;
            this.textS.TextChanged += new System.EventHandler(this.textS_TextChanged);
            this.textS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textS_KeyPress);
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.Location = new System.Drawing.Point(145, 91);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(277, 22);
            this.textName.TabIndex = 7;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // SurName
            // 
            this.SurName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurName.Location = new System.Drawing.Point(145, 30);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(277, 22);
            this.SurName.TabIndex = 6;
            this.SurName.TextChanged += new System.EventHandler(this.SurName_TextChanged);
            this.SurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SurName_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.BackColor = System.Drawing.Color.MistyRose;
            this.search.Location = new System.Drawing.Point(1194, 682);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(250, 69);
            this.search.TabIndex = 18;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 282);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Location = new System.Drawing.Point(915, 682);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(245, 69);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 754);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textclientcode;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textEmail;
        private Gradient gradient1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
    }
}

namespace WindowsFormsApp1
{
    partial class GrudSeller
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gradient1 = new WindowsFormsApp1.Gradient();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textGender = new System.Windows.Forms.TextBox();
            this.textPrize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textIDPos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSalary = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textCur = new System.Windows.Forms.TextBox();
            this.textS = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.SurName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gradient1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(26, 294);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Текущий";
            label4.UseCompatibleTextRendering = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 282);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 377);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(729, 282);
            this.dataGridView2.TabIndex = 20;
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.BackColor = System.Drawing.Color.MistyRose;
            this.search.Location = new System.Drawing.Point(1015, 652);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(250, 47);
            this.search.TabIndex = 28;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Location = new System.Drawing.Point(1310, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 60);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(1073, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 60);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.MistyRose;
            this.btnUpdate.Location = new System.Drawing.Point(824, 566);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 60);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btnEdit.Location = new System.Drawing.Point(1310, 472);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 69);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MistyRose;
            this.btnSave.Location = new System.Drawing.Point(1073, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 69);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Location = new System.Drawing.Point(824, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 69);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.SlateBlue;
            this.gradient1.BottomColor = System.Drawing.Color.Transparent;
            this.gradient1.Controls.Add(this.search);
            this.gradient1.Controls.Add(this.groupBox1);
            this.gradient1.Controls.Add(this.btnUpdate);
            this.gradient1.Controls.Add(this.btnDelete);
            this.gradient1.Controls.Add(this.btnAdd);
            this.gradient1.Controls.Add(this.btnCancel);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.btnSave);
            this.gradient1.Controls.Add(this.btnEdit);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1466, 711);
            this.gradient1.TabIndex = 29;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gradient1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textGender);
            this.groupBox1.Controls.Add(this.textPrize);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textIDPos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textSalary);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.textCur);
            this.groupBox1.Controls.Add(this.textS);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.SurName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(807, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 386);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Пол";
            // 
            // textGender
            // 
            this.textGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textGender.Location = new System.Drawing.Point(354, 213);
            this.textGender.Name = "textGender";
            this.textGender.Size = new System.Drawing.Size(277, 22);
            this.textGender.TabIndex = 20;
            this.textGender.TextChanged += new System.EventHandler(this.textGender_TextChanged);
            this.textGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textGender_KeyPress);
            // 
            // textPrize
            // 
            this.textPrize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPrize.Location = new System.Drawing.Point(354, 101);
            this.textPrize.Name = "textPrize";
            this.textPrize.Size = new System.Drawing.Size(277, 22);
            this.textPrize.TabIndex = 19;
            this.textPrize.TextChanged += new System.EventHandler(this.textPrize_TextChanged);
            this.textPrize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrize_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(351, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "ID";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Премия";
            // 
            // textId
            // 
            this.textId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textId.Location = new System.Drawing.Point(354, 161);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(277, 22);
            this.textId.TabIndex = 16;
            this.textId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            this.textId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textId_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID_Позиция";
            // 
            // textIDPos
            // 
            this.textIDPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textIDPos.Location = new System.Drawing.Point(17, 213);
            this.textIDPos.Name = "textIDPos";
            this.textIDPos.Size = new System.Drawing.Size(277, 22);
            this.textIDPos.TabIndex = 14;
            this.textIDPos.TextChanged += new System.EventHandler(this.textIDPos_TextChanged);
            this.textIDPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIDPos_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Зарплата";
            // 
            // textSalary
            // 
            this.textSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSalary.Location = new System.Drawing.Point(354, 43);
            this.textSalary.Name = "textSalary";
            this.textSalary.Size = new System.Drawing.Size(277, 22);
            this.textSalary.TabIndex = 12;
            this.textSalary.TextChanged += new System.EventHandler(this.textSalary_TextChanged);
            this.textSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSalary_KeyPress);
            // 
            // textPhone
            // 
            this.textPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPhone.Location = new System.Drawing.Point(17, 260);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(277, 22);
            this.textPhone.TabIndex = 11;
            this.textPhone.TextChanged += new System.EventHandler(this.textPhone_TextChanged);
            this.textPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPhone_KeyPress);
            // 
            // textCur
            // 
            this.textCur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCur.Location = new System.Drawing.Point(17, 317);
            this.textCur.Name = "textCur";
            this.textCur.Size = new System.Drawing.Size(277, 22);
            this.textCur.TabIndex = 9;
            this.textCur.TextChanged += new System.EventHandler(this.textCur_TextChanged);
            this.textCur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCur_KeyPress);
            // 
            // textS
            // 
            this.textS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textS.Location = new System.Drawing.Point(17, 161);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(277, 22);
            this.textS.TabIndex = 8;
            this.textS.TextChanged += new System.EventHandler(this.textS_TextChanged);
            this.textS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textS_KeyPress);
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.Location = new System.Drawing.Point(17, 101);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(277, 22);
            this.textName.TabIndex = 7;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // SurName
            // 
            this.SurName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SurName.Location = new System.Drawing.Point(17, 43);
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
            this.label6.Location = new System.Drawing.Point(23, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GrudSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 711);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.gradient1);
            this.Name = "GrudSeller";
            this.Text = "GrudSeller";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gradient1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSalary;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textCur;
        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textIDPos;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private Gradient gradient1;
        private System.Windows.Forms.TextBox textPrize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textGender;
    }
}
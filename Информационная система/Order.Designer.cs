
namespace WindowsFormsApp1
{
    partial class Order
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
            this.gradient1 = new WindowsFormsApp1.Gradient();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textIdProduct = new System.Windows.Forms.TextBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textAvailability = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.btnCancel);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Controls.Add(this.btnSave);
            this.gradient1.Controls.Add(this.btnUpdate);
            this.gradient1.Controls.Add(this.btnAdd);
            this.gradient1.Controls.Add(this.search);
            this.gradient1.Controls.Add(this.dataGridView2);
            this.gradient1.Controls.Add(this.btnEdit);
            this.gradient1.Controls.Add(this.groupBox1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1418, 791);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.Location = new System.Drawing.Point(1242, 548);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 60);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 372);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.MistyRose;
            this.btnSave.Location = new System.Drawing.Point(1050, 544);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 69);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.MistyRose;
            this.btnUpdate.Location = new System.Drawing.Point(877, 657);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 60);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdd.Location = new System.Drawing.Point(877, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 69);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search.BackColor = System.Drawing.Color.MistyRose;
            this.search.Location = new System.Drawing.Point(1051, 657);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(155, 60);
            this.search.TabIndex = 39;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 497);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(808, 262);
            this.dataGridView2.TabIndex = 32;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btnEdit.Location = new System.Drawing.Point(1242, 657);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 60);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxManufacturer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textIdProduct);
            this.groupBox1.Controls.Add(this.textCategory);
            this.groupBox1.Controls.Add(this.textAvailability);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(838, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 340);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Стоимость всего";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxManufacturer.Location = new System.Drawing.Point(185, 94);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(277, 22);
            this.textBoxManufacturer.TabIndex = 14;
            this.textBoxManufacturer.TextChanged += new System.EventHandler(this.textBoxManufacturer_TextChanged);
            this.textBoxManufacturer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxManufacturer_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 13;
            // 
            // textIdProduct
            // 
            this.textIdProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textIdProduct.Location = new System.Drawing.Point(185, 45);
            this.textIdProduct.Name = "textIdProduct";
            this.textIdProduct.Size = new System.Drawing.Size(277, 22);
            this.textIdProduct.TabIndex = 12;
            this.textIdProduct.TextChanged += new System.EventHandler(this.textIdProduct_TextChanged);
            this.textIdProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textIdProduct_KeyPress);
            // 
            // textCategory
            // 
            this.textCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCategory.Location = new System.Drawing.Point(185, 148);
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(277, 22);
            this.textCategory.TabIndex = 8;
            this.textCategory.TextChanged += new System.EventHandler(this.textCategory_TextChanged);
            this.textCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCategory_KeyPress);
            // 
            // textAvailability
            // 
            this.textAvailability.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAvailability.Location = new System.Drawing.Point(185, 278);
            this.textAvailability.Name = "textAvailability";
            this.textAvailability.Size = new System.Drawing.Size(277, 22);
            this.textAvailability.TabIndex = 7;
            this.textAvailability.TextChanged += new System.EventHandler(this.textAvailability_TextChanged);
            this.textAvailability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAvailability_KeyPress);
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.Location = new System.Drawing.Point(185, 220);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(277, 22);
            this.textName.TabIndex = 6;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            this.textName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textName_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Продавец ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 791);
            this.Controls.Add(this.gradient1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.gradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIdProduct;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textAvailability;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
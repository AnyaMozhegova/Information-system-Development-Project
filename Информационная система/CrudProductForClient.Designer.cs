
namespace WindowsFormsApp1
{
    partial class CrudProductForClient
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.Plum;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.button1);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1225, 591);
            this.gradient1.TabIndex = 22;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(813, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 100);
            this.label4.TabIndex = 26;
            this.label4.Text = "Приносим Вам свои извинения, \r\nно из-за \r\nполитики магазина\r\nсделать бронь возмож" +
    "но \r\nмаксимум на 3 различных продукта";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(813, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 80);
            this.label3.TabIndex = 25;
            this.label3.Text = "Кроме того, если Вам что-то не понятно,\r\nто Вы лично можете позвонить нам.\r\nКонта" +
    "ктные данные нашего магазина \r\nнаходятся на вкладке \"О нас\"";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(812, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 100);
            this.label2.TabIndex = 24;
            this.label2.Text = "После заполнения формы,\r\nсвязанной с товарами, \r\nкоторые нам необходимо отложить," +
    " \r\nнаши сотрудники позвонят Вам\r\nдля уточнения заказа";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.OldLace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(812, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 80);
            this.label1.TabIndex = 23;
            this.label1.Text = "Вы можете оставить заказ,\r\nдля того чтобы\r\nинтересующие Вас \r\nвещи сформировали в" +
    " бронь.";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(292, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Оставить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 490);
            this.dataGridView1.TabIndex = 21;
            // 
            // CrudProductForClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 591);
            this.Controls.Add(this.gradient1);
            this.Name = "CrudProductForClient";
            this.Text = "CrudProductForClient";
            this.Load += new System.EventHandler(this.CrudProductForClient_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Gradient gradient1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
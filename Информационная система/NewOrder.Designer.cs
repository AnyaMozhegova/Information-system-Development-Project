
namespace WindowsFormsApp1
{
    partial class NewOrder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.textBox1);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(this.btnDelete);
            this.gradient1.Controls.Add(this.dataGridView1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(930, 557);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(103, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "id";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.MistyRose;
            this.btnDelete.Location = new System.Drawing.Point(384, 485);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 60);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 372);
            this.dataGridView1.TabIndex = 21;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.gradient1);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
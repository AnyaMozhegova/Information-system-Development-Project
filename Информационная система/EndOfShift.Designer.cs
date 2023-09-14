
namespace WindowsFormsApp1
{
    partial class EndOfShift
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
            this.label16 = new System.Windows.Forms.Label();
            this.sber2 = new System.Windows.Forms.TextBox();
            this.totalSber = new System.Windows.Forms.TextBox();
            this.refund = new System.Windows.Forms.TextBox();
            this.textBoxSmall = new System.Windows.Forms.TextBox();
            this.cash1 = new System.Windows.Forms.TextBox();
            this.cash2 = new System.Windows.Forms.TextBox();
            this.textBoxFifty = new System.Windows.Forms.TextBox();
            this.textBoxOneHundred = new System.Windows.Forms.TextBox();
            this.textBoxFiveHundred = new System.Windows.Forms.TextBox();
            this.textBoxOneThousand = new System.Windows.Forms.TextBox();
            this.textBoxFiveThousand = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.collection = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.total2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.TextBox();
            this.sber1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BackColor = System.Drawing.Color.SeaShell;
            this.gradient1.BottomColor = System.Drawing.Color.Empty;
            this.gradient1.Controls.Add(this.label16);
            this.gradient1.Controls.Add(this.sber2);
            this.gradient1.Controls.Add(this.totalSber);
            this.gradient1.Controls.Add(this.refund);
            this.gradient1.Controls.Add(this.textBoxSmall);
            this.gradient1.Controls.Add(this.cash1);
            this.gradient1.Controls.Add(this.cash2);
            this.gradient1.Controls.Add(this.textBoxFifty);
            this.gradient1.Controls.Add(this.textBoxOneHundred);
            this.gradient1.Controls.Add(this.textBoxFiveHundred);
            this.gradient1.Controls.Add(this.textBoxOneThousand);
            this.gradient1.Controls.Add(this.textBoxFiveThousand);
            this.gradient1.Controls.Add(this.label15);
            this.gradient1.Controls.Add(this.label14);
            this.gradient1.Controls.Add(this.label13);
            this.gradient1.Controls.Add(this.label12);
            this.gradient1.Controls.Add(this.label9);
            this.gradient1.Controls.Add(this.label7);
            this.gradient1.Controls.Add(this.label5);
            this.gradient1.Controls.Add(this.collection);
            this.gradient1.Controls.Add(this.buttonAdd);
            this.gradient1.Controls.Add(this.comboBox1);
            this.gradient1.Controls.Add(this.label6);
            this.gradient1.Controls.Add(this.total2);
            this.gradient1.Controls.Add(this.quantity);
            this.gradient1.Controls.Add(this.label4);
            this.gradient1.Controls.Add(this.label8);
            this.gradient1.Controls.Add(this.label3);
            this.gradient1.Controls.Add(this.label11);
            this.gradient1.Controls.Add(this.total1);
            this.gradient1.Controls.Add(this.sber1);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(this.label10);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(1223, 627);
            this.gradient1.TabIndex = 35;
            this.gradient1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Chocolate;
            this.label16.Location = new System.Drawing.Point(389, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(404, 57);
            this.label16.TabIndex = 57;
            this.label16.Text = "Закрытие смены";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sber2
            // 
            this.sber2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sber2.Location = new System.Drawing.Point(399, 243);
            this.sber2.Name = "sber2";
            this.sber2.Size = new System.Drawing.Size(297, 22);
            this.sber2.TabIndex = 24;
            this.sber2.TextChanged += new System.EventHandler(this.sber2_TextChanged);
            this.sber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sber2_KeyPress);
            this.sber2.Validated += new System.EventHandler(this.sber2_Validated);
            // 
            // totalSber
            // 
            this.totalSber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalSber.Location = new System.Drawing.Point(402, 332);
            this.totalSber.Name = "totalSber";
            this.totalSber.Size = new System.Drawing.Size(297, 22);
            this.totalSber.TabIndex = 27;
            this.totalSber.TextChanged += new System.EventHandler(this.totalSber_TextChanged);
            this.totalSber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalSber_KeyPress);
            this.totalSber.Validated += new System.EventHandler(this.totalSber_Validated);
            // 
            // refund
            // 
            this.refund.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refund.Location = new System.Drawing.Point(50, 429);
            this.refund.Name = "refund";
            this.refund.Size = new System.Drawing.Size(255, 22);
            this.refund.TabIndex = 31;
            this.refund.TextChanged += new System.EventHandler(this.refund_TextChanged);
            this.refund.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.refund_KeyPress);
            this.refund.Validated += new System.EventHandler(this.refund_Validated);
            // 
            // textBoxSmall
            // 
            this.textBoxSmall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSmall.Location = new System.Drawing.Point(888, 493);
            this.textBoxSmall.Name = "textBoxSmall";
            this.textBoxSmall.Size = new System.Drawing.Size(202, 22);
            this.textBoxSmall.TabIndex = 56;
            this.textBoxSmall.TextChanged += new System.EventHandler(this.textBoxSmall_TextChanged);
            this.textBoxSmall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSmall_KeyPress);
            this.textBoxSmall.Validated += new System.EventHandler(this.textBoxSmall_Validated);
            // 
            // cash1
            // 
            this.cash1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cash1.Location = new System.Drawing.Point(49, 148);
            this.cash1.Name = "cash1";
            this.cash1.Size = new System.Drawing.Size(255, 22);
            this.cash1.TabIndex = 20;
            this.cash1.TextChanged += new System.EventHandler(this.cash1_TextChanged);
            this.cash1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash1_KeyPress);
            this.cash1.Validated += new System.EventHandler(this.cash1_Validated);
            // 
            // cash2
            // 
            this.cash2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cash2.Location = new System.Drawing.Point(49, 243);
            this.cash2.Name = "cash2";
            this.cash2.Size = new System.Drawing.Size(255, 22);
            this.cash2.TabIndex = 21;
            this.cash2.TextChanged += new System.EventHandler(this.cash2_TextChanged);
            this.cash2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cash2_KeyPress);
            this.cash2.Validated += new System.EventHandler(this.cash2_Validated);
            // 
            // textBoxFifty
            // 
            this.textBoxFifty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFifty.Location = new System.Drawing.Point(888, 429);
            this.textBoxFifty.Name = "textBoxFifty";
            this.textBoxFifty.Size = new System.Drawing.Size(202, 22);
            this.textBoxFifty.TabIndex = 55;
            this.textBoxFifty.TextChanged += new System.EventHandler(this.textBoxFifty_TextChanged);
            this.textBoxFifty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFifty_KeyPress);
            this.textBoxFifty.Validated += new System.EventHandler(this.textBoxFifty_Validated);
            // 
            // textBoxOneHundred
            // 
            this.textBoxOneHundred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOneHundred.Location = new System.Drawing.Point(888, 354);
            this.textBoxOneHundred.Name = "textBoxOneHundred";
            this.textBoxOneHundred.Size = new System.Drawing.Size(202, 22);
            this.textBoxOneHundred.TabIndex = 54;
            this.textBoxOneHundred.TextChanged += new System.EventHandler(this.textBoxOneHundred_TextChanged);
            this.textBoxOneHundred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOneHundred_KeyPress);
            this.textBoxOneHundred.Validated += new System.EventHandler(this.textBoxOneHundred_Validated);
            // 
            // textBoxFiveHundred
            // 
            this.textBoxFiveHundred.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFiveHundred.Location = new System.Drawing.Point(888, 289);
            this.textBoxFiveHundred.Name = "textBoxFiveHundred";
            this.textBoxFiveHundred.Size = new System.Drawing.Size(202, 22);
            this.textBoxFiveHundred.TabIndex = 53;
            this.textBoxFiveHundred.TextChanged += new System.EventHandler(this.textBoxFiveHundred_TextChanged);
            this.textBoxFiveHundred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiveHundred_KeyPress);
            this.textBoxFiveHundred.Validated += new System.EventHandler(this.textBoxFiveHundred_Validated);
            // 
            // textBoxOneThousand
            // 
            this.textBoxOneThousand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOneThousand.Location = new System.Drawing.Point(888, 205);
            this.textBoxOneThousand.Name = "textBoxOneThousand";
            this.textBoxOneThousand.Size = new System.Drawing.Size(202, 22);
            this.textBoxOneThousand.TabIndex = 52;
            this.textBoxOneThousand.TextChanged += new System.EventHandler(this.textBoxOneThousand_TextChanged);
            this.textBoxOneThousand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOneThousand_KeyPress);
            this.textBoxOneThousand.Validated += new System.EventHandler(this.textBoxOneThousand_Validated);
            // 
            // textBoxFiveThousand
            // 
            this.textBoxFiveThousand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFiveThousand.Location = new System.Drawing.Point(888, 137);
            this.textBoxFiveThousand.Name = "textBoxFiveThousand";
            this.textBoxFiveThousand.Size = new System.Drawing.Size(202, 22);
            this.textBoxFiveThousand.TabIndex = 36;
            this.textBoxFiveThousand.TextChanged += new System.EventHandler(this.textBoxFiveThousand_TextChanged);
            this.textBoxFiveThousand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiveThousand_KeyPress);
            this.textBoxFiveThousand.Validated += new System.EventHandler(this.textBoxFiveThousand_Validated);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(780, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 24);
            this.label15.TabIndex = 51;
            this.label15.Text = "Мелочь";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(823, 429);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 24);
            this.label14.TabIndex = 50;
            this.label14.Text = "50";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(812, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 24);
            this.label13.TabIndex = 49;
            this.label13.Text = "100";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(812, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "500";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(801, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "1000";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(801, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "5000";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(791, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Опись сдаваемых наличных денег";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // collection
            // 
            this.collection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.collection.Location = new System.Drawing.Point(227, 513);
            this.collection.Name = "collection";
            this.collection.Size = new System.Drawing.Size(263, 22);
            this.collection.TabIndex = 33;
            this.collection.TextChanged += new System.EventHandler(this.collection_TextChanged);
            this.collection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.collection_KeyPress);
            this.collection.Validated += new System.EventHandler(this.collection_Validated);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(464, 580);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(263, 39);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.Validated += new System.EventHandler(this.buttonAdd_Validated);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Наличными",
            "Безналичными"});
            this.comboBox1.Location = new System.Drawing.Point(154, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 24);
            this.comboBox1.TabIndex = 42;
            this.comboBox1.Text = "Безналичными";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(398, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 41;
            this.label6.Text = "Количество чеков";
            // 
            // total2
            // 
            this.total2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total2.AutoSize = true;
            this.total2.BackColor = System.Drawing.Color.Transparent;
            this.total2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.total2.Location = new System.Drawing.Point(398, 289);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(329, 24);
            this.total2.TabIndex = 40;
            this.total2.Text = "Итого по безналичному расчету";
            // 
            // quantity
            // 
            this.quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantity.Location = new System.Drawing.Point(402, 429);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(297, 22);
            this.quantity.TabIndex = 29;
            this.quantity.TextChanged += new System.EventHandler(this.quantity_TextChanged);
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            this.quantity.Validated += new System.EventHandler(this.quantity_Validated);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(406, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Сбербанк касса 2";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(406, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "Сбербанк касса 1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(289, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 37;
            this.label3.Text = "Инкассация";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(45, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 36;
            this.label11.Text = "Возврат";
            // 
            // total1
            // 
            this.total1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.total1.Location = new System.Drawing.Point(51, 332);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(254, 22);
            this.total1.TabIndex = 22;
            this.total1.TextChanged += new System.EventHandler(this.total1_TextChanged);
            this.total1.Validated += new System.EventHandler(this.total1_Validated);
            // 
            // sber1
            // 
            this.sber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sber1.Location = new System.Drawing.Point(399, 148);
            this.sber1.Name = "sber1";
            this.sber1.Size = new System.Drawing.Size(297, 22);
            this.sber1.TabIndex = 23;
            this.sber1.TextChanged += new System.EventHandler(this.sber1_TextChanged);
            this.sber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sber1_KeyPress);
            this.sber1.Validated += new System.EventHandler(this.sber1_Validated);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Итого";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(47, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(187, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Наличка с кассы 2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наличка с кассы 1";
            // 
            // EndOfShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 627);
            this.Controls.Add(this.gradient1);
            this.Name = "EndOfShift";
            this.Text = "EndOfShift";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox sber2;
        private System.Windows.Forms.TextBox sber1;
        private System.Windows.Forms.TextBox total1;
        private System.Windows.Forms.TextBox cash2;
        private System.Windows.Forms.TextBox cash1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalSber;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox refund;
        private System.Windows.Forms.TextBox collection;
        private System.Windows.Forms.Button buttonAdd;
        private Gradient gradient1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label total2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxSmall;
        private System.Windows.Forms.TextBox textBoxFifty;
        private System.Windows.Forms.TextBox textBoxOneHundred;
        private System.Windows.Forms.TextBox textBoxFiveHundred;
        private System.Windows.Forms.TextBox textBoxOneThousand;
        private System.Windows.Forms.TextBox textBoxFiveThousand;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
    }
}
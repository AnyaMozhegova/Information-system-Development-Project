
namespace WindowsFormsApp1
{
    partial class DayBlank
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDay = new System.Windows.Forms.Label();
            this.iconButtonPlus = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDay.Location = new System.Drawing.Point(0, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(170, 84);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "01";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButtonPlus
            // 
            this.iconButtonPlus.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.iconButtonPlus.IconColor = System.Drawing.Color.Black;
            this.iconButtonPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPlus.Location = new System.Drawing.Point(126, 0);
            this.iconButtonPlus.Name = "iconButtonPlus";
            this.iconButtonPlus.Size = new System.Drawing.Size(44, 42);
            this.iconButtonPlus.TabIndex = 1;
            this.iconButtonPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonPlus.UseVisualStyleBackColor = true;
            this.iconButtonPlus.Click += new System.EventHandler(this.iconButtonPlus_Click);
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.iconButtonPlus);
            this.Controls.Add(this.labelDay);
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(170, 84);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelDay;
        private FontAwesome.Sharp.IconButton iconButtonPlus;
    }
}

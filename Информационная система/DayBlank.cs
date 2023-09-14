using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DayBlank : UserControl
    {
        private DateTime _currentDate;
        private Color _backColor;
        public DayBlank()
        {
            InitializeComponent();
        }

        public void Refresh(Color backColor, int day, DateTime date, Color foreColor)
        {
            BackColor =  _backColor= backColor;
            labelDay.Text = day.ToString();
            _currentDate = date;
            if (_currentDate.ToShortDateString() == DateTime.Now.ToShortDateString())
                BackColor = Color.FromArgb(222, 255, 159, 67);
            labelDay.ForeColor = foreColor;
        }

        private void DayBlank_Load(object sender, EventArgs e)
        {
            new List<Control> {labelDay , iconButtonPlus, this}.ForEach(x =>
            {
                x.MouseClick += labelDayControl_MouseClick;
                x.MouseEnter += labelDay_MouseEnter;
                x.MouseLeave += labelDay_MouseLeave;
            });
        }

        private void labelDay_MouseEnter(object sender, EventArgs e)
        {
           
            BackColor = Color.FromArgb(123, _backColor);
        }

        private void labelDay_MouseLeave(object sender, EventArgs e)
        {
            if (!ClientRectangle.Contains(PointToClient(MousePosition)))
            {
               
                BackColor = _backColor;
            }
        }

        private void labelDayControl_MouseClick(object sender, MouseEventArgs e)
        {

            // Next tutorial
         
           
        }

        private void iconButtonPlus_Click(object sender, EventArgs e)
        {
            
        }
    }
}

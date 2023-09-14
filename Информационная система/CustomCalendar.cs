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
    public partial class CustomCalendar : UserControl
    {
        
        private readonly Color Holiday_Color = Color.FromArgb(85, 238, 82, 83);
        private readonly Color Day_Color = Color.FromArgb(85, 246, 242, 242);
        private readonly Color Previos_Month_Day_Color = Color.FromArgb(35, 34, 47, 62);
        public CustomCalendar()
        {
            InitializeComponent();
           
            
        }

            public void DisplayDays(DateTime date)
            {
                var now = date;
                var previousMonth = date.AddMonths(-1);

                var startOfTheMonth = new DateTime(now.Year, now.Month, 1);

                int days = DateTime.DaysInMonth(now.Year, now.Month);
                int previousMonthDays = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);

                int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) == 0
                    ? 7
                    : Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

                dayOfTheWeek = dayOfTheWeek == 1 ? 8 : dayOfTheWeek;

                //Заполняем дни предыдущего месяца
                for (int i = 1; i < dayOfTheWeek; i++)
                {
                    (tableLayoutPanel1.Controls[42 - i] as DayBlank).Refresh(Previos_Month_Day_Color,
                        (previousMonthDays - dayOfTheWeek + i + 1),
                        new DateTime(previousMonth.Year, previousMonth.Month, (previousMonthDays - dayOfTheWeek + i + 1)),
                        Color.LightGray);
                }
                // Заполняем дни текущего месяца
                for (int i = 0; i < days; i++)
                {
                    if ((42 - i - dayOfTheWeek) % 7 == 0 || (42 - i - dayOfTheWeek - 1) % 7 == 0)
                    {
                        (tableLayoutPanel1.Controls[42 - i - dayOfTheWeek] as DayBlank).Refresh(Holiday_Color,
                            i + 1,
                            new DateTime(now.Year, now.Month, i + 1),
                            Color.Azure);
                    }
                    else
                    {
                        (tableLayoutPanel1.Controls[42 - i - dayOfTheWeek] as DayBlank).Refresh(Day_Color,
                            i + 1,
                            new DateTime(now.Year, now.Month, i + 1),
                            Color.Azure);
                    }
                }


                // Заполняем дни след. месяца
                int otherDays = 42 - days - dayOfTheWeek;
                for (int i = otherDays; i >= 0; i--)
                {
                    (tableLayoutPanel1.Controls[i] as DayBlank).Refresh(Previos_Month_Day_Color,
                        otherDays - i + 1,
                        new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, otherDays - i + 1),
                        Color.LightGray);
                }


            }
        }
    }


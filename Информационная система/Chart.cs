using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }
        DB db = new DB();
       
        
        MySqlDataAdapter da;
       
        DataTable dt;
        DataSet dataSet = null;

        private void Chart_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
            connection.Open();

            da = new MySqlDataAdapter("SELECT*FROM end_of_shift ", connection);
            dataSet = new DataSet();
            
            cartesianChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataSet.Tables["end_of_shift"]!=null)
            dataSet.Tables["end_of_shift"].Clear();
            
            da.Fill(dataSet, "end_of_shift");
            dt = dataSet.Tables["end_of_shift"];
            SeriesCollection series = new SeriesCollection();
            ChartValues<int> ShiftValues = new ChartValues<int>();
            List<string> code = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                ShiftValues.Add(Convert.ToInt32(row["Collection"]));
                code.Add(Convert.ToInt32(row["Shift_code"]).ToString());
            }
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis()
            {
                Title="Код",
                Labels=code
            });
            LineSeries line = new LineSeries();
            line.Title = "Инкассация";
            line.Values = ShiftValues;

            series.Add(line);
            cartesianChart1.Series = series;

        }
    }
}

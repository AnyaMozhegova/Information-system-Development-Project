using System;
using System.Data;
using System.Windows.Forms;

using Excel=Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Export : Form
    {
        public Export()
        {
            InitializeComponent();
        }
        DB db = new DB();
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
        MySqlCommand command, command2, command3;
        MySqlDataAdapter da, da2,da3;

        private void button1_Click(object sender, EventArgs e)
        {


            dataGridView1.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.SelectAll();
            DataObject copydata = dataGridView1.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void Export_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        MySqlDataReader reader;
        DataTable dt,dt2,dt3;
        private void LoadData()
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Select * from end_of_shift", connection);
                command.ExecuteNonQuery();
                da = new MySqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                command2 = new MySqlCommand("Select * from product", connection);
                command2.ExecuteNonQuery();
                da2 = new MySqlDataAdapter(command2);
                dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2.DefaultView;
                command3 = new MySqlCommand("Select * from order", connection);
                command3.ExecuteNonQuery();
                da3 = new MySqlDataAdapter(command3);
                dt3 = new DataTable();
                da3.Fill(dt3);
                dataGridView3.DataSource = dt3.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
   
}

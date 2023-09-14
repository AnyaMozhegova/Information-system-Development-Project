using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class CrudProductForClient : Form
    {
        public CrudProductForClient()
        {
            InitializeComponent();
        }
        DB db = new DB();
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;

        private void CrudProductForClient_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Select * from product", connection);
                command.ExecuteNonQuery();
                da = new MySqlDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderFromClientcs registerForm = new OrderFromClientcs();
            registerForm.Show();
        }
    }
}

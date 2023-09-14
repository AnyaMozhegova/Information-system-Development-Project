using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class MainForm : Form

    {
        DB db = new DB(); 
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;

        public MainForm()
        {
            InitializeComponent();
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Select * from client", connection);
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

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            groupBox1.Enabled = true;
            try
            {
            connection.Open();
            command = new MySqlCommand("Insert into client VALUES (NULL, @first_Name, @name, @patr,@gender,@phone,@email)", connection);

            command.Parameters.AddWithValue("@first_Name", SurName.Text);
            command.Parameters.AddWithValue("@name", textName.Text);
            command.Parameters.AddWithValue("@patr", textS.Text);
            command.Parameters.AddWithValue("@gender", textBoxGender.Text);
            command.Parameters.AddWithValue("@phone", textPhone.Text);
            command.Parameters.AddWithValue("@email", textEmail.Text);
            
            
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadData()
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Select * from client", connection);
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

       
        private void cancel()
        {
           
            groupBox1.Enabled = false;
            
            textclientcode.Clear();
            SurName.Clear();
            textName.Clear();
            textS.Clear();
            textEmail.Clear();
            textBoxGender.Clear();
            textPhone.Clear();
           
        }

      

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textclientcode.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SurName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxGender.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
            groupBox1.Enabled = true;
           
        }

        private void search_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            command = new MySqlCommand("Select * from Client where Client_Code=@code_Client", connection);
            command.Parameters.AddWithValue("@code_Client", textclientcode.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("INSERT INTO `client` (`Surname`, `First_Name`, `Patronymic`,`Phone_Number`,`Gender`, `Email` ) VALUES( @client_surname, @client_first_name, @client_patronymic,@client_phone,@gender, @client_email )", db.getConnection());

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data successfully saved");
                cancel();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            cancel();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Delete from Client where Client_Code= '" + textclientcode + "' ", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data successfully deleted");
                cancel();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Update Client set Surname ='" + SurName.Text + "',First_Name='" + textName.Text + "', Patronymic='" + textS.Text + "',Phone_Number='" + textPhone.Text + "',Gender='" + textBoxGender.Text+"',Email='" + textEmail.Text  + "' where Product_Code= '" + textclientcode.Text + "' ", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data successfully update");
                cancel();
                LoadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            groupBox1.Enabled = true;
            btnDelete.Enabled = false;
         
        }

        private void SurName_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textS_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

            private void textBoxGender_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^0-9]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^0-9-A-Za-z-@]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textclientcode_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^0-9]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textclientcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = false;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = true;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = false;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = false;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;

        }

        private void SurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;

        }
    }
    
}

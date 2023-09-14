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
    public partial class CrudProduct : Form
    {
        public CrudProduct()
        {
            InitializeComponent();
        }
        DB db = new DB();
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            groupBox1.Enabled = true;
            try
            {
                connection.Open();
                command = new MySqlCommand("Insert into product VALUES (NULL, @manufact, @category, @name,@availability)", connection);
              
                command.Parameters.AddWithValue("@manufact", textBoxManufacturer.Text);
                command.Parameters.AddWithValue("@category", textCategory.Text);
                command.Parameters.AddWithValue("@name", textName.Text);
                command.Parameters.AddWithValue("@availability", textAvailability.Text);
               


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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Insert into product(`Product_code`, `Manufacturer`, `Name`, `Category`,`Availability`) VALUES( '" + textIdProduct.Text + "','" + textBoxManufacturer.Text + "','" + textName.Text + "', '" + textCategory.Text + "', '" + textAvailability.Text + "')", connection);
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
        private void cancel()
        {
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            groupBox1.Enabled = false;

            textIdProduct.Clear();
            textName.Clear();
            textAvailability.Clear();
            textCategory.Clear();
           
            textBoxManufacturer.Clear();
           

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            groupBox1.Enabled = true;
            btnDelete.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Update product set Manufacturer='" + textBoxManufacturer.Text + "',Name='" + textName.Text + "', Category='" + textCategory.Text + "',Availability='" + textAvailability.Text + "' where Product_Code= '" + textIdProduct.Text + "' ", connection);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Delete from product where Product_code= '" + textIdProduct.Text + "' ", connection);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void search_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            command = new MySqlCommand("Select * from product where Product_code =@code_Pr", connection);
            command.Parameters.AddWithValue("@code_Pr", textIdProduct.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textIdProduct.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBoxManufacturer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textAvailability.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textCategory.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            
           
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }

        private void textIdProduct_KeyPress(object sender, KeyPressEventArgs e)
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

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBoxManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textCategory_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textAvailability_KeyPress(object sender, KeyPressEventArgs e)
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

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textIdProduct_TextChanged(object sender, EventArgs e)
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

        private void textBoxManufacturer_TextChanged(object sender, EventArgs e)
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

        private void textCategory_TextChanged(object sender, EventArgs e)
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

        private void textAvailability_TextChanged(object sender, EventArgs e)
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
    }
}

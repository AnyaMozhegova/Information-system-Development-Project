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
    public partial class GrudSeller : Form
    {
        DB db = new DB();
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;
        public GrudSeller()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Select * from seller", connection);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand("Insert into seller VALUES (NULL, @first_Name, @name, @patr,@gender,@position, @phone,@cur,@salary,@prize)", connection);
                //command.Parameters.AddWithValue("@code_Client",textclientcode.Text);
                command.Parameters.AddWithValue("@first_Name", SurName.Text);
                command.Parameters.AddWithValue("@name", textName.Text);
                command.Parameters.AddWithValue("@patr", textS.Text);
                command.Parameters.AddWithValue("@gender", textGender.Text);
                command.Parameters.AddWithValue("@position", textIDPos.Text);
                command.Parameters.AddWithValue("@phone", textPhone.Text);
                command.Parameters.AddWithValue("@cur", textCur.Text);
                command.Parameters.AddWithValue("@salary", textSalary.Text);
                command.Parameters.AddWithValue("@prize", textPrize.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Update seller set Surname='" + SurName.Text + "',First_Name='" + textName.Text + "', Patronymic='" + textS.Text + "',@gender='" + textGender.Text + "',@position='" + textIDPos.Text + "', Phone='" + textPhone.Text + "', @cur='" + textCur.Text + "', @salary='" + textSalary.Text + "', @prize='" + textPrize.Text + "' where seller_Code= '" + textId.Text + "' ", connection);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Insert into seler(`seller_code`, `Surname`, `First_Name`, `Patronymic`,`Gender`, `Position`, `Phone`, `Cur`,`Salary`, `Prize`) VALUES( '" + textId.Text + "','" + SurName.Text + "', '" + textName.Text + "','" + textS.Text + "', '" + textGender.Text + "', '" + textIDPos.Text + "', '" + textPhone.Text + "', '"+ textCur.Text+"', '" + textSalary.Text+ "', '" + textPrize.Text+ "')", connection);
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

            textId.Clear();
            SurName.Clear();
            textName.Clear();
            textS.Clear();
            
            textGender.Clear();
            textPhone.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Close();
                connection.Open();
                command = new MySqlCommand("Delete from seller where Seller_Code= '" + textId.Text + "' ", connection);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = true;
            groupBox1.Enabled = true;
            btnDelete.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void search_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            command = new MySqlCommand("Select * from seller where Seller_Code=@code_Seller", connection);
            command.Parameters.AddWithValue("@code_Seller", textId.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SurName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textS.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textGender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textIDPos.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textPhone.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString(); 
            textCur.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textSalary.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textPrize.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void gradient1_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }

        private void SurName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textIDPos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textCur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textSalary_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = false;
            }

        }

        private void textPrize_KeyPress(object sender, KeyPressEventArgs e)
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
                e.Handled = false;
            }
        }

        private void textId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
             return;
            else
                e.Handled = true;
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

        private void textIDPos_TextChanged(object sender, EventArgs e)
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

        private void textCur_TextChanged(object sender, EventArgs e)
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

        private void textSalary_TextChanged(object sender, EventArgs e)
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

        private void textPrize_TextChanged(object sender, EventArgs e)
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

        private void textId_TextChanged(object sender, EventArgs e)
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

        private void textGender_TextChanged(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

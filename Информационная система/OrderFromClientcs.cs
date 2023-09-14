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
    public partial class OrderFromClientcs : Form
    {
        public OrderFromClientcs()
        {
            InitializeComponent();
        }
        DB db = new DB();
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root; password=root;database=shopzoo");
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;
        bool test;
        private void cash1_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я-A-Za-z]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void cash2_TextChanged(object sender, EventArgs e)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я-A-Za-z]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void sber1_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я-A-Za-z]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void sber2_TextChanged(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я-A-Za-z]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я-A-Za-z]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
            if (tb == null) return;
            var actual = tb.Text;
            var disallowed = @"[^А-Яа-я-A-Za-z]";
            var newText = Regex.Replace(actual, disallowed, string.Empty);
            if (string.CompareOrdinal(tb.Text, newText) != 0)
            {
                var sstart = tb.SelectionStart;
                tb.Text = newText;
                tb.SelectionStart = sstart - 1;
            }
        }

      

        private void cash1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void cash2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void sber1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void sber2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.Text == "1" & NameProduct1.Text == "" || textBox3.Text == "" || textBox1.Text == "")||(comboBox1.Text == "2" & NameProduct1.Text == "" || textBox3.Text == "" || textBox1.Text == "" || NameProduct2.Text == "" || textBox4.Text == "")||(comboBox1.Text == "3" & NameProduct1.Text == "" || textBox3.Text == "" || textBox1.Text == "" || NameProduct2.Text == "" || textBox4.Text == "" || NameProduct3.Text == "" || textBox5.Text == "")|| (comboBox1.Text == "Выбере сколько уникальных товаров у вас будет"))
                {
                    MessageBox.Show("Извините, но имя у товаров не может отсутствовать, так же важно знать Ваш номер телефона и количество необходимых товаров");
                }
                else
                {
                    test = true;
                }
               
              
                if (test == true)
                {
                    connection.Open();
                    command = new MySqlCommand("Insert into NewOrder VALUES (NULL, @name1, @man1, @count1,@name2, @man2, @count2,@name3, @man3, @count3,@number)", connection);

                    command.Parameters.AddWithValue("@name1", NameProduct1.Text);
                    command.Parameters.AddWithValue("@man1", cash2.Text);
                    command.Parameters.AddWithValue("@count1", textBox3.Text);
                    command.Parameters.AddWithValue("@name2", NameProduct2.Text);
                    command.Parameters.AddWithValue("@man2", sber2.Text);
                    command.Parameters.AddWithValue("@count2", textBox4.Text);
                    command.Parameters.AddWithValue("@name3", NameProduct3.Text);
                    command.Parameters.AddWithValue("@man3", textBox2.Text);
                    command.Parameters.AddWithValue("@count3", textBox5.Text);
                    command.Parameters.AddWithValue("@number", textBox1.Text);



                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Ваш заказ отправлен на обработку к нашему персоналу, в скором времени Вам позвонят для подтверждения заказа");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}

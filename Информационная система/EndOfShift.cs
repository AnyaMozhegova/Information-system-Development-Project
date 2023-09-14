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
    public partial class EndOfShift : Form
    {
        
        public EndOfShift()
        {
            InitializeComponent();
            cash1.Text = "0";
            cash2.Text = "0";
            total1.Text = "0";
            refund.Text = "0";
            sber1.Text = "0";
            sber2.Text = "0";
            totalSber.Text = "0";
            quantity.Text = "0";
           textBoxFiveThousand.Text = "0";
            textBoxOneThousand.Text = "0";
            textBoxFiveHundred.Text = "0";
            textBoxOneHundred.Text = "0";
            textBoxFifty.Text = "0";
            textBoxSmall.Text = "0";
            collection.Text = "0";


        }
        int aa1, ca1;
        int ba1;
        int b,a,c;
        int b1, a1, c1;
        int c2;
        int amount;
        int replacement, col;
        int banknote5000, banknote1000, banknote500, banknote100, banknote50,smallmoney;
        bool approval;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            banknote5000 = Convert.ToInt32(textBoxFiveThousand.Text);
            banknote1000 = Convert.ToInt32(textBoxOneThousand.Text);
            banknote500 = Convert.ToInt32(textBoxFiveHundred.Text);
            banknote100 = Convert.ToInt32(textBoxOneHundred.Text);
            banknote50 = Convert.ToInt32(textBoxFifty.Text);
            smallmoney = Convert.ToInt32(textBoxSmall.Text);
            c1 = Convert.ToInt32(collection.Text);
            b1 = Convert.ToInt32(totalSber.Text);
            a1 = Convert.ToInt32(total1.Text);
            replacement = Convert.ToInt32(refund.Text);
            aa1 = Convert.ToInt32(sber1.Text);
            ca1 = Convert.ToInt32(sber2.Text);
            ba1 = Convert.ToInt32(quantity.Text);
            a = Convert.ToInt32(cash1.Text);
            c = Convert.ToInt32(cash2.Text);
            if (banknote5000 == 0 || banknote1000 == 0 || banknote500 == 0 || banknote100 == 0 || banknote50 == 0 || smallmoney == 0 || c1 == 0 || b1 == 0 || a1 == 0 || aa1 == 0 || ca1 == 0 || ba1 == 0 || a == 0 || c == 0 || replacement == 0)
            {


                DialogResult dr= MessageBox.Show("Вы уверены, что точно ввели все данные верные? Имеются нулевые данные", "Закрытие смены", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    approval = true;
                }
                if (dr == DialogResult.No)
                {
                    approval = false;
                }
            }
                if (approval == true)
                    
            {



                try
                {

                    DB db = new DB();

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();



                    MySqlCommand command = new MySqlCommand("INSERT INTO `end_of_shift` ( `Shift_code`, `Cash_register1`, `Cash_register2`, `Total_cash`,`Sberbank1`, `Sberbank2`,`Total_map`,`Number_of_receipts`, `Collection`, `Refund_amount`,`Banknote5000`,`Banknote1000`, `Banknote500`,`Banknote100`,`Banknote50`,`SmallMoney`) VALUES(NULL, @cR1,@cR2, @tCash, @Sber1,@Sber2,  @tSb, @nOR, @cOl,@ref,@m1, @m2, @m3 ,@m4, @m5, @m6)", db.getConnection());

                    command.Parameters.Add("@cR1", MySqlDbType.VarChar).Value = cash1.Text;
                    command.Parameters.Add("@cR2", MySqlDbType.VarChar).Value = cash2.Text;
                    command.Parameters.Add("@tCash", MySqlDbType.VarChar).Value = total1.Text;
                    command.Parameters.Add("@@ref", MySqlDbType.VarChar).Value = refund.Text;
                    command.Parameters.Add("@cOl", MySqlDbType.VarChar).Value = collection.Text;
                    command.Parameters.Add("@Sber1", MySqlDbType.VarChar).Value = sber1.Text;
                    command.Parameters.Add("@Sber2", MySqlDbType.VarChar).Value = sber2.Text;
                    command.Parameters.Add("@tSb", MySqlDbType.VarChar).Value = totalSber.Text;
                    command.Parameters.Add("@nOR", MySqlDbType.VarChar).Value = quantity.Text;
                    command.Parameters.Add("@m1", MySqlDbType.VarChar).Value = textBoxFiveThousand.Text;
                    command.Parameters.Add("@m2", MySqlDbType.VarChar).Value = textBoxOneThousand.Text;
                    command.Parameters.Add("@m3", MySqlDbType.VarChar).Value = textBoxFiveHundred.Text;
                    command.Parameters.Add("@m4", MySqlDbType.VarChar).Value = textBoxOneHundred.Text;
                    command.Parameters.Add("@m5", MySqlDbType.VarChar).Value = textBoxFifty.Text;
                    command.Parameters.Add("@m6", MySqlDbType.VarChar).Value = textBoxSmall.Text;


                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Данные о смене успешно добавлены");
                    else
                        MessageBox.Show("Аккаунт не создан");

                    db.closeConnection();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void cash1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void cash2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void refund_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void collection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void sber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
        }

        private void sber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& e.KeyChar != '.'*/)
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
        }

        private void collection_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxFiveThousand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOneThousand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxFiveHundred_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxOneHundred_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cash1_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void cash2_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void refund_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void sber1_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void sber2_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void quantity_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxFiveThousand_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxOneThousand_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxFiveHundred_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxOneHundred_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxFifty_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxSmall_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void cash1_TextChanged(object sender, EventArgs e)
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

        private void refund_TextChanged(object sender, EventArgs e)
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

        private void sber1_TextChanged(object sender, EventArgs e)
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

        private void quantity_TextChanged(object sender, EventArgs e)
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

        private void textBoxFiveThousand_TextChanged(object sender, EventArgs e)
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

        private void textBoxOneThousand_TextChanged(object sender, EventArgs e)
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

        private void textBoxFiveHundred_TextChanged(object sender, EventArgs e)
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

        private void textBoxOneHundred_TextChanged(object sender, EventArgs e)
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

        private void textBoxFifty_TextChanged(object sender, EventArgs e)
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

        private void textBoxSmall_TextChanged(object sender, EventArgs e)
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

        private void buttonAdd_Validated(object sender, EventArgs e)
        {
        }

       
        

        private void textBoxFifty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void collection_Validated(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Безналичными")
            {
                
                c1 = Convert.ToInt32(collection.Text);
                b1 = Convert.ToInt32(totalSber.Text);
                a1 = Convert.ToInt32(total1.Text);
                replacement = Convert.ToInt32(refund.Text);
                
                col = b1 - a1- replacement;
                if (col == c1)
                {


                    check();

                }
                else
                {
                    MessageBox.Show("Ошибка, проверьте данные о возврате, инкасации или итоги продаж");
                }
            }
            if (comboBox1.Text == "Наличными")
            {
                c1 = Convert.ToInt32(collection.Text);
                b1 = Convert.ToInt32(totalSber.Text);
                a1 = Convert.ToInt32(total1.Text);
                replacement = Convert.ToInt32(refund.Text);
             
                col = b1 - a1 - replacement;
                if (col == c1)
                {
                    check();
                }
                else
                {
                    MessageBox.Show("Ошибка, проверьте данные о возврате, инкасации или итоги продаж");
                }
            }
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }

        }

        private void total1_Validated(object sender, EventArgs e)
        {
            b = Convert.ToInt32(total1.Text);
            a = Convert.ToInt32(cash1.Text);
            c = Convert.ToInt32(cash2.Text);
            if (b == a + c)
            {

            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void totalSber_Validated(object sender, EventArgs e)
        {
            b1 = Convert.ToInt32(totalSber.Text);
            a1 = Convert.ToInt32(sber1.Text);
            c1 = Convert.ToInt32(sber2.Text);
            if (b1 == a1 + c1)
            {

            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void textBoxSmall_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void totalSber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void totalSber_TextChanged(object sender, EventArgs e)
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

        private void quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void total1_TextChanged(object sender, EventArgs e)
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
        private void check()
        {
      
            banknote5000 = Convert.ToInt32(textBoxFiveThousand.Text);
            banknote1000 = Convert.ToInt32(textBoxOneThousand.Text);
            banknote500 = Convert.ToInt32(textBoxFiveHundred.Text); 
            banknote100 = Convert.ToInt32(textBoxOneHundred.Text);
            banknote50 = Convert.ToInt32(textBoxFifty.Text); 
            smallmoney = Convert.ToInt32(textBoxSmall.Text);
            c2 = Convert.ToInt32(collection.Text);
            amount = banknote5000*5000 + banknote1000*1000 + banknote500*500 + banknote100*100 + banknote50*50 + smallmoney;
            if (c2== amount)
            {

            }
            else
            {
                MessageBox.Show(" Ошибка");
            }
        }
    }
}

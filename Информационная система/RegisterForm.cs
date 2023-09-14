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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            



            this.ClientEmail.AutoSize = false;

            this.ClientEmail.Size = new Size(this.ClientEmail.Size.Width, 52);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      Point lastPoint;
        bool test;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

       


      

        private void buttonRegister_Click(object sender, EventArgs e)

        {
            if (ClientFirstName.Text == "" || ClientPatronymic.Text == "" || ClientName.Text == "" || ClientEmail.Text == "" || ClientAdress.Text == "" || ClientPhone.Text == "" || ClientLogin.Text == "" || ClientPassport.Text == "" || ClientPassword.Text == "")
            {
                MessageBox.Show("Ни одно поле не может быть пустым");
            }
            else
            {



                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO `client` (`Surname`, `First_Name`, `Patronymic`, `Email`, `Adress`, `Phone_Number` ) VALUES( @client_surname, @client_first_name, @client_patronymic, @client_email, @client_adress, @client_phone)", db.getConnection());

                MySqlCommand command1 = new MySqlCommand("INSERT INTO `client_data` (`Login`, `Password`, `Passport`) VALUES(@client_login, @client_password,@client_passport)", db.getConnection());


                command.Parameters.Add("@client_surname", MySqlDbType.VarChar).Value = ClientFirstName.Text;
                command.Parameters.Add("@client_first_name", MySqlDbType.VarChar).Value = ClientName.Text;
                command.Parameters.Add("@client_patronymic", MySqlDbType.VarChar).Value = ClientPatronymic.Text;
                command.Parameters.Add("@client_email", MySqlDbType.VarChar).Value = ClientEmail.Text;
                command.Parameters.Add("@client_adress", MySqlDbType.VarChar).Value = ClientAdress.Text;
                command.Parameters.Add("@client_phone", MySqlDbType.VarChar).Value = ClientPhone.Text;
                command1.Parameters.Add("@client_login", MySqlDbType.VarChar).Value = ClientLogin.Text;
                command1.Parameters.Add("@client_password", MySqlDbType.VarChar).Value = ClientPassword.Text;
                command1.Parameters.Add("@client_passport", MySqlDbType.VarChar).Value = ClientPassport.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1 & command1.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт успешно создан");
                else
                    MessageBox.Show("Аккаунт не создан");

                db.closeConnection();
            }
     

        }
        public Boolean checkClient()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `client_data` WHERE `login`= @cL ", db.getConnection());

            command.Parameters.Add("@cL", MySqlDbType.VarChar).Value = ClientLogin.Text;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже зарегистрирован");
                return true;
            }
            else
               return false;
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm loginForm = new MainForm();
            loginForm.Show();

        }

        private void ClientFirstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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

        private void ClientName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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

        private void ClientPatronymic_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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

        private void ClientEmail_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
            {
                var tb = sender as TextBox;
                if (tb == null) return;
                var actual = tb.Text;
                var disallowed = @"[^0-9A-Za-z]";
                var newText = Regex.Replace(actual, disallowed, string.Empty);
                if (string.CompareOrdinal(tb.Text, newText) != 0)
                {
                    var sstart = tb.SelectionStart;
                    tb.Text = newText;
                    tb.SelectionStart = sstart - 1;
                }
            }
        }

        private void ClientAdress_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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

        private void ClientPhone_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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
        }

        private void ClientLogin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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
        }

        private void ClientPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
            {
                var tb = sender as TextBox;
                if (tb == null) return;
                var actual = tb.Text;
                var disallowed = @"[^0-9A-Za-z]";
                var newText = Regex.Replace(actual, disallowed, string.Empty);
                if (string.CompareOrdinal(tb.Text, newText) != 0)
                {
                    var sstart = tb.SelectionStart;
                    tb.Text = newText;
                    tb.SelectionStart = sstart - 1;
                }
            }
        }

        private void ClientPassport_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClientFirstName.Text))
            {
                test = false;

            }
            else
            {
                test = true;
            }
            if (test == true)
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
        }

        private void ClientFirstName_Validated(object sender, EventArgs e)
        {
        }

        private void ClientName_Validated(object sender, EventArgs e)
        {
        }

        private void ClientPatronymic_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientEmail_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientAdress_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientPhone_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientLogin_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientPassword_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientPassport_Validated(object sender, EventArgs e)
        {
            
        }

        private void ClientFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void ClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void ClientPatronymic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void ClientEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z') 
            //{
            //    e.Handled = false;
            //}

            //else if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            //{
            //    e.Handled = false;

            //    e.Handled = true;
            //}

            

            
          

            //if (Char.IsDigit(e.KeyChar)) return;
            //else
            //    e.Handled = true;
        }

        private void ClientAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            //{

            //    e.Handled = true;
            //}

            //else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            //{
            //    e.Handled = false;
            //}

            

            

            //if (Char.IsDigit(e.KeyChar)) return;
            //else
            //    e.Handled = true;
        }

        private void ClientPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = false;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }

            

            
        }

        private void ClientLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = false;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }

            

            
        }

        private void ClientPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = false;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }

          

           
        }

        private void ClientPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'А' && e.KeyChar <= 'Я' || e.KeyChar >= 'а' && e.KeyChar <= 'я')
            {
                e.Handled = false;
            }

            else if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }

            

           
            
        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Password.AutoSize = false;

            this.Password.Size = new Size(this.Password.Size.Width, 64);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.DarkGreen;
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string loginClient = Logins.Text;
            string passwordClient = Password.Text;
            try
            {

                DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `client_data` WHERE `login`= @cL AND `password`=@cP",db.getConnection());

            command.Parameters.Add("@cL", MySqlDbType.VarChar).Value = loginClient;
            command.Parameters.Add("@cP", MySqlDbType.VarChar).Value = passwordClient;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {   MessageBox.Show("Вы авторизованы");
                this.Hide();
                MenuClientcs mainForm = new MenuClientcs ();
                mainForm.Show();


            }
                

            else
                {
                    DB db1 = new DB();

                    DataTable table1 = new DataTable();

                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM `seller_data` WHERE `login`= @cL AND `password`=@cP", db.getConnection());

                    command1.Parameters.Add("@cL", MySqlDbType.VarChar).Value = loginClient;
                    command1.Parameters.Add("@cP", MySqlDbType.VarChar).Value = passwordClient;

                    adapter1.SelectCommand = command1;
                    adapter1.Fill(table1);

                    if (table1.Rows.Count > 0)
                    {
                        MessageBox.Show("Вы авторизованы");
                        this.Hide();
                        MenuSeller mainForm1 = new MenuSeller();
                        mainForm1.Show();


                    }
                    else
                    {
                        DB db2 = new DB();

                        DataTable table2 = new DataTable();

                        MySqlDataAdapter adapter2 = new MySqlDataAdapter();

                        MySqlCommand command2 = new MySqlCommand("SELECT * FROM `manager_data` WHERE `login`= @cL AND `password`=@cP", db.getConnection());

                        command2.Parameters.Add("@cL", MySqlDbType.VarChar).Value = loginClient;
                        command2.Parameters.Add("@cP", MySqlDbType.VarChar).Value = passwordClient;

                        adapter2.SelectCommand = command2;
                        adapter2.Fill(table2);

                        if (table2.Rows.Count > 0)
                        {
                            MessageBox.Show("Вы авторизованы");
                            this.Hide();
                            Menu mainForm2 = new Menu();
                            mainForm2.Show();


                        }
                    }
                }

            
            }
            catch 
            {
                MessageBox.Show("Неудалось подключиться");
            }




        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calen c= new Calen();
            c.Show();
        }

        private void Logins_TextChanged(object sender, EventArgs e)
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

        private void Password_TextChanged(object sender, EventArgs e)
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
}

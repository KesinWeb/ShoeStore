using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ShoeStore.Properties;

namespace ShoeStore
{
    public partial class AutForm : Form
    {
        public AutForm()
        {
            InitializeComponent();
        }
        public void UserAut()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = @"SELECT user_role.""role"", fio, login, password
	                                FROM public.users
	                                JOIN user_role ON user_role.id = users.role_fk
	                                WHERE login = @login AND password = @password";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("login", textBoxLogin.Text);
                    command.Parameters.AddWithValue("password", textBoxPassword.Text);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            { // Успешная авторизация
                                MessageBox.Show("Авторизация успешна!", "Информация", MessageBoxButtons.OK);
                                this.Hide();
                                MainForm mainForm = new MainForm(reader.GetString(0), reader.GetString(1));
                                mainForm.Show();
                            }
                            else 
                            {
                                // Ошибка авторизации
                                MessageBox.Show("Неверный логин или пароль, Либо вы не заполнили поля");
                                return;
                            }
                        }    
                    }
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            UserAut();
            if (textBoxLogin.Text == "") 
            { 
                MessageBox.Show("Неверный логин или пароль, Либо вы не заполнили поля");
                return;
            }
            if (textBoxPassword.Text == "") 
            { 
                MessageBox.Show("Неверный логин или пароль, Либо вы не заполнили поля");
                return;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm("Гость","");
            mainForm.Show();
        }
    }
}

using Npgsql;
using ShoeStore.Controls;
using ShoeStore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class ZakazControl : UserControl
    {
        public int NomerZakaz { get; set; }
        public string Article { get; set; }
        public string Status { get; set; }
        public string Adress { get; set; }
        public string DataZakaza { get; set; }
        public string DataDostavki { get; set; }
        public string RoleName { get; set; }
        public ZakazControl(string RoleName, int NomerZakaz)
        {
            InitializeComponent();
            this.NomerZakaz = NomerZakaz;
            this.RoleName = RoleName;
            if (RoleName != "Администратор")
            {
                buttonRedactZakaz.Visible = false;
                buttonDeleteZakaz.Visible = false;
            }
            if (RoleName == "Менеджер")
            {
                buttonRedactZakaz.Visible = true;
                buttonRedactZakaz.Text = "Просмотр заказа";
            }
        }
        public void SetLabelsZakaz()
        {
            labelArticle.Text = Article;
            labelStatus.Text = Status.ToString();
            if (Status == "Статус: " + "Завершен")
            {
                labelStatus.ForeColor = Color.Green;
            }
            else 
            {
                labelStatus.ForeColor = Color.Purple;
            }
            labelAdress.Text = Adress;
            labelDataZakaza.Text = DataZakaza;
            labelDataDostavki.Text = DataDostavki;
        }

        private void buttonDeleteZakaz_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"DELETE FROM public.zakaz WHERE nomer_zakaza_pk = '{NomerZakaz}'; ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    {
                        connection.Close();
                    }
                    this.Parent.Controls.Remove(this);
                    MessageBox.Show("Товар успешно удален из базы данных.", "Удаление товара", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonRedactZakaz_Click(object sender, EventArgs e)
        {

            if (RoleName == "Менеджер") 
            { 
                using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
                {
                    connection.Open();
                    string query = $@"SELECT nomer_zakaza_pk, stasus_zakaz.stasus, adres.adress_punct, data_zakaza, data_dostavki
                                     FROM public.zakaz
                                     JOIN stasus_zakaz ON stasus_zakaz.id = zakaz.status_zakaza_fk
                                     JOIN adres ON adres.id = zakaz.adress_fk
                                     WHERE nomer_zakaza_pk = '{NomerZakaz}';";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string status = reader.GetString(1);
                                string adres = reader.GetString(2);
                                DateTime dataZakaza = reader.GetDateTime(3);
                                DateTime dataDostavki = reader.GetDateTime(4);
                                MessageBox.Show(
                                    $"Номер заказа: {NomerZakaz}\n" +
                                    $"Статус: {status}\n" +
                                    $"Адрес доставки: {adres}\n" +
                                    $"Дата заказа: {dataZakaza.ToShortDateString()}\n" +
                                    $"Дата доставки: {dataDostavki.ToShortDateString()}",
                                    "Информация о заказе", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                    connection.Close();
                }
                return;
            }
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadRedactZakaz(NomerZakaz);
        }
    }
}

using Npgsql;
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
        public ZakazControl(string RoleName, int NomerZakaz)
        {
            InitializeComponent();
            this.NomerZakaz = NomerZakaz;
            if (RoleName != "Администратор")
            {
                buttonRedactZakaz.Visible = false;
                buttonDeleteZakaz.Visible = false;
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
    }
}

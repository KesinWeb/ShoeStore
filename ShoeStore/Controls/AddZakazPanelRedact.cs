using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using ShoeStore.Properties;

namespace ShoeStore.Controls
{
    public partial class AddZakazPanelRedact : UserControl
    {
        public string FioClient {  get; set; }
        public int QuantityAdd {  get; set; }
        public string ListBoxAdd { get; set; }
        public string ArticleId { get; set; }
        public string Stasus { get; set; }
        public string Adress { get; set; }
        public DateTime Zakaz {  get; set; }
        public DateTime Vidacha { get; set; }
        public AddZakazPanelRedact()
        {
            InitializeComponent();
        }
        public void SetZakazControl()
        {
            comboBoxAdress.Text = Adress;
            comboBoxArticle.Text = ArticleId;
            comboBoxStatus.Text = Stasus;
            dateTimePickerZakaz.Value = Zakaz;
            dateTimePickerVidacha.Value = Vidacha;
            listBoxAdd.Text = ListBoxAdd;
            numericUpDownAddQuantity.Value = QuantityAdd;
            comboBoxClient.Text = FioClient;
        }
        public void InsertZakaz()
        {
            int zakazId = 0;
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = @"INSERT INTO public.zakaz(
	                            data_zakaza, data_dostavki, adress_fk, fio_client_fk, status_zakaza_fk)
	                            VALUES ( 
                                @data_zakaza, 
                                @data_dostavki, 
                                @adress_punct, 
                                @fio,  
                                @stasus ) returning nomer_zakaza_pk; ";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@data_zakaza", dateTimePickerZakaz.Value);
                    command.Parameters.AddWithValue("@data_dostavki", dateTimePickerVidacha.Value);
                    command.Parameters.AddWithValue("@adress_punct", comboBoxAdress.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@fio", comboBoxClient.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@stasus", comboBoxStatus.SelectedIndex + 1);
                    zakazId = Convert.ToInt32(command.ExecuteScalar());
                }
                connection.Close();
                connection.Open();
                string query1 = @"INSERT INTO public.zakaz_tovar(
	                            id_zakaz_fk, article_fk, quantity)
	                            VALUES ((SELECT nomer_zakaza_pk 
                                FROM zakaz WHERE nomer_zakaza_pk = @nomer_zakaza_pk), 
                                @id_article, 
                                @quantity); ";
                using (NpgsqlCommand command1 = new NpgsqlCommand(query1, connection))
                {
                    foreach (var item in listBoxAdd.Items) 
                    {
                        command1.Parameters.AddWithValue("@id_article", item.ToString().Split(' ')[0]);
                        command1.Parameters.AddWithValue("@quantity", Convert.ToInt32(item.ToString().Split(' ')[1]));
                        command1.Parameters.AddWithValue("@nomer_zakaza_pk", zakazId);
                        command1.ExecuteNonQuery();
                    }    
                }
                connection.Close();
            }
        }
        private void buttonAddTovar_Click(object sender, EventArgs e)
        {
            if (comboBoxArticle.Text != null & numericUpDownAddQuantity.Value > 0)
            {
                listBoxAdd.Items.Add(comboBoxArticle.Text + " " + numericUpDownAddQuantity.Value.ToString());
            }
        }
        private void buttonZakazAddRedact_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxAdress.Text))
            {
                Adress = comboBoxAdress.Text;
            }
            else 
            {
                MessageBox.Show("Введите адрес!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(comboBoxClient.Text))
            {
                FioClient = comboBoxClient.Text;
            }
            else
            {
                MessageBox.Show("Выберите клиента!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InsertZakaz();
            MessageBox.Show("Успешно Добавлен Заказ", "Несосал");
        }
    }
}

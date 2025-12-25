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
        public Boolean IsRedact { get; set; }
        public string NameZakazIsEdit { get; set; }
        public string FioClient {  get; set; }
        public int QuantityAdd {  get; set; }
        public string ListBoxAdd { get; set; }
        public string ArticleId { get; set; }
        public string Stasus { get; set; }
        public string Adress { get; set; }
        public DateTime Zakaz {  get; set; }
        public DateTime Vidacha { get; set; }
        public int NomerZakaz { get; set; }
        public AddZakazPanelRedact(Boolean isRedact)
        {
            InitializeComponent();
            IsRedact = isRedact;
            if (isRedact)
            {
                labelDovalenieZakazRedact.Text = "Редактирование Заказа";
                buttonZakazAddRedact.Text = "Сохранить";
            }
            else
            {
                labelDovalenieZakazRedact.Text = "Добавление Заказа";
                buttonZakazAddRedact.Text = "Добавить";
            }
        }
        public void SetZakazControl()
        {
            comboBoxAdress.Text = Adress;
            comboBoxArticle.Text = ArticleId;
            comboBoxStatus.Text = Stasus;
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
        public void UpdateZakaz()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"UPDATE public.zakaz
                                SET data_zakaza = @data_zakaza,
                                    data_dostavki = @data_dostavki,
                                    adress_fk = @adress_fk,
                                    fio_client_fk = @fio_client_fk,
                                    status_zakaza_fk = @status_zakaza_fk
                                WHERE nomer_zakaza_pk = @nomer_zakaza_pk; ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@data_zakaza", dateTimePickerZakaz.Value);
                    command.Parameters.AddWithValue("@data_dostavki", dateTimePickerVidacha.Value);
                    command.Parameters.AddWithValue("@adress_fk", comboBoxAdress.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@fio_client_fk", comboBoxClient.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@status_zakaza_fk", comboBoxStatus.SelectedIndex + 1);
                    command.Parameters.AddWithValue("@nomer_zakaza_pk", Convert.ToInt32(NomerZakaz));
                    command.ExecuteNonQuery();
                }
                connection.Close();
                
                int rowCount = SelectIdZakazTovar().Count;
                if (rowCount < listBoxAdd.Items.Count)
                {
                    connection.Open();
                    for (int i = rowCount; i < listBoxAdd.Items.Count; i++)
                    {
                        string queryInsert = $@"INSERT INTO public.zakaz_tovar(
                                            id_zakaz_fk, article_fk, quantity)
                                            VALUES ({Convert.ToInt32(NomerZakaz)},'{listBoxAdd.Items[i].ToString().Split(' ')[0]}',{Convert.ToInt32(listBoxAdd.Items[i].ToString().Split(' ')[1])});";
                        using (NpgsqlCommand commandInsert = new NpgsqlCommand(queryInsert, connection))
                        {
                            commandInsert.ExecuteNonQuery();
                        }
                    }          
                    connection.Close();
                }
            }
        }
        public List<int> SelectIdZakazTovar()
        {
            List<int> list = new List<int>();
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT id
                                FROM public.zakaz_tovar
                                WHERE id_zakaz_fk = @id_zakaz_fk; ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_zakaz_fk", Convert.ToInt32(NomerZakaz));
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(Convert.ToInt32(ArticleId));
                        }
                    }
                }
                connection.Close();
            }
            return list;
        }
        public void SelectZakaz()     
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT 
                                data_zakaza, 
                                data_dostavki, 
                                adress_fk, 
                                fio_client_fk, 
                                status_zakaza_fk
                                FROM public.zakaz
                                WHERE nomer_zakaza_pk = @nomer_zakaza_pk; ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomer_zakaza_pk", Convert.ToInt32(NomerZakaz));
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dateTimePickerZakaz.Value = reader.GetDateTime(0);
                            dateTimePickerVidacha.Value = reader.GetDateTime(1);
                            comboBoxAdress.SelectedIndex = reader.GetInt32(2) - 1;
                            comboBoxClient.SelectedIndex = reader.GetInt32(3) - 1;
                            comboBoxStatus.SelectedIndex = reader.GetInt32(4) - 1;      
                        }  
                    }
                }
                connection.Close();
                connection.Open();
                string query1 = $@"SELECT 
                                article_fk, 
                                quantity
                                FROM public.zakaz_tovar
                                WHERE id_zakaz_fk = @id_zakaz_fk; ";
                using (NpgsqlCommand command1 = new NpgsqlCommand(query1, connection))
                {                     
                    command1.Parameters.AddWithValue("@id_zakaz_fk", Convert.ToInt32(NomerZakaz));
                    using (NpgsqlDataReader reader = command1.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listBoxAdd.Items.Add(reader.GetString(0) + " " + reader.GetInt32(1).ToString());
                        }
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
            if (!string.IsNullOrEmpty(comboBoxStatus.Text))
            {
                Stasus = comboBoxStatus.Text;
            }
            else
            {
                MessageBox.Show("Выберите статус!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsRedact)
            {
                UpdateZakaz();
                MessageBox.Show("Успешно Отредактирован Заказ", "Несосал");
                return;
            }
            InsertZakaz();
            MessageBox.Show("Успешно Добавлен Заказ", "Несосал");
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadZakaz();
        }

        private void buttonZakazBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadZakaz();
        }
    }
}

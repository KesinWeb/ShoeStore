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
        using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
        {
            connection.Open();
            string query = $@"SELECT zakaz.nomer_zakaza_pk, stasus_zakaz.stasus, adres.adress_punct, 
                                     zakaz.data_zakaza, zakaz.data_dostavki, name_tovar.name_tovar, 
                                     proizvoditel.name_proizv, category_tovar.category, zakaz_tovar.quantity
                              FROM public.zakaz_tovar
                              JOIN public.tovar ON tovar.id_article = zakaz_tovar.article_fk
                              JOIN public.name_tovar ON name_tovar.id = tovar.name_tovar_fk
                              JOIN public.proizvoditel ON proizvoditel.id_pk_proiz = tovar.proizvoditel_fk
                              JOIN public.category_tovar ON category_tovar.id_pk_category_tovar = tovar.category_name_fk
                              JOIN public.zakaz ON zakaz.nomer_zakaza_pk = zakaz_tovar.id_zakaz_fk
                              JOIN public.stasus_zakaz ON stasus_zakaz.id = zakaz.status_zakaza_fk
                              JOIN public.adres ON adres.id = zakaz.adress_fk
                              WHERE nomer_zakaza_pk = '{NomerZakaz}';";
    
            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    StringBuilder messageBuilder = new StringBuilder();
                    bool isFirstRow = true;
            
                    while (reader.Read())
                    {
                        if (isFirstRow)
                        {
                            // Данные о заказе берем только из первой строки
                            string status = reader.GetString(1);
                            string adres = reader.GetString(2);
                            DateTime dataZakaza = reader.GetDateTime(3);
                            DateTime dataDostavki = reader.GetDateTime(4);
                    
                            messageBuilder.AppendLine($"Номер заказа: {NomerZakaz}");
                            messageBuilder.AppendLine($"Статус: {status}");
                            messageBuilder.AppendLine($"Адрес доставки: {adres}");
                            messageBuilder.AppendLine($"Дата заказа: {dataZakaza.ToShortDateString()}");
                            messageBuilder.AppendLine($"Дата доставки: {dataDostavki.ToShortDateString()}");
                            messageBuilder.AppendLine();
                            messageBuilder.AppendLine("Товары в заказе:");
                            messageBuilder.AppendLine("----------------------------------------");
                    
                            isFirstRow = false;
                        }
                
                        // Данные о товаре из каждой строки
                        string nameTovar = reader.GetString(5);
                        string proizvoditel = reader.GetString(6);
                        string category = reader.GetString(7);
                        int quantity = reader.GetInt32(8);
                
                        // Добавляем информацию о товаре
                        messageBuilder.AppendLine($"• {nameTovar}");
                        messageBuilder.AppendLine($"  Производитель: {proizvoditel}");
                        messageBuilder.AppendLine($"  Категория: {category}");
                        messageBuilder.AppendLine($"  Количество: {quantity} шт.");
                        //messageBuilder.AppendLine();
                    }
            
                    if (messageBuilder.Length > 0)
                    {
                        MessageBox.Show(
                            messageBuilder.ToString(),
                            "Информация о заказе", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show("Заказ не найден", "Ошибка", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        connection.Close();
        return;
        }
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadRedactZakaz(NomerZakaz);
        }
    }
}

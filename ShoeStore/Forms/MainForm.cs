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
using Npgsql;
using Npgsql.Internal;
using ShoeStore.Controls;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace ShoeStore
{
    public partial class MainForm : Form
    {
        public string Fio {  get; set; }
        public string Filter { get; set; }
        public string FilterPostavshik { get; set; }
        public string Search { get; set; }
        public string RoleName { get; set; }
        public MainForm(string RoleName, string fio)
        {
            InitializeComponent();
            //реализация логики проверки по ролям
            this.RoleName = RoleName;
            labelRoleName.Text = RoleName;
            if (RoleName == "Гость" || RoleName == "Авторизированный клиент")
            {
                buttonTovar.Visible = false;
                buttonAddTovar.Visible = false;
                buttonZakaz.Visible = false;
                buttonAddZakaz.Visible = false;
            }
            if (RoleName == "Менеджер")
            {
                buttonAddTovar.Visible = false;
                buttonAddZakaz.Visible = false;
            }
            FilterPostavshik = "Все поставщики";
            Search = "";
            Filter = "";
            this.Fio = fio;
            labelFio.Text = fio;
            LoadTovar(Filter, Search, FilterPostavshik);           
        }
        public void LoadTovar(string orderBy, string searchSrt, string postavchik)
        {
            flowLayoutPanel1.Controls.Clear(); // Очистка текущих элементов перед загрузкой новых
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT name_tovar.name_tovar, edin_izmer, sale, postavchik.postavchik_name, proizvoditel.name_proizv, category_tovar.category, dicsount, quantity, opisanie, picture, id_article,
                                ROUND(sale * (100 - dicsount) / 100,2) AS final_price
                                FROM public.tovar
                                JOIN name_tovar ON name_tovar.id = tovar.name_tovar_fk
                                JOIN postavchik ON postavchik.id = tovar.postavchik_fk
                                JOIN proizvoditel ON proizvoditel.id_pk_proiz = tovar.proizvoditel_fk
                                JOIN category_tovar ON category_tovar.id_pk_category_tovar = tovar.category_name_fk 
                                {(searchSrt != "" ? $"WHERE name_tovar.name_tovar ILIKE '%{searchSrt}%' " +   //реализация поиска через запросник        
                                $"OR proizvoditel.name_proizv ILIKE '%{searchSrt}%' " +
                                $"OR category_tovar.category ILIKE '%{searchSrt}%'" +
                                $"OR opisanie ILIKE '%{searchSrt}%'" : " ")} 
                                {(postavchik != "Все поставщики" ? $"WHERE postavchik.postavchik_name = '{postavchik}' " : " ")} 
                                ORDER BY tovar.sale {orderBy} ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        flowLayoutPanel1.SuspendLayout();
                        while (reader.Read())
                        {
                            PanelControl panelControl = new PanelControl(RoleName);
                            panelControl.NameTovar = "Наименование: " + reader.GetString(0);
                            panelControl.EdinicIzm = "Единица измерения: " + reader.GetString(1);
                            panelControl.Count = reader.GetDouble(2).ToString() + " руб.";
                            panelControl.Postavchik = "Поставщик: " + reader.GetString(3);
                            panelControl.Proizvoditel = "Производитель: " + reader.GetString(4);
                            panelControl.Category = "Категория: " + reader.GetString(5);
                            panelControl.Discount = reader.GetInt32(6);
                            panelControl.Quantity = "Количество на складе: " + reader.GetInt32(7).ToString();
                            panelControl.Opisanie = "Описание: " + reader.GetString(8);
                            panelControl.Picture = reader.IsDBNull(9) ? "picture.png" : reader.GetString(9);
                            panelControl.DiscountCount = reader.GetDouble(11).ToString() + " руб.";
                            panelControl.IdArticle = reader.GetString(10);
                            panelControl.SetLabels();
                            flowLayoutPanel1.Controls.Add(panelControl);
                        }
                        flowLayoutPanel1.ResumeLayout(false);
                        flowLayoutPanel1.PerformLayout();
                    }
                }
                connection.Close();
            }
        }
        public void LoadZakaz()
        {
            flowLayoutPanel1.Controls.Clear(); // Очистка текущих элементов перед загрузкой новых
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = @"SELECT zakaz.nomer_zakaza_pk, data_zakaza, data_dostavki, adres.adress_punct, stasus_zakaz.stasus
	                            FROM public.zakaz
	                            JOIN public.adres ON adres.id = zakaz.adress_fk
	                            JOIN public.stasus_zakaz ON stasus_zakaz.id = zakaz.status_zakaza_fk";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        flowLayoutPanel1.SuspendLayout();
                        while (reader.Read())
                        {
                            ZakazControl zakazControl = new ZakazControl(RoleName, reader.GetInt32(0));
                            zakazControl.Article = "Артикул Заказа: " + reader.GetInt32(0).ToString();
                            zakazControl.DataZakaza = "Дата заказа: " + reader.GetDateTime(1).ToString("dd.MM.yyyy");
                            zakazControl.DataDostavki = "Дата доставки: " + reader.GetDateTime(2).ToString("dd.MM.yyyy");
                            zakazControl.Adress = "Адрес доставки: " + reader.GetString(3);
                            zakazControl.Status = "Статус: " + reader.GetString(4);
                            zakazControl.SetLabelsZakaz();
                            flowLayoutPanel1.Controls.Add(zakazControl);
                        }
                        flowLayoutPanel1.ResumeLayout(false);
                        flowLayoutPanel1.PerformLayout();
                    }
                }
                connection.Close();
            }
        }
        public void LoadRedact(string ArticleTovar)
        {
            flowLayoutPanel1.Controls.Clear(); // Очистка текущих элементов перед загрузкой новых
            AddPanelRedact redactPanel = new AddPanelRedact(true);
            redactPanel.ArticleTovar = ArticleTovar;
            redactPanel.setAddcontrols();
            redactPanel.LoadTovarData();
            this.flowLayoutPanel1.Controls.Add(redactPanel);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            string imageFolder = Path.Combine(Application.StartupPath, "images");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void buttonZakaz_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            LoadZakaz();
        }
        public void buttonAddTovar_Click(object sender, EventArgs e)
        {
            AddPanelRedact addPanelRedact = new AddPanelRedact(false);
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.Controls.Add(addPanelRedact);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PanelControl panelControl = new PanelControl(RoleName);
            this.flowLayoutPanel1.Controls.Clear();
            LoadTovar("DESC", "", "Все поставщики");
        }
        //Фильтры, поиск
        private void textSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            Search = textSearchBox.Text;
            LoadTovar(Filter, Search, FilterPostavshik);
        }
        private void comboBoxPostavshik_SelectedIndexChanged(object sender, EventArgs e)
        {
               FilterPostavshik = comboBoxPostavshik.Text;
               LoadTovar(Filter, Search, FilterPostavshik);
        }
        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                Filter = "DESC";
                checkBoxAsc.Checked = false;
                LoadTovar(Filter, Search, FilterPostavshik);
            }
            else
            {
                Filter = "";
            }
        }
        private void checkBoxAsc_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                Filter = "ASC";
                checkBoxDesc.Checked = false;
                LoadTovar(Filter, Search, FilterPostavshik);
            }
            else
            {
                Filter = "";
            }
        }
        private void buttonAddZakaz_Click(object sender, EventArgs e)
        {
            AddZakazPanelRedact addZakazPanelRedact = new AddZakazPanelRedact();
            this.flowLayoutPanel1.Controls.Clear();
            this.flowLayoutPanel1.Controls.Add(addZakazPanelRedact);  
        }
    }  
}

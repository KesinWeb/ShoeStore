using Npgsql;
using ShoeStore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore.Controls
{
    public partial class AddPanelRedact : UserControl
    {
        public Boolean isEditMode = false;
        public string NameTovarToEdit { get; set; }
        public string Category { get; set; }
        public string NameTovar { get; set; }
        public string Opisanie { get; set; }
        public string Proizvoditel { get; set; }
        public string Postavchik { get; set; }
        public string Sale { get; set; }
        public string EdinicIzm { get; set; }   
        public string Quantity { get; set; }
        public int Discount { get; set; }
        public string ArticleTovar { get; set; }

        public AddPanelRedact(Boolean isEditMode)
        {
            InitializeComponent();
            comboBoxName.Text = NameTovar;
            maskedTextBoxQuantity.Text = Quantity;
            maskedTextBoxSale.Text = Sale;
            comboBoxCategory.Text = Category;
            textBoxProizvoditel.Text = Proizvoditel;
            comboBoxPostavshik.Text = Postavchik;
            maskedTextBoxDiscount.Text = Discount.ToString();
            maskedTextBoxArticle.Text = ArticleTovar;
            textBoxOpisanie.Text = Opisanie;
            labelIzm.Text = EdinicIzm;
            this.isEditMode = isEditMode;
            if (isEditMode)
            {
                this.labelDovalenieRedact.Text = "Редактирование товара";
                buttonAddRedact.Text = "Сохранить изменения";
            }
            else
            {
                this.labelDovalenieRedact.Text = "Добавление товара";
                buttonAddRedact.Text = "Добавить товар";
            }
        }
        public void setAddcontrols()
        {
            comboBoxName.Text = NameTovar;
            maskedTextBoxQuantity.Text = Quantity;
            maskedTextBoxSale.Text = Sale;
            comboBoxCategory.Text = Category;
            textBoxProizvoditel.Text = Proizvoditel;
            comboBoxPostavshik.Text = Postavchik;
            maskedTextBoxDiscount.Text = Discount.ToString();
            maskedTextBoxArticle.Text = ArticleTovar;
            textBoxOpisanie.Text = Opisanie;
            labelIzm.Text = EdinicIzm;
        }
        public void AddTovar()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = @"INSERT INTO public.tovar (name_tovar_fk, edin_izmer, sale, postavchik_fk, proizvoditel_fk, category_name_fk, dicsount, quantity, opisanie, picture, id_article)
                                 VALUES (
                                 (SELECT id FROM name_tovar WHERE name_tovar = @name_tovar),
                                 @edin_izmer,
                                 @sale,
                                 (SELECT id FROM postavchik WHERE postavchik_name = @postavchik),
                                 (SELECT id_pk_proiz FROM proizvoditel WHERE name_proizv = @proizvoditel),
                                 (SELECT id_pk_category_tovar FROM category_tovar WHERE category = @category),
                                 @dicsount,
                                 @quantity,
                                 @opisanie, 
                                 @picture,
                                 @id_article)";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name_tovar", comboBoxName.Text);
                    command.Parameters.AddWithValue("@edin_izmer", labelIzm.Text);
                    command.Parameters.AddWithValue("@sale", Convert.ToDouble(maskedTextBoxSale.Text));
                    command.Parameters.AddWithValue("@postavchik", comboBoxPostavshik.Text);
                    command.Parameters.AddWithValue("@proizvoditel", textBoxProizvoditel.Text);
                    command.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@dicsount", Convert.ToInt32(maskedTextBoxDiscount.Text));
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(maskedTextBoxQuantity.Text));
                    command.Parameters.AddWithValue("@opisanie", textBoxOpisanie.Text);
                    command.Parameters.AddWithValue("@picture", buttonDownloadImage.Text);
                    command.Parameters.AddWithValue("@id_article", maskedTextBoxArticle.Text);                  
                    command.ExecuteNonQuery();
                }                      
                connection.Close();
            }
        }
        private void AddTovar_Load(object sender, EventArgs e)
        {
            if (!isEditMode)
                return;

            if (string.IsNullOrEmpty(NameTovarToEdit))
                return;
            LoadTovarData();
        }
        public void UpdateTovar()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = @"UPDATE public.tovar
                                 SET name_tovar_fk = (SELECT id FROM name_tovar WHERE name_tovar = @name_tovar),
                                     edin_izmer = @edin_izmer,
                                     sale = @sale,
                                     postavchik_fk = (SELECT id FROM postavchik WHERE postavchik_name = @postavchik),
                                     proizvoditel_fk = (SELECT id_pk_proiz FROM proizvoditel WHERE name_proizv = @proizvoditel),
                                     category_name_fk = (SELECT id_pk_category_tovar FROM category_tovar WHERE category = @category),
                                     dicsount = @dicsount,
                                     quantity = @quantity,
                                     opisanie = @opisanie,
                                     picture = @picture,
                                     id_article = @id_article
                                 WHERE id_article = @id_article";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name_tovar", comboBoxName.Text);
                    command.Parameters.AddWithValue("@edin_izmer", "шт.");
                    command.Parameters.AddWithValue("@sale", Convert.ToDouble(maskedTextBoxSale.Text));
                    command.Parameters.AddWithValue("@postavchik", comboBoxPostavshik.Text);
                    command.Parameters.AddWithValue("@proizvoditel", textBoxProizvoditel.Text);
                    command.Parameters.AddWithValue("@category", comboBoxCategory.Text);
                    command.Parameters.AddWithValue("@dicsount", Convert.ToInt32(maskedTextBoxDiscount.Text));
                    command.Parameters.AddWithValue("@quantity", Convert.ToInt32(maskedTextBoxQuantity.Text));
                    command.Parameters.AddWithValue("@opisanie", textBoxOpisanie.Text);
                    command.Parameters.AddWithValue("@picture", buttonDownloadImage.Text);
                    command.Parameters.AddWithValue("@id_article", maskedTextBoxArticle.Text);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void LoadTovarData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"SELECT name_tovar.name_tovar, edin_izmer, sale, postavchik.postavchik_name, proizvoditel.name_proizv, category_tovar.category, dicsount, quantity, opisanie, picture, id_article
                                 FROM public.tovar
                                 JOIN name_tovar ON name_tovar.id = tovar.name_tovar_fk
                                 JOIN postavchik ON postavchik.id = tovar.postavchik_fk
                                 JOIN proizvoditel ON proizvoditel.id_pk_proiz = tovar.proizvoditel_fk
                                 JOIN category_tovar ON category_tovar.id_pk_category_tovar = tovar.category_name_fk
                                 WHERE id_article = '{maskedTextBoxArticle.Text}' ";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            comboBoxName.Text = reader.GetString(0);
                            maskedTextBoxSale.Text = reader.GetDouble(2).ToString();
                            comboBoxPostavshik.Text = reader.GetString(3);
                            textBoxProizvoditel.Text = reader.GetString(4);
                            comboBoxCategory.Text = reader.GetString(5);
                            maskedTextBoxDiscount.Text = reader.GetInt32(6).ToString();
                            maskedTextBoxQuantity.Text = reader.GetInt32(7).ToString();
                            textBoxOpisanie.Text = reader.GetString(8);
                            buttonDownloadImage.Text = reader.IsDBNull(9) ? string.Empty + "Загрузить фото" : reader.GetString(9).ToString();
                            maskedTextBoxArticle.Text = reader.GetString(10);
                        }
                    }
                }
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadTovar("DESC", "", "Все поставщики"); 
        }

        private void buttonAddRedact_Click(object sender, EventArgs e)
        {
            //ну здесь проверки на заполненность полей, просто Ctrl+c Ctrl+v, чтобы наверстать баллы
            if (!string.IsNullOrEmpty(comboBoxName.Text))
            {
                NameTovar = comboBoxName.Text;
            }
            else 
            {
                MessageBox.Show("Введите название товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(comboBoxCategory.Text))
            {
                Category = comboBoxCategory.Text;
            }
            else
            {
                MessageBox.Show("Введите категорию товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(textBoxProizvoditel.Text))
            {
                Proizvoditel = textBoxProizvoditel.Text;
            }
            else
            {
                MessageBox.Show("Введите производителя товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(comboBoxPostavshik.Text))
            {
                Postavchik = comboBoxPostavshik.Text;
            }
            else
            {
                MessageBox.Show("Введите поставщика товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(maskedTextBoxQuantity.Text) && int.TryParse(maskedTextBoxQuantity.Text, out int quantityValue))
            {
                Quantity = maskedTextBoxQuantity.Text;
            }
            else
            {
                MessageBox.Show("Введите корректное количество товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(maskedTextBoxSale.Text) && double.TryParse(maskedTextBoxSale.Text, out double saleValue))
            {
                Sale = maskedTextBoxSale.Text;
            }
            else
            {
                MessageBox.Show("Введите корректную цену товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(maskedTextBoxDiscount.Text) && int.TryParse(maskedTextBoxDiscount.Text, out int discountValue))
            {
                Discount = discountValue;
            }
            else
            {
                MessageBox.Show("Введите корректную скидку товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(maskedTextBoxArticle.Text))
            {
                ArticleTovar = maskedTextBoxArticle.Text;
            }
            else
            {
                MessageBox.Show("Введите артикул товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(textBoxOpisanie.Text))
            {
                Opisanie = textBoxOpisanie.Text;
            }
            else
            {
                MessageBox.Show("Введите описание товара!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //здесь проверяем режим редактирования или добавления
            if (isEditMode)
            {
                UpdateTovar();
                MessageBox.Show("Товар успешно обновлён!", "Информация", MessageBoxButtons.OK);
            }
            else
            {
                AddTovar();
                MessageBox.Show("Товар успешно добавлен!", "Информация", MessageBoxButtons.OK);
            }
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadTovar("DESC", "", "Все поставщики");
        }
        //здесь настраиваем маску под 0 индекс, чтобы при клике возвращало в начало строки
        private void maskedTextBoxQuantity_Click(object sender, EventArgs e)
        {
            maskedTextBoxQuantity.Clear();
        }

        private void maskedTextBoxSale_Click(object sender, EventArgs e)
        {
            maskedTextBoxSale.Clear();

        }

        private void maskedTextBoxDiscount_Click(object sender, EventArgs e)
        {
            maskedTextBoxDiscount.Clear();
        }

        private void maskedTextBoxArticle_Click(object sender, EventArgs e)
        {
            maskedTextBoxArticle.Clear();
        }
        //Здесь реализация кнопки Загрузки через OpenFileDialog
        private void buttonDownloadImage_Click(object sender, EventArgs e)
        {
            { 
                var dialog = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*" };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Копируем фото
                    string newPath = Path.Combine(Path.Combine(Application.StartupPath, "images"), dialog.SafeFileName);
                    File.Copy(dialog.FileName, newPath, true);
                    // Загружаем в PictureBox
                    pictureBoxPhotoTovar.Image = Image.FromFile(newPath);
                    buttonDownloadImage.Text = dialog.SafeFileName;
                    MessageBox.Show("Фото загружено!");
                }
            }
        }
    }
}

using Npgsql.Internal;
using ShoeStore.Controls;
using ShoeStore.Properties;
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
using System.DirectoryServices.ActiveDirectory;
using System.IO;


namespace ShoeStore
{
    public partial class PanelControl : UserControl
    {
        public string Category { get; set; }
        public string NameTovar { get; set; }
        public string Opisanie { get; set; }
        public string Proizvoditel { get; set; }
        public string Postavchik { get; set; }
        public string Count { get; set; }
        public string EdinicIzm { get; set; }
        public string Quantity { get; set; }
        public int Discount { get; set; }
        public string DiscountCount { get; set; }
        public string Picture { get; set; }
        public string IdArticle { get; set; }

        public PanelControl(string RoleName)
        {
            InitializeComponent();
            if (RoleName != "Администратор")
            {
                buttonRedact.Visible = false;
                buttonDelete.Visible = false;
            }
        }
        public void SetLabels()
        {
            labelCategory.Text = Category;
            labelNameTovar.Text = NameTovar;
            labelOpisanie.Text = Opisanie;
            labelProizvoditel.Text = Proizvoditel;
            labelPostavshik.Text = Postavchik;
            labelCount.Text = Count;
            labelDiscountPrice.Text = DiscountCount;
            labelEdinIzm.Text = EdinicIzm;
            labelQuantity.Text = Quantity;
            //здесь реализация загрузки Картинки
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "images") + "\\" + Picture;
            //здесь реализиция вывода скидки под цвета
            labelDiscount.Text = "Cкидка: " + Discount.ToString() + "%";
            if (Discount > 15)
            {
                labelDiscount.BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
            if (Discount == 0)
            {
                labelDiscountPrice.Visible = false;
            }
            else
            {
                labelDiscountPrice.Visible = true;
                labelCount.Font = new Font(labelCount.Font, FontStyle.Strikeout);
                labelCount.ForeColor = Color.Red;
            }
        }
        //открытие редактирование товара
        public void buttonRedact_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.FindForm() as MainForm;
            mainForm.LoadRedact(IdArticle);
        }
        //кнопка удаление реализация
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(Resources.connectionDB))
            {
                connection.Open();
                string query = $@"DELETE FROM public.tovar WHERE id_article = '{IdArticle}'; ";
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

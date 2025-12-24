namespace ShoeStore.Controls
{
    partial class AddPanelRedact
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProizvoditel = new System.Windows.Forms.Label();
            this.labelPostavshik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOpisanie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonDownloadImage = new System.Windows.Forms.Button();
            this.buttonAddRedact = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPhotoTovar = new System.Windows.Forms.PictureBox();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.comboBoxEdinIzm = new System.Windows.Forms.ComboBox();
            this.comboBoxPostavshik = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxArticle = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxQuantity = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDiscount = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSale = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDovalenieRedact = new System.Windows.Forms.Label();
            this.textBoxProizvoditel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoTovar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProizvoditel
            // 
            this.labelProizvoditel.AutoSize = true;
            this.labelProizvoditel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProizvoditel.Location = new System.Drawing.Point(32, 101);
            this.labelProizvoditel.Margin = new System.Windows.Forms.Padding(5);
            this.labelProizvoditel.Name = "labelProizvoditel";
            this.labelProizvoditel.Size = new System.Drawing.Size(112, 17);
            this.labelProizvoditel.TabIndex = 9;
            this.labelProizvoditel.Text = "Наименование";
            // 
            // labelPostavshik
            // 
            this.labelPostavshik.AutoSize = true;
            this.labelPostavshik.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostavshik.Location = new System.Drawing.Point(31, 249);
            this.labelPostavshik.Margin = new System.Windows.Forms.Padding(5);
            this.labelPostavshik.Name = "labelPostavshik";
            this.labelPostavshik.Size = new System.Drawing.Size(116, 17);
            this.labelPostavshik.TabIndex = 8;
            this.labelPostavshik.Text = "Производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Поставщик:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Количество на складе";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(516, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Скидка";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxOpisanie
            // 
            this.textBoxOpisanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOpisanie.Location = new System.Drawing.Point(602, 80);
            this.textBoxOpisanie.Multiline = true;
            this.textBoxOpisanie.Name = "textBoxOpisanie";
            this.textBoxOpisanie.Size = new System.Drawing.Size(268, 185);
            this.textBoxOpisanie.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Цена";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(31, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Категория";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(533, 283);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Артикл";
            // 
            // buttonDownloadImage
            // 
            this.buttonDownloadImage.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownloadImage.Location = new System.Drawing.Point(720, 365);
            this.buttonDownloadImage.Name = "buttonDownloadImage";
            this.buttonDownloadImage.Size = new System.Drawing.Size(150, 23);
            this.buttonDownloadImage.TabIndex = 25;
            this.buttonDownloadImage.Text = "Загрузить Изображение";
            this.buttonDownloadImage.UseVisualStyleBackColor = true;
            this.buttonDownloadImage.Click += new System.EventHandler(this.buttonDownloadImage_Click);
            // 
            // buttonAddRedact
            // 
            this.buttonAddRedact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddRedact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRedact.Location = new System.Drawing.Point(197, 376);
            this.buttonAddRedact.Name = "buttonAddRedact";
            this.buttonAddRedact.Size = new System.Drawing.Size(140, 38);
            this.buttonAddRedact.TabIndex = 26;
            this.buttonAddRedact.Text = "Добавить";
            this.buttonAddRedact.UseVisualStyleBackColor = false;
            this.buttonAddRedact.Click += new System.EventHandler(this.buttonAddRedact_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(35, 376);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(140, 38);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.labelDovalenieRedact);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 30);
            this.panel1.TabIndex = 28;
            // 
            // pictureBoxPhotoTovar
            // 
            this.pictureBoxPhotoTovar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBoxPhotoTovar.Location = new System.Drawing.Point(780, 280);
            this.pictureBoxPhotoTovar.Name = "pictureBoxPhotoTovar";
            this.pictureBoxPhotoTovar.Size = new System.Drawing.Size(90, 79);
            this.pictureBoxPhotoTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoTovar.TabIndex = 29;
            this.pictureBoxPhotoTovar.TabStop = false;
            // 
            // comboBoxName
            // 
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Items.AddRange(new object[] {
            "Ботинки",
            "Туфли",
            "Кроссовки",
            "Полуботинки",
            "Кеды",
            "Тапочки",
            "Сапоги"});
            this.comboBoxName.Location = new System.Drawing.Point(35, 126);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(127, 21);
            this.comboBoxName.TabIndex = 30;
            // 
            // comboBoxEdinIzm
            // 
            this.comboBoxEdinIzm.FormattingEnabled = true;
            this.comboBoxEdinIzm.Items.AddRange(new object[] {
            "шт."});
            this.comboBoxEdinIzm.Location = new System.Drawing.Point(343, 161);
            this.comboBoxEdinIzm.Name = "comboBoxEdinIzm";
            this.comboBoxEdinIzm.Size = new System.Drawing.Size(58, 21);
            this.comboBoxEdinIzm.TabIndex = 31;
            this.comboBoxEdinIzm.Text = "шт.";
            // 
            // comboBoxPostavshik
            // 
            this.comboBoxPostavshik.FormattingEnabled = true;
            this.comboBoxPostavshik.Items.AddRange(new object[] {
            "Обувь для вас",
            "Kari"});
            this.comboBoxPostavshik.Location = new System.Drawing.Point(210, 219);
            this.comboBoxPostavshik.Name = "comboBoxPostavshik";
            this.comboBoxPostavshik.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPostavshik.TabIndex = 32;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Мужская обувь",
            "Женская обувь"});
            this.comboBoxCategory.Location = new System.Drawing.Point(210, 275);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(127, 21);
            this.comboBoxCategory.TabIndex = 33;
            // 
            // maskedTextBoxArticle
            // 
            this.maskedTextBoxArticle.Location = new System.Drawing.Point(602, 280);
            this.maskedTextBoxArticle.Mask = ">L000L0";
            this.maskedTextBoxArticle.Name = "maskedTextBoxArticle";
            this.maskedTextBoxArticle.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBoxArticle.TabIndex = 34;
            this.maskedTextBoxArticle.Click += new System.EventHandler(this.maskedTextBoxArticle_Click);
            // 
            // maskedTextBoxQuantity
            // 
            this.maskedTextBoxQuantity.BeepOnError = true;
            this.maskedTextBoxQuantity.Location = new System.Drawing.Point(210, 162);
            this.maskedTextBoxQuantity.Mask = "000";
            this.maskedTextBoxQuantity.Name = "maskedTextBoxQuantity";
            this.maskedTextBoxQuantity.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBoxQuantity.TabIndex = 35;
            this.maskedTextBoxQuantity.Click += new System.EventHandler(this.maskedTextBoxQuantity_Click);
            // 
            // maskedTextBoxDiscount
            // 
            this.maskedTextBoxDiscount.BeepOnError = true;
            this.maskedTextBoxDiscount.Location = new System.Drawing.Point(210, 302);
            this.maskedTextBoxDiscount.Mask = "00";
            this.maskedTextBoxDiscount.Name = "maskedTextBoxDiscount";
            this.maskedTextBoxDiscount.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBoxDiscount.TabIndex = 36;
            this.maskedTextBoxDiscount.Click += new System.EventHandler(this.maskedTextBoxDiscount_Click);
            // 
            // maskedTextBoxSale
            // 
            this.maskedTextBoxSale.BeepOnError = true;
            this.maskedTextBoxSale.Location = new System.Drawing.Point(210, 188);
            this.maskedTextBoxSale.Mask = "00000";
            this.maskedTextBoxSale.Name = "maskedTextBoxSale";
            this.maskedTextBoxSale.Size = new System.Drawing.Size(127, 20);
            this.maskedTextBoxSale.TabIndex = 37;
            this.maskedTextBoxSale.ValidatingType = typeof(int);
            this.maskedTextBoxSale.Click += new System.EventHandler(this.maskedTextBoxSale_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 81);
            this.panel2.TabIndex = 38;
            // 
            // labelDovalenieRedact
            // 
            this.labelDovalenieRedact.AutoSize = true;
            this.labelDovalenieRedact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDovalenieRedact.Location = new System.Drawing.Point(30, 5);
            this.labelDovalenieRedact.Margin = new System.Windows.Forms.Padding(5);
            this.labelDovalenieRedact.Name = "labelDovalenieRedact";
            this.labelDovalenieRedact.Size = new System.Drawing.Size(354, 24);
            this.labelDovalenieRedact.TabIndex = 39;
            this.labelDovalenieRedact.Text = "Добавление/Редактирование товара";
            // 
            // textBoxProizvoditel
            // 
            this.textBoxProizvoditel.FormattingEnabled = true;
            this.textBoxProizvoditel.Items.AddRange(new object[] {
            "Kari",
            "Marco Tozzi",
            "Рос",
            "Rieker",
            "Alessio Nesca",
            "CROSBY"});
            this.textBoxProizvoditel.Location = new System.Drawing.Point(210, 245);
            this.textBoxProizvoditel.Name = "textBoxProizvoditel";
            this.textBoxProizvoditel.Size = new System.Drawing.Size(127, 21);
            this.textBoxProizvoditel.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(602, 310);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 49);
            this.label11.TabIndex = 41;
            this.label11.Text = "Пример маски: L000L0 введите данный по образцу";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddPanelRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxProizvoditel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.maskedTextBoxSale);
            this.Controls.Add(this.maskedTextBoxDiscount);
            this.Controls.Add(this.maskedTextBoxQuantity);
            this.Controls.Add(this.maskedTextBoxArticle);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxPostavshik);
            this.Controls.Add(this.comboBoxEdinIzm);
            this.Controls.Add(this.comboBoxName);
            this.Controls.Add(this.pictureBoxPhotoTovar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddRedact);
            this.Controls.Add(this.buttonDownloadImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxOpisanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelProizvoditel);
            this.Controls.Add(this.labelPostavshik);
            this.Name = "AddPanelRedact";
            this.Size = new System.Drawing.Size(889, 501);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoTovar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProizvoditel;
        private System.Windows.Forms.Label labelPostavshik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOpisanie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDownloadImage;
        private System.Windows.Forms.Button buttonAddRedact;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxPhotoTovar;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.ComboBox comboBoxEdinIzm;
        private System.Windows.Forms.ComboBox comboBoxPostavshik;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxArticle;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantity;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDiscount;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDovalenieRedact;
        private System.Windows.Forms.ComboBox textBoxProizvoditel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

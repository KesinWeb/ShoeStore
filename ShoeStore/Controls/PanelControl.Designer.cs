namespace ShoeStore
{
    partial class PanelControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameTovar = new System.Windows.Forms.Label();
            this.labelOpisanie = new System.Windows.Forms.Label();
            this.labelProizvoditel = new System.Windows.Forms.Label();
            this.labelPostavshik = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelEdinIzm = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.buttonRedact = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelDiscountPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategory.AutoEllipsis = true;
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.Location = new System.Drawing.Point(178, 14);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(5);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(195, 17);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Категория: Какая то обувь";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(387, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "|";
            // 
            // labelNameTovar
            // 
            this.labelNameTovar.AutoSize = true;
            this.labelNameTovar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameTovar.Location = new System.Drawing.Point(408, 14);
            this.labelNameTovar.Margin = new System.Windows.Forms.Padding(5);
            this.labelNameTovar.Name = "labelNameTovar";
            this.labelNameTovar.Size = new System.Drawing.Size(187, 17);
            this.labelNameTovar.TabIndex = 3;
            this.labelNameTovar.Text = "Наименование: Название";
            // 
            // labelOpisanie
            // 
            this.labelOpisanie.AutoEllipsis = true;
            this.labelOpisanie.AutoSize = true;
            this.labelOpisanie.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOpisanie.Location = new System.Drawing.Point(178, 34);
            this.labelOpisanie.Margin = new System.Windows.Forms.Padding(5);
            this.labelOpisanie.Name = "labelOpisanie";
            this.labelOpisanie.Size = new System.Drawing.Size(133, 17);
            this.labelOpisanie.TabIndex = 4;
            this.labelOpisanie.Text = "Описание товара:";
            this.labelOpisanie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelProizvoditel
            // 
            this.labelProizvoditel.AutoSize = true;
            this.labelProizvoditel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProizvoditel.Location = new System.Drawing.Point(178, 51);
            this.labelProizvoditel.Margin = new System.Windows.Forms.Padding(5);
            this.labelProizvoditel.Name = "labelProizvoditel";
            this.labelProizvoditel.Size = new System.Drawing.Size(121, 17);
            this.labelProizvoditel.TabIndex = 6;
            this.labelProizvoditel.Text = "Производитель:";
            // 
            // labelPostavshik
            // 
            this.labelPostavshik.AutoSize = true;
            this.labelPostavshik.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostavshik.Location = new System.Drawing.Point(178, 69);
            this.labelPostavshik.Margin = new System.Windows.Forms.Padding(5);
            this.labelPostavshik.Name = "labelPostavshik";
            this.labelPostavshik.Size = new System.Drawing.Size(93, 17);
            this.labelPostavshik.TabIndex = 5;
            this.labelPostavshik.Text = "Поставщик:";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(227, 86);
            this.labelCount.Margin = new System.Windows.Forms.Padding(5);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(44, 17);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Цена";
            // 
            // labelEdinIzm
            // 
            this.labelEdinIzm.AutoSize = true;
            this.labelEdinIzm.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEdinIzm.Location = new System.Drawing.Point(178, 103);
            this.labelEdinIzm.Margin = new System.Windows.Forms.Padding(5);
            this.labelEdinIzm.Name = "labelEdinIzm";
            this.labelEdinIzm.Size = new System.Drawing.Size(153, 17);
            this.labelEdinIzm.TabIndex = 7;
            this.labelEdinIzm.Text = "Единица измерения:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantity.Location = new System.Drawing.Point(178, 120);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(166, 17);
            this.labelQuantity.TabIndex = 9;
            this.labelQuantity.Text = "Количество на складе:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDiscount.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDiscount.Location = new System.Drawing.Point(851, 3);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(160, 144);
            this.labelDiscount.TabIndex = 10;
            this.labelDiscount.Text = "Действующая скидка:";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRedact
            // 
            this.buttonRedact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRedact.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRedact.Location = new System.Drawing.Point(744, 101);
            this.buttonRedact.Name = "buttonRedact";
            this.buttonRedact.Size = new System.Drawing.Size(101, 23);
            this.buttonRedact.TabIndex = 15;
            this.buttonRedact.Text = "Редактировать";
            this.buttonRedact.UseVisualStyleBackColor = false;
            this.buttonRedact.Click += new System.EventHandler(this.buttonRedact_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(744, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 23);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelDiscountPrice
            // 
            this.labelDiscountPrice.AutoSize = true;
            this.labelDiscountPrice.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDiscountPrice.Location = new System.Drawing.Point(296, 86);
            this.labelDiscountPrice.Margin = new System.Windows.Forms.Padding(5);
            this.labelDiscountPrice.Name = "labelDiscountPrice";
            this.labelDiscountPrice.Size = new System.Drawing.Size(95, 17);
            this.labelDiscountPrice.TabIndex = 17;
            this.labelDiscountPrice.Text = "Со скидкой:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(178, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Цена:";
            // 
            // PanelControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDiscountPrice);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRedact);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelEdinIzm);
            this.Controls.Add(this.labelProizvoditel);
            this.Controls.Add(this.labelPostavshik);
            this.Controls.Add(this.labelOpisanie);
            this.Controls.Add(this.labelNameTovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.Name = "PanelControl";
            this.Size = new System.Drawing.Size(1023, 154);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNameTovar;
        private System.Windows.Forms.Label labelOpisanie;
        private System.Windows.Forms.Label labelProizvoditel;
        private System.Windows.Forms.Label labelPostavshik;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelEdinIzm;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Button buttonRedact;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelDiscountPrice;
        private System.Windows.Forms.Label label1;
    }
}

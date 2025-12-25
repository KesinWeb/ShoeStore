namespace ShoeStore.Controls
{
    partial class AddZakazPanelRedact
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
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelDataZakaza = new System.Windows.Forms.Label();
            this.labelArticle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDovalenieZakazRedact = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerZakaz = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVidacha = new System.Windows.Forms.DateTimePicker();
            this.buttonZakazBack = new System.Windows.Forms.Button();
            this.buttonZakazAddRedact = new System.Windows.Forms.Button();
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.comboBoxArticle = new System.Windows.Forms.ComboBox();
            this.numericUpDownAddQuantity = new System.Windows.Forms.NumericUpDown();
            this.listBoxAdd = new System.Windows.Forms.ListBox();
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelAdress.Location = new System.Drawing.Point(32, 306);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(165, 19);
            this.labelAdress.TabIndex = 16;
            this.labelAdress.Text = "Адрес пункта выдачи";
            // 
            // labelDataZakaza
            // 
            this.labelDataZakaza.AutoSize = true;
            this.labelDataZakaza.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataZakaza.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDataZakaza.Location = new System.Drawing.Point(523, 108);
            this.labelDataZakaza.Name = "labelDataZakaza";
            this.labelDataZakaza.Size = new System.Drawing.Size(95, 19);
            this.labelDataZakaza.TabIndex = 15;
            this.labelDataZakaza.Text = "Дата Заказа";
            // 
            // labelArticle
            // 
            this.labelArticle.AutoSize = true;
            this.labelArticle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelArticle.Location = new System.Drawing.Point(32, 108);
            this.labelArticle.Name = "labelArticle";
            this.labelArticle.Size = new System.Drawing.Size(125, 19);
            this.labelArticle.TabIndex = 14;
            this.labelArticle.Text = "Артикул Товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(32, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Статус заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(523, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Дата Выдачи";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Завершен",
            "Новый"});
            this.comboBoxStatus.Location = new System.Drawing.Point(214, 264);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(127, 21);
            this.comboBoxStatus.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.labelDovalenieZakazRedact);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 32);
            this.panel1.TabIndex = 33;
            // 
            // labelDovalenieZakazRedact
            // 
            this.labelDovalenieZakazRedact.AutoSize = true;
            this.labelDovalenieZakazRedact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDovalenieZakazRedact.Location = new System.Drawing.Point(32, 5);
            this.labelDovalenieZakazRedact.Margin = new System.Windows.Forms.Padding(5);
            this.labelDovalenieZakazRedact.Name = "labelDovalenieZakazRedact";
            this.labelDovalenieZakazRedact.Size = new System.Drawing.Size(352, 24);
            this.labelDovalenieZakazRedact.TabIndex = 46;
            this.labelDovalenieZakazRedact.Text = "Добавление/Редактирование заказа";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 81);
            this.panel2.TabIndex = 40;
            // 
            // dateTimePickerZakaz
            // 
            this.dateTimePickerZakaz.Location = new System.Drawing.Point(655, 108);
            this.dateTimePickerZakaz.Name = "dateTimePickerZakaz";
            this.dateTimePickerZakaz.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerZakaz.TabIndex = 43;
            // 
            // dateTimePickerVidacha
            // 
            this.dateTimePickerVidacha.Location = new System.Drawing.Point(655, 141);
            this.dateTimePickerVidacha.Name = "dateTimePickerVidacha";
            this.dateTimePickerVidacha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVidacha.TabIndex = 44;
            // 
            // buttonZakazBack
            // 
            this.buttonZakazBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZakazBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakazBack.Location = new System.Drawing.Point(36, 376);
            this.buttonZakazBack.Name = "buttonZakazBack";
            this.buttonZakazBack.Size = new System.Drawing.Size(140, 38);
            this.buttonZakazBack.TabIndex = 48;
            this.buttonZakazBack.Text = "Назад";
            this.buttonZakazBack.UseVisualStyleBackColor = false;
            this.buttonZakazBack.Click += new System.EventHandler(this.buttonZakazBack_Click);
            // 
            // buttonZakazAddRedact
            // 
            this.buttonZakazAddRedact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZakazAddRedact.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakazAddRedact.Location = new System.Drawing.Point(195, 376);
            this.buttonZakazAddRedact.Name = "buttonZakazAddRedact";
            this.buttonZakazAddRedact.Size = new System.Drawing.Size(140, 38);
            this.buttonZakazAddRedact.TabIndex = 47;
            this.buttonZakazAddRedact.Text = "Добавить";
            this.buttonZakazAddRedact.UseVisualStyleBackColor = false;
            this.buttonZakazAddRedact.Click += new System.EventHandler(this.buttonZakazAddRedact_Click);
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Items.AddRange(new object[] {
            "420151, г. Лесной, ул. Вишневая, 32",
            "125061, г. Лесной, ул. Подгорная, 8",
            "630370, г. Лесной, ул. Шоссейная, 24",
            "400562, г. Лесной, ул. Зеленая, 32",
            "614510, г. Лесной, ул. Маяковского, 47",
            "410542, г. Лесной, ул. Светлая, 46",
            "620839, г. Лесной, ул. Цветочная, 8",
            "443890, г. Лесной, ул. Коммунистическая, 1",
            "603379, г. Лесной, ул. Спортивная, 46",
            "603721, г. Лесной, ул. Гоголя, 41",
            "410172, г. Лесной, ул. Северная, 13",
            "614611, г. Лесной, ул. Молодежная, 50",
            "454311, г.Лесной, ул. Новая, 19",
            "660007, г.Лесной, ул. Октябрьская, 19",
            "603036, г. Лесной, ул. Садовая, 4",
            "394060, г.Лесной, ул. Фрунзе, 43",
            "410661, г. Лесной, ул. Школьная, 50",
            "625590, г. Лесной, ул. Коммунистическая, 20",
            "625683, г. Лесной, ул. 8 Марта",
            "450983, г.Лесной, ул. Комсомольская, 26",
            "394782, г. Лесной, ул. Чехова, 3",
            "603002, г. Лесной, ул. Дзержинского, 28",
            "450558, г. Лесной, ул. Набережная, 30",
            "344288, г. Лесной, ул. Чехова, 1",
            "614164, г.Лесной,  ул. Степная, 30",
            "394242, г. Лесной, ул. Коммунистическая, 43",
            "660540, г. Лесной, ул. Солнечная, 25",
            "125837, г. Лесной, ул. Шоссейная, 40",
            "125703, г. Лесной, ул. Партизанская, 49",
            "625283, г. Лесной, ул. Победы, 46",
            "614753, г. Лесной, ул. Полевая, 35",
            "426030, г. Лесной, ул. Маяковского, 44",
            "450375, г. Лесной ул. Клубная, 44",
            "625560, г. Лесной, ул. Некрасова, 12",
            "630201, г. Лесной, ул. Комсомольская, 17",
            "190949, г. Лесной, ул. Мичурина, 26"});
            this.comboBoxAdress.Location = new System.Drawing.Point(214, 307);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(297, 21);
            this.comboBoxAdress.TabIndex = 53;
            // 
            // comboBoxArticle
            // 
            this.comboBoxArticle.FormattingEnabled = true;
            this.comboBoxArticle.Items.AddRange(new object[] {
            "D329H3",
            "D364R4",
            "D572U8",
            "E482R4",
            "F122F2",
            "F222F2",
            "F427R5",
            "F572H7",
            "F635R4",
            "G432E4",
            "G531F4",
            "G783F5",
            "H535R5",
            "H782T5",
            "J384T6",
            "K345R4",
            "K358H6",
            "L754R4",
            "M542T5",
            "N457T5",
            "O754F4",
            "P764G4",
            "S213E3",
            "S326R5",
            "S634B5",
            "T324F5",
            "А112Т4"});
            this.comboBoxArticle.Location = new System.Drawing.Point(214, 109);
            this.comboBoxArticle.Name = "comboBoxArticle";
            this.comboBoxArticle.Size = new System.Drawing.Size(127, 21);
            this.comboBoxArticle.TabIndex = 54;
            // 
            // numericUpDownAddQuantity
            // 
            this.numericUpDownAddQuantity.Location = new System.Drawing.Point(347, 108);
            this.numericUpDownAddQuantity.Name = "numericUpDownAddQuantity";
            this.numericUpDownAddQuantity.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownAddQuantity.TabIndex = 55;
            // 
            // listBoxAdd
            // 
            this.listBoxAdd.FormattingEnabled = true;
            this.listBoxAdd.Location = new System.Drawing.Point(214, 163);
            this.listBoxAdd.Name = "listBoxAdd";
            this.listBoxAdd.ScrollAlwaysVisible = true;
            this.listBoxAdd.Size = new System.Drawing.Size(127, 95);
            this.listBoxAdd.TabIndex = 56;
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTovar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTovar.Location = new System.Drawing.Point(214, 136);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(107, 21);
            this.buttonAddTovar.TabIndex = 57;
            this.buttonAddTovar.Text = "Добавить товар";
            this.buttonAddTovar.UseVisualStyleBackColor = false;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(32, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Получатель";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Items.AddRange(new object[] {
            "Никифорова Весения Николаевна",
            "Сазонов Руслан Германович",
            "Одинцов Серафим Артёмович",
            "Степанов Михаил Артёмович",
            "Ворсин Петр Евгеньевич",
            "Старикова Елена Павловна",
            "Михайлюк Анна Вячеславовна",
            "Ситдикова Елена Анатольевна",
            "Ворсин Петр Евгеньевич",
            "Старикова Елена Павловна",
            "adsasd"});
            this.comboBoxClient.Location = new System.Drawing.Point(214, 334);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(297, 21);
            this.comboBoxClient.TabIndex = 59;
            // 
            // AddZakazPanelRedact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.listBoxAdd);
            this.Controls.Add(this.numericUpDownAddQuantity);
            this.Controls.Add(this.comboBoxArticle);
            this.Controls.Add(this.comboBoxAdress);
            this.Controls.Add(this.buttonZakazBack);
            this.Controls.Add(this.buttonZakazAddRedact);
            this.Controls.Add(this.dateTimePickerVidacha);
            this.Controls.Add(this.dateTimePickerZakaz);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelDataZakaza);
            this.Controls.Add(this.labelArticle);
            this.Name = "AddZakazPanelRedact";
            this.Size = new System.Drawing.Size(889, 501);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelDataZakaza;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerZakaz;
        private System.Windows.Forms.DateTimePicker dateTimePickerVidacha;
        private System.Windows.Forms.Label labelDovalenieZakazRedact;
        private System.Windows.Forms.Button buttonZakazBack;
        private System.Windows.Forms.Button buttonZakazAddRedact;
        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.ComboBox comboBoxArticle;
        private System.Windows.Forms.NumericUpDown numericUpDownAddQuantity;
        private System.Windows.Forms.ListBox listBoxAdd;
        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}

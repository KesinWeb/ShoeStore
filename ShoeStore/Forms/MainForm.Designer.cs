namespace ShoeStore
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textSearchBox = new System.Windows.Forms.TextBox();
            this.labelS = new System.Windows.Forms.Label();
            this.comboBoxPostavshik = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelPostav = new System.Windows.Forms.Label();
            this.buttonZakaz = new System.Windows.Forms.Button();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.buttonAddTovar = new System.Windows.Forms.Button();
            this.buttonAddZakaz = new System.Windows.Forms.Button();
            this.buttonTovar = new System.Windows.Forms.Button();
            this.labelFio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxDesc = new System.Windows.Forms.CheckBox();
            this.checkBoxAsc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SeaShell;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(53, 68);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1062, 500);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // textSearchBox
            // 
            this.textSearchBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textSearchBox.Location = new System.Drawing.Point(1125, 90);
            this.textSearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textSearchBox.Name = "textSearchBox";
            this.textSearchBox.Size = new System.Drawing.Size(140, 20);
            this.textSearchBox.TabIndex = 1;
            this.textSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchBox_KeyDown);
            // 
            // labelS
            // 
            this.labelS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS.Location = new System.Drawing.Point(1121, 68);
            this.labelS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(59, 19);
            this.labelS.TabIndex = 2;
            this.labelS.Text = "Поиск:";
            // 
            // comboBoxPostavshik
            // 
            this.comboBoxPostavshik.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxPostavshik.FormattingEnabled = true;
            this.comboBoxPostavshik.Items.AddRange(new object[] {
            "Все поставщики",
            "Обувь для вас",
            "Kari"});
            this.comboBoxPostavshik.Location = new System.Drawing.Point(1125, 230);
            this.comboBoxPostavshik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxPostavshik.Name = "comboBoxPostavshik";
            this.comboBoxPostavshik.Size = new System.Drawing.Size(140, 21);
            this.comboBoxPostavshik.TabIndex = 4;
            this.comboBoxPostavshik.Text = "Все поставщики";
            this.comboBoxPostavshik.SelectedIndexChanged += new System.EventHandler(this.comboBoxPostavshik_SelectedIndexChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilter.Location = new System.Drawing.Point(1121, 130);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(82, 19);
            this.labelFilter.TabIndex = 6;
            this.labelFilter.Text = "Фильтры:";
            // 
            // labelPostav
            // 
            this.labelPostav.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPostav.AutoSize = true;
            this.labelPostav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPostav.Location = new System.Drawing.Point(1121, 208);
            this.labelPostav.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostav.Name = "labelPostav";
            this.labelPostav.Size = new System.Drawing.Size(96, 19);
            this.labelPostav.TabIndex = 7;
            this.labelPostav.Text = "Поставщик:";
            // 
            // buttonZakaz
            // 
            this.buttonZakaz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonZakaz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonZakaz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZakaz.Location = new System.Drawing.Point(1126, 493);
            this.buttonZakaz.Name = "buttonZakaz";
            this.buttonZakaz.Size = new System.Drawing.Size(141, 33);
            this.buttonZakaz.TabIndex = 15;
            this.buttonZakaz.Text = "Заказы";
            this.buttonZakaz.UseVisualStyleBackColor = false;
            this.buttonZakaz.Click += new System.EventHandler(this.buttonZakaz_Click);
            // 
            // labelRoleName
            // 
            this.labelRoleName.AutoSize = true;
            this.labelRoleName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoleName.Location = new System.Drawing.Point(266, 38);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(157, 24);
            this.labelRoleName.TabIndex = 16;
            this.labelRoleName.Text = "Администратор";
            // 
            // buttonAddTovar
            // 
            this.buttonAddTovar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddTovar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddTovar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTovar.Location = new System.Drawing.Point(1126, 405);
            this.buttonAddTovar.Name = "buttonAddTovar";
            this.buttonAddTovar.Size = new System.Drawing.Size(141, 33);
            this.buttonAddTovar.TabIndex = 17;
            this.buttonAddTovar.Text = "Добавить Товар";
            this.buttonAddTovar.UseVisualStyleBackColor = false;
            this.buttonAddTovar.Click += new System.EventHandler(this.buttonAddTovar_Click);
            // 
            // buttonAddZakaz
            // 
            this.buttonAddZakaz.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAddZakaz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddZakaz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddZakaz.Location = new System.Drawing.Point(1126, 532);
            this.buttonAddZakaz.Name = "buttonAddZakaz";
            this.buttonAddZakaz.Size = new System.Drawing.Size(141, 33);
            this.buttonAddZakaz.TabIndex = 18;
            this.buttonAddZakaz.Text = "Добавить Заказ";
            this.buttonAddZakaz.UseVisualStyleBackColor = false;
            this.buttonAddZakaz.Click += new System.EventHandler(this.buttonAddZakaz_Click);
            // 
            // buttonTovar
            // 
            this.buttonTovar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTovar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTovar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTovar.Location = new System.Drawing.Point(1125, 366);
            this.buttonTovar.Name = "buttonTovar";
            this.buttonTovar.Size = new System.Drawing.Size(141, 33);
            this.buttonTovar.TabIndex = 19;
            this.buttonTovar.Text = "Товары";
            this.buttonTovar.UseVisualStyleBackColor = false;
            this.buttonTovar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelFio
            // 
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.Location = new System.Drawing.Point(716, 38);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(236, 24);
            this.labelFio.TabIndex = 20;
            this.labelFio.Text = "Иван Иванов Иванович";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(53, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(115, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "ООО \"Обувь\"";
            // 
            // checkBoxDesc
            // 
            this.checkBoxDesc.AutoSize = true;
            this.checkBoxDesc.Location = new System.Drawing.Point(1125, 152);
            this.checkBoxDesc.Name = "checkBoxDesc";
            this.checkBoxDesc.Size = new System.Drawing.Size(97, 17);
            this.checkBoxDesc.TabIndex = 23;
            this.checkBoxDesc.Text = "По убыванию";
            this.checkBoxDesc.UseVisualStyleBackColor = true;
            this.checkBoxDesc.CheckedChanged += new System.EventHandler(this.checkBoxDesc_CheckedChanged);
            // 
            // checkBoxAsc
            // 
            this.checkBoxAsc.AutoSize = true;
            this.checkBoxAsc.Location = new System.Drawing.Point(1125, 175);
            this.checkBoxAsc.Name = "checkBoxAsc";
            this.checkBoxAsc.Size = new System.Drawing.Size(109, 17);
            this.checkBoxAsc.TabIndex = 24;
            this.checkBoxAsc.Text = "По возрастанию";
            this.checkBoxAsc.UseVisualStyleBackColor = true;
            this.checkBoxAsc.CheckedChanged += new System.EventHandler(this.checkBoxAsc_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1279, 587);
            this.Controls.Add(this.checkBoxAsc);
            this.Controls.Add(this.checkBoxDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.buttonTovar);
            this.Controls.Add(this.buttonAddZakaz);
            this.Controls.Add(this.buttonAddTovar);
            this.Controls.Add(this.labelRoleName);
            this.Controls.Add(this.buttonZakaz);
            this.Controls.Add(this.labelPostav);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.comboBoxPostavshik);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.textSearchBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Обувь\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textSearchBox;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.ComboBox comboBoxPostavshik;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelPostav;
        private System.Windows.Forms.Button buttonZakaz;
        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.Button buttonAddTovar;
        private System.Windows.Forms.Button buttonAddZakaz;
        private System.Windows.Forms.Button buttonTovar;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxDesc;
        private System.Windows.Forms.CheckBox checkBoxAsc;
    }
}


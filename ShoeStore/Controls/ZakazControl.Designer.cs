namespace ShoeStore
{
    partial class ZakazControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZakazControl));
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelDataZakaza = new System.Windows.Forms.Label();
            this.labelArticle = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDataDostavki = new System.Windows.Forms.Label();
            this.buttonRedactZakaz = new System.Windows.Forms.Button();
            this.buttonDeleteZakaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAdress
            // 
            resources.ApplyResources(this.labelAdress, "labelAdress");
            this.labelAdress.Name = "labelAdress";
            // 
            // labelDataZakaza
            // 
            resources.ApplyResources(this.labelDataZakaza, "labelDataZakaza");
            this.labelDataZakaza.Name = "labelDataZakaza";
            // 
            // labelArticle
            // 
            resources.ApplyResources(this.labelArticle, "labelArticle");
            this.labelArticle.Name = "labelArticle";
            // 
            // labelStatus
            // 
            resources.ApplyResources(this.labelStatus, "labelStatus");
            this.labelStatus.Name = "labelStatus";
            // 
            // labelDataDostavki
            // 
            this.labelDataDostavki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelDataDostavki, "labelDataDostavki");
            this.labelDataDostavki.Name = "labelDataDostavki";
            // 
            // buttonRedactZakaz
            // 
            this.buttonRedactZakaz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonRedactZakaz, "buttonRedactZakaz");
            this.buttonRedactZakaz.Name = "buttonRedactZakaz";
            this.buttonRedactZakaz.UseVisualStyleBackColor = false;
            this.buttonRedactZakaz.Click += new System.EventHandler(this.buttonRedactZakaz_Click);
            // 
            // buttonDeleteZakaz
            // 
            this.buttonDeleteZakaz.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.buttonDeleteZakaz, "buttonDeleteZakaz");
            this.buttonDeleteZakaz.Name = "buttonDeleteZakaz";
            this.buttonDeleteZakaz.UseVisualStyleBackColor = false;
            this.buttonDeleteZakaz.Click += new System.EventHandler(this.buttonDeleteZakaz_Click);
            // 
            // ZakazControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.buttonDeleteZakaz);
            this.Controls.Add(this.buttonRedactZakaz);
            this.Controls.Add(this.labelDataDostavki);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelDataZakaza);
            this.Controls.Add(this.labelArticle);
            this.Controls.Add(this.labelStatus);
            this.Name = "ZakazControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelDataZakaza;
        private System.Windows.Forms.Label labelArticle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelDataDostavki;
        private System.Windows.Forms.Button buttonRedactZakaz;
        private System.Windows.Forms.Button buttonDeleteZakaz;
    }
}

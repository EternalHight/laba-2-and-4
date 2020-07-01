namespace laba_2._3
{
    partial class Form1
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
            this.comboBoxZapyat = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.TextCelsius = new System.Windows.Forms.TextBox();
            this.TextKelvin = new System.Windows.Forms.TextBox();
            this.TextFahrenheit = new System.Windows.Forms.TextBox();
            this.TextReaumur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxZapyat
            // 
            this.comboBoxZapyat.FormattingEnabled = true;
            this.comboBoxZapyat.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxZapyat.Location = new System.Drawing.Point(159, 318);
            this.comboBoxZapyat.Name = "comboBoxZapyat";
            this.comboBoxZapyat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxZapyat.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "точка",
            "запятая"});
            this.comboBox2.Location = new System.Drawing.Point(376, 317);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox3.Location = new System.Drawing.Point(586, 316);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // TextCelsius
            // 
            this.TextCelsius.Location = new System.Drawing.Point(171, 102);
            this.TextCelsius.Name = "TextCelsius";
            this.TextCelsius.Size = new System.Drawing.Size(100, 20);
            this.TextCelsius.TabIndex = 3;
            this.TextCelsius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCelsius_KeyPress);
            this.TextCelsius.Leave += new System.EventHandler(this.TextCelsius_Leave);
            // 
            // TextKelvin
            // 
            this.TextKelvin.Location = new System.Drawing.Point(171, 214);
            this.TextKelvin.Name = "TextKelvin";
            this.TextKelvin.Size = new System.Drawing.Size(100, 20);
            this.TextKelvin.TabIndex = 4;
            this.TextKelvin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextKelvin_KeyPress);
            this.TextKelvin.Leave += new System.EventHandler(this.TextKelvin_Leave);
            // 
            // TextFahrenheit
            // 
            this.TextFahrenheit.Location = new System.Drawing.Point(467, 101);
            this.TextFahrenheit.Name = "TextFahrenheit";
            this.TextFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.TextFahrenheit.TabIndex = 5;
            this.TextFahrenheit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextFahrenheit_KeyPress);
            this.TextFahrenheit.Leave += new System.EventHandler(this.TextFahrenheit_Leave);
            // 
            // TextReaumur
            // 
            this.TextReaumur.Location = new System.Drawing.Point(467, 214);
            this.TextReaumur.Name = "TextReaumur";
            this.TextReaumur.Size = new System.Drawing.Size(100, 20);
            this.TextReaumur.TabIndex = 6;
            this.TextReaumur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextReaumur_KeyPress);
            this.TextReaumur.Leave += new System.EventHandler(this.TextReaumur_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Цельсий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Реамюр";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кельвин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Фаренгейт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "знаки после запятой";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextReaumur);
            this.Controls.Add(this.TextFahrenheit);
            this.Controls.Add(this.TextKelvin);
            this.Controls.Add(this.TextCelsius);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxZapyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxZapyat;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox TextCelsius;
        private System.Windows.Forms.TextBox TextKelvin;
        private System.Windows.Forms.TextBox TextFahrenheit;
        private System.Windows.Forms.TextBox TextReaumur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


namespace РасчетСтоимостьМонтажа
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.serviceComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addServiceButton = new System.Windows.Forms.Button();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveServiceButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serviceComboBox
            // 
            this.serviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceComboBox.FormattingEnabled = true;
            this.serviceComboBox.Items.AddRange(new object[] {
            "Установка отопительного прибора",
            "Прокладка труб отопления (до Ø20 мм)",
            "Установка терморегулятора",
            "Установка распределительного коллектора",
            "Заполнение системы теплоносителем (до 150 м²)",
            "Монтаж водяных «теплых полов»",
            "Сборка и монтаж радиатора отопления",
            "Сборка и монтаж внутрипольного конвектора отопления",
            "Монтаж отопительного прибора нестандартного",
            "Монтаж точки водоснабжения",
            "Монтаж распределительного коллектора водоснабжения",
            "Монтаж скважинного насоса",
            "Монтаж реле давления",
            "Монтаж термостатического регулятора"});
            this.serviceComboBox.Location = new System.Drawing.Point(6, 45);
            this.serviceComboBox.Name = "serviceComboBox";
            this.serviceComboBox.Size = new System.Drawing.Size(260, 21);
            this.serviceComboBox.TabIndex = 0;
            this.serviceComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(6, 95);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // addServiceButton
            // 
            this.addServiceButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addServiceButton.Location = new System.Drawing.Point(6, 131);
            this.addServiceButton.Name = "addServiceButton";
            this.addServiceButton.Size = new System.Drawing.Size(100, 23);
            this.addServiceButton.TabIndex = 2;
            this.addServiceButton.Text = "Добавить";
            this.addServiceButton.UseVisualStyleBackColor = false;
            this.addServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.Location = new System.Drawing.Point(12, 236);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(301, 134);
            this.serviceListBox.TabIndex = 3;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.totalCostLabel.Location = new System.Drawing.Point(12, 383);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(146, 17);
            this.totalCostLabel.TabIndex = 4;
            this.totalCostLabel.Text = "Общая стоимость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите услугу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 208);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveServiceButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serviceComboBox);
            this.groupBox1.Controls.Add(this.quantityTextBox);
            this.groupBox1.Controls.Add(this.addServiceButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 198);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор услуги";
            // 
            // RemoveServiceButton
            // 
            this.RemoveServiceButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RemoveServiceButton.Location = new System.Drawing.Point(6, 160);
            this.RemoveServiceButton.Name = "RemoveServiceButton";
            this.RemoveServiceButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveServiceButton.TabIndex = 7;
            this.RemoveServiceButton.Text = "Удалить";
            this.RemoveServiceButton.UseVisualStyleBackColor = false;
            this.RemoveServiceButton.Click += new System.EventHandler(this.RemoveServiceButton_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(362, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.serviceListBox);
            this.Name = "MainForm";
            this.Text = "Расчет стоимости монтажа";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serviceComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button addServiceButton;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveServiceButton;
    }
}

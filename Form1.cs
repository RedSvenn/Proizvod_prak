using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace РасчетСтоимостьМонтажа
{
    public partial class MainForm : Form
    {
        private Dictionary<string, double> servicePrices = new Dictionary<string, double>
        {
            {"Установка отопительного прибора", 3000},
            {"Прокладка труб отопления (до Ø20 мм)", 70},
            {"Установка терморегулятора", 300},
            {"Установка распределительного коллектора", 3500},
            {"Заполнение системы теплоносителем (до 150 м²)", 2500},
            {"Монтаж термостатического регулятора", 300},
            {"Монтаж электрокотла до 9 кВт", 8000},
            {"Монтаж водяных «теплых полов»", 500},
            {"Сборка и монтаж радиатора отопления", 2000},
            {"Сборка и монтаж внутрипольного конвектора отопления", 2500},
            {"Монтаж отопительного прибора нестандартного", 3000},
            {"Монтаж точки водоснабжения", 1000},
            {"Монтаж распределительного коллектора водоснабжения", 3500},
            {"Монтаж скважинного насоса", 6500},
            {"Монтаж реле давления", 2250},
        };

        private List<Service> selectedServices = new List<Service>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите услугу из списка.");
                    return;
                }

                string selectedService = serviceComboBox.SelectedItem.ToString();
                if (string.IsNullOrWhiteSpace(quantityTextBox.Text) || !double.TryParse(quantityTextBox.Text, out double quantity) || quantity <= 0)
                {
                    MessageBox.Show("Введите корректное количество.");
                    return;
                }

                double price = servicePrices[selectedService];
                selectedServices.Add(new Service { Name = selectedService, Quantity = quantity, Price = price });

                UpdateServiceList();
                UpdateTotalCost();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void UpdateServiceList()
        {
            serviceListBox.Items.Clear();
            foreach (var service in selectedServices)
            {
                serviceListBox.Items.Add($"{service.Name} - {service.Quantity} ед. - {service.TotalCost} руб.");
            }
        }

        private void UpdateTotalCost()
        {
            double totalCost = 0;
            foreach (var service in selectedServices)
            {
                totalCost += service.TotalCost;
            }
            totalCostLabel.Text = $"Общая стоимость: {totalCost} руб.";
        }

     

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Load initialization code if needed
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle quantity text changes if needed
        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle service combo box selection changes if needed
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel paint event if needed
        }

        public class Service
        {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public double Price { get; set; }
            public double TotalCost => Quantity * Price;
        }

        private void RemoveServiceButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (serviceListBox.SelectedIndex != -1)
                {
                    selectedServices.RemoveAt(serviceListBox.SelectedIndex);
                    UpdateServiceList();
                    UpdateTotalCost();
                }
                else
                {
                    MessageBox.Show("Выберите элемент для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при удалении: {ex.Message}");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowManagerApp;

namespace c_
{
    public partial class Form1 : Form
    {
        WindowList desktop = new WindowList();

        public Form1()
        {
            InitializeComponent();

            // 1. Вимикаємо кнопку при старті
            btnAdd.Enabled = false;

            // 2. Підписуємо всі поля на одну подію перевірки
            txtX1.TextChanged += ValidateInputs;
            txtY1.TextChanged += ValidateInputs;
            txtX2.TextChanged += ValidateInputs;
            txtY2.TextChanged += ValidateInputs;
            txtBg.TextChanged += ValidateInputs;
            txtTitle.TextChanged += ValidateInputs;
            txtTextCol.TextChanged += ValidateInputs;
        }

        // Метод, який перевіряє, чи всі поля заповнені
        private void ValidateInputs(object sender, EventArgs e)
        {
            // Перевіряємо кожне поле на порожнечу або пробіли
            bool allFilled = !string.IsNullOrWhiteSpace(txtX1.Text) &&
                             !string.IsNullOrWhiteSpace(txtY1.Text) &&
                             !string.IsNullOrWhiteSpace(txtX2.Text) &&
                             !string.IsNullOrWhiteSpace(txtY2.Text) &&
                             !string.IsNullOrWhiteSpace(txtBg.Text) &&
                             !string.IsNullOrWhiteSpace(txtTitle.Text) &&
                             !string.IsNullOrWhiteSpace(txtTextCol.Text);

            // Кнопка стає активною тільки якщо все заповнено
            btnAdd.Enabled = allFilled;
        }

        private void RefreshList()
        {
            lstWindows.Items.Clear();
            foreach (var w in desktop.GetAll())
            {
                lstWindows.Items.Add(w.GetInfo());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int x1 = int.Parse(txtX1.Text);
                int y1 = int.Parse(txtY1.Text);
                int x2 = int.Parse(txtX2.Text);
                int y2 = int.Parse(txtY2.Text);

                if (x2 <= x1 || y2 <= y1)
                {
                    MessageBox.Show("Помилка: x2 має бути > x1, а y2 > y1");
                    return;
                }

                var tw = new TitleWindow(x1, y1, x2, y2, txtBg.Text, txtTitle.Text, txtTextCol.Text);
                desktop.AddWindow(tw);
                RefreshList();

                // Очищаємо поля після додавання (за бажанням)
                ClearInputs();
            }
            catch { MessageBox.Show("Введіть коректні числа в поля координат!"); }
        }

        // Допоміжний метод для очищення полів
        private void ClearInputs()
        {
            txtX1.Clear(); txtY1.Clear(); txtX2.Clear(); txtY2.Clear();
            txtBg.Clear(); txtTitle.Clear(); txtTextCol.Clear();
        }

        private void btnFocus_Click(object sender, EventArgs e)
        {
            if (lstWindows.SelectedIndex != -1)
            {
                desktop.SetFocus(lstWindows.SelectedIndex);
                RefreshList();
                lstWindows.SelectedIndex = 0;
            }
        }

        private void btnChangeStyle_Click(object sender, EventArgs e)
        {
            if (lstWindows.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть вікно у списку!");
                return;
            }

            Window selected = desktop.GetAll()[lstWindows.SelectedIndex];
            string message = selected.SetStyle(txtNewColor.Text);

            MessageBox.Show(message, "Поліморфна дія");
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            desktop.Save("data.txt");
            MessageBox.Show("Дані збережено у файл data.txt");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            desktop.Load("data.txt");
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstWindows.SelectedIndex != -1)
            {
                desktop.RemoveWindow(lstWindows.SelectedIndex);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Виберіть вікно для закриття!");
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
}
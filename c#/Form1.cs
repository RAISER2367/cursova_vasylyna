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
            btnAdd.Enabled = false;

            txtX1.TextChanged += ValidateInputs;
            txtY1.TextChanged += ValidateInputs;
            txtX2.TextChanged += ValidateInputs;
            txtY2.TextChanged += ValidateInputs;
            txtBg.TextChanged += ValidateInputs;
            txtTitle.TextChanged += ValidateInputs;
            txtTextCol.TextChanged += ValidateInputs;

            // Автозавантаження при запуску (Вимога 7)
            desktop.Load("data.txt");
            RefreshList();
        }

        private void ValidateInputs(object sender, EventArgs e)
        {
            bool allFilled = !string.IsNullOrWhiteSpace(txtX1.Text) &&
                             !string.IsNullOrWhiteSpace(txtY1.Text) &&
                             !string.IsNullOrWhiteSpace(txtX2.Text) &&
                             !string.IsNullOrWhiteSpace(txtY2.Text) &&
                             !string.IsNullOrWhiteSpace(txtBg.Text) &&
                             !string.IsNullOrWhiteSpace(txtTitle.Text) &&
                             !string.IsNullOrWhiteSpace(txtTextCol.Text);

            btnAdd.Enabled = allFilled;
        }

        private void RefreshList()
        {
            lstWindows.Items.Clear();
            foreach (var w in desktop)
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
                ClearInputs();
            }
            catch { MessageBox.Show("Введіть коректні числа в поля координат!"); }
        }

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

            int currentIndex = 0;
            Window selected = null;

            foreach (var w in desktop)
            {
                if (currentIndex == lstWindows.SelectedIndex)
                {
                    selected = w;
                    break;
                }
                currentIndex++;
            }

            if (selected != null)
            {
                string message = selected.SetStyle(txtNewColor.Text); // Поліморфізм
                MessageBox.Show(message, "Поліморфна дія");
                RefreshList();
            }
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

        // =========================================================
        // НОВІ ОБРОБНИКИ ДЛЯ ДЕМОНСТРАЦІЇ ПЕРЕВАНТАЖЕННЯ ОПЕРАТОРІВ
        // (Створіть ці дві кнопки на формі)
        // =========================================================

        private void btnShift_Click(object sender, EventArgs e)
        {
            if (lstWindows.SelectedIndex != -1)
            {
                desktop.ShiftWindow(lstWindows.SelectedIndex, 15); // Зсув на 15 пікселів
                MessageBox.Show("Координати обраного вікна зсунуто на +15 (Демонстрація оператора +=)");
                RefreshList();
            }
            else
            {
                MessageBox.Show("Виберіть вікно для зсуву!");
            }
        }

        private void btnCombine_Click(object sender, EventArgs e)
        {
            if (lstWindows.Items.Count >= 2)
            {
                TitleWindow combined = desktop.CombineWindows(0, 1);
                MessageBox.Show("Результат накладання перших двох вікон (Спільна оболонка):\n" + combined.GetInfo(), "Демонстрація оператора +");
            }
            else
            {
                MessageBox.Show("Для демонстрації накладання потрібно мінімум 2 вікна у списку!");
            }
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
}
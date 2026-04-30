using System;

namespace WindowManagerApp
{
    public class Window
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public string BgColor { get; set; }

        public Window() { }

        public Window(int x1, int y1, int x2, int y2, string color)
        {
            X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;
            BgColor = color;
        }

        // Конструктор копіювання
        public Window(Window other)
        {
            X1 = other.X1; Y1 = other.Y1;
            X2 = other.X2; Y2 = other.Y2;
            BgColor = string.Copy(other.BgColor);
        }

        // Перевантаження операції + (накладання двох вікон)
        public static Window operator +(Window a, Window b)
        {
            return new Window(
                Math.Min(a.X1, b.X1), Math.Min(a.Y1, b.Y1),
                Math.Max(a.X2, b.X2), Math.Max(a.Y2, b.Y2),
                a.BgColor
            );
        }

        // Перевантаження операції + для числа (автоматично дає змогу використовувати += для зсуву)
        public static Window operator +(Window w, int shift)
        {
            return new Window(w.X1 + shift, w.Y1 + shift, w.X2 + shift, w.Y2 + shift, w.BgColor);
        }

        // ВІРТУАЛЬНИЙ МЕТОД (для Поліморфізму)
        public virtual string SetStyle(string color)
        {
            this.BgColor = color; // У базовому класі змінюємо ФОН
            return "Колір фону вікна змінено на " + color;
        }

        public virtual string GetInfo()
        {
            return $"Вікно: ({X1},{Y1}) to ({X2},{Y2}) | Фон: {BgColor}";
        }

        // Аналог оператора << для збереження у файл
        public override string ToString()
        {
            return $"{X1};{Y1};{X2};{Y2};{BgColor}";
        }
    }
}
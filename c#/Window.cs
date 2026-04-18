using System;

namespace WindowManagerApp
{
    public class Window
    {
        // Координати та колір фону
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public string BgColor { get; set; }

        public Window(int x1, int y1, int x2, int y2, string color)
        {
            X1 = x1; Y1 = y1; X2 = x2; Y2 = y2;
            BgColor = color;
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
    }
}
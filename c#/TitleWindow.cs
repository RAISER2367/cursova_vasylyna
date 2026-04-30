using System;

namespace WindowManagerApp
{
    public class TitleWindow : Window
    {
        public string Title { get; set; }
        public string TextColor { get; set; }

        public TitleWindow() : base() { }

        public TitleWindow(int x1, int y1, int x2, int y2, string bCol, string title, string tCol)
            : base(x1, y1, x2, y2, bCol)
        {
            Title = title;
            TextColor = tCol;
        }

        // Конструктор копіювання
        public TitleWindow(TitleWindow other) : base(other)
        {
            Title = string.Copy(other.Title);
            TextColor = string.Copy(other.TextColor);
        }

        // Перевантаження + для зсуву
        public static TitleWindow operator +(TitleWindow tw, int shift)
        {
            return new TitleWindow(
                tw.X1 + shift, tw.Y1 + shift,
                tw.X2 + shift, tw.Y2 + shift,
                tw.BgColor, tw.Title, tw.TextColor
            );
        }

        // Перевантаження + для накладання
        public static TitleWindow operator +(TitleWindow a, TitleWindow b)
        {
            Window combinedBase = (Window)a + (Window)b;
            return new TitleWindow(combinedBase.X1, combinedBase.Y1, combinedBase.X2, combinedBase.Y2, combinedBase.BgColor, "Combined", "Red");
        }

        // ПЕРЕВИЗНАЧЕННЯ МЕТОДУ (Пізнє зв'язування)
        public override string SetStyle(string color)
        {
            this.TextColor = color; // У похідному класі змінюємо ТЕКСТ
            return "Колір тексту заголовка '" + Title + "' змінено на " + color;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" | Заголовок: {Title} | Текст: {TextColor}";
        }

        // Аналог оператора << 
        public override string ToString()
        {
            return base.ToString() + $";{Title};{TextColor}";
        }

        // Аналог оператора >> (читання з рядка)
        public static TitleWindow Parse(string data)
        {
            string[] p = data.Split(';');
            if (p.Length == 7)
            {
                return new TitleWindow(int.Parse(p[0]), int.Parse(p[1]), int.Parse(p[2]), int.Parse(p[3]), p[4], p[5], p[6]);
            }
            throw new FormatException("Невірний формат рядка.");
        }
    }
}
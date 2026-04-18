namespace WindowManagerApp
{
    public class TitleWindow : Window
    {
        public string Title { get; set; }
        public string TextColor { get; set; }

        public TitleWindow(int x1, int y1, int x2, int y2, string bCol, string title, string tCol)
            : base(x1, y1, x2, y2, bCol)
        {
            Title = title;
            TextColor = tCol;
        }

        // ПЕРЕВИЗНАЧЕННЯ МЕТОДУ (Пізнє зв'язування)
        public override string SetStyle(string color)
        {
            this.TextColor = color; // У похідному класі змінюємо ТЕКСТ
            return "Колір тексту заголовка '" + Title + "' змінено на " + color;
        }

        public override string GetInfo()
        {
            // Викликаємо базову інфо + додаємо своє
            return base.GetInfo() + $" | Заголовок: {Title} | Текст: {TextColor}";
        }
    }
}
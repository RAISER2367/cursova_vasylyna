using System;
using System.Collections.Generic;
using System.IO;

namespace WindowManagerApp
{
    public class WindowList
    {
        private List<TitleWindow> windows = new List<TitleWindow>();

        // Метод додавання (нове вікно завжди стає першим)
        public void AddWindow(TitleWindow tw)
        {
            windows.Insert(0, tw);
        }

        // Метод зміни фокусу (переміщення на 0 позицію)
        public void SetFocus(int index)
        {
            if (index > 0 && index < windows.Count)
            {
                TitleWindow selected = windows[index];
                windows.RemoveAt(index);
                windows.Insert(0, selected);
            }
        }

        public void RemoveWindow(int index)
        {
            if (index >= 0 && index < windows.Count) windows.RemoveAt(index);
        }

        // Доступ до списку (для циклів)
        public List<TitleWindow> GetAll() => windows;

        // Робота з файлом
        public void Save(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var w in windows)
                    sw.WriteLine($"{w.X1};{w.Y1};{w.X2};{w.Y2};{w.BgColor};{w.Title};{w.TextColor}");
            }
        }

        public void Load(string filename)
        {
            if (!File.Exists(filename)) return;
            windows.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                var p = line.Split(';');
                if (p.Length == 7)
                    windows.Add(new TitleWindow(int.Parse(p[0]), int.Parse(p[1]), int.Parse(p[2]), int.Parse(p[3]), p[4], p[5], p[6]));
            }
        }
    }
}
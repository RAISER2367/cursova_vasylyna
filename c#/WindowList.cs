using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WindowManagerApp
{
    // Реалізуємо IEnumerable для підтримки foreach
    public class WindowList : IEnumerable<TitleWindow>
    {
        private List<TitleWindow> windows = new List<TitleWindow>();

        public void AddWindow(TitleWindow tw)
        {
            windows.Insert(0, tw);
        }

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

        // --- РЕАЛІЗАЦІЯ ІТЕРАТОРА ---

        public IEnumerator<TitleWindow> GetEnumerator()
        {
            return new WindowIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Внутрішній КЛАС-ІТЕРАТОР
        private class WindowIterator : IEnumerator<TitleWindow>
        {
            private readonly WindowList _collection;
            private int _currentIndex;

            public WindowIterator(WindowList collection)
            {
                _collection = collection;
                _currentIndex = -1; // Початковий стан перед першим елементом
            }

            public TitleWindow Current => _collection.windows[_currentIndex];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                _currentIndex++;
                return _currentIndex < _collection.windows.Count;
            }

            public void Reset()
            {
                _currentIndex = -1;
            }

            public void Dispose()
            {
                // Тут можна звільняти ресурси, якщо вони є, але для List це не потрібно
            }
        }
    }
}
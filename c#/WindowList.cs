using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace WindowManagerApp
{
    public class WindowList : IEnumerable<TitleWindow>
    {
        private List<TitleWindow> windows = new List<TitleWindow>();

        public void AddWindow(TitleWindow tw)
        {
            windows.Insert(0, tw); // Додавання на нульову позицію
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

        // Демонстрація зсуву (оператор +=)
        public void ShiftWindow(int index, int offset)
        {
            if (index >= 0 && index < windows.Count)
            {
                windows[index] += offset;
            }
        }

        // Демонстрація накладання (оператор +)
        public TitleWindow CombineWindows(int index1, int index2)
        {
            if (index1 >= 0 && index1 < windows.Count && index2 >= 0 && index2 < windows.Count)
            {
                return windows[index1] + windows[index2];
            }
            return null;
        }

        public void Save(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (var w in windows)
                    sw.WriteLine(w.ToString()); // Використовуємо аналог <<
            }
        }

        public void Load(string filename)
        {
            if (!File.Exists(filename)) return;
            windows.Clear();
            string[] lines = File.ReadAllLines(filename);

            // Читаємо з кінця, щоб при вставці на нульову позицію зберігся правильний порядок
            for (int i = lines.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                    AddWindow(TitleWindow.Parse(lines[i])); // Використовуємо аналог >>
            }
        }

        // --- РЕАЛІЗАЦІЯ ІТЕРАТОРА (Без змін) ---
        public IEnumerator<TitleWindow> GetEnumerator()
        {
            return new WindowIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class WindowIterator : IEnumerator<TitleWindow>
        {
            private readonly WindowList _collection;
            private int _currentIndex;

            public WindowIterator(WindowList collection)
            {
                _collection = collection;
                _currentIndex = -1;
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

            public void Dispose() { }
        }
    }
}
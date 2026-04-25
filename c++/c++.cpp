#include "WindowList.h"
#include <iostream>
#include <string>
#include <Windows.h>

using namespace std;

int main() {
    // Налаштування для коректного відображення кирилиці
    SetConsoleCP(65001);
    SetConsoleOutputCP(65001);

    WindowList manager;
    int choice;

    while (true) {
        cout << "\n--- ГОЛОВНЕ МЕНЮ ПРОГРАМИ ---" << endl;
        cout << "1. Додати нове вікно" << endl;
        cout << "2. Вивести список усіх вікон" << endl;
        cout << "3. Встановити фокус на вікно (перемістити в початок)" << endl;
        cout << "4. Закрити вікно (видалити за номером)" << endl;
        cout << "5. Оновити стиль оформлення" << endl;
        cout << "6. Зберегти або завантажити дані" << endl;
        cout << "0. Вихід" << endl;
        cout << "-----------------------------" << endl;
        cout << "Ваш вибір: ";

        if (!(cin >> choice)) {
            cin.clear();
            cin.ignore(10000, '\n');
            continue;
        }

        if (choice == 0) break;

        switch (choice) {
        case 1: {
            int x1, y1, x2, y2;
            string bg, title, textCol;

            cout << "\nВведіть координати діагоналі (x1 y1 x2 y2): ";
            cin >> x1 >> y1 >> x2 >> y2;

            // Проста перевірка валідності координат
            if (x2 <= x1 || y2 <= y1) {
                cout << "Помилка: координати x2 та y2 мають бути більшими за x1 та y1!" << endl;
            }
            else {
                cout << "Колір фону: "; cin >> bg;
                cout << "Текст заголовка: "; cin >> title;
                cout << "Колір тексту заголовка: "; cin >> textCol;

                manager.open(TitleWindow(x1, y1, x2, y2, bg, title, textCol));
                cout << "Вікно успішно додано." << endl;
            }
            break;
        }

        case 2:
            cout << "\nСПИСОК ВІДКРИТИХ ВІКОН:" << endl;
            manager.displayAll();
            break;

        case 3: {
            int idx;
            cout << "Введіть номер вікна для перенесення у фокус: ";
            cin >> idx;
            manager.setFocus(idx);
            cout << "Фокус змінено (вікно тепер під номером 0)." << endl;
            break;
        }

        case 4: {
            int idx;
            cout << "Введіть номер вікна для закриття: ";
            cin >> idx;
            manager.close(idx);
            cout << "Вікно видалено." << endl;
            break;
        }

        case 5: {
            string newColor;
            cout << "Введіть новий колір для масового оновлення: ";
            cin >> newColor;

            // Демонстрація поліморфізму: проходимо по списку через ітератор
            // і викликаємо метод через вказівник на базовий клас
            for (auto it = manager.begin(); it != manager.end(); ++it) {
                Window* basePtr = &(*it); // Вказівник базового типу
                basePtr->setColor(newColor); // Викличеться setColor з TitleWindow
            }
            cout << "Стиль усіх вікон оновлено" << endl;
            break;
        }

        case 6: {
            int op;
            cout << "1 - Зберегти у файл, 2 - Завантажити з файлу: ";
            cin >> op;
            if (op == 1) {
                manager.save("windows_data.txt");
                cout << "Дані збережено." << endl;
            }
            else {
                manager.load("windows_data.txt");
                cout << "Дані завантажено." << endl;
            }
            break;
        }

        default:
            cout << "Невірний пункт меню!" << endl;
            break;
        }
    }

    return 0;
}
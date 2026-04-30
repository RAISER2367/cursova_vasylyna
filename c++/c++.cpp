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
    manager.load("windows_data.txt"); // Додано автозавантаження

    int choice;

    while (true) {
        cout << "\n--- ГОЛОВНЕ МЕНЮ ПРОГРАМИ ---" << endl;
        cout << "1. Додати нове вікно" << endl;
        cout << "2. Вивести список усіх вікон" << endl;
        cout << "3. Встановити фокус на вікно" << endl;
        cout << "4. Закрити вікно" << endl;
        cout << "5. Оновити стиль" << endl;
        cout << "6. Зберегти дані у файл" << endl;
        cout << "7. Оператори накладання та зміщення" << endl;
        cout << "0. Вихід" << endl;
        cout << "-----------------------------" << endl;
        cout << "Ваш вибір: ";

        if (!(cin >> choice)) {
            cin.clear();
            cin.ignore(10000, '\n');
            continue;
        }

        if (choice == 0) {
            manager.save("windows_data.txt"); // Автозбереження при виході
            break;
        }

        switch (choice) {
        case 1: {
            int x1, y1, x2, y2;
            string bg, title, textCol;

            cout << "\nВведіть координати діагоналі (x1 y1 x2 y2): ";
            cin >> x1 >> y1 >> x2 >> y2;

            if (!Window::isValid(x1, y1, x2, y2)) {
                cout << "Помилка: координати x2 та y2 мають бути більшими за x1 та y1!" << endl;
            }
            else {
                cout << "Колір фону (без пробілів): "; cin >> bg;
                cout << "Текст заголовка (без пробілів): "; cin >> title;
                cout << "Колір тексту заголовка: "; cin >> textCol;

                manager.open(TitleWindow(x1, y1, x2, y2, bg, title, textCol));
                cout << "Вікно успішно відкрито." << endl;
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
            cout << "Введіть новий колір для оновлення: ";
            cin >> newColor;

            for (auto it = manager.begin(); it != manager.end(); ++it) {
                Window* basePtr = &(*it);
                basePtr->setColor(newColor);
            }
            cout << "Стиль усіх вікон оновлено" << endl;
            break;
        }

        case 6: {
            manager.save("windows_data.txt");
            cout << "Дані збережено." << endl;
            break;
        }

        case 7: {
            cout << "\n--- Демонстрація перевантаження операторів ---" << endl;
            Window w1(10, 10, 50, 50, "Red");
            Window w2(20, 20, 60, 60, "Blue");
            cout << "Вікно 1: " << w1 << endl;
            cout << "Вікно 2: " << w2 << endl;

            Window w3 = w1 + w2;
            cout << "Результат об'єднання через оператор +: \n" << w3 << endl;

            cout << "\nЗсув координат через оператор += :" << endl;
            cout << "До зсуву: " << w1 << endl;
            w1 += 15;
            cout << "Після зсуву на +15: " << w1 << endl;
            break;
        }

        default:
            cout << "Невірний пункт меню!" << endl;
            break;
        }
    }

    return 0;
}
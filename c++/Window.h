#ifndef WINDOW_H
#define WINDOW_H

#include <iostream>
#include <string>
#include <algorithm>

class Window {
protected:
    int x1, y1, x2, y2;
    std::string bgColor;

public:
    Window(int x1 = 0, int y1 = 0, int x2 = 100, int y2 = 100, std::string color = "White");
    virtual ~Window() {}

    // Валідація координат
    static bool isValid(int x1, int y1, int x2, int y2) { return (x2 > x1 && y2 > y1); }

    // МЕТОДИ ДЛЯ ЧИТАННЯ ТА ЗМІНИ (Геттери і Сетери)
    int getX1() const; void setX1(int v);
    int getY1() const; void setY1(int v);
    int getX2() const; void setX2(int v);
    int getY2() const; void setY2(int v);
    std::string getBgColor() const;

    // ВІРТУАЛЬНИЙ МЕТОД (Основа поліморфізму)
    virtual void setColor(std::string color);
    virtual void display() const;

    // Оператори за завданням
    Window operator+(const Window& other) const; // Накладання
    friend void operator+=(Window& w, int shift); // Зміна координат

    // Оператори присвоєння
    Window& operator=(const Window& other);      // Копіювання
    Window& operator=(Window&& other) noexcept;  // Переміщення

    // Конструктор копіювання
    Window(const Window& other);

    // Конструктор переміщення
    Window(Window&& other) noexcept;

    // Потокові операції
    friend std::ostream& operator<<(std::ostream& os, const Window& w);
    friend std::istream& operator>>(std::istream& is, Window& w);
};

#endif
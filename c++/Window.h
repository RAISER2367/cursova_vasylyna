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

    // ВІРТУАЛЬНИЙ МЕТОД (Основа поліморфізму)
    virtual void setColor(std::string color);
    virtual void display() const;

    // Оператори за завданням
    Window operator+(const Window& other) const; // Накладання
    friend void operator+=(Window& w, int shift); // Зміна координат
    Window& operator=(const Window& other);      // Присвоєння

    // Потокові операції
    friend std::ostream& operator<<(std::ostream& os, const Window& w);
    friend std::istream& operator>>(std::istream& is, Window& w);
};

#endif
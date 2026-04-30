#ifndef TITLE_WINDOW_H
#define TITLE_WINDOW_H

#include "Window.h"

class TitleWindow : public Window {
private:
    std::string title;
    std::string textColor;

public:
    TitleWindow();
    TitleWindow(int x1, int y1, int x2, int y2, std::string bCol, std::string tText, std::string tCol);

    // Додано конструктори копіювання, переміщення та деструктор
    TitleWindow(const TitleWindow& other);
    TitleWindow(TitleWindow&& other) noexcept;
    TitleWindow& operator=(const TitleWindow& other);
    TitleWindow& operator=(TitleWindow&& other) noexcept;
    ~TitleWindow() override {}

    // Геттери та сетери
    std::string getTitle() const;
    void setTitle(const std::string& t);
    std::string getTextColor() const;

    // ПЕРЕВИЗНАЧЕННЯ (Демонстрація пізнього зв'язування)
    void setColor(std::string color) override;
    void display() const override;

    friend std::ostream& operator<<(std::ostream& os, const TitleWindow& tw);
    friend std::istream& operator>>(std::istream& is, TitleWindow& tw);
};

#endif
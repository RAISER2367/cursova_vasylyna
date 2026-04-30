#include "TitleWindow.h"

TitleWindow::TitleWindow() : Window(), title("Без заголовка"), textColor("Black") {}

TitleWindow::TitleWindow(int x1, int y1, int x2, int y2, std::string bCol, std::string tText, std::string tCol)
    : Window(x1, y1, x2, y2, bCol), title(tText), textColor(tCol) {
}

// Конструктор копіювання
TitleWindow::TitleWindow(const TitleWindow& other)
    : Window(other), title(other.title), textColor(other.textColor) {
}

// Конструктор переміщення
TitleWindow::TitleWindow(TitleWindow&& other) noexcept
    : Window(std::move(other)), title(std::move(other.title)), textColor(std::move(other.textColor)) {
}

// Оператор присвоєння
TitleWindow& TitleWindow::operator=(const TitleWindow& other) {
    if (this != &other) {
        Window::operator=(other);
        title = other.title;
        textColor = other.textColor;
    }
    return *this;
}

// Оператор присвоєння з переміщенням
TitleWindow& TitleWindow::operator=(TitleWindow&& other) noexcept {
    if (this != &other) {
        Window::operator=(std::move(other));
        title = std::move(other.title);
        textColor = std::move(other.textColor);
    }
    return *this;
}

std::string TitleWindow::getTitle() const { return title; }
void TitleWindow::setTitle(const std::string& t) { title = t; }
std::string TitleWindow::getTextColor() const { return textColor; }

void TitleWindow::setColor(std::string color) {
    this->textColor = color; // У похідному класі змінюємо КОЛІР ТЕКСТУ
}

void TitleWindow::display() const {
    Window::display();
    std::cout << " | Заголовок: \"" << title << "\", Текст: " << textColor;
}

std::ostream& operator<<(std::ostream& os, const TitleWindow& tw) {
    os << static_cast<const Window&>(tw) << " " << tw.title << " " << tw.textColor;
    return os;
}

std::istream& operator>>(std::istream& is, TitleWindow& tw) {
    is >> static_cast<Window&>(tw) >> tw.title >> tw.textColor;
    return is;
}
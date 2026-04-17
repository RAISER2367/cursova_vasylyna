#include "TitleWindow.h"

TitleWindow::TitleWindow() : Window(), title("Без заголовка"), textColor("Black") {}

TitleWindow::TitleWindow(int x1, int y1, int x2, int y2, std::string bCol, std::string tText, std::string tCol)
    : Window(x1, y1, x2, y2, bCol), title(tText), textColor(tCol) {
}

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
#include "Window.h"

Window::Window(int x1, int y1, int x2, int y2, std::string color)
    : x1(x1), y1(y1), x2(x2), y2(y2), bgColor(color) {
}

// Реалізація геттерів та сетерів
int Window::getX1() const { return x1; }
void Window::setX1(int v) { x1 = v; }
int Window::getY1() const { return y1; }
void Window::setY1(int v) { y1 = v; }
int Window::getX2() const { return x2; }
void Window::setX2(int v) { x2 = v; }
int Window::getY2() const { return y2; }
void Window::setY2(int v) { y2 = v; }
std::string Window::getBgColor() const { return bgColor; }

void Window::setColor(std::string color) {
    this->bgColor = color; // У базовому класі змінюємо ФОН
}

void Window::display() const {
    std::cout << "Вікно: [(" << x1 << "," << y1 << "), (" << x2 << "," << y2 << ")]. Фон: " << bgColor;
}

Window::Window(const Window& other)
    : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2), bgColor(other.bgColor) {
}

Window::Window(Window&& other) noexcept
    : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2), bgColor(std::move(other.bgColor)) {
    // Після переміщення "зануляємо" дані старого об'єкта
    other.x1 = 0; other.y1 = 0; other.x2 = 0; other.y2 = 0;
}

Window Window::operator+(const Window& other) const {
    return Window(std::min(x1, other.x1), std::min(y1, other.y1),
        std::max(x2, other.x2), std::max(y2, other.y2), bgColor);
}

void operator+=(Window& w, int shift) {
    w.x1 += shift; w.y1 += shift; w.x2 += shift; w.y2 += shift;
}

Window& Window::operator=(const Window& other) {
    if (this != &other) {
        x1 = other.x1; y1 = other.y1; x2 = other.x2; y2 = other.y2;
        bgColor = other.bgColor;
    }
    return *this;
}

// Оператор присвоєння з переміщенням
Window& Window::operator=(Window&& other) noexcept {
    if (this != &other) {
        x1 = other.x1; y1 = other.y1; x2 = other.x2; y2 = other.y2;
        bgColor = std::move(other.bgColor);
        other.x1 = 0; other.y1 = 0; other.x2 = 0; other.y2 = 0;
    }
    return *this;
}

std::ostream& operator<<(std::ostream& os, const Window& w) {
    os << w.x1 << " " << w.y1 << " " << w.x2 << " " << w.y2 << " " << w.bgColor;
    return os;
}

std::istream& operator>>(std::istream& is, Window& w) {
    is >> w.x1 >> w.y1 >> w.x2 >> w.y2 >> w.bgColor;
    return is;
}
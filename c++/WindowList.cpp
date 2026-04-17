#include "WindowList.h"

void WindowList::setFocus(int idx) {
    if (idx > 0 && idx < (int)windows.size()) {
        TitleWindow temp = windows[idx];
        windows.erase(windows.begin() + idx);
        windows.insert(windows.begin(), temp);
    }
}

void WindowList::displayAll() const {
    for (size_t i = 0; i < windows.size(); ++i) {
        std::cout << "[" << i << "] ";
        // ВИКЛИК ЧЕРЕЗ ВКАЗІВНИК БАЗОВОГО КЛАСУ (Поліморфізм)
        const Window* poly = &windows[i];
        poly->display();
        std::cout << std::endl;
    }
}

void WindowList::save(std::string path) const {
    std::ofstream fs(path);
    fs << windows.size() << "\n";
    for (const auto& w : windows) fs << w << "\n";
}

void WindowList::load(std::string path) {
    std::ifstream fs(path);
    if (!fs) return;
    int n; fs >> n;
    windows.clear();
    for (int i = 0; i < n; ++i) {
        TitleWindow tw; fs >> tw;
        windows.push_back(tw);
    }
}
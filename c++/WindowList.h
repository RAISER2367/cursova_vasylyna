#ifndef WINDOW_LIST_H
#define WINDOW_LIST_H

#include "TitleWindow.h"
#include <vector>
#include <fstream>

// Ітератор за завданням
class WindowIterator {
    TitleWindow* ptr;
public:
    WindowIterator(TitleWindow* p) : ptr(p) {}
    TitleWindow& operator*() { return *ptr; }
    WindowIterator& operator++() { ptr++; return *this; }
    bool operator!=(const WindowIterator& other) const { return ptr != other.ptr; }
};

class WindowList {
private:
    std::vector<TitleWindow> windows;

public:
    void open(const TitleWindow& w) { windows.insert(windows.begin(), w); }
    void close(int idx) { if (idx >= 0 && idx < (int)windows.size()) windows.erase(windows.begin() + idx); }
    void setFocus(int idx);



    void displayAll() const;
    void save(std::string path) const;
    void load(std::string path);

    WindowIterator begin() { return WindowIterator(windows.empty() ? nullptr : &windows[0]); }
    WindowIterator end() { return WindowIterator(windows.empty() ? nullptr : &windows[0] + windows.size()); }
    size_t count() const { return windows.size(); }
};

#endif
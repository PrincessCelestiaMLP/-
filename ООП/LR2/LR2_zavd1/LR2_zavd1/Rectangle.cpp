#include "Rectangle.h"
//test
#include <iostream>
#include <stdexcept>
#include <iomanip>
using namespace  std;
// Конструктор з параметрами
Rectangle::Rectangle(int a, int b) : a_(a), b_(b) {
    set_a(a);
    set_b(b);
}

// Вивід сторін
void Rectangle::Print(bool T) const {
    cout << setw(5) << "|" << setw(5) << a_
        << setw(5) << "|" << setw(5) << b_
        << setw(5) << "|" << setw(5) << perimeter()
        << setw(5) << "|" << setw(5) << area()
        << setw(5) << "|" << setw(5) << (T ? "Так" : "Ні") << endl;

}
Rectangle::~Rectangle() {
    cout << "Видаленно масив даних" << endl;
}
// Периметр
int Rectangle::perimeter() const {
    return 2 * (a_ + b_);
}
Rectangle::Rectangle(const Rectangle& other) : a_(other.a_), b_(other.b_) {
    cout << "копію зробленно" << endl;
}
// Площа
int Rectangle::area() const {
    return a_ * b_;
}
void Rectangle::Init() {
    double a, b;
n:
    cout << "Введіть сторону а" << endl;
    cin >> a;
    cout << "Введіть сторону b" << endl;
    cin >> b;
    set_a(a);
    set_b(b);
}
void Rectangle::set_a(double a) {

    if (a <= 0) throw std::invalid_argument("Сторона a має бути > 0");
    a_ = a;
}
void Rectangle::set_b(double b) {
    if (b <= 0) throw std::invalid_argument("Сторона b має бути > 0");
    b_ = b;
}

// Перевантаження операторів

Rectangle Rectangle::operator++() {
    ++a_;
    ++b_;
    return *this;
}
Rectangle Rectangle::operator++(int) {
    Rectangle temp = *this;
    a_++;
    b_++;
    return temp;
}
Rectangle Rectangle::operator--() {
    --a_;
    --b_;
    if (a_ <= 0 || b_ <= 0) throw invalid_argument("Сторони не можуть бути <= 0");
    return *this;
}
Rectangle Rectangle::operator--(int) {
    Rectangle temp = *this;
    a_--;
    b_--;
    if (a_ <= 0 || b_ <= 0) throw invalid_argument("Сторони не можуть бути <= 0");
    return temp;
}
Rectangle Rectangle::operator*(int scalar) const {
    if (scalar <= 0) throw invalid_argument("Сторони не можуть бути <= 0");
    return Rectangle(a_ * scalar, b_ * scalar);
}


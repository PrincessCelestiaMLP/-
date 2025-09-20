#include "Rectangle.h"

#include <iostream>
#include <stdexcept>
#include <iomanip>
extern bool T;
using namespace  std;
// ����������� � �����������
Rectangle::Rectangle(int a, int b) : a_(a), b_(b) {
    set_a(a);
    set_b(b);
}


Rectangle::~Rectangle() {
    cout << "��������� ����� �����" << endl;
}
// ��������
int Rectangle::perimeter() const {
    return 2 * (a_ + b_);
}
Rectangle::Rectangle(const Rectangle& other) : a_(other.a_), b_(other.b_) {
    cout << "���� ���������" << endl;
}
// �����
int Rectangle::area() const {
    return a_ * b_;
}
void Rectangle::Init() {
    double a, b;
n:
    cout << "������ ������� �" << endl;
    cin >> a;
    cout << "������ ������� b" << endl;
    cin >> b;
    set_a(a);
    set_b(b);
}
void Rectangle::set_a(double a) {

    if (a <= 0) throw std::invalid_argument("������� a �� ���� > 0");
    a_ = a;
}
void Rectangle::set_b(double b) {
    if (b <= 0) throw std::invalid_argument("������� b �� ���� > 0");
    b_ = b;
}

// �������������� ���������

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
    if (a_ <= 0 || b_ <= 0) throw invalid_argument("������� �� ������ ���� <= 0");
    return *this;
}
Rectangle Rectangle::operator--(int) {
    Rectangle temp = *this;
    a_--;
    b_--;
    if (a_ <= 0 || b_ <= 0) throw invalid_argument("������� �� ������ ���� <= 0");
    return temp;
}
Rectangle Rectangle::operator*(int scalar) const {
    if (scalar <= 0) throw invalid_argument("������� �� ������ ���� <= 0");
    return Rectangle(a_ * scalar, b_ * scalar);
}
std::ostream& operator<<(ostream& os, const Rectangle& rect) {
    os << setw(5) << "|" << setw(5) << rect.a_
        << setw(5) << "|" << setw(5) << rect.b_
        << setw(5) << "|" << setw(5) << rect.perimeter()
        << setw(5) << "|" << setw(5) << rect.area()
        << setw(5) << "|" << setw(5) << (T ? "���" : "ͳ") << endl;
    return os;
}
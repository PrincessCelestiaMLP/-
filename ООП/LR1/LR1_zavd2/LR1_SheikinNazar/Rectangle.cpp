#include "Rectangle.h"
#include <iostream>
#include <stdexcept>
#include <iomanip>
using namespace  std;
// ����������� � �����������
Rectangle::Rectangle(int a, int b) : a_(a), b_(b) {
    set_a(a);
    set_b(b);
}

// ���� �����
void Rectangle::Print() const{
    cout << setw(5) << "|" << setw(5) << a_
        << setw(5) << "|" << setw(5) << b_
        << setw(5) << "|" << setw(5) << perimeter()
        << setw(5) << "|" << setw(5) << area()
        << setw(5) << "|" << setw(5) << (is_square() ? "���" : "ͳ") << endl;

}
Rectangle::~Rectangle() {
    cout << "��������� ����� �����"<<endl;
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
    double a,b;
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
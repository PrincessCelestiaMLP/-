#pragma once
#include <iostream>
#include <iomanip>
using namespace std;
class Rectangle {
private:
    int a_ = 0;
    int b_ = 0;

public:
    // ������������
    Rectangle() = default;
    Rectangle(int a, int b);
    // ����
    Rectangle(const Rectangle& other);
    // ��������������
    ~Rectangle();
    // ������� 
    int a() const noexcept { return a_; }
    int b() const noexcept { return b_; }


    //�������
    void set_a(double a);
    void set_b(double b);

    // ������  
    int perimeter() const;
    int area() const;

    void Init();
    void Print(bool T) const;

    // �������������� ���������
    Rectangle operator++();
    Rectangle operator++(int);
    Rectangle operator--();
    Rectangle operator--(int);
    Rectangle operator*(int scalar) const;
    explicit operator bool() const noexcept { return a_ == b_; }
    friend std::ostream& operator<<(ostream& os, const Rectangle& rect);
    friend 

};



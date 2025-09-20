#pragma once
class Rectangle {
private:
    int a_ = 0; 
    int b_ = 0; 

public:
    // ������������
    Rectangle() = default;
    Rectangle(int a, int b);
    // ����
    Rectangle(const Rectangle& other) ;
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

    bool is_square() const noexcept { return a_ == b_; }

    void Init();
    void Print() const;
};


#pragma once
#include <iostream>
using namespace std;

class Animal {
protected:
    string name;
    double weight;
public:
    Animal(string n, double w) : name(n), weight(w) {}
    virtual void sound() const = 0;      
    virtual void info() const {
        cout << "Назва: " << name << ", Вага: " << weight << " кг" << endl;
    }
    virtual ~Animal() = default;
};
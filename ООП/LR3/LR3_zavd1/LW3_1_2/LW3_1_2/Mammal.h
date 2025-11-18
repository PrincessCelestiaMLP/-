#pragma once
#include "Animal.h"
class Mammal : public Animal {
protected:
    bool hasFur;
public:
    Mammal(string n, double w, bool fur)
        : Animal(n, w), hasFur(fur) {
    }

    void info() const override {
        cout << "Ссавець: ";
        Animal::info();
        cout << "   Має шерсть: " << (hasFur ? "так" : "ні") << endl;
    }
    void sound() const override {
        cout << name << " видає звуки ссавців." << endl;
    }
};
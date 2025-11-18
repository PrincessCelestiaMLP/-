#pragma once
#include "Animal.h"
class Bird : public Animal {
private:
    double wingSpan;
public:
    Bird(string n, double w, double wings)
        : Animal(n, w), wingSpan(wings) {
    }

    void info() const override {
        cout << "Птах: ";
        Animal::info();
        cout << "   Розмах крил: " << wingSpan << " м" << endl;
    }

    void sound() const override {
        cout << name << " щебече або співає." << endl;
    }
};
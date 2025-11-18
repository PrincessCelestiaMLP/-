#pragma once
#include "Mammal.h"

class EvenToed : public Mammal {
private:
    string hoofType;
public:
    EvenToed(string n, double w, string hoof)
        : Mammal(n, w, true), hoofType(hoof) {
    }

    void info() const override {
        cout << "Парнокопитна тварина: ";
        Animal::info();
        cout << "   Тип копит: " << hoofType << endl;
    }

    void sound() const override {
        cout << name << " мукає або бекає (звук парнокопитних)." << endl;
    }
};
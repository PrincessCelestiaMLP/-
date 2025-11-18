#include <iostream>
#include <string>
#include <vector>
#include <memory>
#include "Animal.h"
#include "Mammal.h"
#include "EvenToed.h"
#include "Bird.h"
using namespace std;

int main() {
    setlocale(0, "");
    vector<shared_ptr<Animal>> zoo;

    zoo.push_back(make_shared<Mammal>("Кіт", 4.5, true));
    zoo.push_back(make_shared<EvenToed>("Корова", 250.0, "широкі копита"));
    zoo.push_back(make_shared<Bird>("Орел", 6.2, 2.1));

    cout << "=== Інформація про тварин у зоопарку ===\n";
    for (const auto& animal : zoo) {
        animal->info();
        animal->sound();
        cout << "---------------------------------\n";
    }

    return 0;
}

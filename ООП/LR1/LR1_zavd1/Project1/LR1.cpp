#include "Country.h"
#include "iostream"
int main() {
	string FRule, Name;
	Country c;
	double S;
	setlocale(0, "ukr");
	bool F = true;

	int Choose;
	while (F) {
		system("cls");
		cout << R"(Створення країни:
1.Ввести країну
2.Вивести країни
3.Вийти
)";
		
		cout << "Зробіть вибір: ";
		cin >> Choose;
		switch (Choose) {
		case 1: {
			cout << "Введіть назву краЇни\n";
			cin >> Name;
			cout << "Введіть форма правління\n";
			cin >> FRule;
			cout << "Введіть площу\n";
			cin >> S;
			c.set_Country(Name, FRule, S);
			break;
		}
		case 2: {


			c.Print();
			system("pause");
			break;
		}
		case 3: {
			F = false;
			break;
		}

		default: {
			cout << "Такої дії не існує";
			break;
		}

		}
	}
}
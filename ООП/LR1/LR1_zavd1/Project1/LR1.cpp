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
		cout << R"(��������� �����:
1.������ �����
2.������� �����
3.�����
)";
		
		cout << "������ ����: ";
		cin >> Choose;
		switch (Choose) {
		case 1: {
			cout << "������ ����� �����\n";
			cin >> Name;
			cout << "������ ����� ��������\n";
			cin >> FRule;
			cout << "������ �����\n";
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
			cout << "���� 䳿 �� ����";
			break;
		}

		}
	}
}
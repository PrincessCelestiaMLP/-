#include "Rectangle.h"
#include <iostream>
#include <iomanip>
bool T = false;
using namespace std;
int main() {
    setlocale(0, "ukr");
    try {

        int N = 0;
        cout << "������ ������ ������������� �� ������ ������: ";
        cin >> N;

        Rectangle* r1 = new Rectangle[N];
        for (int i = 0; i < N; i++) {
            cout << i + 1 << ") ";
            cin>>r1[i];
        }

        int choise = -1;
        while (choise != 0) {
            system("cls");
            cout << "����:" << endl
                << "1) ������� �� �������������" << endl
                << "2) ������� ���� ������� �������������" << endl
                << "3) ��������� �� ������� �� ������" << endl
                << "4) ����������� ���������" << endl
                << "5) ����������� ���������" << endl
                << "0) �����" << endl;
            cin >> choise;

            switch (choise) {
            case 1: {
                cout << setw(5) << "� " << setw(5) << "|" << setw(5) << "a"
                    << setw(5) << "|" << setw(5) << "b"
                    << setw(5) << "|" << setw(5) << "P"
                    << setw(5) << "|" << setw(5) << "S"
                    << setw(5) << "|" << setw(5) << "Is square?" << endl;

                for (int i = 0; i < N; i++) {
                    T = (r1[i]) ? true:false;
                    cout << setw(5) << i + 1;
                    cout<<r1[i];

                }

                system("pause");
                break;
            }

            case 2: {
                int k;
                Rectangle r2;

                cout << setw(5) << "� " << setw(5) << "|" << setw(5) << "a"
                    << setw(5) << "|" << setw(5) << "b"
                    << setw(5) << "|" << setw(5) << "P"
                    << setw(5) << "|" << setw(5) << "S"
                    << setw(5) << "|" << setw(5) << "Is square?" << endl;

                for (int i = 0; i < N; i++) {
                    T = (r1[i]) ? true : false;
                    cout << setw(5) << i + 1;
                    cout<<r1[i];
                }

                cout << "������ ����� �������������, ���� ������ ���������: ";
                cin >> k;

                if (k < 1 || k > N) {
                    cout << "������������ ����!" << endl;
                    system("pause");
                    break;
                }

                r2 = r1[k - 1];

                cout << "\n����������� ������������:\n";
                cout << setw(5) << "� " << setw(5) << "|" << setw(5) << "a"
                    << setw(5) << "|" << setw(5) << "b"
                    << setw(5) << "|" << setw(5) << "P"
                    << setw(5) << "|" << setw(5) << "S"
                    << setw(5) << "|" << setw(5) << "Is square?" << endl;

                T = (r2) ? true : false;
                cout << setw(5) << 1;
                cout<<r2;

                system("pause");
                break;
            }
            case 3:
                cout << "������ �� ���� ������ �� ������ ���������\n";
				int scalar;
				cin >> scalar;
                for (int i = 0; i < N; i++) {
                    r1[i] = r1[i] * scalar;
				}
				break;
            case 4:
                for (int i = 0; i < N; i++) {
                    r1[i]++;
                }
				break;
            case 5:
                for (int i = 0; i < N; i++) {
                    r1[i]--;
				}
            case 0:
                cout << "����� � ��������..." << endl;
                break;

            default:
                cout << "������ ������ �� ����. ��������� �����." << endl;
                system("pause");
                break;
            }
        }

        delete[] r1;
    }
    catch (const exception& ex) {
        cout << "�������: " << ex.what() << "\n";
    }

    return 0;
}

#include "Rectangle.h"
#include <iostream>
#include <iomanip>
using namespace std;
int main() {
    setlocale(0,"ukr");
    try {
        int N = 0;
        cout << "������ ������� ��������������� �� ������ ������" << endl;
        cin >> N;
        Rectangle* r1=new Rectangle[N];
        for (int i = 0; i < N; i++) {
            cout << i + 1<<") ";
            r1[i].Init();
        }
        int choise;
        m:
        system("cls");
        cout << "������� �� �������������?" << endl
            << "1)���" <<endl
            << "2)ͳ" << endl;
        cin >> choise;
        switch (choise) {
        case 1:{
            cout << setw(5) << "� " << setw(5) <<"|" << setw(5) << "a"
                << setw(5) << "|"<< setw(5) <<"b"
                << setw(5) << "|"<< setw(5) <<"P"
                << setw(5) << "|"<< setw(5) <<"S"
                << setw(5) << "|"<< setw(5) <<"Is squert?" << endl;
            for (int i = 0; i < N; i++) {
                
                cout << setw(5) << i + 1 ;
                r1[i].Print();
            }
            system("pause");
            system("cls");
            break;
            }
              
        case 2: {
            cout << "�� ��������" << endl;
            break;
        }
        default: {
            cout << "������ ������ �� ����.��������� �����" << endl;
            system("pause");
            goto m;
        }
        }
        bool f=true;
        while (f) {
            system("cls");
            cout << "������� ���� ������� ��������������?" << endl
                << "1)���" << endl
                << "2)ͳ" << endl;
            cin >> choise;
            switch (choise) {
            case 1: {
                int k;
                Rectangle r2;
                cout << setw(5) << "� " << setw(5) << "|" << setw(5) << "a"
                    << setw(5) << "|" << setw(5) << "b"
                    << setw(5) << "|" << setw(5) << "P"
                    << setw(5) << "|" << setw(5) << "S"
                    << setw(5) << "|" << setw(5) << "Is squert?" << endl;
                for (int i = 0; i < N; i++) {

                    cout << setw(5) << i + 1;
                    r1[i].Print();
                }

            n:
                
                cout << "������ ����� ���� ��������������� ����� �� ������ ���������" << endl;
                cin >> k;
                if (k > N || k < 0) {
                    cout << "������������ ����.��������� ��)" << endl;
                    system("pause");
                    system("cls");
                    goto n;

                }
                for (int i = 0; i < N; i++) {
                    if (i + 1 == k) {
                         r2 = r1[i];
                    }
                }
                cout << setw(5) << "� " << setw(5) << "|" << setw(5) << "a"
                    << setw(5) << "|" << setw(5) << "b"
                    << setw(5) << "|" << setw(5) << "P"
                    << setw(5) << "|" << setw(5) << "S"
                    << setw(5) << "|" << setw(5) << "Is squert?" << endl;
                cout << setw(5) << 1;
                r2.Print();
                f = false;
                
                break;
            }
            case 2: {
                cout << "�� ��������" << endl;
                f = false;
                break;
            }
            default: {
                cout << "������ ������ �� ����.��������� �����" << endl;
                system("pause");
            }

            }
        }
        delete[] r1;
       
    }
    catch (const exception& ex) {
        cerr << "�������: " << ex.what() << "\n";
    }
    
    return 0;
}
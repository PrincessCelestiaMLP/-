#include "Rectangle.h"
#include <iostream>
#include <iomanip>
using namespace std;
int main() {
    setlocale(0,"ukr");
    try {
        int N = 0;
        cout << "Введіть склільки чотирьохкутників ви хочете ввести" << endl;
        cin >> N;
        Rectangle* r1=new Rectangle[N];
        for (int i = 0; i < N; i++) {
            cout << i + 1<<") ";
            r1[i].Init();
        }
        int choise;
        m:
        system("cls");
        cout << "Вивести всі чотирикутники?" << endl
            << "1)Так" <<endl
            << "2)Ні" << endl;
        cin >> choise;
        switch (choise) {
        case 1:{
            cout << setw(5) << "№ " << setw(5) <<"|" << setw(5) << "a"
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
            cout << "Як забажаєте" << endl;
            break;
        }
        default: {
            cout << "Такого вибору не існує.Спробуйте знову" << endl;
            system("pause");
            goto m;
        }
        }
        bool f=true;
        while (f) {
            system("cls");
            cout << "Зробити копію певного чотирихкутника?" << endl
                << "1)Так" << endl
                << "2)Ні" << endl;
            cin >> choise;
            switch (choise) {
            case 1: {
                int k;
                Rectangle r2;
                cout << setw(5) << "№ " << setw(5) << "|" << setw(5) << "a"
                    << setw(5) << "|" << setw(5) << "b"
                    << setw(5) << "|" << setw(5) << "P"
                    << setw(5) << "|" << setw(5) << "S"
                    << setw(5) << "|" << setw(5) << "Is squert?" << endl;
                for (int i = 0; i < N; i++) {

                    cout << setw(5) << i + 1;
                    r1[i].Print();
                }

            n:
                
                cout << "Введіть цифру того чотирьохкутника якого ви хочете скопіювати" << endl;
                cin >> k;
                if (k > N || k < 0) {
                    cout << "Неправильний вибір.Спробуйте ще)" << endl;
                    system("pause");
                    system("cls");
                    goto n;

                }
                for (int i = 0; i < N; i++) {
                    if (i + 1 == k) {
                         r2 = r1[i];
                    }
                }
                cout << setw(5) << "№ " << setw(5) << "|" << setw(5) << "a"
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
                cout << "Як забажаєте" << endl;
                f = false;
                break;
            }
            default: {
                cout << "Такого вибору не існує.Спробуйте знову" << endl;
                system("pause");
            }

            }
        }
        delete[] r1;
       
    }
    catch (const exception& ex) {
        cerr << "Помилка: " << ex.what() << "\n";
    }
    
    return 0;
}
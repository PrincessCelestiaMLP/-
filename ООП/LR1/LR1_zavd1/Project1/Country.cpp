#include "Country.h"
#include "iostream"
using namespace std;
Country::Country(string Name, string FormRule, double S)
	:Name_(move(Name)),
	FormRule_(move(FormRule)),
	S_(S) {
	set_name(Name_);
	set_FormRule(FormRule_);
	set_S(S_);
}
void Country::set_name(string Name) {
	if (Name.empty())
	{
		cout << "Назва не може бути порожнію" << endl; return;
	}
	Name_ = move(Name);
	
}
void Country::set_FormRule(string FormRule) {
	if (FormRule.empty())
	{
		cout << "Правління не може бути ніяким" << endl; return;
	}
	FormRule_ = move(FormRule);

}
void Country::set_S(double S) {
	if (S <= 0)
	{
		cout << "Рлоща не може бути відємною або нульовою" << endl; return;
	}
	S_ = S;

}
void Country::set_Country(string Name, string FormRule, double S) {
	if (Name.empty())
	{
		cout << "Назва не може бути порожнію" << endl; return;
	}
	Name_ = move(Name);
	if (FormRule.empty())
	{
		cout << "Правління не може бути ніяким" << endl; return;
	}
	FormRule_ = move(FormRule);
	if (S <= 0)
	{
		cout << "Площа не може бути відємною або нульовою" << endl; return;
	}
	S_ = S;
}
void Country::Print() const{
	if (Name_.empty()) {
		cout << "Нема що виводити" << endl;
		return;
	}
	cout << "Назва країни: " << Name_ << endl
		<< "Форма правління: " << FormRule_ << endl
		<< "Площа: " << S_ << endl;
}
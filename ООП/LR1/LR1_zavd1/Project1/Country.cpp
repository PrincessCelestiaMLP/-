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
		cout << "����� �� ���� ���� �������" << endl; return;
	}
	Name_ = move(Name);
	
}
void Country::set_FormRule(string FormRule) {
	if (FormRule.empty())
	{
		cout << "�������� �� ���� ���� �����" << endl; return;
	}
	FormRule_ = move(FormRule);

}
void Country::set_S(double S) {
	if (S <= 0)
	{
		cout << "����� �� ���� ���� ������ ��� ��������" << endl; return;
	}
	S_ = S;

}
void Country::set_Country(string Name, string FormRule, double S) {
	if (Name.empty())
	{
		cout << "����� �� ���� ���� �������" << endl; return;
	}
	Name_ = move(Name);
	if (FormRule.empty())
	{
		cout << "�������� �� ���� ���� �����" << endl; return;
	}
	FormRule_ = move(FormRule);
	if (S <= 0)
	{
		cout << "����� �� ���� ���� ������ ��� ��������" << endl; return;
	}
	S_ = S;
}
void Country::Print() const{
	if (Name_.empty()) {
		cout << "���� �� ��������" << endl;
		return;
	}
	cout << "����� �����: " << Name_ << endl
		<< "����� ��������: " << FormRule_ << endl
		<< "�����: " << S_ << endl;
}
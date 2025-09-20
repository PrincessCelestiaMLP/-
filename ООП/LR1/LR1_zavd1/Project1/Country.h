#pragma once
#include "string";
using namespace std;
class Country
{
public:
	string Name_;
private:
	string FormRule_;
	double S_=0;
public:
	Country() = default;
	Country(string Name,string FormRule,double S);

	const string name() const { return Name_; }
	const string FormRule() const { return FormRule_; }
	double S() const noexcept { return S_; }

	void set_name(string name);
	void set_FormRule(string FormRule);
	void set_S(double S);
	void set_Country(string Name, string FormRule, double S);

	void Print() const;
};


#include <iostream>
#include <string>

using namespace std;

// This class stores a fraction's numerator and denominator
class Fraction
{
	int numerator;
	int denominator;
public:
	Fraction() { } // Empty constructor required because no arg constructor called in main for f3
	Fraction(int a, int b)
	{
		numerator = a;
		denominator = b;
	}

	int getNumerator(void) { return numerator; }
	int getDenominator(void) { return denominator; }
	void setNumerator(int x) { numerator = x; }
	void setDenominator(int y) { denominator = y; }
};

// The following two functions are 'global functions',
// ie not a member of a class - not an OO approach but common C-like approach.
// Assumes inputs are valid (no input error checking).
int readNum(string str)
{
	int fslash = str.find('/'); // Finds index of '/' symbol in string
	string val = str.substr(0, fslash); // Extracts numerator as a string
	int value = atoi(val.c_str()); // Converts numerator to an int
	return value;
};

int readDen(string str)
{
	int fslash = str.find('/');
	int end = str.length(); // Length of input string
	string val = str.substr(fslash + 1, end); // Extracts denominator as a string
	int value = atoi(val.c_str());  // Converts denominator to an int
	return value;
};

Addition operator +(Addition& a)
{

}

int main(void)
{
	string fraction1;
	cout << "This program processes a fraction entered at the keyboard using syntax 'a/b'." << endl;
	cout << "Enter fraction 1:";
	cin >> fraction1;
	int num = readNum(fraction1);
	int den = readDen(fraction1);
	Fraction f1(num, den);   // Create the first fraction object

	cout << "Fraction1 is " << f1.getNumerator() << "/" << f1.getDenominator() << endl;

	string fraction2;
	cout << "This program processes a fraction entered at the keyboard using syntax 'a/b'." << endl;
	cout << "Enter fraction 2:";
	cin >> fraction2;
	int num2 = readNum(fraction2);
	int den2 = readDen(fraction2);
	Fraction f2(num2, den2);   // Create the second fraction object

	cout << "Fraction2 is " << f2.getNumerator() << "/" << f2.getDenominator() << endl;

	string fraction3;
	cout << "We will now add fraction 1 to fracton 2 to make fraction 3" << endl;
	cout << "Fraction 1 = " << f1.getNumerator() << "/" << f1.getDenominator() << "fraction 2 = " << f2.getNumerator() << "/" << f2.getDenominator() << endl;
	int num3 = (num*den2) + (den*num2);
	int den3 = (den*den2);
	Fraction f3(num3, den3);

	cout << "fraction 3 is " << f3.getNumerator() << "/" << f3.getDenominator() << endl;

	
	system("PAUSE");
	return 0;
	
}
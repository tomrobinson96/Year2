/* covert.cpp*/

#include <iostream>
using namespace std;


float convert(float fr)
{
	float cel = (fr - 32) * 5) / 9;
	return cel;
}

int main ()
{
float celsius;
float fahrenheit;

	cout << "Please enter your temperature in Fahrenheit.\n";
	cin >> fahrenheit;

	celsius = convert(fahrenheit);

	cout << "The tempreture in Celsius is " << celsius <<".";
	cout << "Press any key to close the program.";
	system("pause");
	return 0;
}



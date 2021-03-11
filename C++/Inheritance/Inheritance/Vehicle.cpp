#include "Vehicle.h"

Vehicle::Vehicle(int inwheels, float inweight)

{  // constructor for base class
	wheels = inwheels;
	weight = inweight;
}

int Vehicle::getwheels(void)
{  // get the number of wheels of this Vehicle
	return wheels;
}

float Vehicle::getweight(void)
{  // return the weight of this Vehicle
	return weight;
}

void Vehicle::service(void)
{
	cout << "Information on servicing a general vehicle is not known" << endl << endl;
}

Car::Car(int numwheels, float inweight, int people) : Vehicle(numwheels, inweight)

{
	numpassengers = people;
}

int Car::getpassengers(void)
{
	return numpassengers;
}

void Car::service(void)
{
	cout << "For servicing your car, take it to your local garage" << endl << endl;
}

Lorry::Lorry(int numwheels, float inweight, float height) : Vehicle(numwheels, inweight)

{
	tallness = height;
}
float Lorry::getHeight(void)
{
	return tallness;
}
void Lorry::service(void)
{
	cout << "You must service your Lorry regularly to prevent accidents" << endl << endl;
}

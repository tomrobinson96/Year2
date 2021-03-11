#ifndef VEHICLEH
#define VEHICLEH

#include <iostream>
#include <cstdlib>

using namespace std;

class Vehicle       	// base class
{
protected:
	int wheels;  	// number of wheels
	float weight;  	// unladen weight
public:
	Vehicle(int inwheels, float inweight);  // constructor
	int getwheels(void);  	// how many wheels
	float getweight(void); 	// how heavy
	void service(void);
};

class Car : public Vehicle      	// derived class
{
	int numpassengers;            	// number of passengers
public:
	Car(int numwheels, float inweight, int people);
	int getpassengers(void);     	// how many passengers
	void service(void);
};

class Lorry : public Vehicle
{
	float tallness;
public:
	Lorry(int numwheels, float inweight, float height);
	float getHeight(void);
	void service(void);
};

#endif
#include "Vehicle.h"

int main(void)
{
	Vehicle v1(2, 0.3);
	cout << "Vehicle" << endl;
	cout << "No.of wheels is " << v1.getwheels() << endl;
	cout << "Weight of vehicle is " << v1.getweight() << endl;
	v1.service();

	Car* c1 = new Car(4, 1.5, 5);
	cout << "Car" << endl;
	cout << "No.of wheels is " << c1->getwheels() << endl;
	cout << "Weight of vehicle is " << c1->getweight() << endl;
	cout << "No.of passengers is " << c1->getpassengers() << endl;
	c1->service();

	Lorry* l1 = new Lorry(6, 4, 10);
	cout << "Lorry" << endl;
	cout << "No.of wheels is " << l1->getwheels() << endl;
	cout << "Weight of vehicle is " << l1->getweight() << endl;
	cout << "Height of the lorry is " << l1->getHeight() << " Meters" << endl;
	l1->service();

	system("PAUSE");
	return 0;
}
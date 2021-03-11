/* HelloFunctionWorld.cpp */
#include<iostream>
#include<cstdlib>

using namespace std;

void printMessage( char statement[ ] )
{
cout << "Message is: " << statement << endl;
} ;
int main(void)
{
char message[ ] = "Hello World";
printMessage( message );
system("pause");
return 0;
}
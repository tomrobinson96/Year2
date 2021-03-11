/* calcsum.cpp */

#include<iostream>
using namespace std;


float timestwo( float val )
{
   float twice;
   twice = 2.0 * val;
   return twice;
};

/* Main function */
int main(void)
{
 float a,answer;
   cout << "Enter a value>" ;
   cin >> "%f", &a ; // Microsoft version of scanf()
   answer = timestwo( a );
   cout << "Result of function call is: %6.2f \n", answer;
   system("PAUSE");
   return 0;
}

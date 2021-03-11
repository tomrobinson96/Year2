#include "Infix2Postfix.h"

/*
INFIX TO POSTFIX
Only '+'  ,  '-'  , '*' and '/' are aloud
Operator and operands must be single character.
Input Infix expression must be in a desired format.
*/

int main()
{
	string expression;
	cout << "Enter Infix Expression ";
	cin >> expression;
	cout << "Infix expression : " << expression << endl;


	string postfix = InfixToPostfix(expression);
	cout << "Postfix expression = " << postfix << endl;
	system("PAUSE");
	return 0;
}
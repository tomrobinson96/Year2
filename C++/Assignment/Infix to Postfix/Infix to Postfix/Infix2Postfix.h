#ifndef INFIX2POSTFIX
#define INFIX2POSTFIX

/*
INFIX TO POSTFIX
Only '+'  ,  '-'  , '*' and '/' are aloud
Operator and operands must be single character.
Input Infix expression must be in a desired format.
*/
#include<iostream>
#include<stack>
#include<string>

using namespace std;

// Converts Infix expression to postfix
string InfixToPostfix(string expression);

// Operator or not.
bool IsOperator(char C);

// letter, numeric digit, or neither.
bool IsOperand(char C);

// Get value with greater significance.
int GetOperatorPriority(char op);

// Verifys which operator has higher importance
int HasGreaterPriority(char operator1, char operator2);

#endif // !INFIX2POSTFIX
#pragma once

#include <iostream>
#include "Stack.h"
using namespace std;
void main()
{
	Stack<int> myStack;
	myStack.push(1);
	myStack.push(2);
	myStack.push(3);
	cout << myStack.top() << endl;
	myStack.pop();
	cout << myStack.top() << endl;
	myStack.pop();
	cout << myStack.top() << endl;
	myStack.pop();

}
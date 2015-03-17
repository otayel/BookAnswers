#include <iostream>
#include "Stack.h"
#include "3.2 StackMin.h"
#include "Queue.h"

using namespace std;

void TryStack()
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

void TryQueue()
{
	Queue<int> myQueue;
	myQueue.Enqueue(10);
	cout << myQueue.Dequeue() << endl;
	myQueue.Enqueue(15);
	myQueue.Enqueue(1);
	cout << myQueue.Dequeue() << endl;
	cout << myQueue.Dequeue() << endl;
	myQueue.Enqueue(101);
	cout << myQueue.Dequeue() << endl;
	cout << myQueue.Dequeue() << endl;
}

void TryMinStack()
{
	StackMin<int> myStack;
	myStack.push(1);
	cout << myStack.min() << endl;
	myStack.push(2);
	cout << myStack.min() << endl;
	myStack.push(0);
	cout << myStack.min() << endl;
	myStack.pop();
	cout << myStack.top() << endl;
	cout << myStack.min() << endl;
	myStack.pop();
	cout << myStack.top() << endl;
	cout << myStack.min() << endl;
	myStack.pop();
}

void main()
{
	TryMinStack();
}
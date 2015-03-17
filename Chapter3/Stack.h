#ifndef STACK_H
#define STACK_H

#include "Node.h"

template <class T>
class Stack{
private:
	Node<T>* topItem = nullptr;

public:
	Stack();
	void push(T data);
	void pop();
	T top();
	bool empty();
};

template<class T>
Stack<T>::Stack()
{

}

template<class T>
void Stack<T>::push(T data)
{
	Node<T>* newNode = new Node < T >{ data, topItem };
	topItem = newNode;
}

template<class T>
void Stack<T>::pop()
{
	if (topItem)
	{
		Node<T>* temp = topItem;
		topItem = topItem->next;
		delete temp;
	}
}

template<class T>
T Stack<T>::top()
{
	return topItem->value;
}

template < class T >
bool Stack<T>::empty()
{
	if (!topItem)
	{
		return true;
	}
	else
	{
		return false;
	}
}
#endif
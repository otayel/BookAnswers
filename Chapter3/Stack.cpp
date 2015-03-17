#include "Stack.h"

template<class T>
Stack<T>::Stack()
{

}

template<class T>
void Stack<T>::push(T data)
{
	Node<T>* newNode = new Node < T > { data, topItem };
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
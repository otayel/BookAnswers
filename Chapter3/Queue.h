#ifndef QUEUE_H
#define QUEUE_H

#include "Node.h"

template <class T>
class Queue{
private:
	Node<T>* first = nullptr;
	Node<T>* last = nullptr;

public:
	Queue();
	void Enqueue(T value);
	T Dequeue();

};

template<class T>
Queue<T>::Queue()
{

}

template<class T>
void Queue<T>::Enqueue(T value)
{
	if (first && last)
	{
		Node<T>* newNode = new Node < T > { value, nullptr };
		last->next = newNode;
		last = newNode;
	}
	else
	{
		first = new Node < T > { value, nullptr };
		last = first;
	}
}

template<class T>
T Queue<T>::Dequeue()
{
	if (first && last)
	{
		if (first == last)
		{
			Node<T>* temp = first;
			first = nullptr;
			last = nullptr;
			return temp->value;
		}
		else
		{
			Node<T>* temp = first;
			first = first->next;
			return temp->value;
		}
	}
	else
	{
		//Throw Queue Empty Exception
		return -1;
	}
}

#endif
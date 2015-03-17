#ifndef NODE_H
#define NODE_H

template <class T>
struct Node{
	T value;
	Node<T>* next;
};
#endif
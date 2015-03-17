#ifndef STACK_H
#define STACK_H

template <class T>
struct Node{
	T value;
	Node<T>* next;
};


template <class T>
class Stack{
private:
	Node<T>* topItem = nullptr;

public:
	Stack();
	void push(T data);
	void pop();
	T top();
};
#include "Stack.cpp"
#endif
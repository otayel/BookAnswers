#ifndef STACK_MIN_H
#define STACK_MIN_H

#include "Stack.h"

template <class T>
class StackMin{
private:
	Stack<T> stack;
	Stack<T> min_stack;

public:
	StackMin();
	void pop();
	void push(T value);
	T top();
	T min();
};

template<class T>
StackMin<T>::StackMin()
{

}

template<class T>
void StackMin<T>::pop()
{
	if (!stack.empty() && !min_stack.empty())
	{
		stack.pop();
		min_stack.pop();
	}
}

template<class T>
void StackMin<T>::push(T value)
{
	stack.push(value);
	if (min_stack.empty())
	{
		min_stack.push(value);
	}
	else
	{
		min_stack.push(min_stack.top() < value ? min_stack.top() : value);
	}
}

template<class T>
T StackMin<T>::top()
{
	if (!stack.empty())
	{
		return stack.top();
	}
}

template<class T>
T StackMin<T>::min()
{
	if (!min_stack.empty())
	{
		return min_stack.top();
	}
}
#endif
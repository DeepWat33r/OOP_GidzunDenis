#include <iostream>

using namespace std;

class List
{
public:
	List();
	~List();
	void push_back(float data);
	void Remove(float a);
	void RemoveLessThan(float a);
	int CountMoreThan(float a);
	int GetSize() 
	{
		return Size;
	}

private:

	class Node
	{
	public:
		Node* pNext;
		float data;
		Node(float data = float(), Node* pNext = nullptr)
		{
			this->data = data;
			this->pNext = pNext;
		}
	};

	int Size;
	Node* head;
	Node* tail;
};

List::List()
{
	Size = 0;
	head = nullptr;
}
List::~List()
{

}
void List::push_back(float data)
{
	if (head == nullptr)
	{
		head = new Node(data);
	}
	else
	{
		Node* current = head;
		while (current->pNext != nullptr)
		{
			current = current->pNext;			 
		}
		if(current->pNext==nullptr) current->pNext = new Node(data);
	}
	Size++;
}
void List::Remove(float a)
{
	Node* previous = nullptr;
	Node* current = head;
	while (current != nullptr)
	{
		if (current->data == a)
		{
			if (previous != nullptr) 
			{
				while(current->pNext!=nullptr) current = current->pNext;
				current->pNext=nullptr;
			}
			else 
			{
				head = head->pNext;
			}
			Size--;
		}
		previous = current;
		current = current->pNext;
	}
}
void List::RemoveLessThan(float a)
{
	Node* current = head;
	while (current != nullptr)
	{
		if (current->data < a) Remove(current->data);
		current = current->pNext;
	}
}
int List::CountMoreThan(float a) 
{
	Node* current = head;
	int count=0;
	while (current != nullptr)
	{
		if (current->data > a) count++;
		current = current->pNext;
	}
	return count;
}
int main()
{
	List lst;
	lst.push_back(5);
	lst.push_back(10);
	lst.push_back(1);
	lst.push_back(1.4);
	lst.push_back(1.7);
	lst.push_back(2.1);
	lst.push_back(26);
	lst.push_back(14);
	lst.push_back(0.5);

	cout << lst.GetSize() << endl;
	cout<<lst.CountMoreThan(10.5)<<endl;
	lst.RemoveLessThan(2.6);
	cout << lst.GetSize() << endl;
}
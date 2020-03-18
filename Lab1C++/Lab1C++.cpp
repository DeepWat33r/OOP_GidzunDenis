#include <iostream>

using namespace std;
bool Compare(int, int);
void Decrement(int&);

int main()
{
    int num1 = 34, num2 = 34;
    Compare(num1,num2);
    Decrement(num1);
    cout << num1;
}
bool Compare(int num1, int num2)
{
    bool flag = false;
    if ((num1 ^ num2) == 0)
        flag = true;
    return flag;
}
void Decrement(int &num1)
{
	int num2 = 1,temp=0;
	temp = num1 & num2;
	if (temp == 0)
	{

		while (temp == 0) {
			temp = num1 & num2;
			num1 = num1 ^ num2;
			num2=num2 << 1;
		}
	}
	else {
		num1 = num1^num2;
	}
}



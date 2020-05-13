#include <iostream>
#include <math.h>
#include <exception>

using namespace std;


class Calculate
{
private:
    double a, c, d;
public:
    Calculate() {};
    Calculate(double a, double c, double d);
    double Result();
    void SetA(double a);
    void SetC(double c);
    void SetD(double d);
};

int main()
{
    Calculate* arr[10];
    int k = 3;
    arr[0] = new Calculate(0.5, 2, 5.7);
    arr[1] = new Calculate(4, -1, 5.7);
    arr[2] = new Calculate(10, 4, 5.7);
    for (int i = 0; i < k; i++)
    {
        try
        {
            double r = arr[i]->Result();
            cout << r << endl;
        }
        catch (invalid_argument& e)
        {
            cout << e.what() << endl;
        }
        catch (exception& e)
        {
            cout << e.what() << endl;
        }
    }
    return 0;
}
Calculate::Calculate(double a, double c, double d)
{
    this->a = a;
    this->c = c;
    this->d = d;
}
double Calculate::Result()
{
    if (a / 4 + c == 0) throw exception("Divide by Zero");
    if (2 * c - a <= 0) throw invalid_argument("ArgumentException");
    double r;
    r = (log10(2 * c - a) + d - 152) / (a / 4 + c);
    return r;
}
void Calculate::SetA(double a)
{
    this->a = a;
}
void Calculate::SetC(double c)
{
    this->c = c;
}
void Calculate::SetD(double d)
{
    this->d = d;
}
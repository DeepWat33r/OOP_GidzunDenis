#include <iostream>

using namespace std;

class Square
{
private:
    double x1, y1;
    double A;

public:
    Square();
    Square(double x1, double y1, double A);
    Square(const Square& s);
    Square operator +(Square s2);
    Square operator+(double A);
    Square operator/(Square s2);
    double& X1() 
    {
        return this->x1;
    }
    double& Y1()
    {
        return this->y1;
    }
    double& X2()
    {
        return this->x1;
    }
    double& Y2()
    {
        double Y2 = this->y1 + this->A;
        return Y2;
    }
    double& X3()
    {
        double X3 = this->x1 + this->A;
        return X3;
    }
    double& Y3()
    {
        double Y3 = this->y1 + this->A;
        return Y3;
    }
    double& X4()
    {
        double X4 = this->x1 + this->A;
        return X4;
    }
    double& Y4()
    {
        return this->y1;
    }
    double& a() 
    {
        return this->A;
    }
    double& P() 
    {
        double P=0;
        P = this->A * 4;
        return P;
    }
    double& S()
    {
        double S = 0;
        S = this->A * this->A;
        return S;
    }
};
    Square::Square()
    {
        x1 = y1 = 1;
        A = 1;
    }
    Square::Square(double x1, double y1, double A)
    {
        this->x1 = x1; this->y1 = y1;
        this->A = A;

    }
    Square::Square(const Square& s)
    {
        this->x1 = s.x1; this->y1 = s.y1;
        this->A = s.A;
    }
    Square Square::operator + (Square  s2)
    {
        Square s3(this->x1, this->y1, this->A + s2.A);
        return s3;
    }
    Square Square::operator+(double A)
    {
        Square s3(this->x1, this->y1, this->A + A);
        return s3;
    }
     Square Square::operator /(Square s2)
    {
        Square s3(this->x1, this->y1, this->A / s2.A);
        return s3;
    }
int main()
{
    Square K1;
    Square K2(10, 10, 9);
    Square K3(K2);
    Square K4 = K1 + K2;
    cout<<"x1="<< K4.X1()<<" y1="<<K4.Y1()<<" A="<<K4.a()<<endl;
    K3 = K3 + 5;
    cout << "x1=" << K3.X1() << " y1=" << K3.Y1() << " A=" << K3.a() << endl;
    K1 = K2 / K3;
    cout << "x1=" << K1.X1() << " y1=" << K1.Y1() << " A=" << K1.a() << endl;
}
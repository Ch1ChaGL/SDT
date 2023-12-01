#ifndef _SAMPLE_MODULE_H_
#define _SAMPLE_MODULE_H_

class ComplexNumber {
private:
    double real; // ������������ �����
    double imaginary; // ������ �����

public:
    // ����������� �� ���������
    ComplexNumber();

    // ����������� � �����������
    ComplexNumber(double realPart, double imaginaryPart);

    // ������ ��� ��������� ������������ � ������ ������
    double getReal() const;
    double getImaginary() const;

    // �������� � ������������ �������
    ComplexNumber operator+(const ComplexNumber& other) const;
    ComplexNumber operator-(const ComplexNumber& other) const;
    ComplexNumber operator*(const ComplexNumber& other) const;
    ComplexNumber operator/(const ComplexNumber& other) const;

    // ����� ��� ������ ����������
    void print() const;
};

#endif

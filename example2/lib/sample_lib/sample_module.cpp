#include "sample_module.h"
#include <iostream>

// ����������� �� ���������
ComplexNumber::ComplexNumber() : real(0.0), imaginary(0.0) {}

// ����������� � �����������
ComplexNumber::ComplexNumber(double realPart, double imaginaryPart) : real(realPart), imaginary(imaginaryPart) {}

// ������ ��� ��������� ������������ � ������ ������
double ComplexNumber::getReal() const {
    return real;
}

double ComplexNumber::getImaginary() const {
    return imaginary;
}

// �������� � ������������ �������
ComplexNumber ComplexNumber::operator+(const ComplexNumber& other) const {
    return ComplexNumber(real + other.real, imaginary + other.imaginary);
}

ComplexNumber ComplexNumber::operator-(const ComplexNumber& other) const {
    return ComplexNumber(real - other.real, imaginary - other.imaginary);
}

ComplexNumber ComplexNumber::operator*(const ComplexNumber& other) const {
    double resultReal = real * other.real - imaginary * other.imaginary;
    double resultImaginary = real * other.imaginary + imaginary * other.real;
    return ComplexNumber(resultReal, resultImaginary);
}

ComplexNumber ComplexNumber::operator/(const ComplexNumber& other) const {
    double denominator = other.real * other.real + other.imaginary * other.imaginary;
    double resultReal = (real * other.real + imaginary * other.imaginary) / denominator;
    double resultImaginary = (imaginary * other.real - real * other.imaginary) / denominator;
    return ComplexNumber(resultReal, resultImaginary);
}

// ����� ��� ������ ����������
void ComplexNumber::print() const {
    std::cout << "(" << real << " + " << imaginary << "i)" << std::endl;
}

#include <iostream>
#include "sample_module.h"

int main() {
    ComplexNumber a(1.0, 2.0);
    ComplexNumber b(3.0, 4.0);

    // ������� ��������
    ComplexNumber sum = a + b;
    ComplexNumber difference = a - b;
    ComplexNumber product = a * b;
    ComplexNumber quotient = a / b;

    // ����� �����������
    sum.print();
    difference.print();
    product.print();
    quotient.print();

    return 0;
}
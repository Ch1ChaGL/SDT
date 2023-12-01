#ifndef _SAMPLE_MODULE_H_
#define _SAMPLE_MODULE_H_

class ComplexNumber {
private:
    double real; // Вещественная часть
    double imaginary; // Мнимая часть

public:
    // Конструктор по умолчанию
    ComplexNumber();

    // Конструктор с параметрами
    ComplexNumber(double realPart, double imaginaryPart);

    // Методы для получения вещественной и мнимой частей
    double getReal() const;
    double getImaginary() const;

    // Операции с комплексными числами
    ComplexNumber operator+(const ComplexNumber& other) const;
    ComplexNumber operator-(const ComplexNumber& other) const;
    ComplexNumber operator*(const ComplexNumber& other) const;
    ComplexNumber operator/(const ComplexNumber& other) const;

    // Метод для вывода информации
    void print() const;
};

#endif

#include <iostream>

int main()
{
    setlocale(LC_ALL, "Russian");
    int Array[10];

    std::cout << "¬ведите числа: " << std::endl;

    for (int i = 1; i <= 10; i++)
        std::cin >> Array[i];

    for (int i = 1; i <= 10; i++)
        std::cout << "Array [" << i << "] = " << Array[i] << std::endl;

    system("pause");
    return 0;
}
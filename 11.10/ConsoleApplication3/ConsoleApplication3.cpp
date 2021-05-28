#include <iostream>

using namespace std;

int main() {
    int n;
    int a[20]{};
    int i{ 0 };
    cout << "N:\n";
    cin >> n;
    while (n) {
        a[i] = n % 10;
        n /= 10;
        i++;
    }
    for (int j = 0; j < i; j++) {
        std::cout << a[j] << ' ';
    }
    std::cout << '\n';

}
//Erick Gamboa
//Suma Recursiva y Iterativa 

#include <iostream>

using namespace std;

int SumaIterativa(int n) {
    int suma = 0;

    while (n > 9) {
        suma += n % 10;
        n /= 10;
    }
    return (suma + n);
}

int SumaRecursiva(int n) {
    if (n <= 9)
        return n;
    else
        return SumaRecursiva(n / 10) + n % 10;
}

int main() {
    int opcion;
    int digito;

    cout << "1. Suma Recursiva \n";
    cout << "2. Suma Iterativa \n";
    cout << "Ingrese una opcion: ";

    cin >> opcion;

    switch (opcion) {
    case 1:
        cout << "Ingrese un digito para la suma: ";
        cin >> digito;
        cout << "Suma recursiva: " << SumaRecursiva(digito) << endl;
        break;
    case 2:
        cout << "Ingrese un digito para la suma: ";
        cin >> digito;
        cout << "Suma iterativa: " << SumaIterativa(digito) << endl;
        break;
    default:
        cout << "No existe esa opcion" << endl;
        break;
    }
    return 0;
}

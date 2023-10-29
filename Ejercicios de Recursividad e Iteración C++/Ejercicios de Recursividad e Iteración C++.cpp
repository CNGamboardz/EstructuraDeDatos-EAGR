//Erick Gamboa
//Ejercicios de Recursividad e Iteración

#include <iostream>
#include <string>

using namespace std;

int main()
{
    int NUM, I, RESULT;
    string linea;
    cout << "DIGITE NUMERO: ";
    getline(cin, linea);
    NUM = stoi(linea);
    for (I = 1; I <= 12; I++)
    {
        RESULT = NUM * I;
        cout << NUM << " * " << I << " = " << RESULT << endl;
    }
    cout << "Pulse una tecla: ";
    cin.ignore();
    return 0;
}

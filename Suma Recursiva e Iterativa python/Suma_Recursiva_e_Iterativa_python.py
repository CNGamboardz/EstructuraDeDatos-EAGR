#Erick Gamboa
#Suma de Recursividad y Iterativa

def suma_iterativa(n):
    suma = 0
    while n > 9:
        suma += n % 10
        n //= 10
    return suma + n

def suma_recursiva(n):
    if n <= 9:
        return n
    else:
        return suma_recursiva(n // 10) + n % 10

opcion = int(input("1. Suma Recursiva\n2. Suma Iterativa\nIngrese una opcion: "))

if opcion == 1:
    digito = int(input("Ingrese un numero para la suma: "))
    print("Suma recursiva:", suma_recursiva(digito))
elif opcion == 2:
    digito = int(input("Ingrese un numero para la suma: "))
    print("Suma iterativa:", suma_iterativa(digito))
else:
    print("Opcion no valida.")


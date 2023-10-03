#Practica 02 - Sumatoria de 8 digitos enteros
#Erick Gamboa

NUM = 8
nums = [0] * NUM 
total = 0
for i in range(NUM):
        nums[i] = int(input("Por favor, introduzca el numero: "))
        total += nums[i]
        print("El total de numeros es: ", total)
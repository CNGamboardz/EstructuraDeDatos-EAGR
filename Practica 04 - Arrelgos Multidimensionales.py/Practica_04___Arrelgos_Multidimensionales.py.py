#Erick Gamboa
#Practica 04 - Arrelgos Multidimensionales

maxf = 3
maxc = 5
a = [[0] * maxc for _ in range(maxf)]

print("LIDS 3J")
 #Escribir el array 
for f in range(maxf):
  for c in range(maxc):
    print("Ingresa el valor: ")
    a[f][c] = int (float(input()))

#Leer el array
print (" Los valores del arreglo son los siguientes: ")
for f in range(maxf):
    for c in range(maxc):
      print (a[f][c], end=" ")
      print()
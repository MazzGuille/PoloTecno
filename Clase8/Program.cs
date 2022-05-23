﻿using System.Security.AccessControl;
using static System.Console;
using System.Collections;

Clear();
//1)Crear una matriz de dos dimensiones de tipo int llamada numeros.
int[,] numeros;

//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla.
WriteLine("Indica el numero de filas que tendra la matriz");
int filasMatriz = int.Parse(ReadLine());
WriteLine();

WriteLine("Indica el numero de columnas que tendra la matriz");
int columnasMatriz = int.Parse(ReadLine());
WriteLine();

numeros = new int[filasMatriz, columnasMatriz];

WriteLine($"Numero de filas: {numeros.GetLength(0)}\nNumero de columnas: {numeros.GetLength(1)}");

//3) Declarar un vector de tipo double llamado promedios
double[] promedios;


//4) Recorrer la matriz para su carga con elementos de tipo int
for (int i = 0; i < numeros.GetLength(0); i++)
{

    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        WriteLine($"Introduce un valor para la posicion {i} de la fila");
        int valorFila = int.Parse(ReadLine());

        WriteLine($"Introduce un valor para la posicion {j} de la columna");
        int valorCol = int.Parse(ReadLine());


        numeros[i, j] = valorFila * valorCol;
    }
}

//5) Recorrer la matriz para mostrar cada valor de la matriz
for (int i = 0; i < numeros.GetLength(0); i++)
{

    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        WriteLine();
        WriteLine($"Cuando la posicion es: {i} , {j}; Valor = {numeros[i, j]}");
        WriteLine();
    }
}


int[,] arrayTest;

arrayTest = new int[,]
{
{1}, {2},
{3}, {4}
};

double[] vectorTest;



for(int i = 0; i < arrayTest.GetLength(0); i++)
{
    int suma = 0;
    for(int j = 0; j < arrayTest.GetLength(1); j++)
    {
        suma += arrayTest[i,j];
    }
    WriteLine($"Linea {i} = {suma}");
}

for(int j = 0; j < arrayTest.GetLength(0); j++)
{
    int suma = 0;
    for(int i = 0; i < arrayTest.GetLength(1); i++)
    {
        suma += arrayTest[i,j];
    }
     WriteLine($"columna {j} = {suma}");    
}







double columna11 = numeros[0, 0]; // esto hay que ponerlo de alguna manera dinamico
double columna21 = numeros[1, 0];
double columna12 = numeros[0, 1];
double columna22 = numeros[1, 1];
WriteLine($"Valor columna11: {columna11}");
WriteLine($"Valor columna21: {columna21}");
WriteLine($"Valor columna12: {columna12}");
WriteLine($"Valor columna22: {columna22}");
WriteLine();


double vector0 = (columna11 + columna21) / 2;
double vector1 = (columna12 + columna22) / 2;
WriteLine($"Vector 0: {vector0}");
WriteLine($"Vector 1: {vector1}");
WriteLine();



promedios = new double[] { vector0, vector1 };
WriteLine(promedios[0] + promedios[1]);




//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios



//7) Mostrar los promedios recorriendo el vector promedios




WriteLine("Press any key to finish");
ReadKey();
Clear();


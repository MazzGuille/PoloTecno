using static System.Console;

Clear();
//1)Crear una matriz de dos dimensiones de tipo int llamada numeros.
int [,] numeros;

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


        numeros[i , j] = valorFila * valorCol ;
    }
}

//5) Recorrer la matriz para mostrar cada valor de la matriz
for (int i = 0; i < numeros.GetLength(0); i++)
{
      
    for (int j = 0; j < numeros.GetLength(1); j++)
    {   
        WriteLine();
        WriteLine($"Cuando la posicion es: {i} , {j}; Valor = {numeros[i , j]}");
        WriteLine();
    }
}


//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
promedios = new double[numeros.GetLength(1)];
WriteLine();
WriteLine($"El tamaño del vector es: {promedios.Length}");
WriteLine();
WriteLine($"El promedio del vector es: {promedios.Average()}");


//7) Mostrar los promedios recorriendo el vector promedios




WriteLine("Press any key to finish");
ReadKey();
Clear();


using static System.Console;

Clear();
//1)Crear una matriz de dos dimensiones de tipo int llamada numeros.
int[,] numeros;

//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla.
WriteLine("Indica el numero de filas que tendra la matriz \"Numeros\"");
int filasMatriz = int.Parse(ReadLine());
WriteLine();

WriteLine("Indica el numero de columnas que tendra la matriz \"Numeros\"");
int columnasMatriz = int.Parse(ReadLine());
WriteLine();

numeros = new int[filasMatriz, columnasMatriz];

WriteLine($"El numero de filas de la matriz \"Numeros\" es: {numeros.GetLength(0)}\nEl numero de columnas de la matriz \"Numeros\" es: {numeros.GetLength(1)}");
WriteLine();

//3) Declarar un vector de tipo double llamado promedios
double[] promedios;
promedios = new double[columnasMatriz]; 


//4) Recorrer la matriz para su carga con elementos de tipo int
for (int i = 0; i < numeros.GetLength(0); i++)
{

    for (int j = 0; j < numeros.GetLength(1); j++)
    {
        WriteLine($"Introduce un valor para la posicion {i},{j} de la matriz \"Numeros\"");
        numeros[i,j] = int.Parse(ReadLine());
    }
}

//5) Recorrer la matriz para mostrar cada valor de la matriz
for (int i = 0; i < numeros.GetLength(1); i++)
{
    WriteLine();
    WriteLine($"Columna {i} de la matriz \"Numeros\":");
    for (int j = 0; j < numeros.GetLength(0); j++)
    {
        WriteLine();        
        WriteLine($"Cuando la posicion de la matriz \"Numeros\" es: {j},{i}; Su valor es = {numeros[j, i]}");
    }
    WriteLine();
    
}


//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
double suma = 0;
for (int i = 0; i < columnasMatriz; i++)
{
    suma = 0;
    for(int k = 0; k < filasMatriz; k++)
    {
      suma = suma + numeros[k,i];                     
    }       
    promedios[i] = (suma / columnasMatriz);      
}


//7) Mostrar los promedios recorriendo el vector promedios
for(int i = 0; i < promedios.Length; i++)
{
    WriteLine($"La posicion {i} del vector \"Promedios\" es: {promedios[i]}");
}



WriteLine("Press any key to finish");
ReadKey();
Clear();


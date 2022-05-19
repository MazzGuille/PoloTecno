//1. Pida 10 numeros al usuario.
Console.WriteLine("¡Hola! Acontinuación te pediremos que ingreses 10 numeros aleatorios, y te mostraremos la suma, el mayor, el menor y el promedio de todos los numeros ingresados.\n");

int[] numeros = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Numero {(i + 1)}"  );
    numeros[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}

//2. Calcule la suma de los numeros.
var suma = numeros.Sum();

//3. Calcule el mayor de todos los numeros.
var mayor = numeros.Max();

//4. Calcule el menor de todos los numeros.
var menor = numeros.Min();

//5. Calcule el promedio de todos los numeros.
var promedio = numeros.Average();

//6. Mostrar todos los numeros ingresados.
Console.WriteLine($"Los numeros que ingresaste son: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}, {numeros[6]}, {numeros[7]}, {numeros[8]}, {numeros[9]}\n");

//7. Mostrar los valores calculados en los puntos 2,3,4,5.
Console.WriteLine($"La suma de los numeros es: {suma}\n");
Console.WriteLine($"El mayor de los numeros es: {mayor}\n");
Console.WriteLine($"El menor de los numeros es: {menor}\n");
Console.WriteLine($"El promedio de los numeros es: {promedio}\n");























//1. Pida 10 numeros al usuario.
Console.WriteLine("Ingrese 10 numeros enteros al azar");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());
int num6 = int.Parse(Console.ReadLine());
int num7 = int.Parse(Console.ReadLine());
int num8 = int.Parse(Console.ReadLine());
int num9 = int.Parse(Console.ReadLine());
int num10 = int.Parse(Console.ReadLine());
Console.WriteLine();

//2. Calcule la suma de los numeros.
int suma = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10;
Console.WriteLine($"La suma de los numeros es: {suma}");
Console.WriteLine();

int[] numeros = new int[] { num1, num2, num3, num4, num5, num6, num7, num8, num9, num10 };
//3. Calcule el mayor de todos los numeros.
var mayor = numeros.Max();
Console.WriteLine($"El mayor de los numeros es: {mayor}");
Console.WriteLine();

//4. Calcule el menor de todos los numeros.
var menor = numeros.Min();
Console.WriteLine($"El menor de los numeros es: {menor}");
Console.WriteLine();

//5. Calcule el promedio de todos los numeros.
var promedio = numeros.Average();
Console.WriteLine($"El promedio de los numeros es: {promedio}");
Console.WriteLine();

//6. Mostrar todos los numeros ingresados.
Console.WriteLine($"Los numeros que ingresaste son: {numeros[0]}, {numeros[1]}, {numeros[2]}, {numeros[3]}, {numeros[4]}, {numeros[5]}, {numeros[6]}, {numeros[7]}, {numeros[8]}, {numeros[9]}");

//7. Mostrar los valores calculados en los puntos 2,3,4,5.

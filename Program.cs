int n = 0;
int sumaPares = 0;
bool check = false;

// 1. Solicitar al usuario que ingrese un número entero positivo N mayor que cero.
do
{
    Console.Write(">> Por favor, ingresa un número entero positivo mayor que cero: ");
    check = int.TryParse(Console.ReadLine(), out n);
} while (check == false || n <= 0); // Vuelve a solicitar un número hasta que el usuario ingresa uno válido.

// 2. Calcular la suma de los números enteros positivos pares menores o iguales que N y almacenar el resultado.
for (int i = 2; i <= n; i += 2)
{
    sumaPares += i;
}

// 3. Imprimir en pantalla todos los números enteros positivos menores o iguales que N que sean divisibles entre 2 y 3.
Console.WriteLine("\n>> Los números enteros positivos menores o iguales que {0} que son divisibles entre 2 y 3 son: ", n);
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

// 4. Imprimir en pantalla todos los números enteros positivos menores o iguales que N que sean divisibles entre 3 y 5.
Console.WriteLine("\n>> Los números enteros positivos menores o iguales que {0} que son divisibles entre 3 y 5 son: ", n);
for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

// 5. Imprimir en pantalla la secuencia de números enteros positivos que comienzan en N y se decrementan en 1 hasta que se alcance un valor menor que 1.
Console.WriteLine("\n>> La secuencia de números enteros positivos que comienzan en {0} y se decrementan en 1 hasta llegar a 0 es: ", n);
for (int i = n; i >= 0; i--)
{
    Console.Write(i + " ");
}
Console.WriteLine();

// 6. Imprimir en pantalla el valor de la variable "sumaPares".
Console.WriteLine("\n>> La suma de los números enteros positivos pares menores o iguales que {0} es: {1}", n, sumaPares);

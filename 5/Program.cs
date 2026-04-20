// Solicitar n números en un arreglo y determinar el valor mayor

Console.WriteLine("Ingrese la cantidad de números:");
int n;

while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Error, ingrese un número válido mayor que 0");
}

int[] numeros = new int[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Ingrese el número {i + 1}");
    while (!int.TryParse(Console.ReadLine(), out numeros[i]))
    {
        Console.WriteLine("Ingrese un número válido");
    }
}

int mayor = numeros[0];

for (int i = 1; i < n; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
}

Console.WriteLine($"El número mayor es: {mayor}");
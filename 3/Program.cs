// Solicitar n números enteros, guardarlos en un arreglo y calcular la suma total
int suma = 0;
Console.WriteLine("Ingrese la cantidad de números que quiera guardar:");
int n;

while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Error ingrese un número válido mayor que 0");
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

// SUMAR
for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i];
}

// MOSTRAR RESULTADO
Console.WriteLine("La suma total es: " + suma); 
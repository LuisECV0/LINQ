using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Crear una lista de números enteros
        List<int> numeros = new List<int> { 7, 3, 10, 2, 9, 5, 8, 4, 1, 6 };

        Console.WriteLine("Lista original:");
        MostrarLista(numeros);

        // Ordenar la lista de números en orden ascendente
        var numerosOrdenados = numeros.OrderBy(n => n).ToList();
        Console.WriteLine("\nLista ordenada:");
        MostrarLista(numerosOrdenados);

        // Filtrar los números pares
        var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("\nNúmeros pares:");
        MostrarLista(numerosPares);

        // Ordenar la lista en orden descendente
        var numerosOrdenadosDesc = numeros.OrderByDescending(n => n).ToList();
        Console.WriteLine("\nLista ordenada en orden descendente:");
        MostrarLista(numerosOrdenadosDesc);

        // Filtrar números impares
        var numerosImpares = numeros.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("\nNúmeros impares:");
        MostrarLista(numerosImpares);

    }

    static void MostrarLista(List<int> lista)
    {
        Console.WriteLine(string.Join(", ", lista));
    }
}

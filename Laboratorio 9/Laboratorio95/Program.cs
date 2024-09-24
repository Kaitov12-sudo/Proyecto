﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Aleatorios aleatorios = new Aleatorios();  

        // Generar un número aleatorio entre 1 y 100
        int numeroAleatorio = aleatorios.GenerarNumero();
        Console.WriteLine("Número aleatorio entre 1 y 100: " + numeroAleatorio);

        // Solicitar el tamaño del arreglo
        Console.Write("Ingrese el tamaño del arreglo de números aleatorios: ");
        int tamaño = Convert.ToInt32(Console.ReadLine());

        // Generar un arreglo de números aleatorios entre 1 y 100
        int[] numerosAleatorios = aleatorios.GenerarArreglo(tamaño);
        Console.WriteLine($"Arreglo de números aleatorios entre 1 y 100 (tamaño {tamaño}):");
        foreach (int numero in numerosAleatorios)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        // Generar un arreglo de números no repetidos entre 1 y 100
        int[] numerosNoRepetidos = aleatorios.GenerarArregloSinRepetidos(tamaño);
        Console.WriteLine($"Arreglo de números no repetidos entre 1 y 100 (tamaño {tamaño}):");
        foreach (int numero in numerosNoRepetidos)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}
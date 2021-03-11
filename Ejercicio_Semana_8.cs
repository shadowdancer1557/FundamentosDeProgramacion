using System;
using System.Collections.Generic;
namespace Ejercicio_Semana_8
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //Variables
            string[] palabras;
            string palabraBuscada = "";
            string fraseInicial = "";
            List<int> posicionPalabra = new List<int>();
            int cantidadDeRepeticiones = 0;
            //Entradas
            Console.WriteLine("Ingrese una frase sin signos de puntuacion ni tildes ");
            fraseInicial = Console.ReadLine();
            Console.WriteLine("Ingrese la palabra que desea buscar");
            palabraBuscada = Console.ReadLine();

            //Proceso
            palabras = fraseInicial.Split(" ");// divide las palabras por cada espacio 

            for(int i = 0; i < palabras.Length; i++)//Recorre el arreglo de palabras
            {
                if(palabras[i].ToUpper() == palabraBuscada.ToUpper())//Determina si las palabras son iguales
                {
                    cantidadDeRepeticiones++;//aumenta el contador de la aparicion de la palabra
                    posicionPalabra.Add(i);
                }
            }

            if(cantidadDeRepeticiones > 0)
            {
                Console.WriteLine("La palabra " + palabraBuscada + " se repite: " + cantidadDeRepeticiones + " veces");
                Console.WriteLine("En las posiciones:");
                for (int i = 0; i < posicionPalabra.Count; i++)
                {
                    Console.WriteLine(posicionPalabra[i] + 1);
                }
            }
            else
            {
                Console.WriteLine("La palabra " + palabraBuscada + " no se encuentra en la frase ingresada");
            }

        }
    }
}

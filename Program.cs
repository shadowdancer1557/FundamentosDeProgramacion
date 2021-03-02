using System;

namespace Ejercicio_1
{
    class Program
    {

       

        static void Main(string[] args)
        {
            int contadorPuntos = 0;
            int vidasJugador = 3;
            int numeroDeRonda = 0;
            int tiro = 0;
            int tiro2 = 0;


            string respuesta;
            bool finDelJuego = false;

       
            while (!finDelJuego)
            {
                respuesta = null;
                Console.WriteLine("Actualmente tienes: " + contadorPuntos + " puntos y tienes: " + vidasJugador + " vidas" );
                        
                if(numeroDeRonda % 3 == 0 && numeroDeRonda !=0)
                {
                    Console.WriteLine("En esta ronda se tiraran 2 dados");

                    Console.WriteLine("¿Deseas TIRAR o RETIRARTE? t/r");
                    respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() == "T")
                    {
                        tiro = LanzarDado(6);
                        tiro2 = LanzarDado(6);
                        contadorPuntos += tiro;
                        contadorPuntos += tiro2;
                        numeroDeRonda++;
                        if (tiro == tiro2)
                            vidasJugador++;
                        Console.WriteLine(tiro);
                        Console.WriteLine(tiro2);
                    }
                    else if (respuesta.ToUpper() == "R")
                    {
                        Console.WriteLine("Te has retirado con: " + contadorPuntos + " puntos");
                        finDelJuego = true;
                    }
                    else
                    {
                        Console.WriteLine("La respuesta ingresada no es valida, intente de nuevo");
                    }
                }
                else
                {
                    Console.WriteLine("¿Deseas TIRAR o RETIRARTE? t/r");
                    respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() == "T")
                    {
                        tiro = LanzarDado(6);
                        contadorPuntos += tiro;
                        numeroDeRonda++;
                        Console.WriteLine(tiro);
                    }
                    else if (respuesta.ToUpper() == "R")
                    {
                        Console.WriteLine("Te has retirado con: " + contadorPuntos + " puntos");
                        finDelJuego = true;
                    }
                    else
                    {
                        Console.WriteLine("La respuesta ingresada no es valida, intente de nuevo");
                    }
                }


               if(numeroDeRonda % 2 == 0)
                {
                    vidasJugador--;
                }


                if (vidasJugador > 3)
                    vidasJugador = 3;

                if(vidasJugador == 0)
                {
                    Console.WriteLine("Te has quedado sin vidas, has perdido");
                    Console.WriteLine("Puntuacion: " + contadorPuntos);
                    finDelJuego = true;
                }

                if(contadorPuntos >= 100)
                {
                    Console.WriteLine("Felicidades, has ganado!!!");
                    finDelJuego = true;
                }
            }

        }

        static int LanzarDado(int cantCaras)
        {
            Random _random = new Random();
            return _random.Next(1, cantCaras+1);
        }

    }
}

using System;

namespace Ejercicio_1
{
    class Program
    {

       

        static void Main(string[] args)
        {
            int contadorPuntos = 0;
            int vidasJugador = 3;
            int dadosEspeciales = 2;
            int tiro = 0;


            int contadorDe1s = 0;
            int contadorDe6s = 0;
            string respuesta;
            bool finDelJuego = false;
            bool resetContador6s = false;
       
            while (!finDelJuego)
            {
                respuesta = null;
                Console.WriteLine("Actualmente tienes: " + contadorPuntos + " puntos y tienes: " + vidasJugador + " vidas" );


                if (DadosEspeciales(dadosEspeciales))
                {
                    Console.WriteLine("Tiene disponible " + dadosEspeciales + " Dados especiales ¿Desea usar 1? " + "s/n");
                    respuesta = Console.ReadLine();
                    
                    if(respuesta.ToUpper() == "S")
                    {
                         tiro = LanzarDado(12);
                        contadorPuntos += tiro;
                        dadosEspeciales--;
                        Console.WriteLine(tiro);
                    }
                    else if(respuesta.ToUpper() == "N")
                    {
                        Console.WriteLine("¿Deseas TIRAR o RETIRARTE? t/r");
                        string respuesta1 = Console.ReadLine();

                        if(respuesta1.ToUpper() == "T")
                        {
                            tiro = LanzarDado(6);
                            contadorPuntos += tiro;
                            Console.WriteLine(tiro);
                        }
                        else if(respuesta1.ToUpper() == "R")
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
                        Console.WriteLine("La respuesta ingresada no es valida, intente de nuevo");
                        
                    }
                }
                else
                {
                    Console.WriteLine("¿Deseas TIRAR o RETIRARTE? t/r");
                    string respuesta1 = Console.ReadLine();
                    if (respuesta1.ToUpper() == "T")
                    {
                        tiro = LanzarDado(6);
                        contadorPuntos += tiro;
                        Console.WriteLine(tiro);
                    }
                    else if (respuesta1.ToUpper() == "R")
                    {
                        Console.WriteLine("Te has retirado con: " + contadorPuntos + " puntos");
                        finDelJuego = true;
                    }
                    else
                    {
                        Console.WriteLine("La respuesta ingresada no es valida, intente de nuevo");
                    }

                }
                if (tiro == 1)
                    contadorDe1s++;
                if (tiro == 6)
                {
                    contadorDe6s++;
                    resetContador6s = true;
                }

                if (contadorDe1s == 2)
                {
                    vidasJugador--;
                    contadorDe1s = 0;
                }

                if(contadorDe6s == 1 && resetContador6s)
                {
                    contadorDe6s = 0;
                }else if(contadorDe6s == 2)
                {
                    vidasJugador++;
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

        //Determina si aun hay disponibles dados especiales
        static bool DadosEspeciales(int cantDados)
        {
            if (cantDados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int LanzarDado(int cantCaras)
        {
            Random _random = new Random();
            return _random.Next(1, cantCaras+1);
        }

    }
}

using System.Collections.Generic;

namespace JuegoDeTenis
{
    public class Juego
    {
        public IConsole Console;
        public Juego()
        {
            Console = new ConsoleCust();
        }

        public string JuegoDeTenisEmpezar()
        {
            string result = string.Empty;
            List<Jugador> lista = new List<Jugador>();
            DisplayBanner();
            string userInput = string.Empty;

            do
            {
                userInput = Console.ReadLine();
                switch (System.Convert.ToInt32(userInput))
                {
                    case 1:
                        if (lista.Count == 2)
                        {
                            addSpaces(1);
                            Console.WriteLine("NOT OK. No podemos crear mas de 2 jugadores.");
                            break;
                        }
                        addSpaces(1);
                        Console.WriteLine("Escibir el nombre:");
                        string nombre = Console.ReadLine();
                        Jugador jugador = new Jugador()
                        {
                            Nombre = nombre,
                            Puntos = 0
                        };
                        lista.Add(jugador);
                        addSpaces(1);
                        Console.WriteLine("OK. El jugador creado!");
                        addSpaces(3);
                        DisplayBanner();
                        break;

                    case 2:
                        addSpaces(1);
                        Console.WriteLine("Escibir el nombre:");
                        string nombreParaBuscar = Console.ReadLine();
                        Jugador jugadorEncontrado = lista.Find(j => j.Nombre.Equals(nombreParaBuscar));
                        if (null == jugadorEncontrado)
                        {
                            addSpaces(1);
                            Console.WriteLine("NOT OK. El jugador no encontre.");
                            addSpaces(3);
                            DisplayBanner();
                            break;
                        }
                        addSpaces(1);
                        Console.WriteLine("Escibir el punto:");
                        string puntos = Console.ReadLine();
                        try
                        {
                            jugadorEncontrado.Puntos += System.Convert.ToInt32(puntos);
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("######################################");
                            Console.WriteLine("Puntos solo aceptar valor de numericos");
                            Console.WriteLine("######################################");
                            addSpaces(3);
                            DisplayBanner();
                            break;
                        }

                        addSpaces(1);
                        Console.WriteLine("OK. Aggregando puntos para jugador - " + jugadorEncontrado.Nombre);
                        Console.WriteLine("Player: " + jugadorEncontrado.Nombre + " Puntos: " + jugadorEncontrado.Puntos);
                        addSpaces(3);
                        DisplayBanner();
                        break;

                    case 3:
                        if (lista.Count == 0)
                        {
                            Console.WriteLine("######################################");
                            Console.WriteLine("No existe jugadores. Aggregrar jugadores");
                            Console.WriteLine("######################################");
                            addSpaces(3);
                            DisplayBanner();
                            break;
                        }

                        if (lista.Count < 2)
                        {
                            Console.WriteLine("##############################################");
                            Console.WriteLine("Necesita 2 jugadores por tenis. Aggregrar jugadores");
                            Console.WriteLine("##############################################");
                            addSpaces(3);
                            DisplayBanner();
                            break;
                        }

                        if (lista[0].Puntos >= 40 || lista[1].Puntos >= 40)
                        {
                            if (lista[0].Puntos > 41)
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine(lista[0].Nombre + " wins.");
                                Console.WriteLine("**********************");

                                result = lista[0].Nombre + " wins.";
                                break;
                            }

                            if (lista[1].Puntos > 41)
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine(lista[1].Nombre + " wins.");
                                Console.WriteLine("**********************");

                                result = lista[1].Nombre + " wins.";
                                break;
                            }

                            if (lista[0].Puntos == 40 && lista[1].Puntos == 40)
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine("Deuce");
                                Console.WriteLine("**********************");

                                result = "Deuce";
                            }

                            else if (lista[0].Puntos > lista[1].Puntos)
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine("Advantage " + lista[0].Nombre);
                                Console.WriteLine("**********************");

                                result = "Advantage " + lista[0].Nombre;
                            }
                            else if (lista[0].Puntos < lista[1].Puntos)
                            {
                                Console.WriteLine("**********************");
                                Console.WriteLine("Advantage " + lista[1].Nombre);
                                Console.WriteLine("**********************");

                                result = "Advantage " + lista[1].Nombre;
                            }
                        }
                        else
                        {
                            Console.WriteLine("========================");
                            Console.WriteLine("Player: " + lista[0].Nombre + " Puntos: " + lista[0].Puntos);
                            Console.WriteLine("Player: " + lista[1].Nombre + " Puntos: " + lista[1].Puntos);
                            Console.WriteLine("========================");

                            result = lista[0].Nombre + " " + lista[0].Puntos + " " + lista[1].Nombre + " " + lista[1].Puntos;
                        }

                        addSpaces(3);
                        DisplayBanner();

                        break;
                    default:
                        Console.WriteLine("Chao");
                        break;
                }
            } while (!userInput.Equals("4"));

            return result;
        }

        public void DisplayBanner()
        {
            Console.WriteLine("**************");
            Console.WriteLine("Juego de tenis");
            Console.WriteLine("**************");

            Console.WriteLine("*******MENU*******");
            Console.WriteLine("1. Crear jugador");
            Console.WriteLine("2. Aggregar puntos");
            Console.WriteLine("3. Ver puntos");
            Console.WriteLine("4. Salir");
        }

        public void addSpaces(int i)
        {
            for (int j = 0; j < i; j++)
                Console.WriteLine("");
        }
    }
}

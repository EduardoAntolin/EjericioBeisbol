using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion y inicializacion de lista de jugadores
            List<Equipo> equipos = new List<Equipo>();
           

            //Declaracion y asignacion de valores jugadores
            //Declaracion de equipo
            Equipo jugador1 = new Equipo();
            
           
            equipos.Add(new Equipo());
            equipos[0].Nombre = "Guajolotes FC";
            equipos[0].CiudadOrigen = "MonTeJuana";
            equipos[0].Entrenador = "Javier Contreras";
            equipos[0].estadio = new Estadio();
            equipos[0].estadio.NombreEstadio = "Estadio 1 ";
            equipos[0].estadio.Direccion = "Al fondo a la derecha";
            equipos[0].estadio.Capacidad = 90000;
            
            //Añadir Jugadores 
            equipos[0].Jugadores.Add(new Jugador("Kami Tokotori", "28"));
            equipos[0].Jugadores.Add(new Jugador("Tori Kamitori", "18"));
            equipos[0].Jugadores.Add(new Jugador("Esteban Dido", "32"));
            equipos[0].Jugadores.Add(new Jugador("Elsa Bandija", "24"));
            equipos[0].Jugadores.Add(new Jugador("Escrom Lambin", "23"));
            equipos[0].Jugadores.Add(new Jugador("Niko ni", "32"));
            equipos[0].Jugadores.Add(new Jugador("Morelo Micon", "54"));
            equipos[0].Jugadores.Add(new Jugador("Elso millon", "25"));
            equipos[0].Jugadores.Add(new Jugador("Molino ventudo", "44"));

            //New equipo
            Equipo Jugador2 = new Equipo();
            equipos.Add(new Equipo());
            equipos[1].Nombre = "Equipo sin nombrexd";
            equipos[1].CiudadOrigen = "Morelia Yucatan";
            equipos[1].Entrenador = "Siguririgu";
            equipos[1].estadio = new Estadio();
            equipos[1].estadio = null;
            //Añadir Jugadoreds 
            equipos[1].Jugadores.Add(new Jugador("Osbaldo moreno", "25"));
            equipos[1].Jugadores.Add(new Jugador("Spider man", "25"));
            equipos[1].Jugadores.Add(new Jugador("Sigurirur", "15"));
            equipos[1].Jugadores.Add(new Jugador("Buen canal", "41"));
            equipos[1].Jugadores.Add(new Jugador("Hola bola", "43"));
            equipos[1].Jugadores.Add(new Jugador("Nombre feik", "32"));
            equipos[1].Jugadores.Add(new Jugador("Nombre real", "42"));
            equipos[1].Jugadores.Add(new Jugador("El pei nado", "34"));
            equipos[1].Jugadores.Add(new Jugador("Stemenxd", "42"));

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre);
                Console.WriteLine("Ciudad de origen " + equipo.Nombre);
                Console.WriteLine("Entrenador " + equipo.Entrenador);
                //If nulos por si no se añaden datos 
                if (equipo.estadio != null)
                {
                    Console.WriteLine("Nombre estadio: " + equipo.estadio.NombreEstadio);
                    Console.WriteLine("Direccion del estadio: " + equipo.estadio.Direccion);
                    Console.WriteLine("Capacidad del estadio: " + equipo.estadio.Capacidad);
                }
                else
                {
                    Console.WriteLine("No se añadieron datos");
                }
                foreach (Jugador jugadores in equipo.Jugadores)
                {
                    Console.WriteLine("Jugador " + jugadores.Nombre);
                    Console.WriteLine("Numero " + jugadores.Numero);
                }
            }
            Console.ReadLine();   
        }
    }
}

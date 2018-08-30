using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }
        public string Entrenador { get; set; }
        public Estadio estadio { get; set; }

        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Nombre = "Inserte nombre";
            Jugadores = new List<Jugador>();
        }
    }
}

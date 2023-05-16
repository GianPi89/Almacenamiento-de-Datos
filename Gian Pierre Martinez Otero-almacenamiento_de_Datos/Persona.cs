using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace almacenamientoDeDatos
{

    public class Persona
    {
        //public static List<Persona> persona = new List<Persona>();


        public int id { get; set; }
        public string name { get; set; }

        public Persona(int _id, string _name) {
            id = _id;
            name = _name;
        }


    }
}

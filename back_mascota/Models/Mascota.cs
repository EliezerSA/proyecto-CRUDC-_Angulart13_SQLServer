using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_mascota.Models
{
    public class Mascota
    {
        public int idMascota { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public string descripcion{ get; set; }


        public Mascota() { }

        public Mascota(int id, string Nombre, int Edad, string desc)
        {
            idMascota = id;
            nombre = Nombre;
            edad = Edad;
            descripcion = desc;

        }

        public Mascota(string Nombre, int Edad, string desc)
        {
            nombre = Nombre;
            edad = Edad;
            descripcion = desc;

        }
    }
}
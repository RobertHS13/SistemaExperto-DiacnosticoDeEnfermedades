using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reciclaje
{
    class Material
    {
        public string imagen;
        public string nombre;
        public string nombreProlog;
        public int posicion;

        public Material()
        {

        }

        public Material(string imagen, string nombre, string nombreProlog, int posicion)
        {
            this.imagen = imagen;
            this.nombre = nombre;
            this.nombreProlog = nombreProlog;
            this.posicion = posicion;
        }

        public string Imagen { get => imagen; set => imagen = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreProlog { get => nombreProlog; set => nombreProlog = value; }
        public int Posicion { get => posicion; set => posicion = value; }
    }
}

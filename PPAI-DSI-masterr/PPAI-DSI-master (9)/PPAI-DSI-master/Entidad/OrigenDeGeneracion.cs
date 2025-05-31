using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class OrigenDeGeneracion
    {
        //Atributos
        private string descripcion;
        private string nombre;

        // Constructor
        public OrigenDeGeneracion(string descripcion, string nombre) 
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        //Metodos
        public void obtenerOrigenGeneracion()
        {
            // implementar lógica para obtener origen de generación
        }
        public string getNombre() { return nombre; }


    }
}

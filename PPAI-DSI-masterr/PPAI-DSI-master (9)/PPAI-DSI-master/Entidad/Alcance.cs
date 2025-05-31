using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PPAI_DSI.Entidad
{
    public class Alcance
    {
        // Atributos
        private string descripcion;
        private string nombre;

        // Constructor
        public Alcance(string descripcion, string nombre) 
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        // Metodos
        public void obtenerAlcance()
        {

        }
        public string getNombre() { return nombre; }


    }
}

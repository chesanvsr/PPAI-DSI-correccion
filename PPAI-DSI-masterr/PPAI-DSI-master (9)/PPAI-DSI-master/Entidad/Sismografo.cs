using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class Sismografo
    {
        // Atributos
        private DateTime fechaAdquisicion;
        private int idSismografo;
        private int nroSerie;

        // Constructor
        public Sismografo(DateTime fechaAdquisicion, int idSismografo, int nroSerie) 
        {
            this.fechaAdquisicion = fechaAdquisicion;
            this.idSismografo = idSismografo;
            this.nroSerie = nroSerie;
        }

        // Métodos
        public void getEstación() 
        {

        }
    }
}

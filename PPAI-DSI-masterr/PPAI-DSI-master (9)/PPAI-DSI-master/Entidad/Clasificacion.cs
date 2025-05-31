using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class Clasificacion
    {
        // Atributos 
        private double kmProfundidadDesde;
        private double kmProfundidadHasta;
        private string nombre;

        // Constructor
        public Clasificacion(double kmProfundidadDesde, double kmProfundidadHasta, string nombre) 
        {
            this.kmProfundidadDesde = kmProfundidadDesde;
            this.kmProfundidadHasta = kmProfundidadHasta;
            this.nombre = nombre;
        }
        public double getDesde() { return kmProfundidadDesde; }
        public double getHasta() { return kmProfundidadHasta; }
        public string getNombre() { return nombre; }


        // Metodos
        public void obtenerClasificacion() { }
    }
}

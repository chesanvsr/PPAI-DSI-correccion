using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class MuestraSismica
    {
        // Atributos
        private DateTime fechaHoraMuestra;
        private List<DetalleMuestraSismica> detalles;

        // Constructor
        public MuestraSismica(DateTime fechaHoraMuestra, List<DetalleMuestraSismica> detalles) 
        {
            this.fechaHoraMuestra = fechaHoraMuestra;
            this.detalles = detalles ?? new List<DetalleMuestraSismica>();
        }

        // Metodos

        // Getter para fecha y hora de la muestra
        public DateTime getFechaHora()
        {
            return fechaHoraMuestra;
        }

        // Método genérico para buscar un detalle por denominación
        private double obtenerValorPorDenominacion(string denominacion)
        {
            // Recorremos la lista de detalles
            foreach (var detalle in detalles)
            {
                // Si la denominación del tipo coincide con la que buscamos
                if (detalle.getTipo().getDenominacion() == denominacion)
                {
                    // Devolvemos el valor de ese detalle
                    return detalle.getValor();
                }
            }

            // Si no encontramos ningún detalle con esa denominación, devolvemos 0
            return 0;
        }


        public double getVelocidadOnda()
        {
            return obtenerValorPorDenominacion("Velocidad de Onda");
        }

        public double getFrecuenciaOnda()
        {
            return obtenerValorPorDenominacion("Frecuencia de Onda");
        }

        public double getLongitudOnda()
        {
            return obtenerValorPorDenominacion("Longitud de Onda");
        }
        
        public void crearDetalleMuestra() { }
        public void crear() { }
        public void obtenerMuestra() { }
    }
}

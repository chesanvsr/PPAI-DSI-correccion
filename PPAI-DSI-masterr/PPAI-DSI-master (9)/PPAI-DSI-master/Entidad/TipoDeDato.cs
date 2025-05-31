using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class TipoDeDato
    {
        // Atributos
        private string denominacion;
        private string nombreUnidadMedida;
        private double valorUmbral;

        // Constructor
        public TipoDeDato(string denominacion, string nombreUnidadMedida, double valorUmbral) 
        {
            this.denominacion = denominacion;
            this.nombreUnidadMedida = nombreUnidadMedida;
            this.valorUmbral = valorUmbral;
        }

        // Metodos

        public string getDenominacion() => denominacion;
        public string getNombreUnidadMedida() => nombreUnidadMedida;
        public double getValorUmbral() => valorUmbral;


        public string GetDatos()
        {
            return $"Denominacion: {denominacion} - Nombre Unidad Medida: {nombreUnidadMedida} - Valor Umbral: {valorUmbral}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class DetalleMuestraSismica
    {
        // Atributos 
        private double valor;
        private TipoDeDato tipo;


        // Constructor
        public DetalleMuestraSismica(double valor, TipoDeDato tipoDeDato)
        {
            this.valor = valor;
            this.tipo = tipoDeDato;
        }

        // Metodos
        public double getValor() => valor;
        public TipoDeDato getTipo() => tipo;


    }
}

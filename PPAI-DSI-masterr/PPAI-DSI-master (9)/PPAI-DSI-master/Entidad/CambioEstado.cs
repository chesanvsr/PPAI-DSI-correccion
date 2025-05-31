using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class CambioEstado
    {
        // Atributos
        private DateTime fechaHoraInicio;
        private DateTime? fechaHoraFin;
        private Empleado empleado;
        private Estado estado;

        // Constructor
        public CambioEstado (DateTime fechaHoraInicio, DateTime? fechaHoraFin, Empleado empleado, Estado estado) 
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.empleado = empleado;
            this.estado = estado;
        }

        // Metodos
        public bool esEstadoActual()
        {
            if (fechaHoraFin == null)
            {
                return true;
            }
            return false;
        }

        public bool esPteRevision() 
        {
            if (this.estado.sosPteRevision()) 
            {
                return true;
            }
            return false;
        }

        public void setFechaHoraFin(DateTime fechaFin)
        {
            if (fechaHoraFin == null)
            {
                fechaHoraFin = fechaFin;
            }
        }

        public Estado GetEstado() => estado;
 
        public void crear()
        {

        }


    }
}

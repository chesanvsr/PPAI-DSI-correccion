using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class Sesion
    {
        // Atributos
        private DateTime fechaHorarioInicio;
        private DateTime? fechaHoraFin;
        private Usuario usuario;


        // Constructor
        public Sesion(DateTime fechaHorarioInicio, DateTime? fechaHoraFin, Usuario usuario) 
        {
            this.fechaHorarioInicio = fechaHorarioInicio;
            this.fechaHoraFin = fechaHoraFin;
            this.usuario = usuario;
        }

        //Metodos
        public Usuario obtenerUsuarioLogueado()
        {
            return usuario;

        }
    }
}

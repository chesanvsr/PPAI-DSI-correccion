using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class Usuario
    {
        // Atributos
        private string contraseña;
        private string nombreUsuario;
        private Empleado empleado;

        // Constructor
        public Usuario(string contraseña, string nombreUsuario, Empleado empleado) 
        {
            this.contraseña = contraseña;
            this.nombreUsuario = nombreUsuario;
            this.empleado = empleado;
        }

       
        // Método para obtener el nombre del usuario
        public Empleado obtenerEmpleado()
        {
            return empleado;
        }



    }
}

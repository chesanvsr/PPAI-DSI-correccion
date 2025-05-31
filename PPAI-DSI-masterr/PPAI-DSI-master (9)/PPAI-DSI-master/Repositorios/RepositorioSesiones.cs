using PPAI_DSI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Repositorios
{
    public class RepositorioSesiones
    {
        private List<Sesion> sesiones = new List<Sesion>
        {
            new Sesion(
                DateTime.Parse("2025-05-24 10:30"),
                null,
                new Usuario("123", "admin123", new Empleado("Nom456", "Ape123"))
            )
        };

        public Sesion ObtenerSesionActiva()
        {
            return sesiones[0]; // Simula que hay una única sesión activa
        }
    }
}


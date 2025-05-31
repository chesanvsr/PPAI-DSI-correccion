using PPAI_DSI.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Repositorios
{
    public class RepositorioEstados
    {
        private List<Estado> estados = new List<Estado>
        {
            new Estado("Evento Sismico", "PendienteRevision"),
            new Estado("Evento Sismico", "Bloqueado"),
            new Estado("Evento Sismico", "Rechazado"),
            new Estado("Evento Sismico", "AutoDetectado"),
            new Estado("Evento Sismico", "EventoSinRevision"),
            new Estado("Evento Sismico", "AutoConfirmado"),
            new Estado("Evento Sismico", "Confirmado")


        };

        public List<Estado> ObtenerTodos()
        {
            return estados;
        }
    }
}

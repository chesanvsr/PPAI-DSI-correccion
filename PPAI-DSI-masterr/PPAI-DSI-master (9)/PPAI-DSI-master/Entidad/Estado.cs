using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class Estado
    {
        // Atributos
        private string ambito;
        private string nombre;

        // Constructor
        public Estado(string ambito, string nombre)
        {
            this.ambito = ambito;
            this.nombre = nombre;
        }

        public bool sosPteRevision()
        {
            if (this.nombre.Equals("PendienteRevision"))
            {
                return true;
            }
            return false;
        }

        public bool sosBloqueado()
        {
            if (this.nombre.Equals("Bloqueado"))
            {
                return true;
            }
            return false;
        }

        public bool esRechazado()
        {
            if (this.nombre.Equals("Rechazado"))
            {
                return true;
            }
            return false;
        }

        public bool esAmbitoES()
        {
            if (this.ambito.Equals("Evento Sismico"))
            {
                return true;
            }
            return false;
        }
        public bool esConfirmado()
        {
            return nombre.Equals("Confirmado", StringComparison.OrdinalIgnoreCase);
        }

        public bool esDerivado()
        {
            return nombre.Equals("Derivado", StringComparison.OrdinalIgnoreCase);
        }

       

    }
}
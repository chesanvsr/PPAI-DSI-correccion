using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// RepositorioProvider.cs  (en tu carpeta Repositorios)
namespace PPAI_DSI.Repositorios
{
    public static class RepositorioProvider
    {
        public static RepositorioEventosSismicos Eventos { get; } = new RepositorioEventosSismicos();
        public static RepositorioEstados Estados { get; } = new RepositorioEstados();
        public static RepositorioSesiones Sesiones { get; } = new RepositorioSesiones();
    }
}

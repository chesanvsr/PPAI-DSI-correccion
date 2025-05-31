using System;
using System.Collections.Generic;
using System.Linq;
using PPAI_DSI.Entidad;
using PPAI_DSI.Interfaz;
using PPAI_DSI.Repositorios;
using System.Windows.Forms;

namespace PPAI_DSI.Control
{
    public class GestorRegResultado
    {
        private List<EventoSismico> eventosSismicos;
        private List<EventoSismico> eventosPteRevision;
        private EventoSismico eventoSeleccionado;
        private List<Estado> estados;
        private PantallaRegResultado pantallaRegResultado;
        private Sesion sesion;

        private GestorGenerarSismograma gestorGenerarSismograma;

        public GestorRegResultado(PantallaRegResultado pantalla)
        {
            pantallaRegResultado = pantalla;
            eventosPteRevision = new List<EventoSismico>();
            eventosSismicos = RepositorioProvider.Eventos.ObtenerTodos().ToList();
            estados = RepositorioProvider.Estados.ObtenerTodos().ToList();
            sesion = RepositorioProvider.Sesiones.ObtenerSesionActiva();
            gestorGenerarSismograma = new GestorGenerarSismograma();
        }

        public void opRegResultadosRevision()
        {
            buscarEventoPteRevision();
        }

        public void buscarEventoPteRevision()
        {
            eventosPteRevision.Clear();

            foreach (var evento in eventosSismicos)
            {
                if (evento.estaPendienteRevision())
                {
                    eventosPteRevision.Add(evento);
                }
            }

            if (eventosPteRevision.Count == 0)
            {
                MessageBox.Show("No hay sismos auto detectados pendientes de revisión.");
                return;
            }

            ordenarPorFechaHora();
            pantallaRegResultado.solicitarSelecEventoSismico(eventosPteRevision);
        }

        public void ordenarPorFechaHora()
        {
            eventosPteRevision = eventosPteRevision.OrderBy(ev => ev.getFechaHoraOcurrencia()).ToList();
        }

        public void tomarSelecEventoSismico(EventoSismico evento)
        {
            DateTime fechaHoraActual = getFechaHoraActual();
            Empleado usuarioLogueado = buscarUsuarioLogueado();
            Estado estadoBloqueado = buscarEstadoBloqueado();

            eventoSeleccionado = evento;
            eventoSeleccionado.revisar(fechaHoraActual, usuarioLogueado, estadoBloqueado);

            gestorGenerarSismograma.ejecutar();
        }

        public DateTime getFechaHoraActual()
        {
            return DateTime.Now;
        }

        public Empleado buscarUsuarioLogueado()
        {
            return sesion.obtenerUsuarioLogueado().obtenerEmpleado();
        }

        public Estado buscarEstadoBloqueado()
        {
            foreach (var estado in estados)
            {
                if (estado.sosBloqueado() && estado.esAmbitoES())
                {
                    return estado;
                }
            }
            return null;
        }

        public void validarExistencias(EventoSismico evento, string accion)
        {
            if ((evento.getValorMagnitud().Equals("null") || string.IsNullOrEmpty(evento.getNombreAlcance()) || string.IsNullOrEmpty(evento.getNombreOrigenGeneracion())))
            {
                MessageBox.Show("Faltan datos obligatorios del evento (magnitud, alcance u origen).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(accion))
            {
                MessageBox.Show("Por favor, seleccione una opción (Confirmar, Rechazar o Solicitar Revisión).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaHoraActual = getFechaHoraActual();
            Empleado usuarioLogueado = buscarUsuarioLogueado();
            eventoSeleccionado = evento;

            if (accion.Equals("Rechazar"))
            {
                Estado estadoRechazado = buscarEstadoRechazado();
                eventoSeleccionado.rechazar(fechaHoraActual, usuarioLogueado, estadoRechazado);
                MessageBox.Show("Evento rechazado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (accion.Equals("Confirmar"))
            {
                Estado estadoConfirmado = buscarEstadoConfirmado();
                eventoSeleccionado.confirmar(fechaHoraActual, usuarioLogueado, estadoConfirmado);
                MessageBox.Show("Se confirmó correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (accion.Equals("Derivar"))
            {
                Estado estadoDerivado = buscarEstadoDerivado();
                eventoSeleccionado.derivar(fechaHoraActual, usuarioLogueado, estadoDerivado);
                MessageBox.Show("Se solicitó la revisión correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Application.Exit();
        }

        public Estado buscarEstadoRechazado()
        {
            foreach (var estado in estados)
            {
                if (estado.esRechazado() && estado.esAmbitoES())
                {
                    return estado;
                }
            }
            return null;
        }

        public Estado buscarEstadoConfirmado()
        {
            foreach (var estado in estados)
            {
                if (estado.esConfirmado() && estado.esAmbitoES())
                {
                    return estado;
                }
            }
            return null;
        }

        public Estado buscarEstadoDerivado()
        {
            foreach (var estado in estados)
            {
                if (estado.esDerivado() && estado.esAmbitoES())
                {
                    return estado;
                }
            }
            return null;
        }

        public void finCU()
        {
            MessageBox.Show("El evento sísmico ha sido rechazado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}

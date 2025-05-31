using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class EventoSismico
    {
        // Atributo 
        private DateTime fechaHoraOcurrencia;
        private DateTime? fechaHoraFin;
        private double latitudEpicentro;
        private double longitudEpicentro;
        private double latitudHipocentro;
        private double longitudHipocentro;
        private double valorMagnitud;
        private List<CambioEstado> cambiosEstado;
        private Alcance alcance;
        private OrigenDeGeneracion origenGeneracion;
        private Clasificacion clasificacion;
        private List<SerieTemporal> seriesTemporales;
        private Estado estadoActual;



        // Constructor

        public EventoSismico(
            DateTime fechaHoraOcurrencia,
            DateTime? fechaHoraFin,
            double latitudEpicentro,
            double longitudEpicentro,
            double latitudHipocentro,
            double longitudHipocentro,
            double valorMagnitud,
            List<CambioEstado> cambiosEstado,
            Alcance alcance,
            OrigenDeGeneracion origenGeneracion,
            Clasificacion clasificacion,
            List<SerieTemporal> seriesTemporales,
            Estado estadoActual)
        {
            this.fechaHoraOcurrencia = fechaHoraOcurrencia;
            this.fechaHoraFin = fechaHoraFin;
            this.latitudEpicentro = latitudEpicentro;
            this.longitudEpicentro = longitudEpicentro;
            this.latitudHipocentro = latitudHipocentro;
            this.longitudHipocentro = longitudHipocentro;
            this.valorMagnitud = valorMagnitud;
            this.cambiosEstado = cambiosEstado ?? new List<CambioEstado>();
            this.alcance = alcance;
            this.origenGeneracion = origenGeneracion;
            this.clasificacion = clasificacion;
            this.seriesTemporales = seriesTemporales ?? new List<SerieTemporal>();
            this.estadoActual = estadoActual;
        }

        // Metodos
        public bool estaPendienteRevision()
        {
            return estadoActual != null && estadoActual.sosPteRevision();
        }


        public void revisar(DateTime fechaHoraActual, Empleado usuarioLogueado, Estado nuevoEstado) 
        {
            buscarEstadoActual();
            crearCambioEstado(fechaHoraActual, usuarioLogueado, nuevoEstado);
        }

        public void rechazar(DateTime fechaHoraActual, Empleado usuarioLogueado, Estado nuevoEstado)
        {
            buscarEstadoActual();
            crearCambioEstado(fechaHoraActual, usuarioLogueado, nuevoEstado);
        }

        public void buscarEstadoActual() 
        {
            foreach (var cambioEstado in cambiosEstado)
            {
                if (cambioEstado.esEstadoActual())
                {
                    cambioEstado.setFechaHoraFin(DateTime.Now);
                    break;

                }
            }
        }

        public void crearCambioEstado(DateTime fechaHoraActual, Empleado usuarioLogueado, Estado nuevoEstado)
        {
            var cambio = new CambioEstado(fechaHoraActual, null, usuarioLogueado, nuevoEstado);
            cambiosEstado.Add(cambio);
            estadoActual = nuevoEstado;
        }


        public string getNombreAlcance()
        {
            return alcance.getNombre();
        }

        public string getNombreOrigenGeneracion()
        {
            return origenGeneracion.getNombre();
        }

        public string getNombreClasificacion()
        {
            return clasificacion.getNombre();
        }


        public (Alcance alcance, OrigenDeGeneracion origen, Clasificacion clasificacion) obtenerDatosEventoSismico()
        {
            return (alcance, origenGeneracion, clasificacion);
        }

        public void registrarEventoRechazado() { }

        public DateTime getFechaHoraOcurrencia() 
        {
            return fechaHoraOcurrencia;
        }

        public DateTime? getFechaHoraFin() 
        {
            return fechaHoraFin;
        }

        public double getLatitudEpicentro() 
        {
            return latitudEpicentro;
        }

        public double getLongitudEpicentro() 
        {
            return longitudEpicentro;
        }

        public double getLatitudHipocentro() 
        {
            return latitudHipocentro;
        }

        public double getLongitudHipocentro() 
        {
            return longitudHipocentro;
        }

        public double getValorMagnitud() 
        {
            return valorMagnitud;
        }
        public void setFechaHoraFin(DateTime fechaHoraFin) 
        {
            this.fechaHoraFin = fechaHoraFin;
        }

        public List<SerieTemporal> obtenerDatosSeriesTemporales()
        {
            return seriesTemporales;
        }
        

        public void confirmar(DateTime fechaHoraActual, Empleado usuarioLogueado, Estado nuevoEstado)
        {
            CambioEstado cambio = new CambioEstado(fechaHoraActual, null, usuarioLogueado, nuevoEstado);
            agregarCambioEstado(cambio);
        }

        public void derivar(DateTime fechaHoraActual, Empleado usuarioLogueado, Estado nuevoEstado)
        {
            CambioEstado cambio = new CambioEstado(fechaHoraActual, null, usuarioLogueado, nuevoEstado);
            agregarCambioEstado(cambio);
        }

        private void agregarCambioEstado(CambioEstado cambio)
        {
            cambiosEstado.Add(cambio);
        }

    }
}

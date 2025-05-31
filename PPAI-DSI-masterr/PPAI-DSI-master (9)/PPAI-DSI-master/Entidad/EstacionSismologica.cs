using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_DSI.Entidad
{
    public class EstacionSismologica
    {
        //Atributos
        public int codigoEstacion;
        public string documentoCertificacionAdq;
        public DateTime fechaSolicitudAdquisicion;
        public float latitud;
        public float longitud;
        public string nombre;
        public int nroCertificacionAdquisicion;

        //Constructor
        public EstacionSismologica (int codigoEstacion, string documentoCertificacionAdq, DateTime fechaSolicitudAdquisicion, float latitud, float longitud, string nombre, int nroCertificacionAdquisicion) 
        {
            this.codigoEstacion = codigoEstacion;
            this.documentoCertificacionAdq = documentoCertificacionAdq;
            this.fechaSolicitudAdquisicion = fechaSolicitudAdquisicion;
            this.latitud = latitud;
            this.longitud = longitud;
            this.nombre = nombre;
            this.nroCertificacionAdquisicion = nroCertificacionAdquisicion;                 
        }

        //Metodos
        public int getCodigoEstacion()
        {
            return codigoEstacion;
        }

    }
}

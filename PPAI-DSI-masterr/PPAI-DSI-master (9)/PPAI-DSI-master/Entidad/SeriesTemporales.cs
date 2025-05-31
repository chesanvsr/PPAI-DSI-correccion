using System;
using System.Collections.Generic;

namespace PPAI_DSI.Entidad
{
    public class SerieTemporal
    {
        // Atributos
        private string condicionAlarma;
        private DateTime fechaHoraInicioRegistroMuestras;
        private DateTime fechaHoraRegistro;
        private int frecuenciaMuestreo;
        private List<MuestraSismica> muestras;
        private EstacionSismologica estacion;

        // Constructor
        public SerieTemporal(
            string condicionAlarma,
            DateTime fechaHoraInicioRegistroMuestras,
            DateTime fechaHoraRegistro,
            int frecuenciaMuestreo,
            List<MuestraSismica> muestras,
            EstacionSismologica estacion)
        {
            this.condicionAlarma = condicionAlarma;
            this.fechaHoraInicioRegistroMuestras = fechaHoraInicioRegistroMuestras;
            this.fechaHoraRegistro = fechaHoraRegistro;
            this.frecuenciaMuestreo = frecuenciaMuestreo;
            this.muestras = muestras ?? new List<MuestraSismica>();
            this.estacion = estacion;
        }

        //Métodos
        public EstacionSismologica getEstacionSismologica()
        {
            return estacion;
        }

        public void setEstacionSismologica(EstacionSismologica estacion)
        {
            this.estacion = estacion;
        }

        public List<MuestraSismica> getMuestras()
        {
            return muestras;
        }

        public string getCondicionAlarma()
        {
            return condicionAlarma;
        }

        public DateTime getFechaHoraInicioRegistroMuestras()
        {
            return fechaHoraInicioRegistroMuestras;
        }

        public DateTime getFechaHoraRegistro()
        {
            return fechaHoraRegistro;
        }

        public int getFrecuenciaMuestreo()
        {
            return frecuenciaMuestreo;
        }
    }
}


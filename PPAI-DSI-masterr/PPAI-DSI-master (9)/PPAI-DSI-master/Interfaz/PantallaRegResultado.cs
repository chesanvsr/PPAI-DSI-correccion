using PPAI_DSI.Control;
using PPAI_DSI.Entidad;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI.Interfaz
{
    public class PantallaRegResultado
    {
        // Atributos
        private GestorRegResultado gestor;
        private RegistroResultadoES formRegResultadoES;
        private AccionesEvento formAccionesEvento;

        private string opcionSeleccionada; // Puede ser "Confirmar", "Rechazar", "Revisión"


        // Constructor
        public PantallaRegResultado()
        {
            gestor = new GestorRegResultado(this);
        }

        // Métodos
        public void opRegResultados() 
        {
            habilitarPantalla();
            gestor.opRegResultadosRevision();
        }

        public void habilitarPantalla() 
        {
            formRegResultadoES = new RegistroResultadoES(this);
            formRegResultadoES.Show();
        }

        public void solicitarSelecEventoSismico(List<EventoSismico> eventosPteRevision) 
        {
            foreach (var evento in eventosPteRevision)
            {
                formRegResultadoES.agregarEventoSismico(evento);
            }
        }

        public void tomarSelecEventoSismico(EventoSismico evento) 
        {
            gestor.tomarSelecEventoSismico(evento);
        }

        public void solicitarOpMapa(EventoSismico evento)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea visualizar en un mapa el evento sísmico y las estaciones sismológicas involucradas?",
                "Generar Mapa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            tomarOpMapa(resultado == DialogResult.Yes, evento);

        }

        public void tomarOpMapa(bool deseaVerMapa, EventoSismico evento)
        {
            if (deseaVerMapa)
            {
                // Aquí iría la lógica para mostrar el mapa (puede ser abrir un nuevo form con un control de mapa)
                MessageBox.Show("Mostrando el mapa del evento y las estaciones..."); // Placeholder
            }
            else
            {
                MessageBox.Show("Visualización del mapa cancelada.");
            }
            // Una vez procesado el mapa, consultamos modificación de datos
            solicitarOpModificarDatos(evento);
        }
        public void solicitarOpModificarDatos(EventoSismico evento)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea modificar los datos del evento sísmico?",
                "Modificar Datos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            tomarOpModificarDatos(resultado == DialogResult.Yes, evento);
        }

        public void tomarOpModificarDatos(bool deseaModificar, EventoSismico evento)
        {
            if (deseaModificar)
            {
                MessageBox.Show("Funcionalidad para modificar datos aún no implementada.");
            
            }

            formAccionesEvento = new AccionesEvento(evento, this);
            formAccionesEvento.Show();
        }

     
    }
}

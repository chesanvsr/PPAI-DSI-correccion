using PPAI_DSI.Entidad;
using PPAI_DSI.Interfaz;
using PPAI_DSI.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_DSI
{
    public partial class RegistroResultadoES : Form
    {
        private PantallaRegResultado pantallaRegResultado;
        DataTable tabla;
        private List<EventoSismico> eventosMostrados = new List<EventoSismico>();
        public RegistroResultadoES(PantallaRegResultado pantallaRegResultado)
        {
            InitializeComponent();
            this.pantallaRegResultado = pantallaRegResultado;
        }

        private void RegistroResultadoES_Load(object sender, EventArgs e)
        {
            // Limpiar si ya existen datos
            if (tabla != null)
            {
                tabla.Clear();
                eventosMostrados.Clear();
            }

            tabla = new DataTable("tabla");
            tabla.Columns.Add("Fecha Hora Ocurrencia", typeof(DateTime));
            tabla.Columns.Add("Latitud Epicentro", typeof(double));
            tabla.Columns.Add("Longitud Epicentro", typeof(double));
            tabla.Columns.Add("Latitud Hipocentro", typeof(double));
            tabla.Columns.Add("Longitud Hipocentro", typeof(double));
            tabla.Columns.Add("Magnitud", typeof(double));
            dataGridViewES.DataSource = tabla;


            //limpia la seleccion por defecto
            dataGridViewES.ClearSelection();
        }

        public void agregarEventoSismico(EventoSismico evento)
        {
            DataRow fila = tabla.NewRow();
            fila["Fecha Hora Ocurrencia"] = evento.getFechaHoraOcurrencia();
            fila["Latitud Epicentro"] = evento.getLatitudEpicentro();
            fila["Longitud Epicentro"] = evento.getLongitudEpicentro();
            fila["Latitud Hipocentro"] = evento.getLatitudHipocentro();
            fila["Longitud Hipocentro"] = evento.getLongitudHipocentro();
            fila["Magnitud"] = evento.getValorMagnitud();
            tabla.Rows.Add(fila);

            eventosMostrados.Add(evento); // Se guarda el objeto

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (dataGridViewES.SelectedRows.Count > 0)
            {
                int filaSeleccionada = dataGridViewES.SelectedRows[0].Index;
                EventoSismico eventoSeleccionado = eventosMostrados[filaSeleccionada];

                // Se pasa el evento seleccionado a la pantalla de resultados
                pantallaRegResultado.tomarSelecEventoSismico(eventoSeleccionado);

                // Mostramos mensaje de éxito después de que se generó el sismograma
                MessageBox.Show("Sismograma generado con éxito");

                this.Close();

                // Abrir la nueva ventana de detalle
                DatosSismicosSelec detalleForm = new DatosSismicosSelec(eventoSeleccionado, pantallaRegResultado);
                detalleForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un evento sísmico de la lista.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}


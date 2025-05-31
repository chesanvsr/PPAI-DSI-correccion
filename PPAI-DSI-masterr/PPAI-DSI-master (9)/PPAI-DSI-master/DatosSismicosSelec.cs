using PPAI_DSI.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPAI_DSI.Interfaz
{
    public partial class DatosSismicosSelec : Form
    {
        private EventoSismico evento;
        private PantallaRegResultado pantallaRegResultado;
        private DataTable tabla;
        private DataTable tablaSeries;

        public DatosSismicosSelec(EventoSismico evento, PantallaRegResultado pantalla)
        {
            InitializeComponent();
            this.evento = evento;
            this.pantallaRegResultado = pantalla;
        }

        private void DatosSismicosSelec_Load(object sender, EventArgs e)
        {
            // Cargar campos editables
            txtMagnitud.Text = evento.getMagnitud().ToString();
            comboAlcance.Items.AddRange(new string[] { "Bajo", "Medio", "Alto" });
            comboOrigen.Items.AddRange(new string[] { "Natural", "Artificial", "Indeterminado" });
            comboAlcance.SelectedItem = evento.getNombreAlcance();
            comboOrigen.SelectedItem = evento.getNombreOrigenGeneracion();

            // Tabla de datos generales
            tabla = new DataTable();
            tabla.Columns.Add("Alcance");
            tabla.Columns.Add("Origen");
            tabla.Columns.Add("Clasificacion");
            dataGridViewDatosGenerales.AutoGenerateColumns = true;
            dataGridViewDatosGenerales.DataSource = tabla;
            MostrarDatosGeneralesEvento();

            // Tabla series temporales
            tablaSeries = new DataTable();
            tablaSeries.Columns.Add("Estación");
            tablaSeries.Columns.Add("Fecha/Hora Muestra");
            tablaSeries.Columns.Add("Velocidad de Onda (Km/seg)");
            tablaSeries.Columns.Add("Frecuencia de Onda (Hz)");
            tablaSeries.Columns.Add("Longitud de Onda (km/ciclo)");
            dataGridViewSeriesTemporales.AutoGenerateColumns = true;
            dataGridViewSeriesTemporales.DataSource = tablaSeries;
            dataGridViewSeriesTemporales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            MostrarSeriesTemporales();
        }

        private void MostrarDatosGeneralesEvento()
        {
            DataRow fila = tabla.NewRow();
            fila["Alcance"] = evento.getNombreAlcance();
            fila["Origen"] = evento.getNombreOrigenGeneracion();
            fila["Clasificacion"] = evento.getNombreClasificacion();
            tabla.Rows.Add(fila);
        }

        private void MostrarSeriesTemporales()
        {
            var series = evento.obtenerDatosSeriesTemporales()
                               .OrderBy(s => s.getEstacionSismologica().getCodigoEstacion());

            foreach (var serie in series)
            {
                foreach (var muestra in serie.getMuestras())
                {
                    DataRow fila = tablaSeries.NewRow();
                    fila["Estación"] = serie.getEstacionSismologica().getCodigoEstacion().ToString();
                    fila["Fecha/Hora Muestra"] = muestra.getFechaHora();
                    fila["Velocidad de Onda (Km/seg)"] = muestra.getVelocidadOnda();
                    fila["Frecuencia de Onda (Hz)"] = muestra.getFrecuenciaOnda();
                    fila["Longitud de Onda (km/ciclo)"] = muestra.getLongitudOnda();
                    tablaSeries.Rows.Add(fila);
                }
            }
        }

        private void btnGenerarSismogramas_Click(object sender, EventArgs e)
        {
            var estaciones = tablaSeries.AsEnumerable()
                                        .Select(f => f.Field<string>("Estación"))
                                        .Distinct()
                                        .ToList();

            var mensaje = new StringBuilder();
            foreach (var estacion in estaciones)
            {
                mensaje.AppendLine($"Visualizando sismograma de la estación {estacion}");
            }

            MessageBox.Show(mensaje.ToString(), "Sismogramas");
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                float nuevaMagnitud = float.Parse(txtMagnitud.Text);
                string nuevoAlcance = comboAlcance.SelectedItem.ToString();
                string nuevoOrigen = comboOrigen.SelectedItem.ToString();

                evento.setMagnitud(nuevaMagnitud);
                evento.setAlcance(nuevoAlcance);  // Asume que tenés un método así
                evento.setOrigenGeneracion(nuevoOrigen); // Asume que tenés un método así

                MessageBox.Show("Los cambios fueron guardados correctamente.", "Confirmación");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            pantallaRegResultado.solicitarOpMapa(evento);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
                this.Close();
        }
    }
}

namespace PPAI_DSI.Interfaz
{
    partial class DatosSismicosSelec
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDatosGenerales = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSeriesTemporales = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGenerarSismogramas = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosGenerales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriesTemporales)).BeginInit();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Text = "Evento Sísmico Seleccionado:";
            this.label1.Size = new System.Drawing.Size(375, 29);

            // dataGridViewDatosGenerales
            this.dataGridViewDatosGenerales.AllowUserToAddRows = false;
            this.dataGridViewDatosGenerales.AllowUserToDeleteRows = false;
            this.dataGridViewDatosGenerales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatosGenerales.Location = new System.Drawing.Point(17, 88);
            this.dataGridViewDatosGenerales.ReadOnly = true;
            this.dataGridViewDatosGenerales.Size = new System.Drawing.Size(1098, 70);

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(56, 176);
            this.label2.Text = "Series Temporales del Evento:";

            // dataGridViewSeriesTemporales
            this.dataGridViewSeriesTemporales.AllowUserToAddRows = false;
            this.dataGridViewSeriesTemporales.AllowUserToDeleteRows = false;
            this.dataGridViewSeriesTemporales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSeriesTemporales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeriesTemporales.Location = new System.Drawing.Point(61, 222);
            this.dataGridViewSeriesTemporales.ReadOnly = true;
            this.dataGridViewSeriesTemporales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeriesTemporales.Size = new System.Drawing.Size(1054, 300);
            this.dataGridViewSeriesTemporales.BackgroundColor = System.Drawing.Color.White;

            // btnGenerarSismogramas 
            this.btnGenerarSismogramas = new System.Windows.Forms.Button();
            this.btnGenerarSismogramas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnGenerarSismogramas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarSismogramas.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerarSismogramas.ForeColor = System.Drawing.Color.White;
            this.btnGenerarSismogramas.Location = new System.Drawing.Point((1179 - 300) / 2, 540); // Centramos horizontalmente
            this.btnGenerarSismogramas.Name = "btnGenerarSismogramas";
            this.btnGenerarSismogramas.Size = new System.Drawing.Size(300, 50);
            this.btnGenerarSismogramas.Text = "Generar sismogramas";
            this.btnGenerarSismogramas.UseVisualStyleBackColor = false;
            this.btnGenerarSismogramas.Click += new System.EventHandler(this.btnGenerarSismogramas_Click);


            // button1
            this.button1.Location = new System.Drawing.Point(856, 540);
            this.button1.Size = new System.Drawing.Size(259, 40);
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // button2
            this.button2.Location = new System.Drawing.Point(17, 590);
            this.button2.Size = new System.Drawing.Size(259, 40);
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);

            // DatosSismicosSelec
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 650);
            this.Controls.Add(this.btnGenerarSismogramas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewSeriesTemporales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDatosGenerales);
            this.Controls.Add(this.label1);
            this.Name = "DatosSismicosSelec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualización Datos";
            this.Load += new System.EventHandler(this.DatosSismicosSelec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatosGenerales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriesTemporales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDatosGenerales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSeriesTemporales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGenerarSismogramas;
    }
}


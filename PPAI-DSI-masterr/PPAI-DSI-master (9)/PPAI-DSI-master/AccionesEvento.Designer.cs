namespace PPAI_DSI
{
    partial class AccionesEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdConfirmar = new System.Windows.Forms.RadioButton();
            this.rdRechazar = new System.Windows.Forms.RadioButton();
            this.rdDerivar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdConfirmar
            // 
            this.rdConfirmar.AutoSize = true;
            this.rdConfirmar.Location = new System.Drawing.Point(47, 96);
            this.rdConfirmar.Name = "rdConfirmar";
            this.rdConfirmar.Size = new System.Drawing.Size(97, 24);
            this.rdConfirmar.TabIndex = 0;
            this.rdConfirmar.TabStop = true;
            this.rdConfirmar.Text = "Confirmar";
            this.rdConfirmar.UseVisualStyleBackColor = true;
            // 
            // rdRechazar
            // 
            this.rdRechazar.AutoSize = true;
            this.rdRechazar.Location = new System.Drawing.Point(47, 151);
            this.rdRechazar.Name = "rdRechazar";
            this.rdRechazar.Size = new System.Drawing.Size(96, 24);
            this.rdRechazar.TabIndex = 1;
            this.rdRechazar.TabStop = true;
            this.rdRechazar.Text = "Rechazar";
            this.rdRechazar.UseVisualStyleBackColor = true;
            // 
            // rdDerivar
            // 
            this.rdDerivar.AutoSize = true;
            this.rdDerivar.Location = new System.Drawing.Point(47, 209);
            this.rdDerivar.Name = "rdDerivar";
            this.rdDerivar.Size = new System.Drawing.Size(151, 24);
            this.rdDerivar.TabIndex = 2;
            this.rdDerivar.TabStop = true;
            this.rdDerivar.Text = "Solicitar Revisión"; // Cambio acá
            this.rdDerivar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la acción correspondiente:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccionesEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdDerivar);
            this.Controls.Add(this.rdRechazar);
            this.Controls.Add(this.rdConfirmar);
            this.Name = "AccionesEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccionesEvento";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rdConfirmar;
        private System.Windows.Forms.RadioButton rdRechazar;
        private System.Windows.Forms.RadioButton rdDerivar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


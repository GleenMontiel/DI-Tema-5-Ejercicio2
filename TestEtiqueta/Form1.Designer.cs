
namespace TestEtiqueta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.etiquetaAviso1 = new ControlPorFin.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Final = System.Drawing.Color.Violet;
            this.etiquetaAviso1.Gradiente = false;
            this.etiquetaAviso1.ImagenMarca = global::TestEtiqueta.Properties.Resources.Logros;
            this.etiquetaAviso1.Inicio = System.Drawing.Color.Red;
            this.etiquetaAviso1.Location = new System.Drawing.Point(280, 139);
            this.etiquetaAviso1.Marca = ControlPorFin.eMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(170, 40);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPorFin.EtiquetaAviso etiquetaAviso1;
    }
}


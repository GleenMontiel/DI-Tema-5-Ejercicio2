
namespace PruebaControl
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.etiquetaAviso1 = new ControlPorFin.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.Final = System.Drawing.Color.Violet;
            this.etiquetaAviso1.Gradiente = false;
            this.etiquetaAviso1.ImagenMarca = global::PruebaControl.Properties.Resources.and_icon;
            this.etiquetaAviso1.Inicio = System.Drawing.Color.Red;
            this.etiquetaAviso1.Location = new System.Drawing.Point(516, 80);
            this.etiquetaAviso1.Marca = ControlPorFin.eMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(170, 40);
            this.etiquetaAviso1.TabIndex = 2;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 450);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ControlPorFin.EtiquetaAviso customControl11;
        private System.Windows.Forms.Button button1;
        private ControlPorFin.EtiquetaAviso etiquetaAviso1;
    }
}


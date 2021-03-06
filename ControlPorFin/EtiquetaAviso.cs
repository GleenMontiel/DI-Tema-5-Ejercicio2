using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPorFin
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    [DefaultProperty("EtiquetaAviso"),DefaultEvent("Load")]
    public partial class EtiquetaAviso : Control
    {
        private bool gradiente;
        private Image imagenMarca;
        private Size tamanio;
        public EtiquetaAviso()
        {
            InitializeComponent();
            gradiente = false;
            Inicio = Color.Red;
            Final = Color.Violet;
            marca = eMarca.Nada;
        }

        [Category("Ejercicio")]
        [Description("Indica si tiene o no un fondo gradiente")]
        public bool Gradiente
        {
            set 
            { 
                gradiente = value; 
                Refresh(); 
            }
            get 
            {
                return gradiente; 
            }
        }

        private Color inicio;
        [Category("Ejercicio")]
        [Description("Indica el color inicial para el fondo gradiente")]
        public Color Inicio
        {
            set 
            {
                inicio = value;
                Refresh();
            }
            get 
            { 
                return inicio; 
            }
        }
        private Color final;
        [Category("Ejercicio")]
        [Description("Indica el color final para el fondo gradiente")]
        public Color Final
        {
            set 
            {
                final = value; 
                Refresh();
            }
            get 
            { 
                return final;
            }
        }


        private eMarca marca;
        [Category("Ejercicio")]
        [Description("Indica la marca para la etiqueta")]
        public eMarca Marca
        {
            set 
            {
                marca = value;
                this.Refresh();
            }
            get 
            {
                return marca;
            }
        }

        [Category("Ejercicio")]
        [Description("Indica la ruta de la imagen para la etiqueta")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
                Refresh();
            }
            get { return imagenMarca; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            Graphics g = e.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
                             // a la hora de dibujar

            if (gradiente)
            {
                Rectangle bg = new Rectangle(0, 0, Width, Height);
                SolidBrush solid = new SolidBrush(Color.BlueViolet);
                LinearGradientBrush linearGradient = new LinearGradientBrush(bg, Inicio, Final, 45f);
                g.FillRectangle(linearGradient, bg);
            }
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                   this.Font.Height, this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 5;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, this.Font.Height,
                   this.Font.Height);
                    g.DrawLine(lapiz, this.Font.Height, grosor, grosor,
                   this.Font.Height);
                    offsetX = this.Font.Height + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case eMarca.Imagen:

                    if (ImagenMarca != null)
                    {
                        int coorde = 5;
                        Bitmap bm = new Bitmap(ImagenMarca);
                        g.DrawImage(bm, coorde, coorde, this.Font.Height * 2, this.Height);
                        offsetX = this.Font.Height * 3;
                        offsetY = coorde * 2;
                    }

                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            tamanio = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tamanio.Width + offsetX + grosor, tamanio.Height + offsetY * 2);
            b.Dispose();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        [Category("Ejercicio Eventos")]
        [Description("Se lanza cuando se produce un click en la zona de imagen")]
        public event System.EventHandler ClickEnMarca;


        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.X < this.Width - tamanio.Width && marca != eMarca.Nada) 
            {
                ClickEnMarca?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}

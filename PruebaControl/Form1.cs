using ControlPorFin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaControl
{
    public partial class Form1 : Form
    {
        int index;
        public Form1()
        {
            InitializeComponent();
            index = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
       

            Graphics g = e.Graphics;
            ControlPaint.DrawButton(g, 0, 40, 100, 60, ButtonState.Flat);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
           /* etiquetaAviso1.Gradiente = true;
            etiquetaAviso1.Marca = (eMarca)index;
            index++;
            if (index ==4) index = 0;*/
            

        }
    }
}

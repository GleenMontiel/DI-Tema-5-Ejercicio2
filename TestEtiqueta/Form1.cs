﻿using ControlPorFin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEtiqueta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void etiquetaAviso1_ClickEnMarca(object sender, EventArgs e)
        {
           
                MessageBox.Show(etiquetaAviso1.Marca.ToString());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaARD
{
    public partial class ReporteIndemnizacionTransporte : Form
    {
        public ReporteIndemnizacionTransporte()
        {
            InitializeComponent();
        }
        private DateTime _FechaInicio;

        public DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }
        private DateTime _FechaFinal;

        public DateTime FechaFinal
        {
            get { return _FechaFinal; }
            set { _FechaFinal = value; }
        }
        private void ReporteIndemnizacionTransporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'losnacimientosDataSet.Reporte_Indemnizacion_Transporte' Puede moverla o quitarla según sea necesario.
            try
            {
                this.Reporte_Indemnizacion_TransporteTableAdapter.Fill(this.losnacimientosDataSet.Reporte_Indemnizacion_Transporte, FechaInicio, FechaFinal);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception)
            {
                this.reportViewer1.RefreshReport();
            }

            this.reportViewer1.RefreshReport();
        }
    }
}

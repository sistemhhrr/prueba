﻿namespace SistemaARD
{
    partial class ReporteIndemnizacionMantenimiento
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.losnacimientosDataSet = new SistemaARD.losnacimientosDataSet();
            this.Reporte_Indemnizacion_MantenimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_Indemnizacion_MantenimientoTableAdapter = new SistemaARD.losnacimientosDataSetTableAdapters.Reporte_Indemnizacion_MantenimientoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Indemnizacion_MantenimientoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1Indemnizacion";
            reportDataSource1.Value = this.Reporte_Indemnizacion_MantenimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaARD.Reportes.ReporteIndemnizacionMantenimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // losnacimientosDataSet
            // 
            this.losnacimientosDataSet.DataSetName = "losnacimientosDataSet";
            this.losnacimientosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reporte_Indemnizacion_MantenimientoBindingSource
            // 
            this.Reporte_Indemnizacion_MantenimientoBindingSource.DataMember = "Reporte_Indemnizacion_Mantenimiento";
            this.Reporte_Indemnizacion_MantenimientoBindingSource.DataSource = this.losnacimientosDataSet;
            // 
            // Reporte_Indemnizacion_MantenimientoTableAdapter
            // 
            this.Reporte_Indemnizacion_MantenimientoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteIndemnizacionMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteIndemnizacionMantenimiento";
            this.Text = "ReporteIndemnizacionMantenimiento";
            this.Load += new System.EventHandler(this.ReporteIndemnizacionMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.losnacimientosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_Indemnizacion_MantenimientoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_Indemnizacion_MantenimientoBindingSource;
        private losnacimientosDataSet losnacimientosDataSet;
        private losnacimientosDataSetTableAdapters.Reporte_Indemnizacion_MantenimientoTableAdapter Reporte_Indemnizacion_MantenimientoTableAdapter;
    }
}
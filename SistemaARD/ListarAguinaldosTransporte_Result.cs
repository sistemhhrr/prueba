//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaARD
{
    using System;
    
    public partial class ListarAguinaldosTransporte_Result
    {
        public int Id { get; set; }
        public int Empleado_Id { get; set; }
        public string Empleado { get; set; }
        public decimal Salario_diario { get; set; }
        public string Fecha_de_ingreso { get; set; }
        public int Años_de_trabajo { get; set; }
        public Nullable<int> Dias_trabajados { get; set; }
        public Nullable<int> Dias_a_pagar { get; set; }
        public System.DateTime Fecha_de_pago { get; set; }
    }
}

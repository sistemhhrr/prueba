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
    
    public partial class ListarPagosVacacionesAdministracion_Result
    {
        public int Id { get; set; }
        public Nullable<int> Empleado_Id { get; set; }
        public string Empleado { get; set; }
        public string Cargo { get; set; }
        public string Fecha_de_ingreso { get; set; }
        public Nullable<System.DateTime> Fecha_de_pago { get; set; }
        public string Total_a_pagar { get; set; }
        public Nullable<decimal> Monto { get; set; }
    }
}

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
    using System.Collections.Generic;
    
    public partial class PlanillasProduccion
    {
        public int Id { get; set; }
        public int Empleado_Id { get; set; }
        public decimal Pago_hora { get; set; }
        public int Horas_laboradas { get; set; }
        public decimal Anticipos { get; set; }
        public System.DateTime Fecha_Inicio { get; set; }
        public System.DateTime Fecha_Final { get; set; }
        public Nullable<double> Horas_extras { get; set; }
        public Nullable<int> Dias_vacaciones { get; set; }
        public Nullable<int> Dias_incapacitado { get; set; }
        public Nullable<double> Horas_dias_incompletos { get; set; }
        public Nullable<double> Horas_dias_asueto { get; set; }
        public Nullable<int> Dias_perdidos { get; set; }
        public Nullable<int> Dias_laborados { get; set; }
        public Nullable<int> Categoria_Id { get; set; }
    
        public virtual Empleados Empleados { get; set; }
    }
}

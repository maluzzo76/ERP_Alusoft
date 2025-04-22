using System.ComponentModel.DataAnnotations;

namespace ERP_Alusoft.Model
{
    public class LineaAsiento
    {
        public int Id { get; set; }
        public int Asiento_Id { get; set; }


        [Required(ErrorMessage = "Debe seleccionar una cuenta")]
        public Nullable<int> Plan_CuentasId { get; set; }
        public string Concepto { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Debe es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Debe ser mayor que 0")]
        public Nullable<decimal> Debe { get; set; }

        [Required(ErrorMessage = "El campo Haber es obligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Debe ser mayor que 0")]
        public Nullable<decimal> Haber { get; set; }


        public Plan_Cuentas Plan_Cuentas { get; set; }        

    }
}

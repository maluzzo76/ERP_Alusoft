namespace ERP_Alusoft.Model
{
    public class LineaAsiento
    {
        public int Id { get; set; }
        public Nullable<int> Asiento_Id { get; set; }
        public Nullable<int> Plan_CuentasId { get; set; }
        public string Concepto { get; set; } = string.Empty;
        public Nullable<decimal> Debe { get; set; }
        public Nullable<decimal> Haber { get; set; }
        public Plan_Cuentas Plan_Cuentas { get; set; }
        

    }
}

    namespace ERP_Alusoft.Model
{
    public class Plan_Cuentas
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public Nullable<int> Numero { get; set; }  
        public Nullable<bool> IsImputable { get ; set; }
        public Nullable<bool> IsResultado { get; set; }

        public List<LineaAsiento> Lineas_Asiento { get; set; } = new List<LineaAsiento>();
    }
}

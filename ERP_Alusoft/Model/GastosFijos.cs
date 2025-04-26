namespace ERP_Alusoft.Model
{
    public class GastosFijos
    {
        public int Id { get; set; }

        public string TipoGasto { get; set; } = string.Empty;

        public decimal Monto { get; set; } = 0;
    }
}

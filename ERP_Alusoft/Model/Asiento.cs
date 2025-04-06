using System.ComponentModel.DataAnnotations;

namespace ERP_Alusoft.Model
{
    public class Asiento
    {
        public int Id { get; set; }
        public string Concepto { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Fecha { get; set; }
        
        
    }
}

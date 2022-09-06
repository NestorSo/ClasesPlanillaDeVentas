namespace Modelo
{
    public partial class Boleta
    {
        public string? Cliente { get; set; }
        public string? direcccion { get; set; }
        public double Nboleta { get; set; }
        public DateTime fechacompra { get; set; }

        public string? nCedula { get; set; }
        public string? producto { get; set; }
        public int cantidad { get; set; }



       
    }
}
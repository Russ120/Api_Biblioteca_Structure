namespace DAL.Entities
{
    public class Libro
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string? autor { get; set; }
        public string? editorial { get; set; }
        public string año { get; set; }
        public int Cantidad { get; set; }
        public string? descripcion { get; set; }
        public decimal precio { get; set; }
    }
}
namespace HideluzEstacionamentos.Models
{
    public class Tax
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int IdType { get; set; }
        public int IdVehicleType { get; set; }
    }
}

namespace Versta_Web_App.Models
{
    public class CargoOrder
    {
        public int Id { get; set; }
        public string SenderCity { get; set; }
        public string SenderAddress { get; set;}
        public string RecipientCity { get; set; }
        public string RecipientAddress { get; set;}
        public float CargoWeight { get; set;}
        public string DepartureDate { get; set; }
        public string OrderUniqueId { get; set; }
    }
}

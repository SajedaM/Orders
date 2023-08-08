namespace ordering.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int PruductId { get; set; }
        public Order Order { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}

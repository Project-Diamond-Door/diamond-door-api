using Diamond.Door.Domain.Catalog;

namespace Diamond.Door.Domain.Orders;

public class OrderItem
{
    public int Id { get; set; }
    public Item Item { get; set; } = null!;
    public int Quantity { get; set; }

    public decimal Price => Item.Price * Quantity;
}

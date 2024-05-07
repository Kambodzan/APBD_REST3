namespace APBD_REST3.Controllers;

public class ProductDTO
{
    public int IdProduct { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class OrderDTO
{
    public int IdOrder { get; set; }
    public int IdProduct { get; set; }
    public int Amount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? FulfilledAt { get; set; }
}

public class ProductWarehouseDTO
{
    public int IdProductWarehouse { get; set; }
    public int IdProduct { get; set; }
    public int IdWarehouse { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class WarehouseDTO
{
    public int IdWarehouse { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
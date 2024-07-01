namespace Luzyce.Core.Models.Order;

public class GetWarehouseLevelsResponseDto
{
    public int ProductId { get; set; }
    public int WarehouseId { get; set; }
    public int Quantity { get; set; }
    public int QuantityMin { get; set; }
    public int QuantityRes { get; set; }
    public int QuantityMax { get; set; }
}
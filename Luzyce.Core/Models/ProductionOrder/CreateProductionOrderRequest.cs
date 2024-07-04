using Luzyce.Core.Models.Order;

namespace Luzyce.Core.Models.ProductionOrder;

public class CreateProductionOrderRequest
{
    public GetOrderResponseDto Order { get; set; } = new GetOrderResponseDto();
    public List<CreateProductionOrder> ProductionOrderPositions { get; set; } = [];
}
namespace Luzyce.Core.Models.ProductionOrder;

public class UpdateProductionOrder
{
    public List<UpdateProductionOrderPosition> Positions { get; set; } = [];
}
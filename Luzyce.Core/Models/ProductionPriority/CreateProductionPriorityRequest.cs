using Luzyce.Core.Models.ProductionOrder;

namespace Luzyce.Core.Models.ProductionPriority;

public class CreateProductionPriorityRequest
{
    public List<GetProductionOrderPosition> position { get; set; } = [];
}
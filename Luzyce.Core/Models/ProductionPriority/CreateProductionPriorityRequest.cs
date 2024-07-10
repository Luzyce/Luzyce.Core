using Luzyce.Core.Models.ProductionOrder;

namespace Luzyce.Core.Models.ProductionPriority;

public class CreateProductionPriorityRequest
{
    public List<GetProductionOrderPosition> positions { get; set; } = [];
}
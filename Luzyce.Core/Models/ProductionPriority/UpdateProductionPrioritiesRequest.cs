using Luzyce.Core.Models.ProductionOrder;

namespace Luzyce.Core.Models.ProductionPriority;

public class UpdateProductionPrioritiesRequest
{
    public List<GetProductionOrderPosition> positions { get; set; } = [];
}
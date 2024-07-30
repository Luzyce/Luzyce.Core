using Luzyce.Core.Models.ProductionOrder;

namespace Luzyce.Core.Models.ProductionPlan;

public class GetProductionPlanPosition
{
    public int Id { get; set; }
    public GetProductionOrderPosition DocumentPosition { get; set; } = new GetProductionOrderPosition();
    public int? NumberOfHours { get; set; }
}
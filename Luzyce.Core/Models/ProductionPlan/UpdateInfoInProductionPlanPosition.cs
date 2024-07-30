namespace Luzyce.Core.Models.ProductionPlan;

public class UpdateInfoInProductionPlanPosition
{
    public int PositionId { get; set; }
    public int? NumberOfHours { get; set; }
    public int? WeightNetto { get; set; }
    public int? WeightBrutto { get; set; }
}
namespace Luzyce.Core.Models.ProductionPlan;

public class UpdateInfoInProductionPlanPosition
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public int? NumberOfHours { get; set; }
    public double? WeightNetto { get; set; }
    public double? WeightBrutto { get; set; }
    public int? QuantityPerChange { get; set; }
}
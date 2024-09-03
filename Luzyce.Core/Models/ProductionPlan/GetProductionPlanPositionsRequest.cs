namespace Luzyce.Core.Models.ProductionPlan;

public class GetProductionPlanPositionsRequest
{
    public DateOnly Date { get; set; }
    public int Shift { get; set; }
    public int Team { get; set; }
}
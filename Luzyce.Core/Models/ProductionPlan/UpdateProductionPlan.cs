namespace Luzyce.Core.Models.ProductionPlan;

public class UpdateProductionPlan
{
    public int? ShiftSupervisorId { get; set; }
    public List<UpdateInfoInProductionPlanPosition> ProductionPlanPositions { get; set; } = [];
}
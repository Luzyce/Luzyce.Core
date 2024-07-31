namespace Luzyce.Core.Models.ProductionPlan;

public class UpdateProductionPlan
{
    public int Id { get; set; }
    public int? ShiftSupervisorId { get; set; }
    public List<UpdateInfoInProductionPlanPosition> ProductionPlanPositions { get; set; } = [];
}
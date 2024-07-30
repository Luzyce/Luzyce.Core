namespace Luzyce.Core.Models.ProductionPlan;

public class AddItemsToProductionPlan
{
    public DateOnly Date { get; set; }
    public int Change { get; set; }
    public int Team { get; set; }
    public Dictionary<int, int> Positions { get; set; } = new();
}
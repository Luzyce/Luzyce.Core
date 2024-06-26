namespace Luzyce.Core.Models.ProductionOrder;

public class GetProductionOrderPositionsDto
{
    public int DocumentId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public int Gross { get; set; }
    public int Net { get; set; }
}
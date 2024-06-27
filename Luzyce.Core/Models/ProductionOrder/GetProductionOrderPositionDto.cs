namespace Luzyce.Core.Models.ProductionOrder;

public class GetProductionOrderPositionDto
{
    public int DocumentItemId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public int Gross { get; set; }
    public int Net { get; set; }
}
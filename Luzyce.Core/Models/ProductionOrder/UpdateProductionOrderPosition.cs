namespace Luzyce.Core.Models.ProductionOrder;

public class UpdateProductionOrderPosition
{
    public int QuantityNetto { get; set; }
    public int? NumberOfChanges { get; set; }
    public int? QuantityPerChange { get; set; }
    public DateTime? ExecutionDate { get; set; }
    public int? QuantityMade { get; set; }
    public string Remarks { get; set; } = string.Empty;
    public string? MethodOfPackaging { get; set; }
    public int? QuantityPerPack { get; set; }
}
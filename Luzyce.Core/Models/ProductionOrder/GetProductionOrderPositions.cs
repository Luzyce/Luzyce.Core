using Luzyce.Core.Models.Lampshade;

namespace Luzyce.Core.Models.ProductionOrder;

public class GetProductionOrderPositions
{ 
    public int Id { get; set; }
    public int QuantityNetto { get; set; }
    public int QuantityGross { get; set; }
    public DateTime? ExecutionDate { get; set; }
    public GetLampshade Lampshade { get; set; } = new GetLampshade();
    public GetLampshadeNorm LampshadeNorm { get; set; } = new GetLampshadeNorm();
    public string LampshadeDekor { get; set; } = string.Empty;
    public string Remarks { get; set; } = string.Empty;
    public int? NumberOfChanges { get; set; }
    public int? QuantityMade { get; set; }
    public string? MethodOfPackaging { get; set; }
    public int? QuantityPerPack { get; set; }
    public int ProductId { get; set; }
}
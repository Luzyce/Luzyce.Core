using Luzyce.Core.Models.Lampshade;
using Luzyce.Core.Models.Order;

namespace Luzyce.Core.Models.ProductionOrder;

public class GetProductionOrderPosition
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
    public string Unit { get; set; } = string.Empty;
    public string? ProductionOrderNumber { get; set; }
    public string Client { get; set; } = string.Empty;
    public int Priority { get; set; }
}
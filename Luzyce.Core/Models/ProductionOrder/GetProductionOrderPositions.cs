using Luzyce.Core.Models.Lampshade;

namespace Luzyce.Core.Models.ProductionOrder;

public class GetProductionOrderPositions
{ 
    public int Id { get; set; }
    public int QuantityNetto { get; set; }
    public int QuantityGross { get; set; }
    public DateTime? CreatedAt { get; set; }
    public GetLampshade Lampshade { get; set; } = new GetLampshade();
    public GetLampshadeNorm LampshadeNorm { get; set; } = new GetLampshadeNorm();
    public string LampshadeDekor { get; set; } = string.Empty;
}
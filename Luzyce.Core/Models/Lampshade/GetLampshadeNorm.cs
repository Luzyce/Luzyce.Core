namespace Luzyce.Core.Models.Lampshade;

public class GetLampshadeNorm
{
    public int Id { get; set; }
    public GetLampshade Lampshade { get; set; } = new GetLampshade();
    public GetVariantResponseDto Variant { get; set; } = new GetVariantResponseDto();
    public int QuantityPerChange { get; set; }
}
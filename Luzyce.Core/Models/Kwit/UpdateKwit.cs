namespace Luzyce.Core.Models.Kwit;

public class UpdateKwit
{
    public int Id { get; set; }
    public int StatusId { get; set; }
    public int? LockedById { get; set; }
    public int QuantityNetto { get; set; } // from KwitPosition
    public int QuantityGross { get; set; } // from KwitPosition
    public int QuantityLoss { get; set; } // from KwitPosition
    public int QuantityToImprove { get; set; } // from KwitPosition
}
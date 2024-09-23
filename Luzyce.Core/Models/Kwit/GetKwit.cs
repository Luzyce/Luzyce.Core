using Luzyce.Core.Models.Document;
using Luzyce.Core.Models.Log;
using Luzyce.Core.Models.ProductionPlan;
using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.Kwit;

public class GetKwit
{
    public int Id { get; set; }
    public int DocNumber { get; set; }
    public GetWarehouseResponseDto? Warehouse { get; set; } = new GetWarehouseResponseDto();
    public int Year { get; set; }
    public string? Number { get; set; }
    public GetDocumentsDefinitionResponseDto? DocumentsDefinition { get; set; } = new GetDocumentsDefinitionResponseDto();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public GetStatusResponseDto? Status { get; set; } = new GetStatusResponseDto();
    public GetClient? LockedBy { get; set; } = new GetClient();

    public int Quantity { get; set; } // from ProductionPlanPosition
    public int QuantityNetto { get; set; } // from KwitPosition
    public int QuantityGross { get; set; } // from KwitPosition
    public int QuantityLoss { get; set; } // from KwitPosition
    public int QuantityToImprove { get; set; } // from KwitPosition
}
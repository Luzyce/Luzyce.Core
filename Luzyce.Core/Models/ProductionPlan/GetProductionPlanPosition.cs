using Luzyce.Core.Models.Document;

namespace Luzyce.Core.Models.ProductionPlan;

public class GetProductionPlanPosition
{
    public int Id { get; set; }
    public GetDocumentPositionResponseDto DocumentPosition { get; set; } = new GetDocumentPositionResponseDto();
    public int NumberOfHours { get; set; }
}
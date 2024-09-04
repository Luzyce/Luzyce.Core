using Luzyce.Core.Models.Document;
using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.ProductionPlan;

public class GetProductionPlan
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public GetShift Shift { get; set; } = new();
    public int Team { get; set; }
    public GetUserResponseDto? HeadsOfMetallurgicalTeams { get; set; }
    public GetStatusResponseDto? Status { get; set; }
    public List<GetProductionPlanPosition> ProductionPlanPositions { get; set; } = [];
}
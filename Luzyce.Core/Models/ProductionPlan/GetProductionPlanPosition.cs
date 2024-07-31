using Luzyce.Core.Models.ProductionOrder;
using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.ProductionPlan;

public class GetProductionPlanPosition
{
    public int Id { get; set; }
    public GetProductionOrderPosition DocumentPosition { get; set; } = new GetProductionOrderPosition();
    public int? HeadsOfMetallurgicalTeamsId { get; set; }
    public GetUserResponseDto? HeadsOfMetallurgicalTeams { get; set; }
    public int? NumberOfHours { get; set; }
}
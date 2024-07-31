using Luzyce.Core.Models.Document;
using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.ProductionPlan;

public class GetProductionPlanForCalendar
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public int Change { get; set; }
    public int Team { get; set; }
    public GetUserResponseDto? ShiftSupervisor { get; set; }
    public GetStatusResponseDto? Status { get; set; }
}
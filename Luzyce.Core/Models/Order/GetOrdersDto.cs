namespace Luzyce.Core.Models.Order;

public class GetOrdersDto
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int? CustomerId { get; set; }
}

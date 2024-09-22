using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.Log;

public class GetLog
{
    public int Id { get; set; }
    public DateTime Timestamp { get; set; }
    public GetClient Client { get; set; } = new();
    public string Operation { get; set; } = string.Empty;
    public GetUserResponseDto User { get; set; } = new();
    public string Hash { get; set; } = string.Empty;
}
namespace Luzyce.Core.Models.Log;

public class GetClient
{
    public int Id { get; set; }
    public string? Name { get; set; } = string.Empty;
    public string IpAddress { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}
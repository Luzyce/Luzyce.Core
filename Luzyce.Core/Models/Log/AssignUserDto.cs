using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.Log;

public class AssignUserDto
{
    public int UserId { get; set; }
    public List<GetLog> Logs { get; set; } = [];
}
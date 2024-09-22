using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.Log;

public class AssignUserDto
{
    public GetUserResponseDto User { get; set; } = new();
    public GetLog Log { get; set; } = new();
}
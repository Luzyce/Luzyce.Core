namespace Luzyce.Core.Models.User;

public class LoginResponseDto
{
    public string Token { get; set; } = string.Empty;
    public GetUserResponseDto Result { get; set; } = new GetUserResponseDto();
}

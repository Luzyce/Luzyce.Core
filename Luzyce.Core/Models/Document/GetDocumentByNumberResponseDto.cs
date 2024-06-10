namespace Luzyce.Core.Models.Document;

public class GetDocumentByNumberResponseDto
{
    public int Id { get; set; }
    public string? Number { get; set; }
    public List<GetDocumentPositionResponseDto>? DocumentPositions { get; set; } = [];
}

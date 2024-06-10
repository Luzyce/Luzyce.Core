namespace Luzyce.Core.Models.Document;

public class GetDocumentByNumberResponseDto
{
    public int Id { get; set; }
    public string? Number { get; set; }
    public GetDocumentPositionResponseDto? DocumentPosition { get; set; } = new GetDocumentPositionResponseDto();
}
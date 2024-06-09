using Luzyce.Core.Models.User;

namespace Luzyce.Core.Models.Document;

public class GetDocumentResponseDto
{
    public int Id { get; set; }
    public string DocNumber { get; set; } = string.Empty;
    public GetWarehouseResponseDto Warehouse { get; set; } = new GetWarehouseResponseDto();
    public int Year { get; set; }
    public string Number { get; set; } = string.Empty;
    public GetDocumentsDefinitionResponseDto DocumentDefinition { get; set; } = new GetDocumentsDefinitionResponseDto();
    public GetUserResponseDto User { get; set; } = new GetUserResponseDto();
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public GetStatusResponseDto Status { get; set; } = new GetStatusResponseDto();
}

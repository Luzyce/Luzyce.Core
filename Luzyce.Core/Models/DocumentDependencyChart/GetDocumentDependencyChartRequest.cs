namespace Luzyce.Core.Models.DocumentDependencyChart;

public class GetDocumentDependencyChartRequest
{
    public int DocumentId { get; set; }
    public string DocumentType { get; set; } = string.Empty;
}
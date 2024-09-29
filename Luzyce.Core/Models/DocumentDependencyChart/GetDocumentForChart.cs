namespace Luzyce.Core.Models.DocumentDependencyChart;

public class GetDocumentForChart
{
    public int Id { get; set; }

    public string DocumentType { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<GetDocumentForChart>? Derivatives { get; set; } = null;
}
namespace Luzyce.Core.Models.DocumentDependencyChart;

public class DocumentForChart
{
    public int Id { get; set; }

    public string DocumentType { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<DocumentForChart>? Derivatives { get; set; } = null;
}
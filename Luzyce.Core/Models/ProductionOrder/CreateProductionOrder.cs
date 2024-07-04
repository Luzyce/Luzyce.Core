﻿namespace Luzyce.Core.Models.ProductionOrder;

public class CreateProductionOrder
{
    public int DocumentPositionId { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public int VariantId { get; set; }
    public string Dekor { get; set; } = string.Empty;
    public int Gross { get; set; }
    public int Net { get; set; }
}
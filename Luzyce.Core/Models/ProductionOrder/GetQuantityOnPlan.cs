﻿namespace Luzyce.Core.Models.ProductionOrder;

public class GetQuantityOnPlan
{
    public int Quantity { get; set; }

    // Kwit
    public string KwitId { get; set; } = string.Empty;
    public string KwitName { get; set; } = string.Empty;
    public string KwitNumber { get; set; } = string.Empty;

    // ProductionPlan
    public DateOnly Date { get; set; }
    public int Shift { get; set; }
    public int Team { get; set; }
}
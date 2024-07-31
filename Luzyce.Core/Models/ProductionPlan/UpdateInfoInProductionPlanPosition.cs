﻿namespace Luzyce.Core.Models.ProductionPlan;

public class UpdateInfoInProductionPlanPosition
{
    public int Id { get; set; }
    public int? GetHeadsOfMetallurgicalTeamsId { get; set; }
    public int? NumberOfHours { get; set; }
    public int? WeightNetto { get; set; }
    public int? WeightBrutto { get; set; }
    public int? QuantityPerChange { get; set; }
}
﻿namespace Luzyce.Core.Models.Order;

public class GetWarehousesLevelsDto
{
    public List<int> ProductIds { get; set; } = [];
    public List<int> WarehouseIds { get; set; } = [];
}
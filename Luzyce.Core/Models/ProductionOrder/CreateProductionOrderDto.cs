﻿using Luzyce.Core.Models.Order;

namespace Luzyce.Core.Models.ProductionOrder;

public class CreateProductionOrderDto
{
    public GetOrderResponseDto Order { get; set; } = new GetOrderResponseDto();
    public List<GetProductionOrderPositionDto> ProductionOrderPositions { get; set; } = [];
}
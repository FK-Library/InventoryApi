using System;
using System.Collections.Generic;
using System.Linq;
using InventoryApi.Models;
using InventoryApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InventoryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly ILogger<InventoryController> _logger;
        private readonly InventoryService _inventoryService;

        public InventoryController(ILogger<InventoryController> logger)
        {
            _logger = logger;
            _inventoryService = new InventoryService();
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _inventoryService.GetProducts();
        }

    }
}

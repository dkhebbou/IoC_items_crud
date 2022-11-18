using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Play.Catalog.service.DTOs.Dto;

namespace Play.Catalog.service.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemCOntroller : ControllerBase
    {
        private static readonly List<ItemDto> items;
    }
}
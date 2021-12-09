using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PWebV2.Models;
using PWebV2.Services;

namespace PWebV2.Controllers
{
    public class AboutController : Controller

    {
        private readonly ICosmosDbService _cosmosDbService;
        
        public AboutController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetItemsAsyncAbout("SELECT * FROM c WHERE c.id = '13hom30f9'"));
        }
    }
}

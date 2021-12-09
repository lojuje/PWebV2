using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PWebV2.Models;
using PWebV2.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PWebV2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;
        public HomeController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetItemsAsyncHome("SELECT * FROM c WHERE c.id = '61acc68f9'"));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using lord_of_death;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dark_forest_api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DealerController : ControllerBase
    {
        private readonly ILogger<DealerController> _logger;
        private static DealerRepo dealerRepo;
        public DealerController(ILogger<DealerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public CardSplit GetSplit()
        {
            // HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            // HttpContext.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
            // HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type, X-CSRF-Token, X-Requested-With, Accept, Accept-Version, Content-Length, Content-MD5, Date, X-Api-Version, X-File-Name");
            // HttpContext.Response.Headers.Add("Access-Control-Allow-Methods", "POST,GET,PUT,PATCH,DELETE,OPTIONS");

            var split = new CardSplit();
            split.DiscardPile = DealerRepo.CurrentDealer.GetDiscardPile();
            split.DrawPile = DealerRepo.CurrentDealer.GetDrawPile();
            split.Hand = DealerRepo.CurrentDealer.GetCurrentHand();
            return split;
        }

        [HttpGet]
        public CardSplit DrawHand()
        {
            DealerRepo.CurrentDealer.DrawHand();
            var split = new CardSplit();
            split.DiscardPile = DealerRepo.CurrentDealer.GetDiscardPile();
            split.DrawPile = DealerRepo.CurrentDealer.GetDrawPile();
            split.Hand = DealerRepo.CurrentDealer.GetCurrentHand();
            return split;
        }

        [HttpGet]
        public CardSplit DiscardHand()
        {
            DealerRepo.CurrentDealer.DiscardHand();
            var split = new CardSplit();
            split.DiscardPile = DealerRepo.CurrentDealer.GetDiscardPile();
            split.DrawPile = DealerRepo.CurrentDealer.GetDrawPile();
            split.Hand = DealerRepo.CurrentDealer.GetCurrentHand();
            return split;
        }
    }
}

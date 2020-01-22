using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using lord_of_death;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dark_forest_api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
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
            var split = new CardSplit();
            split.DiscardPile = DealerRepo.CurrentDealer.GetDiscardPile();
            split.DrawPile = DealerRepo.CurrentDealer.GetDrawPile();
            split.Hand = DealerRepo.CurrentDealer.GetCurrentHand();
            return split;
        }

        [HttpGet]
        public CardSplit Draw()
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

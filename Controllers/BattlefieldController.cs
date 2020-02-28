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
    public class BattlefieldController : ControllerBase
    {
        private readonly ILogger<BattlefieldController> _logger;
        private IDealerRepo _dealerRepo;
        private IBattlefieldRepo _battlefieldRepo;
        public BattlefieldController(ILogger<BattlefieldController> logger, IDealerRepo dealerRepo,
                                    IBattlefieldRepo battlefieldRepo)
        {

            _logger = logger;
            _dealerRepo = dealerRepo;
            _battlefieldRepo = battlefieldRepo;
        }

        [HttpGet]
        public BattleState Enter(int selection = 1)
        {
            _dealerRepo.Setup();
            _dealerRepo.DrawHand();
            _battlefieldRepo.Setup();

            return getState();
        }


        [HttpGet]
        public BattleState State(bool endTurn = false)
        {
            if (endTurn)
            {
                _dealerRepo.DiscardHand();
                _dealerRepo.DrawHand();
                _battlefieldRepo.StartTurn();
            }
            return getState();
        }

        [HttpGet]
        public BattleState Play(string cardId)
        {
            var card = _dealerRepo.GetCard(cardId);
            _dealerRepo.Discard(cardId);

            _battlefieldRepo.PlayCard(card);
            return getState();
        }

        private BattleState getState()
        {
            var split = _dealerRepo.GetCurrentSplit();
            var foes = _battlefieldRepo.GetFoes();
            var players = _battlefieldRepo.GetPlayers();
            return new BattleState()
            {
                CardSplit = split,
                Foes = foes,
                Players = players
            };

        }

        // [HttpGet]
        // public CardSplit DrawHand()
        // {
        //     return DealerRepo.CurrentDealer.GetCurrentSplit();

        // }

        // [HttpGet]
        // public CardSplit Draw(int count)
        // {
        //     DealerRepo.CurrentDealer.DrawHand(count);
        //     return DealerRepo.CurrentDealer.GetCurrentSplit();

        // }

        // [HttpGet]
        // public CardSplit DiscardHand()
        // {
        //     DealerRepo.CurrentDealer.DiscardHand();
        //     return DealerRepo.CurrentDealer.GetCurrentSplit();

        // }

        // [HttpGet]
        // public CardSplit Discard(int cardId)
        // {
        //     DealerRepo.CurrentDealer.Discard(cardId);
        //     return DealerRepo.CurrentDealer.GetCurrentSplit();
        // }
    }
}

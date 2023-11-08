﻿using ECTPFinalProject.Core.Entities;
using ECTPFinalProject.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECTPFinalProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GolfLeagueController : Controller
    {
        private readonly IMemberService _memberService;
        private readonly IScoreService _scoreService;

        public GolfLeagueController(IMemberService memberService, IScoreService scoreService)
        {
            _memberService = memberService;
            _scoreService = scoreService;
        }

        [HttpPost]
        public IActionResult AddMemberToLeague([FromBody] League league, Member member)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult RemoveMemberFromLeague([FromBody] League, Member member)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult AddScoreForMember([FromBody] Member member, Score score)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult UpdateScoreForMember([FromBody] Member member, Score score)
        { 
            throw new NotImplementedException(); 
        }

        [HttpPost]
        public IActionResult DeleteScoreForMember([FromBody] Member member, Score score)
        {
            throw new NotImplementedException();
        }
    }
}

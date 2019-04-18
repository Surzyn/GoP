using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoPDataAccess.Interfaces;
using GoPDataAccess.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameOfPubWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PubsController : ControllerBase
    {
        IPubDataRepository _pubRepository;

        public PubsController(IPubDataRepository pubDataRepository)
        {
            _pubRepository = pubDataRepository;
        }

        [HttpGet]
        public IActionResult GetPubs()
        {
            var allPubs = _pubRepository.GetPubs();
            return Ok(allPubs);
        }

        [HttpGet("{id}")]
        public IActionResult GetPub(int id)
        {
            var pubDetails = _pubRepository.GetPub(id);
            return Ok(pubDetails);
        }
    }
}
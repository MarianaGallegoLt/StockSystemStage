using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockSystem.Core.Core.FirstVersion;
using StockSystem.DataAccess.Context;
using StockSystem.Entities.DTOs;
using StockSystem.Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockSystemStage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovementController
    {
        private readonly MovementCore movementCore;

        public MovementController(SqlServerContext context, ILogger<Movement> logger, IMapper mapper)
        {
            movementCore = new MovementCore(context, logger, mapper);
        }

        //GET MOVEMENT
        [HttpGet]
        public async Task<IEnumerable<Movement>> Get()
        {
            return await movementCore.GetMovement();
        }

        [HttpGet("{id}")]
        public async Task<Movement> Get(int id)
        {
            return await movementCore.GetMovement(id);
        }


        //POST/CREATE MOVEMENT
        [HttpPost]
        public async Task<Movement> Post([FromBody] MovementCreateDTO movement)
        {
            return await movementCore.CreateMovement(movement);
        }
    }
}

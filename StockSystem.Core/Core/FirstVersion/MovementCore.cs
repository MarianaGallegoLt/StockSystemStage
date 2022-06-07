using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StockSystem.DataAccess.Context;
using StockSystem.Entities.DTOs;
using StockSystem.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Core.Core.FirstVersion
{
    public class MovementCore
    {
        private readonly SqlServerContext context;
        private readonly ILogger<Movement> logger;
        //private readonly ErrorHandler<Vacancy> errorHandler;
        private readonly IMapper mapper;

        public MovementCore(SqlServerContext context, ILogger<Movement> logger, IMapper mapper)
        {
            this.context = context;
            this.logger = logger;
            //errorHandler = new ErrorHandler<Vacancy>(logger);          
            this.mapper = mapper;
        }


        //GET MOVEMENT
        public async Task<List<Movement>> GetMovement()
        {
            return await context.Movement.ToListAsync();
        }

        public async Task<Movement> GetMovement(int movementId)
        {
            return await context.Movement.FindAsync(movementId);
        }


        //CREATE MOVEMENT
        public async Task<Movement> CreateMovement(MovementCreateDTO entity)
        {
            Movement newMovement = new();

            newMovement.productId = entity.productId;
            newMovement.productName = entity.productName;
            newMovement.productQuantity = entity.productQuantity;
            newMovement.movementDate = entity.movementDate;
            newMovement.movementConcept = entity.movementConcept;
            newMovement.movementStatus = entity.movementStatus;
            newMovement.movementType = entity.movementType;

            var newMovementCreated = context.Movement.Add(newMovement);

            await context.SaveChangesAsync();

            return newMovementCreated.Entity;
        }
    }
}

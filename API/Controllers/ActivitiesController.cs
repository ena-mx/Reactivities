using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    //dotnet watch --no-hot-reload
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext context;
        public ActivitiesController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet] //api/activities/1
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await this.context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //api/activities/1
         public async Task<ActionResult<Activity>> GetActivity(Guid id)
         {
            return await this.context.Activities.FindAsync(id);
         }
    }    
}
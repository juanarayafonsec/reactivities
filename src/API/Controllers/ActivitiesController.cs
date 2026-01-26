using Application.Activities.Queries;
using Dommain;
using Infrastructure.Messaging;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class ActivitiesController(IMediator mediator) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        var query = new GetActivitiesQuery();
        return await mediator.SendQueryAsync<GetActivitiesQuery, List<Activity>>(query);
        
    }

    // [HttpGet("{id}")]
    // public async Task<ActionResult<Activity>> GetActivity(string id)
    // {
    //     var activity = await context.Activities.FindAsync(id);

    //     if(activity is null) return NotFound();
        
    //     return activity;
    // }
}
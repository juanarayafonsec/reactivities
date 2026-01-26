using Dommain;
using Infrastructure.Messaging;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Activities.Queries;

public record GetActivitiesQuery() : IQuery<List<Activity>>;


public class GetActivitiesQueryHandler(AppDbContext context) : IQueryHandler<GetActivitiesQuery, List<Activity>>
{
    public async Task<List<Activity>> HandleAsync(GetActivitiesQuery query, CancellationToken cancellationToken)
    {
        return await context.Activities.ToListAsync(cancellationToken);
    }
}
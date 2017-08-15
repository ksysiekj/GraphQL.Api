using GraphQL.Model;
using GraphQL.Net;

namespace GraphQL.Api.Services
{
    public interface IGraphQLSchemaProvider
    {
        GraphQL<AdventureWorksDbContext> GraphQL { get; }
    }
}
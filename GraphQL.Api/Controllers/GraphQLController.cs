using GraphQL.Api.Model;
using GraphQL.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace GraphQL.Api.Controllers
{
    [Route("graphql")]
    public class GraphQLController : Controller
    {
        private readonly IGraphQLSchemaProvider _graphQlSchemaProvider;

        public GraphQLController(IGraphQLSchemaProvider graphQlSchemaProvider)
        {
            _graphQlSchemaProvider = graphQlSchemaProvider;
        }

        [HttpPost]
        public IActionResult Post([FromBody] GraphQLQueryViewModel query)
        {
            IDictionary<string, object> result = _graphQlSchemaProvider.GraphQL.ExecuteQuery(query.Query);

            return Json(result, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            });
        }
    }
}
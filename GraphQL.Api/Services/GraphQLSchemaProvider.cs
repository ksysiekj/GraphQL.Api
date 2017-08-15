using GraphQL.Model;
using GraphQL.Model.Entities.Human;
using GraphQL.Net;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Linq;

namespace GraphQL.Api.Services
{
    public class GraphQLSchemaProvider : IGraphQLSchemaProvider
    {
        private readonly GraphQL.Net.GraphQL<AdventureWorksDbContext> gql;

        public GraphQLSchemaProvider()
        {
            var options2 = new DbContextOptionsBuilder<AdventureWorksDbContext>();
            options2.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
            GraphQLSchema<AdventureWorksDbContext> schema = GraphQL<AdventureWorksDbContext>.CreateDefaultSchema(() => new AdventureWorksDbContext(options2.Options));

            schema.AddType<Employee>().AddAllFields();
            schema.AddListField("employees", db => db.Employees);
            schema.AddField("employee", new { id = 0 }, (db, args) => db.Employees.FirstOrDefault(u => u.EmployeeID == args.id));

            schema.AddType<JobCandidate>().AddAllFields();
            schema.AddType<Shift>().AddAllFields();
            schema.AddType<Department>().AddAllFields();

            schema.Complete();

            gql = new GraphQL<AdventureWorksDbContext>(schema);
        }

        public GraphQL<AdventureWorksDbContext> GraphQL
        {
            get
            {
                return gql;
            }
        }
    }
}

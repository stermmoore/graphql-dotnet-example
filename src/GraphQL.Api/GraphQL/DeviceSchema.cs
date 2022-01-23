using GraphQL.Types;
using GraphQL;

namespace GraphQL.Api.GraphQL
{
    public class DeviceSchema : Schema
    {
        public DeviceSchema(IServiceProvider dependencyResolver): base(dependencyResolver)
        {
            Query = dependencyResolver.GetRequiredService<DeviceQuery>();
        }
    }
}
using GraphQL.Api.Data.Entities;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types
{
    public class DeviceType : ObjectGraphType<Device>
    {
        public DeviceType()
        {
            Field(d => d.Id);
            Field(d => d.Name);
            Field(d => d.State);
        }
    }
}
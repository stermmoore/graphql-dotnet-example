using GraphQL.Api.Data.Repositories;
using GraphQL.Api.GraphQL.Types;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL
{
    public class DeviceQuery : ObjectGraphType
    {
        public DeviceQuery(DeviceRepository deviceRepository)
        {
            Field<ListGraphType<DeviceType>>(
                "devices",
                resolve: context => deviceRepository.GetDevices()
            );
        }
    }
}
using GraphQL.Api.Data.Entities;
using GraphQL.Api.Data.Repositories;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types
{
    public class DeviceType : ObjectGraphType<Device>
    {
        public DeviceType(DeviceRepository deviceRepository)
        {
            Field(d => d.Id);
            Field(d => d.Name);
            Field(d => d.State);
            Field<ListGraphType<StateHistoryType>>(
                "stateHistory",
                resolve: context => deviceRepository.GetDeviceHistory(context.Source.Id)
            );
        }
    }
}
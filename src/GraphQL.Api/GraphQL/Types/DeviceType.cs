using GraphQL.Api.Data.Entities;
using GraphQL.Api.Data.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types
{
    public class DeviceType : ObjectGraphType<Device>
    {
        public DeviceType(DeviceRepository deviceRepository, IDataLoaderContextAccessor dataLoaderContextAccessor)
        {
            Field(d => d.Id);
            Field(d => d.Name);
            Field(d => d.State);
            Field<ListGraphType<StateHistoryType>>(
                "stateHistory",
                resolve: context => { 
                    var loader = dataLoaderContextAccessor.Context.GetOrAddCollectionBatchLoader<string, StateHistory>(
                        "GetStateHistories", deviceRepository.GetDeviceHistories);
                        return loader.LoadAsync(context.Source.Id);
                }
            );
        }
    }
}
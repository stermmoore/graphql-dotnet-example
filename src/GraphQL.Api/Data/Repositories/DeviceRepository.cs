using GraphQL.Api.Data.Entities;

namespace GraphQL.Api.Data.Repositories
{
    public class DeviceRepository
    {
        public async Task<IEnumerable<Device>> GetDevices()
        {
            return new List<Device> {
                new Device {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Garden Sprinkler",
                    State = "On"
                }
            };

        }
    }
}
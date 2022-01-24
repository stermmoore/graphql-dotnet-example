using GraphQL.Api.Data.Entities;

namespace GraphQL.Api.Data.Repositories
{
    public class DeviceRepository
    {
        private static IEnumerable<Device> DEVICES = new List<Device> {
                new Device {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Garden Sprinkler",
                    State = "On"
                },
                new Device {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Lights",
                    State = "Off"
                }
            };
        public async Task<IEnumerable<Device>> GetDevices()
        {
            return DEVICES;
        }

        internal object GetDevices(string state)
        {
            return DEVICES.Where(s => s.State==state);
        }
    }
}
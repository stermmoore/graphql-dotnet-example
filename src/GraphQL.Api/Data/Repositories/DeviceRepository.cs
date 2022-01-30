using GraphQL.Api.Data.Entities;

namespace GraphQL.Api.Data.Repositories
{
    public class DeviceRepository
    {
        private static IEnumerable<Device> DEVICES = new List<Device> {
                new Device {
                    Id = "47ea12e1-6436-4d35-a10d-7e755b668252",
                    Name = "Garden Sprinkler",
                    State = "On"
                },
                new Device {
                    Id = "434638c5-6754-47ea-ae5d-89c56f0965c5",
                    Name = "Lights",
                    State = "Off"
                }
            };

        private static IEnumerable<StateHistory> STATE_HISTORIES = new List<StateHistory> {
            new StateHistory {
                    DeviceId = "47ea12e1-6436-4d35-a10d-7e755b668252",
                    State = "Off",
                    ReadingDate = new DateTime(2022, 1, 5 , 11, 30, 0)
                },
                new StateHistory {
                    DeviceId = "47ea12e1-6436-4d35-a10d-7e755b668252",
                    State = "On",
                    ReadingDate = new DateTime(2022, 1, 10 , 12, 45, 0)
                },
                new StateHistory {
                    DeviceId = "434638c5-6754-47ea-ae5d-89c56f0965c5",
                    State = "On",
                    ReadingDate = new DateTime(2022, 1, 1 , 11, 10, 0)
                },
                new StateHistory {
                    DeviceId = "434638c5-6754-47ea-ae5d-89c56f0965c5",
                    State = "Off",
                    ReadingDate = new DateTime(2022, 1, 6 , 12, 45, 0)
                }
        };

        public async Task<IEnumerable<Device>> GetDevices()
        {
            return DEVICES;
        }

        public async Task<IEnumerable<StateHistory>> GetDeviceHistory(List<string> deviceIds)
        {
            return STATE_HISTORIES.Where(s => deviceIds.Contains(s.DeviceId));
        }

        public async Task<IEnumerable<StateHistory>> GetDeviceHistory(string deviceId)
        {
            return STATE_HISTORIES.Where(s => s.DeviceId == deviceId);
        }

        internal object GetDevices(string state)
        {
            return DEVICES.Where(s => s.State == state);
        }
    }
}
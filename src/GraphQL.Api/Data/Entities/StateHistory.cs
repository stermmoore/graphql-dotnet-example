namespace GraphQL.Api.Data.Entities
{
    public class StateHistory
    {
        public string DeviceId { get; set; }
        public DateTime ReadingDate { get; set; }
        public string State { get; set; }
    }
}
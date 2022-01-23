namespace GraphQL.Api.Data.Entities
{
    public class Device
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
    }

    public enum State 
    {
        On,
        Off,
        Diabled
    }
}
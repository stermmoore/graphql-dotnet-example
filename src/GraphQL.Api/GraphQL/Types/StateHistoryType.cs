using GraphQL.Api.Data.Entities;
using GraphQL.Types;

namespace GraphQL.Api.GraphQL.Types
{
    public class StateHistoryType : ObjectGraphType<StateHistory>
    {
        public StateHistoryType()
        {
            Field(s => s.DeviceId);
            Field(s => s.ReadingDate);
            Field(s => s.State);
        }
    }
}
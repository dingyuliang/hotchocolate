using System.Collections.Generic;
using HotChocolate.Data.Filters;

namespace HotChocolate.MongoDb.Data.Filters
{
    public class MongoDbFilterScope
        : FilterScope<MongoDbFilterDefinition>
    {
        public MongoDbFilterScope(MongoDbFilterVisitorContext context)
        {
            Context = context;
        }

        public MongoDbFilterVisitorContext Context { get; }

        public Stack<string> Path { get; } = new Stack<string>();
    }
}

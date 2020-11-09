using System;
using HotChocolate.Data.Filters;
using HotChocolate.Language;
using MongoDB.Bson;
using MongoDB.Driver;

namespace HotChocolate.MongoDb.Data.Filters
{
    public class MongoDbListNoneOperationHandler : MongoDbListOperationHandlerBase
    {
        protected override int Operation => DefaultOperations.None;

        protected override MongoDbFilterDefinition HandleListOperation(
            MongoDbFilterVisitorContext context,
            IFilterField field,
            ObjectFieldNode node,
            Type closureType,
            MongoDbFilterScope scope,
            string path,
            MongoDbFilterDefinition? bsonDocument)
        {
            return new MongoDbFilterOperation(
                path,
                new NotMongoDbFilterDefinition(
                    new MongoDbFilterOperation(
                        "$elemMatch",
                        GetFilters(context, scope))));
        }
    }
}

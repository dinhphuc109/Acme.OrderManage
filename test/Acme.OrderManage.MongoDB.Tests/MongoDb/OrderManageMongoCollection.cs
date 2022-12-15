using Xunit;

namespace Acme.OrderManage.MongoDB;

[CollectionDefinition(OrderManageTestConsts.CollectionDefinitionName)]
public class OrderManageMongoCollection : OrderManageMongoDbCollectionFixtureBase
{

}

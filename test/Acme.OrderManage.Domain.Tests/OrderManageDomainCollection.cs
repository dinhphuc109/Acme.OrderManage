using Acme.OrderManage.MongoDB;
using Xunit;

namespace Acme.OrderManage;

[CollectionDefinition(OrderManageTestConsts.CollectionDefinitionName)]
public class OrderManageDomainCollection : OrderManageMongoDbCollectionFixtureBase
{

}

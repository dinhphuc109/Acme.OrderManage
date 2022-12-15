using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.OrderManage.Pages;

[Collection(OrderManageTestConsts.CollectionDefinitionName)]
public class Index_Tests : OrderManageWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

using Volo.Abp.Settings;

namespace Acme.OrderManage.Settings;

public class OrderManageSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OrderManageSettings.MySetting1));
    }
}

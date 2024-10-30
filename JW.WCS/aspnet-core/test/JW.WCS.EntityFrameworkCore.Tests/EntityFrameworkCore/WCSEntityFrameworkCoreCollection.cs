using Xunit;

namespace JW.WCS.EntityFrameworkCore;

[CollectionDefinition(WCSTestConsts.CollectionDefinitionName)]
public class WCSEntityFrameworkCoreCollection : ICollectionFixture<WCSEntityFrameworkCoreFixture>
{

}

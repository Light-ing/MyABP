using JW.WCS.Samples;
using Xunit;

namespace JW.WCS.EntityFrameworkCore.Applications;

[Collection(WCSTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<WCSEntityFrameworkCoreTestModule>
{

}

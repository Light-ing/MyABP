using JW.WCS.Samples;
using Xunit;

namespace JW.WCS.EntityFrameworkCore.Domains;

[Collection(WCSTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<WCSEntityFrameworkCoreTestModule>
{

}

using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Mpn.Pages
{
    public class Index_Tests : MpnWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}

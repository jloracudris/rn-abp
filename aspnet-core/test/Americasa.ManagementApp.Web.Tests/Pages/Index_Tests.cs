using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Americasa.ManagementApp.Pages;

public class Index_Tests : ManagementAppWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}

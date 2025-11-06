using Microsoft.Playwright;
using TUnit.Playwright;

namespace TUnitTest
{
    public class Class1 : PageTest
    {
        [Test]
        public async Task PerformLoginAsync()
        {
            await Page.GotoAsync("https://google.com");

            var title = await Page.MainFrame.TitleAsync();
            await Assert.That(title).IsEqualTo("Google");
        }
    }
}

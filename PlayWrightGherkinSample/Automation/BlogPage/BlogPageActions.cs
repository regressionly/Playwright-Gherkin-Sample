namespace PlayWrightGherkinSample.Automation.BlogPage;

using Microsoft.Playwright;
using System.Threading.Tasks;

using PlayWrightGherkinSample.Automation.Core;

using static PlayWrightGherkinSample.Automation.Core.AppProperties;

public class BlogPageActions : CommonActions {

    public BlogPageActions(IPage page) : base(page)
    {

    }

    public async Task ClickOnBlogLink()
    {
        await Page.ClickAsync("a[data-testid='linkElement']:has-text('Blog')");
    }
}
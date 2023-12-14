namespace PlayWrightGherkinSample.Automation.BlogPage.VerifyBlogs;

using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

using PlayWrightGherkinSample.Automation.BlogPage;
using static PlayWrightGherkinSample.Automation.Core.AppProperties;
using NUnit.Framework;

[Binding]
public sealed class VerifyBlogsSteps
{
    private IPage _page;
    private BlogPageActions _pageActions;

    public VerifyBlogsSteps(IPage page)
    {
        _page = page;
        _page.SetDefaultTimeout(20000);
        _pageActions = new BlogPageActions(page);
    }

    [Given(@"We are on home page")]
    public async Task GivenWeAreOnHomePage()
    {
        await Assertions.Expect(_page.Locator(HomePageProperties.HomePageIdentifierId)).ToBeVisibleAsync();
    }

    [When(@"We click on `Blog` link")]
    public async Task WhenWeClickOnBlogLink()
    {
        await _pageActions.ClickOnBlogLink();
    }

    [Then(@"We verify if we are redirected to `Blog` page")]
    public async Task ThenWeVerifyIfWeAreRedirectedToBlogPage()
    {
        await Assertions.Expect(_page.Locator("button:has-text('All Posts')")).ToBeVisibleAsync();
    }

    [Then(@"We verify if it contains more than '(.*)' post")]
    public async Task ThenWeVerifyIfItContainsMoreThanPost(string numberOfPost)
    {
        var elements = await _page.QuerySelectorAllAsync(".blog-post-homepage-hover-container");
        int posts = Int32.Parse(numberOfPost);

        if (elements.Count < posts)
        {
            throw new Exception("Blog site dont contain more than " + numberOfPost + " posts.");
        }
    }


}

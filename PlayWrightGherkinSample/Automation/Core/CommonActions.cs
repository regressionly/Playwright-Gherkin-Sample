namespace PlayWrightGherkinSample.Automation.Core;

using System.Text.RegularExpressions;
using Microsoft.Playwright;

using static PlayWrightGherkinSample.Automation.Core.AppProperties;

public class CommonActions
{
    protected IPage Page;

    public CommonActions(IPage page)
    {
        this.Page = page;
        Page.SetDefaultTimeout(20000);
    }

    public async Task NavigateEnsurePage(string url)
    {
        if (Page.Url != url)
        {
            await Page.GotoAsync(url);
        }
    }

    public async Task NavigateHardRefresh(string url)
    {
        await Page.GotoAsync(url);
    }
}
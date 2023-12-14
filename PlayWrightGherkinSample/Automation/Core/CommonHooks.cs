namespace PlayWrightGherkinSample.Automation.Core;

using TechTalk.SpecFlow;
using System;
using Microsoft.Playwright;

using static PlayWrightGherkinSample.Automation.Core.AppProperties;
using SpecFlow.Actions.Playwright;

[Binding]
public class CommonHooks
{
    private readonly ScenarioContext _scenarioContext;

    public CommonHooks(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [BeforeScenario(Order = 0)]
    public async Task BeforeScenarioAsync(BrowserDriver browserDriver)
    {
        var page = await (await browserDriver.Current).NewPageAsync();
        await page.GotoAsync(AppProperties.baseUrl);
        _scenarioContext.ScenarioContainer.RegisterInstanceAs(page);
    }

    [AfterScenario]
    public async Task AfterScenario()
    {
        var page = _scenarioContext.ScenarioContainer.Resolve<IPage>();
        if (page != null)
        {
            await page.CloseAsync();
        }
    }
}
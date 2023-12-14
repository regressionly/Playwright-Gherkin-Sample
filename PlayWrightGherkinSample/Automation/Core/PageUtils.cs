using System.Threading.Tasks;
using Microsoft.Playwright;
using SpecFlow.Actions.Playwright;

public class PageUtils
{
    private readonly IPage _page;

    public PageUtils(IPage page)
    {
        _page = page;
    }

    public async Task WaitForNonEmptyValue(string selector)
    {
        await _page.WaitForFunctionAsync($"document.querySelector(\"{selector}\").value !== \"\"");
    }

    public async Task WaitForEmptyValue(string selector)
    {
        await _page.WaitForFunctionAsync($"document.querySelector(\"{selector}\").value === \"\"");
    }
}
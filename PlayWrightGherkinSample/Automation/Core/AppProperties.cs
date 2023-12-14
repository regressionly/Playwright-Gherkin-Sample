namespace PlayWrightGherkinSample.Automation.Core;

public class AppProperties
{
    public static string baseUrl = "https://www.regressionly.com";

    public class HomePageProperties
    {
        public static string HomePageIdentifierId = "#comp-lmul6we9";
    }

    public class BlogPageProperties 
    {
        public static string BlogPageUrl = baseUrl + "/blog";
    }


}
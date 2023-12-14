Feature: VerifyBlogs

Scenario: Navigate to website blog page
Given   We are on home page
When    We click on `Blog` link
Then    We verify if we are redirected to `Blog` page
And     We verify if it contains more than '2' post
[![NuGet Version](https://img.shields.io/nuget/v/Drastic.AdaptiveCards.svg)](https://www.nuget.org/packages/Drastic.AdaptiveCards/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# Drastic.AdaptiveCards

Drastic.AdaptiveCards is an experimental binding for iOS and Catalyst of [AdaptiveCards](https://github.com/Microsoft/AdaptiveCards/tree/main/source/ios), Microsoft's framework for card based content.

![2](https://user-images.githubusercontent.com/898335/226621139-aeb87b30-2cf6-42a4-b924-8182f9e9f197.png)
![3](https://user-images.githubusercontent.com/898335/226637761-f8065604-f4f8-4a8d-bc02-7688f45d7d06.png)

## How To

- Render the incoming JSON content with `ACOAdaptiveCard.FromJson()`
- Render the content with `ACRRenderer.Render`
- Place the resulting `UIView` into your existing page.

```csharp
 string jsonStr = @"{ ""type"": ""AdaptiveCard"", ""version"": ""1.0"", ""body"": [ { ""type"": ""Image"", ""url"": ""http://adaptivecards.io/content/adaptive-card-50.png"", ""horizontalAlignment"":""center"" }, { ""type"": ""TextBlock"", ""horizontalAlignment"":""center"", ""text"": ""Hello **Adaptive Cards!**"" } ], ""actions"": [ { ""type"": ""Action.OpenUrl"", ""title"": ""Learn more"", ""url"": ""http://adaptivecards.io"" }, { ""type"": ""Action.OpenUrl"", ""title"": ""GitHub"", ""url"": ""http://github.com/Microsoft/AdaptiveCards"" } ] }";
        global::AdaptiveCards.ACOAdaptiveCardParseResult cardParseResult = global::AdaptiveCards.ACOAdaptiveCard.FromJson(jsonStr);
        ACRRenderResult renderResult = null;
        if (cardParseResult.IsValid)
        {
            renderResult = ACRRenderer.Render(cardParseResult.Card, null, 300);
            var newView = renderResult.View;
            this.View!.AddSubview(newView);
            // Using 
            newView.MakeConstraints(make => {
                make.Center.EqualTo(this.View);
            });
        }
```


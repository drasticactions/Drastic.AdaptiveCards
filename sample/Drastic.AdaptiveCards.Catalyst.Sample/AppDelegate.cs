using SceneKit;
using AdaptiveCards;
using Masonry;

namespace Drastic.AdaptiveCards.Catalyst.Sample;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {
	public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

		// create a UIViewController with a single UILabel
		var vc = new ViewController();
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();

		return true;
	}
}

public partial class ViewController : UIViewController
{
    public override void ViewDidLoad()
    {
        base.ViewDidLoad();

        string jsonStr = @"{ ""type"": ""AdaptiveCard"", ""version"": ""1.0"", ""body"": [ { ""type"": ""Image"", ""url"": ""http://adaptivecards.io/content/adaptive-card-50.png"", ""horizontalAlignment"":""center"" }, { ""type"": ""TextBlock"", ""horizontalAlignment"":""center"", ""text"": ""Hello **Adaptive Cards!**"" } ], ""actions"": [ { ""type"": ""Action.OpenUrl"", ""title"": ""Learn more"", ""url"": ""http://adaptivecards.io"" }, { ""type"": ""Action.OpenUrl"", ""title"": ""GitHub"", ""url"": ""http://github.com/Microsoft/AdaptiveCards"" } ] }";
        global::AdaptiveCards.ACOAdaptiveCardParseResult cardParseResult = global::AdaptiveCards.ACOAdaptiveCard.FromJson(jsonStr);
        ACRRenderResult renderResult = null;
        if (cardParseResult.IsValid)
        {
            renderResult = ACRRenderer.Render(cardParseResult.Card, null, 300);
            var newView = renderResult.View;
            this.View!.AddSubview(newView);
            newView.MakeConstraints(make => {
                make.Center.EqualTo(this.View);
            });
        }

    }
}
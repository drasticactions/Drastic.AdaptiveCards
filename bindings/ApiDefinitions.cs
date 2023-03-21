using AdaptiveCards;
using Foundation;
using UIKit;

namespace Drastic.AdaptiveCards
{
	// @protocol ACOIResourceResolver
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface ACOIResourceResolver
	{
		// @optional -(UIImage *)resolveImageResource:(NSURL *)url;
		[Export ("resolveImageResource:")]
		UIImage ResolveImageResource (NSUrl url);

		// @optional -(UIImageView *)resolveImageViewResource:(NSURL *)url;
		[Export ("resolveImageViewResource:")]
		UIImageView ResolveImageViewResource (NSUrl url);

		// @optional -(UIImageView *)resolveBackgroundImageViewResource:(NSURL *)url hasStretch:(BOOL)hasStretch;
		[Export ("resolveBackgroundImageViewResource:hasStretch:")]
		UIImageView ResolveBackgroundImageViewResource (NSUrl url, bool hasStretch);
	}

	// @interface ACOResourceResolvers : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOResourceResolvers
	{
		// -(ACOResolverIFType)getResolverIFType:(NSString *)scheme;
		[Export ("getResolverIFType:")]
		ACOResolverIFType GetResolverIFType (string scheme);

		// -(NSObject<ACOIResourceResolver> *)getResourceResolverForScheme:(NSString *)scheme;
		[Export ("getResourceResolverForScheme:")]
		ACOIResourceResolver GetResourceResolverForScheme (string scheme);

		// -(void)setResourceResolver:(NSObject<ACOIResourceResolver> *)resolver scheme:(NSString *)scheme;
		[Export ("setResourceResolver:scheme:")]
		void SetResourceResolver (ACOIResourceResolver resolver, string scheme);
	}
}

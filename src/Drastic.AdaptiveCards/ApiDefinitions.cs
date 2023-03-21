using System;
using AdaptiveCards;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace AdaptiveCards
{
	// @interface ACRParseWarning : NSObject
	[BaseType (typeof(NSObject))]
	interface ACRParseWarning
	{
		// @property (readonly) ACRWarningStatusCode statusCode;
		[Export ("statusCode")]
		ACRWarningStatusCode StatusCode { get; }

		// @property (readonly) NSString * reason;
		[Export ("reason")]
		string Reason { get; }
	}

	// @interface ACOAdaptiveCardParseResult : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOAdaptiveCardParseResult
	{
		// @property (readonly) ACOAdaptiveCard * card;
		[Export ("card")]
		ACOAdaptiveCard Card { get; }

		// @property (readonly) BOOL isValid;
		[Export ("isValid")]
		bool IsValid { get; }

		// @property (readonly) NSArray<NSError *> * parseErrors;
		[Export ("parseErrors")]
		NSError[] ParseErrors { get; }

		// @property (readonly) NSArray<ACRParseWarning *> * parseWarnings;
		[Export ("parseWarnings")]
		ACRParseWarning[] ParseWarnings { get; }

		// -(instancetype)init:(ACOAdaptiveCard *)card errors:(NSArray<NSError *> *)errors warnings:(NSArray<ACRParseWarning *> *)warnings;
		[Export ("init:errors:warnings:")]
		NativeHandle Constructor (ACOAdaptiveCard card, NSError[] errors, ACRParseWarning[] warnings);
	}

	// @interface ACOAuthCardButton : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOAuthCardButton
	{
		// @property NSString * type;
		[Export ("type")]
		string Type { get; set; }

		// @property NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property NSString * image;
		[Export ("image")]
		string Image { get; set; }

		// @property NSString * value;
		[Export ("value")]
		string Value { get; set; }

		// -(instancetype)init:(NSString *)type title:(NSString *)title image:(NSString *)image value:(NSString *)value;
		[Export ("init:title:image:value:")]
		NativeHandle Constructor (string type, string title, string image, string value);
	}

	// @interface ACOTokenExchangeResource : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOTokenExchangeResource
	{
		// @property NSString * Id;
		[Export ("Id")]
		string Id { get; set; }

		// @property NSString * uri;
		[Export ("uri")]
		string Uri { get; set; }

		// @property NSString * providerId;
		[Export ("providerId")]
		string ProviderId { get; set; }

		// -(instancetype)init:(NSString *)stringId uri:(NSString *)uri providerId:(NSString *)providerId;
		[Export ("init:uri:providerId:")]
		NativeHandle Constructor (string stringId, string uri, string providerId);
	}

	// @interface ACOAuthentication : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOAuthentication
	{
		// @property NSString * text;
		[Export ("text")]
		string Text { get; set; }

		// @property NSString * connectionName;
		[Export ("connectionName")]
		string ConnectionName { get; set; }

		// @property ACOTokenExchangeResource * tokenExchangeResource;
		[Export ("tokenExchangeResource", ArgumentSemantic.Assign)]
		ACOTokenExchangeResource TokenExchangeResource { get; set; }

		// @property NSArray<ACOAuthCardButton *> * buttons;
		[Export ("buttons", ArgumentSemantic.Assign)]
		ACOAuthCardButton[] Buttons { get; set; }

		// -(instancetype)init:(NSString *)text connectionName:(NSString *)connectionName tokenExchangeResource:(ACOTokenExchangeResource *)tokenExchangeResource buttons:(NSArray<ACOAuthCardButton *> *)buttons;
		[Export ("init:connectionName:tokenExchangeResource:buttons:")]
		NativeHandle Constructor (string text, string connectionName, ACOTokenExchangeResource tokenExchangeResource, ACOAuthCardButton[] buttons);
	}

	// @interface ACOParseContext : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOParseContext
	{
	}

	// @interface ACOBaseActionElement : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOBaseActionElement
	{
		// @property ACRActionType type;
		[Export ("type", ArgumentSemantic.Assign)]
		ACRActionType Type { get; set; }

		// @property NSString * sentiment;
		[Export ("sentiment")]
		string Sentiment { get; set; }

		// @property (copy, nonatomic) NSString * tooltip;
		[Export ("tooltip")]
		string Tooltip { get; set; }

		// @property (readonly, nonatomic) NSString * inlineTooltip;
		[Export ("inlineTooltip")]
		string InlineTooltip { get; }

		// -(NSString *)title;
		[Export ("title")]
		//[Verify (MethodToProperty)]
		string Title { get; }

		// -(NSString *)elementId;
		[Export ("elementId")]
		//[Verify (MethodToProperty)]
		string ElementId { get; }

		// -(NSString *)url;
		[Export ("url")]
		//[Verify (MethodToProperty)]
		string Url { get; }

		// -(NSString *)data;
		[Export ("data")]
		//[Verify (MethodToProperty)]
		string Data { get; }

		// -(NSString *)verb;
		[Export ("verb")]
		//[Verify (MethodToProperty)]
		string Verb { get; }

		// -(NSData *)additionalProperty;
		[Export ("additionalProperty")]
		//[Verify (MethodToProperty)]
		NSData AdditionalProperty { get; }

		// -(BOOL)isEnabled;
		[Export ("isEnabled")]
		//[Verify (MethodToProperty)]
		bool IsEnabled { get; }

		// -(BOOL)meetsRequirements:(ACOFeatureRegistration *)featureReg;
		[Export ("meetsRequirements:")]
		bool MeetsRequirements (NSObject featureReg);

		// +(NSNumber *)getKey:(ACRActionType)actionType;
		[Static]
		[Export ("getKey:")]
		NSNumber GetKey (ACRActionType actionType);
	}

	// @protocol ACOIBaseActionElementParser
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface ACOIBaseActionElementParser
	{
		// @required -(ACOBaseActionElement *)deserialize:(NSData *)json parseContext:(ACOParseContext *)parseContext;
		[Abstract]
		[Export ("deserialize:parseContext:")]
		ACOBaseActionElement ParseContext (NSData json, ACOParseContext parseContext);
	}

	// @interface ACORefresh : NSObject
	[BaseType (typeof(NSObject))]
	interface ACORefresh
	{
		// @property ACOBaseActionElement * action;
		[Export ("action", ArgumentSemantic.Assign)]
		ACOBaseActionElement Action { get; set; }

		// @property NSArray<NSString *> * userIds;
		[Export ("userIds", ArgumentSemantic.Assign)]
		string[] UserIds { get; set; }

		// -(instancetype)init:(ACOBaseActionElement *)action userIds:(NSArray<NSString *> *)userIds;
		[Export ("init:userIds:")]
		NativeHandle Constructor (ACOBaseActionElement action, string[] userIds);
	}

	// @interface ACOBaseCardElement : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOBaseCardElement
	{
		// -(NSData *)additionalProperty;
		[Export ("additionalProperty")]
		//[Verify (MethodToProperty)]
		NSData AdditionalProperty { get; }

		// @property ACRCardElementType type;
		[Export ("type", ArgumentSemantic.Assign)]
		ACRCardElementType Type { get; set; }

		// -(BOOL)meetsRequirements:(ACOFeatureRegistration *)featureReg;
		[Export ("meetsRequirements:")]
		bool MeetsRequirements (NSObject featureReg);
	}

	// @protocol ACOIBaseCardElementParser
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol, Model]
[BaseType (typeof(NSObject))]

	interface ACOIBaseCardElementParser
	{
		// @required -(ACOBaseCardElement *)deserialize:(NSData *)json parseContext:(ACOParseContext *)parseContext;
		[Abstract]
		[Export ("deserialize:parseContext:")]
		ACOBaseCardElement ParseContext (NSData json, ACOParseContext parseContext);
	}

	// @interface ACORemoteResourceInformation : NSObject
	[BaseType (typeof(NSObject))]
	interface ACORemoteResourceInformation
	{
		// @property (readonly) NSURL * url;
		[Export ("url")]
		NSUrl Url { get; }

		// @property (readonly) NSString * mimeType;
		[Export ("mimeType")]
		string MimeType { get; }
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const ACRInputErrorDomain;
		[Field ("ACRInputErrorDomain", "__Internal")]
		NSString ACRInputErrorDomain { get; }

		// extern NSString *const ACRParseErrorDomain;
		[Field ("ACRParseErrorDomain", "__Internal")]
		NSString ACRParseErrorDomain { get; }
	}

	// @interface ACOFallbackException : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOFallbackException
	{
		// +(ACOFallbackException *)fallbackException;
		[Static]
		[Export ("fallbackException")]
		//[Verify (MethodToProperty)]
		ACOFallbackException FallbackException { get; }
	}

	// @protocol ACRIBaseInputHandler
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface ACRIBaseInputHandler
	{
		// @required @property BOOL isRequired;
		[Abstract]
		[Export ("isRequired")]
		bool IsRequired { get; set; }

		// @required @property BOOL hasValidationProperties;
		[Abstract]
		[Export ("hasValidationProperties")]
		bool HasValidationProperties { get; set; }

		// @required @property BOOL hasVisibilityChanged;
		[Abstract]
		[Export ("hasVisibilityChanged")]
		bool HasVisibilityChanged { get; set; }

		// @required @property NSString * _Nonnull id;
		[Abstract]
		[Export ("id")]
		string Id { get; set; }

		// @required -(BOOL)validate:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export ("validate:")]
		bool Validate ([NullAllowed] out NSError error);

		// @required -(void)setFocus:(BOOL)shouldBecomeFirstResponder view:(UIView * _Nullable)view;
		[Abstract]
		[Export ("setFocus:view:")]
		void SetFocus (bool shouldBecomeFirstResponder, [NullAllowed] UIView view);

		// @required -(void)getInput:(NSMutableDictionary * _Nonnull)dictionary;
		[Abstract]
		[Export ("getInput:")]
		void GetInput (NSMutableDictionary dictionary);
	}

	// @interface ACOAdaptiveCard : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOAdaptiveCard
	{
		// @property ACORefresh * refresh;
		[Export ("refresh", ArgumentSemantic.Assign)]
		ACORefresh Refresh { get; set; }

		// @property ACOAuthentication * authentication;
		[Export ("authentication", ArgumentSemantic.Assign)]
		ACOAuthentication Authentication { get; set; }

		// +(ACOAdaptiveCardParseResult *)fromJson:(NSString *)payload;
		[Static]
		[Export ("fromJson:")]
		ACOAdaptiveCardParseResult FromJson (string payload);

		// -(NSData *)inputs;
		[Export ("inputs")]
		//[Verify (MethodToProperty)]
		NSData Inputs { get; }

		// -(NSArray<ACRIBaseInputHandler> *)getInputs;
		[Export ("getInputs")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] ACRIBaseInputHandlerInputs { get; }

		// -(void)setInputs:(NSArray *)inputs;
		[Export ("setInputs:")]
		//[Verify (StronglyTypedNSArray)]
		void SetInputs (NSObject[] inputs);

		// -(void)appendInputs:(NSArray *)inputs;
		[Export ("appendInputs:")]
		//[Verify (StronglyTypedNSArray)]
		void AppendInputs (NSObject[] inputs);

		// -(NSArray<ACORemoteResourceInformation *> *)remoteResourceInformation;
		[Export ("remoteResourceInformation")]
		//[Verify (MethodToProperty)]
		ACORemoteResourceInformation[] RemoteResourceInformation { get; }

		// -(NSData *)additionalProperty;
		[Export ("additionalProperty")]
		//[Verify (MethodToProperty)]
		NSData AdditionalProperty { get; }
	}

	// @interface ACRRenderResult : NSObject
	[BaseType (typeof(NSObject))]
	interface ACRRenderResult
	{
		// @property ACRView * view;
		[Export ("view", ArgumentSemantic.Assign)]
		UIView View { get; set; }

		// @property ACRViewController * viewcontroller;
		[Export ("viewcontroller", ArgumentSemantic.Assign)]
		UIViewController Viewcontroller { get; set; }

		// @property BOOL succeeded;
		[Export ("succeeded")]
		bool Succeeded { get; set; }

		// @property (weak) NSArray<ACOWarning *> * warnings;
		[Export ("warnings", ArgumentSemantic.Weak)]
		NSObject[] Warnings { get; set; }
	}

	// @interface ACOWarning : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOWarning
	{
		// @property ACRWarningStatusCode statusCode;
		[Export ("statusCode", ArgumentSemantic.Assign)]
		ACRWarningStatusCode StatusCode { get; set; }

		// @property NSString * message;
		[Export ("message")]
		string Message { get; set; }

		// -(instancetype)initWith:(ACRWarningStatusCode)statusCode message:(NSString *)message;
		[Export ("initWith:message:")]
		NativeHandle Constructor (ACRWarningStatusCode statusCode, string message);
	}

	// @interface ACOResourceResolvers : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOResourceResolvers
	{
		// -(ACOResolverIFType)getResolverIFType:(NSString *)scheme;
		[Export ("getResolverIFType:")]
		ACOIResourceResolver GetResolverIFType (string scheme);

		// -(NSObject<ACOIResourceResolver> *)getResourceResolverForScheme:(NSString *)scheme;
		[Export ("getResourceResolverForScheme:")]
		ACOIResourceResolver GetResourceResolverForScheme (string scheme);

		// -(void)setResourceResolver:(NSObject<ACOIResourceResolver> *)resolver scheme:(NSString *)scheme;
		[Export ("setResourceResolver:scheme:")]
		void SetResourceResolver (ACOIResourceResolver resolver, string scheme);
	}

	[Protocol, Model]
	[BaseType (typeof(NSObject))]
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

	// @interface ACOHostConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOHostConfig
	{
		// @property CGFloat buttonPadding;
		[Export ("buttonPadding")]
		nfloat ButtonPadding { get; set; }

		// @property ACOResourceResolvers * resolvers;
		[Export ("resolvers", ArgumentSemantic.Assign)]
		ACOResourceResolvers Resolvers { get; set; }

		// @property NSURL * baseURL;
		[Export ("baseURL", ArgumentSemantic.Assign)]
		NSUrl BaseURL { get; set; }

		// -(NSObject<ACOIResourceResolver> *)getResourceResolverForScheme:(NSString *)scheme;
		[Export ("getResourceResolverForScheme:")]
		ACOIResourceResolver GetResourceResolverForScheme (string scheme);

		// -(ACOResolverIFType)getResolverIFType:(NSString *)scheme;
		[Export ("getResolverIFType:")]
		ACOResolverIFType GetResolverIFType (string scheme);

		// +(ACOHostConfigParseResult *)fromJson:(NSString *)payload;
		[Static]
		[Export ("fromJson:")]
		ACOHostConfigParseResult FromJson (string payload);

		// +(ACOHostConfigParseResult *)fromJson:(NSString *)payload resourceResolvers:(ACOResourceResolvers *)resolvers;
		[Static]
		[Export ("fromJson:resourceResolvers:")]
		ACOHostConfigParseResult FromJson (string payload, ACOResourceResolvers resolvers);

		// -(NSNumber *)getIconPlacement:(NSNumber *)internalId;
		[Export ("getIconPlacement:")]
		NSNumber GetIconPlacement (NSNumber internalId);
	}

		// @interface ACOHostConfigParseResult : NSObject
	[BaseType (typeof(NSObject))]
	interface ACOHostConfigParseResult
	{
		// @property (readonly) ACOHostConfig * config;
		[Export ("config")]
		ACOHostConfig Config { get; }

		// @property (readonly) BOOL isValid;
		[Export ("isValid")]
		bool IsValid { get; }

		// @property (readonly) NSArray<NSError *> * parseErrors;
		[Export ("parseErrors")]
		NSError[] ParseErrors { get; }

		// -(instancetype)init:(ACOHostConfig *)config errors:(NSArray<NSError *> *)errors;
		[Export ("init:errors:")]
		NativeHandle Constructor (ACOHostConfig config, NSError[] errors);
	}

	// @interface ACRRenderer : NSObject
	[BaseType (typeof(NSObject))]
	interface ACRRenderer
	{
		// +(ACRRenderResult *)render:(ACOAdaptiveCard *)card config:(ACOHostConfig *)config widthConstraint:(float)width;
		[Static]
		[Export ("render:config:widthConstraint:")]
		ACRRenderResult Render (ACOAdaptiveCard card, [NullAllowed] ACOHostConfig config, float width);

		// +(ACRRenderResult *)render:(ACOAdaptiveCard *)card config:(ACOHostConfig *)config widthConstraint:(float)width delegate:(id<ACRActionDelegate>)acrActionDelegate;
		[Static]
		[Export ("render:config:widthConstraint:delegate:")]
		ACRRenderResult Render (ACOAdaptiveCard card, [NullAllowed] ACOHostConfig config, float width, [NullAllowed] NSObject acrActionDelegate);

		// +(ACRRenderResult *)renderAsViewController:(ACOAdaptiveCard *)card config:(ACOHostConfig *)config frame:(CGRect)frame delegate:(id<ACRActionDelegate>)acrActionDelegate;
		[Static]
		[Export ("renderAsViewController:config:frame:delegate:")]
		ACRRenderResult RenderAsViewController (ACOAdaptiveCard card, [NullAllowed] ACOHostConfig config, CGRect frame, [NullAllowed] NSObject acrActionDelegate);
	}
}

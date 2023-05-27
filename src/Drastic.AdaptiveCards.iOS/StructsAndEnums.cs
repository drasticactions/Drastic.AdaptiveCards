using ObjCRuntime;

namespace AdaptiveCards
{
	[Native]
	public enum ACOResolverIFType : long
	{
		DefaultIF = 0,
		ImageIF = 0,
		ImageViewIF
	}

	[Native]
	public enum ACRWarningStatusCode : ulong
	{
		UnknownElementType = 0,
		UnknownActionElementType,
		UnknownPropertyOnElement,
		UnknownEnumValue,
		NoRendererForType,
		InteractivityNotSupported,
		MaxActionsExceeded,
		AssetLoadFailed,
		UnsupportedSchemaVersion,
		UnsupportedMediaType,
		InvalidMediaMix,
		InvalidColorFormat,
		InvalidDimensionSpecified,
		InvalidLanguage,
		InvalidValue,
		MissingInputErrorMessage,
		CustomWarning
	}

	[Native]
	public enum ACRImageSize : ulong
	{
		None = 0,
		Auto,
		Stretch,
		Explicit,
		Small,
		Medium,
		Large
	}

	[Native]
	public enum ACRActionType : long
	{
		Execute = 1,
		OpenUrl,
		ShowCard,
		Submit,
		ToggleVisibility,
		Overflow,
		UnknownAction = 7
	}

	[Native]
	public enum ACRIconPlacement : long
	{
		AboveTitle = 0,
		LeftOfTitle,
		NoTitle
	}

	[Native]
	public enum ACRCardElementType : long
	{
		ActionSet = 0,
		AdaptiveCard,
		ChoiceInput,
		ChoiceSetInput,
		Column,
		ColumnSet,
		Container,
		Custom,
		DateInput,
		Fact,
		FactSet,
		Image,
		ImageSet,
		Media,
		NumberInput,
		RichTextBlock,
		Table,
		TableCell,
		TableRow,
		TextBlock,
		TextInput,
		TimeInput,
		ToggleInput,
		Unknown
	}

	[Native]
	public enum ACRContainerStyle : long
	{
		None,
		Default,
		Emphasis,
		Good,
		Attention,
		Warning,
		Accent
	}

	[Native]
	public enum ACRBleedDirection : long
	{
		Restricted = 0,
		ToLeadingEdge = 1,
		ToTrailingEdge = 16,
		ToTopEdge = 256,
		ToBottomEdge = 4096,
		ToAll = ToLeadingEdge | ToTrailingEdge | ToTopEdge | ToBottomEdge
	}

	[Native]
	public enum ACRRtl : long
	{
		None,
		Rtl,
		Ltr
	}

	[Native]
	public enum ACRHorizontalAlignment : ulong
	{
		Left = 0,
		Center,
		Right
	}

	[Native]
	public enum ACRVerticalContentAlignment : ulong
	{
		Top = 0,
		Center,
		Bottom
	}

	[Native]
	public enum ACRHeightType : ulong
	{
		Auto = 0,
		Stretch
	}

	[Native]
	public enum ACRInputError : ulong
	{
		ValueMissing,
		LessThanMin,
		GreaterThanMax,
		LessThanMinDate,
		GreaterThanMaxDate
	}

	[Native]
	public enum ACRRenderingStatus : ulong
	{
		Ok = 0,
		Failed,
		Unsupported
	}
}

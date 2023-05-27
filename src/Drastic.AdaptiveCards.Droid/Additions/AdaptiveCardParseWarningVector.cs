using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IO.Adaptivecards.Objectmodel
{
    public partial class CaptionSourceVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess {
        static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/CaptionSourceVector;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.CaptionSourceVector>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
    }

    public partial class TableRowVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess {
        static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/TableRowVector;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TableRowVector>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
    }

    public partial class TableCellVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess {
        static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/TableCellVector;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TableCellVector>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
    }

     public partial class TableColumnDefinitionVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess {
        static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/TableColumnDefinitionVector;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.TableColumnDefinitionVector>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
    }

    public partial class AuthCardButtonVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess {
        static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/AuthCardButtonVector;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AuthCardButtonVector>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
    }

    public partial class AdaptiveCardParseWarningVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/AdaptiveCardParseWarning;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);
				return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.AdaptiveCardParseWarning>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class BaseActionElementVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/BaseActionElement;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseActionElement>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/BaseActionElement;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class BaseCardElementVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='BaseCardElementVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/BaseCardElement;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.BaseCardElement>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/BaseCardElement;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class CharVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='CharVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Ljava/lang/Character;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Character>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Character>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Ljava/lang/Character;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class ChoiceInputVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ChoiceInputVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/ChoiceInput;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceInput>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ChoiceInput>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/ChoiceInput;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class ColumnVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ColumnVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/Column;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Column>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/Column;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class DateTimePreparsedTokenVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='DateTimePreparsedTokenVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/DateTimePreparsedToken;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.DateTimePreparsedToken>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/DateTimePreparsedToken;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class FactVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='FactVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/Fact;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Fact>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/Fact;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class ImageVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ImageVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/Image;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Image>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/Image;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class InlineVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='InlineVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/Inline;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Inline>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.Inline>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/Inline;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}
	public partial class MediaSourceVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='MediaSourceVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)

		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/MediaSource;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.MediaSource>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/MediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class RemoteResourceInformationVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='RemoteResourceInformationVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)

		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/RemoteResourceInformation;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.RemoteResourceInformation>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.RemoteResourceInformation>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/RemoteResourceInformation;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}

	public partial class StringVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='StringVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		public override unsafe global::Java.Lang.Object Get(int index)

		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Ljava/lang/String;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}


	}

	public partial class ToggleVisibilityTargetVector : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
	{
		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.objectmodel']/class[@name='ToggleVisibilityTargetVector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("get", "(I)Lio/adaptivecards/objectmodel/ToggleVisibilityTarget;", "GetGet_IHandler")]
		public override unsafe global::Java.Lang.Object Get(int index)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID(class_ref, "get", "(I)Lio/adaptivecards/objectmodel/ToggleVisibilityTarget;");
			try
			{
				JValue* __args = stackalloc JValue[1];
				__args[0] = new JValue(index);

				if (((object)this).GetType() == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleVisibilityTarget>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::IO.Adaptivecards.Objectmodel.ToggleVisibilityTarget>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "get", "(I)Lio/adaptivecards/objectmodel/ToggleVisibilityTarget;"), __args), JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
	}
}
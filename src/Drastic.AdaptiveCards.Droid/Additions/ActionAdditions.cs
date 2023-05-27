using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace IO.Adaptivecards.Renderer.Action
{
    public partial class ActionElementRendererIconImageLoaderAsync : global::IO.Adaptivecards.Renderer.InnerImageLoaderAsync {
        protected override Java.Lang.Object DoInBackground(params Java.Lang.Object[] @params)
		{
			return new Java.Lang.Object(JNIEnv.CallObjectMethod(Handle, JNIEnv.GetMethodID(JNIEnv.GetObjectClass(Handle), "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
		}
    }
}
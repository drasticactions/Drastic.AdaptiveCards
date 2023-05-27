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

namespace IO.Adaptivecards.Renderer.Readonly
{
	public partial class ImageRenderer : global::IO.Adaptivecards.Renderer.BaseCardElementRenderer
    {
		static IntPtr id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderArgs_;
		// Metadata.xml XPath method reference: path="/api/package[@name='io.adaptivecards.renderer.readonly']/class[@name='ImageRenderer']/method[@name='render' and count(parameter)=8 and parameter[1][@type='io.adaptivecards.renderer.RenderedAdaptiveCard'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='android.support.v4.app.FragmentManager'] and parameter[4][@type='android.view.ViewGroup'] and parameter[5][@type='io.adaptivecards.objectmodel.BaseCardElement'] and parameter[6][@type='io.adaptivecards.renderer.actionhandler.ICardActionHandler'] and parameter[7][@type='io.adaptivecards.objectmodel.HostConfig'] and parameter[8][@type='io.adaptivecards.renderer.RenderArgs']]"
		public override unsafe global::Android.Views.View Render(global::IO.Adaptivecards.Renderer.RenderedAdaptiveCard renderedCard, global::Android.Content.Context context, global::AndroidX.Fragment.App.FragmentManager fragmentManager, global::Android.Views.ViewGroup viewGroup, global::IO.Adaptivecards.Objectmodel.BaseCardElement baseCardElement, global::IO.Adaptivecards.Renderer.Actionhandler.ICardActionHandler cardActionHandler, global::IO.Adaptivecards.Objectmodel.HostConfig hostConfig, global::IO.Adaptivecards.Renderer.RenderArgs renderArgs)
		{
			if (id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderArgs_ == IntPtr.Zero)
				id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderArgs_ = JNIEnv.GetMethodID(class_ref, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/renderer/RenderArgs;)Landroid/widget/ImageView;");
			try
			{
				JValue* __args = stackalloc JValue[8];
				__args[0] = new JValue(renderedCard);
				__args[1] = new JValue(context);
				__args[2] = new JValue(fragmentManager);
				__args[3] = new JValue(viewGroup);
				__args[4] = new JValue(baseCardElement);
				__args[5] = new JValue(cardActionHandler);
				__args[6] = new JValue(hostConfig);
				__args[7] = new JValue(renderArgs);

				global::Android.Widget.ImageView __ret;
				if (((object)this).GetType() == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_render_Lio_adaptivecards_renderer_RenderedAdaptiveCard_Landroid_content_Context_Landroid_support_v4_app_FragmentManager_Landroid_view_ViewGroup_Lio_adaptivecards_objectmodel_BaseCardElement_Lio_adaptivecards_renderer_actionhandler_ICardActionHandler_Lio_adaptivecards_objectmodel_HostConfig_Lio_adaptivecards_renderer_RenderArgs_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "render", "(Lio/adaptivecards/renderer/RenderedAdaptiveCard;Landroid/content/Context;Landroid/support/v4/app/FragmentManager;Landroid/view/ViewGroup;Lio/adaptivecards/objectmodel/BaseCardElement;Lio/adaptivecards/renderer/actionhandler/ICardActionHandler;Lio/adaptivecards/objectmodel/HostConfig;Lio/adaptivecards/renderer/RenderArgs;)Landroid/widget/ImageView;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}
			finally
			{
			}
		}
	}
}
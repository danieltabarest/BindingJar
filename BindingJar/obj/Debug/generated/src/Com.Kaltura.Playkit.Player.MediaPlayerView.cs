using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/MediaPlayerView", DoNotGenerateAcw=true)]
	public partial class MediaPlayerView : global::Com.Kaltura.Playkit.Player.PlayerView, global::Android.Views.ISurfaceHolderCallback {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/MediaPlayerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaPlayerView); }
		}

		protected MediaPlayerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/constructor[@name='MediaPlayerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MediaPlayerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (MediaPlayerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/constructor[@name='MediaPlayerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MediaPlayerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MediaPlayerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/constructor[@name='MediaPlayerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediaPlayerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MediaPlayerView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getSurfaceHolder;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHolderHandler ()
		{
			if (cb_getSurfaceHolder == null)
				cb_getSurfaceHolder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSurfaceHolder);
			return cb_getSurfaceHolder;
		}

		static IntPtr n_GetSurfaceHolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceHolder);
		}
#pragma warning restore 0169

		static IntPtr id_getSurfaceHolder;
		public virtual unsafe global::Android.Views.ISurfaceHolder SurfaceHolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='getSurfaceHolder' and count(parameter)=0]"
			[Register ("getSurfaceHolder", "()Landroid/view/SurfaceHolder;", "GetGetSurfaceHolderHandler")]
			get {
				if (id_getSurfaceHolder == IntPtr.Zero)
					id_getSurfaceHolder = JNIEnv.GetMethodID (class_ref, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSurfaceHolder), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSurfaceHolder", "()Landroid/view/SurfaceHolder;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hideVideoSubtitles;
#pragma warning disable 0169
		static Delegate GetHideVideoSubtitlesHandler ()
		{
			if (cb_hideVideoSubtitles == null)
				cb_hideVideoSubtitles = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideVideoSubtitles);
			return cb_hideVideoSubtitles;
		}

		static void n_HideVideoSubtitles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideVideoSubtitles ();
		}
#pragma warning restore 0169

		static IntPtr id_hideVideoSubtitles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='hideVideoSubtitles' and count(parameter)=0]"
		[Register ("hideVideoSubtitles", "()V", "GetHideVideoSubtitlesHandler")]
		public override unsafe void HideVideoSubtitles ()
		{
			if (id_hideVideoSubtitles == IntPtr.Zero)
				id_hideVideoSubtitles = JNIEnv.GetMethodID (class_ref, "hideVideoSubtitles", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideVideoSubtitles);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideVideoSubtitles", "()V"));
			} finally {
			}
		}

		static Delegate cb_hideVideoSurface;
#pragma warning disable 0169
		static Delegate GetHideVideoSurfaceHandler ()
		{
			if (cb_hideVideoSurface == null)
				cb_hideVideoSurface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideVideoSurface);
			return cb_hideVideoSurface;
		}

		static void n_HideVideoSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideVideoSurface ();
		}
#pragma warning restore 0169

		static IntPtr id_hideVideoSurface;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='hideVideoSurface' and count(parameter)=0]"
		[Register ("hideVideoSurface", "()V", "GetHideVideoSurfaceHandler")]
		public override unsafe void HideVideoSurface ()
		{
			if (id_hideVideoSurface == IntPtr.Zero)
				id_hideVideoSurface = JNIEnv.GetMethodID (class_ref, "hideVideoSurface", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideVideoSurface);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideVideoSurface", "()V"));
			} finally {
			}
		}

		static Delegate cb_showVideoSubtitles;
#pragma warning disable 0169
		static Delegate GetShowVideoSubtitlesHandler ()
		{
			if (cb_showVideoSubtitles == null)
				cb_showVideoSubtitles = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowVideoSubtitles);
			return cb_showVideoSubtitles;
		}

		static void n_ShowVideoSubtitles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideoSubtitles ();
		}
#pragma warning restore 0169

		static IntPtr id_showVideoSubtitles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='showVideoSubtitles' and count(parameter)=0]"
		[Register ("showVideoSubtitles", "()V", "GetShowVideoSubtitlesHandler")]
		public override unsafe void ShowVideoSubtitles ()
		{
			if (id_showVideoSubtitles == IntPtr.Zero)
				id_showVideoSubtitles = JNIEnv.GetMethodID (class_ref, "showVideoSubtitles", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVideoSubtitles);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showVideoSubtitles", "()V"));
			} finally {
			}
		}

		static Delegate cb_showVideoSurface;
#pragma warning disable 0169
		static Delegate GetShowVideoSurfaceHandler ()
		{
			if (cb_showVideoSurface == null)
				cb_showVideoSurface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowVideoSurface);
			return cb_showVideoSurface;
		}

		static void n_ShowVideoSurface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideoSurface ();
		}
#pragma warning restore 0169

		static IntPtr id_showVideoSurface;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='showVideoSurface' and count(parameter)=0]"
		[Register ("showVideoSurface", "()V", "GetShowVideoSurfaceHandler")]
		public override unsafe void ShowVideoSurface ()
		{
			if (id_showVideoSurface == IntPtr.Zero)
				id_showVideoSurface = JNIEnv.GetMethodID (class_ref, "showVideoSurface", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVideoSurface);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showVideoSurface", "()V"));
			} finally {
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1, int p2, int p3)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Format p1 = (global::Android.Graphics.Format) native_p1;
			__this.SurfaceChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceChanged_Landroid_view_SurfaceHolder_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder p0, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format p1, int p2, int p3)
		{
			if (id_surfaceChanged_Landroid_view_SurfaceHolder_III == IntPtr.Zero)
				id_surfaceChanged_Landroid_view_SurfaceHolder_III = JNIEnv.GetMethodID (class_ref, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_surfaceChanged_Landroid_view_SurfaceHolder_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceChanged", "(Landroid/view/SurfaceHolder;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceCreated_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceCreated_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceCreated_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_surfaceCreated_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceCreated", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.MediaPlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.MediaPlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.ISurfaceHolder p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (p0);
		}
#pragma warning restore 0169

		static IntPtr id_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaPlayerView']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_surfaceDestroyed_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_surfaceDestroyed_Landroid_view_SurfaceHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V"), __args);
			} finally {
			}
		}

	}
}

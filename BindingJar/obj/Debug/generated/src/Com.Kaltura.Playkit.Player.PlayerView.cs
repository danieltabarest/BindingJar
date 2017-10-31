using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/PlayerView", DoNotGenerateAcw=true)]
	public abstract partial class PlayerView : global::Android.Widget.FrameLayout {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/PlayerView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerView); }
		}

		protected PlayerView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/constructor[@name='PlayerView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PlayerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (PlayerView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/constructor[@name='PlayerView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PlayerView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (PlayerView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/constructor[@name='PlayerView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PlayerView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PlayerView)) {
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
			global::Com.Kaltura.Playkit.Player.PlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideVideoSubtitles ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='hideVideoSubtitles' and count(parameter)=0]"
		[Register ("hideVideoSubtitles", "()V", "GetHideVideoSubtitlesHandler")]
		public abstract void HideVideoSubtitles ();

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
			global::Com.Kaltura.Playkit.Player.PlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideVideoSurface ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='hideVideoSurface' and count(parameter)=0]"
		[Register ("hideVideoSurface", "()V", "GetHideVideoSurfaceHandler")]
		public abstract void HideVideoSurface ();

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
			global::Com.Kaltura.Playkit.Player.PlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideoSubtitles ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='showVideoSubtitles' and count(parameter)=0]"
		[Register ("showVideoSubtitles", "()V", "GetShowVideoSubtitlesHandler")]
		public abstract void ShowVideoSubtitles ();

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
			global::Com.Kaltura.Playkit.Player.PlayerView __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowVideoSurface ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='showVideoSurface' and count(parameter)=0]"
		[Register ("showVideoSurface", "()V", "GetShowVideoSurfaceHandler")]
		public abstract void ShowVideoSurface ();

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/player/PlayerView", DoNotGenerateAcw=true)]
	internal partial class PlayerViewInvoker : PlayerView {

		public PlayerViewInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerViewInvoker); }
		}

		static IntPtr id_hideVideoSubtitles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='hideVideoSubtitles' and count(parameter)=0]"
		[Register ("hideVideoSubtitles", "()V", "GetHideVideoSubtitlesHandler")]
		public override unsafe void HideVideoSubtitles ()
		{
			if (id_hideVideoSubtitles == IntPtr.Zero)
				id_hideVideoSubtitles = JNIEnv.GetMethodID (class_ref, "hideVideoSubtitles", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideVideoSubtitles);
			} finally {
			}
		}

		static IntPtr id_hideVideoSurface;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='hideVideoSurface' and count(parameter)=0]"
		[Register ("hideVideoSurface", "()V", "GetHideVideoSurfaceHandler")]
		public override unsafe void HideVideoSurface ()
		{
			if (id_hideVideoSurface == IntPtr.Zero)
				id_hideVideoSurface = JNIEnv.GetMethodID (class_ref, "hideVideoSurface", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideVideoSurface);
			} finally {
			}
		}

		static IntPtr id_showVideoSubtitles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='showVideoSubtitles' and count(parameter)=0]"
		[Register ("showVideoSubtitles", "()V", "GetShowVideoSubtitlesHandler")]
		public override unsafe void ShowVideoSubtitles ()
		{
			if (id_showVideoSubtitles == IntPtr.Zero)
				id_showVideoSubtitles = JNIEnv.GetMethodID (class_ref, "showVideoSubtitles", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVideoSubtitles);
			} finally {
			}
		}

		static IntPtr id_showVideoSurface;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerView']/method[@name='showVideoSurface' and count(parameter)=0]"
		[Register ("showVideoSurface", "()V", "GetShowVideoSurfaceHandler")]
		public override unsafe void ShowVideoSurface ()
		{
			if (id_showVideoSurface == IntPtr.Zero)
				id_showVideoSurface = JNIEnv.GetMethodID (class_ref, "showVideoSurface", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showVideoSurface);
			} finally {
			}
		}

	}

}

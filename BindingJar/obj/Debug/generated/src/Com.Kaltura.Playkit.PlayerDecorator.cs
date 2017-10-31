using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerDecorator", DoNotGenerateAcw=true)]
	public abstract partial class PlayerDecorator : global::Com.Kaltura.Playkit.PlayerDecoratorBase {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PlayerDecorator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerDecorator); }
		}

		protected PlayerDecorator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/constructor[@name='PlayerDecorator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlayerDecorator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PlayerDecorator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getView;
		public override unsafe global::Com.Kaltura.Playkit.Player.PlayerView View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Lcom/kaltura/playkit/player/PlayerView;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Lcom/kaltura/playkit/player/PlayerView;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener'] and parameter[2][@type='java.lang.Enum...']]"
		[Register ("addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V", "")]
		public override sealed unsafe void AddEventListener (global::Com.Kaltura.Playkit.IPKEventListener p0, params global:: Java.Lang.Enum[] p1)
		{
			if (id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='addStateChangeListener' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener']]"
		[Register ("addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V", "")]
		public override sealed unsafe void AddStateChangeListener (global::Com.Kaltura.Playkit.IPKEventListener p0)
		{
			if (id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ == IntPtr.Zero)
				id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ = JNIEnv.GetMethodID (class_ref, "addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_, __args);
			} finally {
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public override sealed unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_onApplicationPaused;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='onApplicationPaused' and count(parameter)=0]"
		[Register ("onApplicationPaused", "()V", "")]
		public override sealed unsafe void OnApplicationPaused ()
		{
			if (id_onApplicationPaused == IntPtr.Zero)
				id_onApplicationPaused = JNIEnv.GetMethodID (class_ref, "onApplicationPaused", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationPaused);
			} finally {
			}
		}

		static IntPtr id_onApplicationResumed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='onApplicationResumed' and count(parameter)=0]"
		[Register ("onApplicationResumed", "()V", "")]
		public override sealed unsafe void OnApplicationResumed ()
		{
			if (id_onApplicationResumed == IntPtr.Zero)
				id_onApplicationResumed = JNIEnv.GetMethodID (class_ref, "onApplicationResumed", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationResumed);
			} finally {
			}
		}

		static IntPtr id_skip;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='skip' and count(parameter)=0]"
		[Register ("skip", "()V", "")]
		public override sealed unsafe void Skip ()
		{
			if (id_skip == IntPtr.Zero)
				id_skip = JNIEnv.GetMethodID (class_ref, "skip", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skip);
			} finally {
			}
		}

		static IntPtr id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerDecorator']/method[@name='updatePluginConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public override sealed unsafe void UpdatePluginConfig (string p0, global::Java.Lang.Object p1)
		{
			if (id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

#region "Event implementation for Com.Kaltura.Playkit.IPKEventListener"
		public event EventHandler<global::Com.Kaltura.Playkit.PKEventEventArgs> StateChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Kaltura.Playkit.IPKEventListener, global::Com.Kaltura.Playkit.IPKEventListenerImplementor>(
						ref weak_implementor_AddStateChangeListener,
						__CreateIPKEventListenerImplementor,
						AddStateChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Kaltura.Playkit.IPKEventListener, global::Com.Kaltura.Playkit.IPKEventListenerImplementor>(
						ref weak_implementor_AddStateChangeListener,
						global::Com.Kaltura.Playkit.IPKEventListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Kaltura.Playkit.IPKEventListener.AddStateChangeListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddStateChangeListener;

		global::Com.Kaltura.Playkit.IPKEventListenerImplementor __CreateIPKEventListenerImplementor ()
		{
			return new global::Com.Kaltura.Playkit.IPKEventListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerDecorator", DoNotGenerateAcw=true)]
	internal partial class PlayerDecoratorInvoker : PlayerDecorator {

		public PlayerDecoratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerDecoratorInvoker); }
		}

	}

}

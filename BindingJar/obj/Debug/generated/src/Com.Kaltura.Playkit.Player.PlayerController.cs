using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/PlayerController", DoNotGenerateAcw=true)]
	public partial class PlayerController : global::Java.Lang.Object, IPlayer
    {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController.Settings']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/player/PlayerController$Settings", DoNotGenerateAcw=true)]
		public partial class Settings : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPlayerSettings {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/player/PlayerController$Settings", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Settings); }
			}

			protected Settings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_setCea608CaptionsEnabled_Z;
#pragma warning disable 0169
			static Delegate GetSetCea608CaptionsEnabled_ZHandler ()
			{
				if (cb_setCea608CaptionsEnabled_Z == null)
					cb_setCea608CaptionsEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetCea608CaptionsEnabled_Z);
				return cb_setCea608CaptionsEnabled_Z;
			}

			static IntPtr n_SetCea608CaptionsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Kaltura.Playkit.Player.PlayerController.Settings __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController.Settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCea608CaptionsEnabled (p0));
			}
#pragma warning restore 0169

			static IntPtr id_setCea608CaptionsEnabled_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController.Settings']/method[@name='setCea608CaptionsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCea608CaptionsEnabled", "(Z)Lcom/kaltura/playkit/Player$Settings;", "GetSetCea608CaptionsEnabled_ZHandler")]
			public virtual unsafe global::Com.Kaltura.Playkit.IPlayerSettings SetCea608CaptionsEnabled (bool p0)
			{
				if (id_setCea608CaptionsEnabled_Z == IntPtr.Zero)
					id_setCea608CaptionsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCea608CaptionsEnabled", "(Z)Lcom/kaltura/playkit/Player$Settings;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCea608CaptionsEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCea608CaptionsEnabled", "(Z)Lcom/kaltura/playkit/Player$Settings;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_;
#pragma warning disable 0169
			static Delegate GetSetContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_Handler ()
			{
				if (cb_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ == null)
					cb_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_);
				return cb_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_;
			}

			static IntPtr n_SetContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.Player.PlayerController.Settings __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController.Settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.PKRequestParams.IAdapter p0 = (global::Com.Kaltura.Playkit.PKRequestParams.IAdapter)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams.IAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentRequestAdapter (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController.Settings']/method[@name='setContentRequestAdapter' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKRequestParams.Adapter']]"
			[Register ("setContentRequestAdapter", "(Lcom/kaltura/playkit/PKRequestParams$Adapter;)Lcom/kaltura/playkit/Player$Settings;", "GetSetContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_Handler")]
			public virtual unsafe global::Com.Kaltura.Playkit.IPlayerSettings SetContentRequestAdapter (global::Com.Kaltura.Playkit.PKRequestParams.IAdapter p0)
			{
				if (id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ == IntPtr.Zero)
					id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ = JNIEnv.GetMethodID (class_ref, "setContentRequestAdapter", "(Lcom/kaltura/playkit/PKRequestParams$Adapter;)Lcom/kaltura/playkit/Player$Settings;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Com.Kaltura.Playkit.IPlayerSettings __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentRequestAdapter", "(Lcom/kaltura/playkit/PKRequestParams$Adapter;)Lcom/kaltura/playkit/Player$Settings;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_useTextureView_Z;
#pragma warning disable 0169
			static Delegate GetUseTextureView_ZHandler ()
			{
				if (cb_useTextureView_Z == null)
					cb_useTextureView_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_UseTextureView_Z);
				return cb_useTextureView_Z;
			}

			static IntPtr n_UseTextureView_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Kaltura.Playkit.Player.PlayerController.Settings __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController.Settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UseTextureView (p0));
			}
#pragma warning restore 0169

			static IntPtr id_useTextureView_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController.Settings']/method[@name='useTextureView' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("useTextureView", "(Z)Lcom/kaltura/playkit/Player$Settings;", "GetUseTextureView_ZHandler")]
			public virtual unsafe global::Com.Kaltura.Playkit.IPlayerSettings UseTextureView (bool p0)
			{
				if (id_useTextureView_Z == IntPtr.Zero)
					id_useTextureView_Z = JNIEnv.GetMethodID (class_ref, "useTextureView", "(Z)Lcom/kaltura/playkit/Player$Settings;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_useTextureView_Z, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "useTextureView", "(Z)Lcom/kaltura/playkit/Player$Settings;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/PlayerController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerController); }
		}

		protected PlayerController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/constructor[@name='PlayerController' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PlayerController (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PlayerController)) {
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

		static Delegate cb_getAdController;
#pragma warning disable 0169
		static Delegate GetGetAdControllerHandler ()
		{
			if (cb_getAdController == null)
				cb_getAdController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdController);
			return cb_getAdController;
		}

		static IntPtr n_GetAdController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdController);
		}
#pragma warning restore 0169

		static IntPtr id_getAdController;
		public virtual unsafe global::Com.Kaltura.Playkit.Ads.IAdController AdController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getAdController' and count(parameter)=0]"
			[Register ("getAdController", "()Lcom/kaltura/playkit/ads/AdController;", "GetGetAdControllerHandler")]
			get {
				if (id_getAdController == IntPtr.Zero)
					id_getAdController = JNIEnv.GetMethodID (class_ref, "getAdController", "()Lcom/kaltura/playkit/ads/AdController;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IAdController> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdController), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IAdController> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdController", "()Lcom/kaltura/playkit/ads/AdController;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBufferedPosition;
#pragma warning disable 0169
		static Delegate GetGetBufferedPositionHandler ()
		{
			if (cb_getBufferedPosition == null)
				cb_getBufferedPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBufferedPosition);
			return cb_getBufferedPosition;
		}

		static long n_GetBufferedPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferedPosition;
		public virtual unsafe long BufferedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getBufferedPosition' and count(parameter)=0]"
			[Register ("getBufferedPosition", "()J", "GetGetBufferedPositionHandler")]
			get {
				if (id_getBufferedPosition == IntPtr.Zero)
					id_getBufferedPosition = JNIEnv.GetMethodID (class_ref, "getBufferedPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferedPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetCurrentPositionHandler ()
		{
			if (cb_getCurrentPosition == null)
				cb_getCurrentPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCurrentPosition);
			return cb_getCurrentPosition;
		}

		static long n_GetCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentPosition;
		public virtual unsafe long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler")]
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isLiveStream;
#pragma warning disable 0169
		static Delegate GetIsLiveStreamHandler ()
		{
			if (cb_isLiveStream == null)
				cb_isLiveStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLiveStream);
			return cb_isLiveStream;
		}

		static bool n_IsLiveStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLiveStream;
		}
#pragma warning restore 0169

		static IntPtr id_isLiveStream;
		public virtual unsafe bool IsLiveStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='isLiveStream' and count(parameter)=0]"
			[Register ("isLiveStream", "()Z", "GetIsLiveStreamHandler")]
			get {
				if (id_isLiveStream == IntPtr.Zero)
					id_isLiveStream = JNIEnv.GetMethodID (class_ref, "isLiveStream", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLiveStream);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLiveStream", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPlaying;
#pragma warning disable 0169
		static Delegate GetIsPlayingHandler ()
		{
			if (cb_isPlaying == null)
				cb_isPlaying = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPlaying);
			return cb_isPlaying;
		}

		static bool n_IsPlaying (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		static IntPtr id_isPlaying;
		public virtual unsafe bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler")]
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPlaying", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionId;
		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static IntPtr id_getView;
		public virtual unsafe global::Com.Kaltura.Playkit.Player.PlayerView View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Lcom/kaltura/playkit/player/PlayerView;", "GetGetViewHandler")]
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Lcom/kaltura/playkit/player/PlayerView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "()Lcom/kaltura/playkit/player/PlayerView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

        IPlayerSettings IPlayer.Settings => throw new NotImplementedException();

        static Delegate cb_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetAddEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler ()
		{
			if (cb_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == null)
				cb_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_);
			return cb_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		}

		static void n_AddEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Enum[] p1 = (global::Java.Lang.Enum[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Enum));
			__this.AddEventListener (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener'] and parameter[2][@type='java.lang.Enum...']]"
		[Register ("addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V", "GetAddEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler")]
		public virtual unsafe void AddEventListener (global::Com.Kaltura.Playkit.IPKEventListener p0, params global:: Java.Lang.Enum[] p1)
		{
			if (id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_;
#pragma warning disable 0169
		static Delegate GetAddStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_Handler ()
		{
			if (cb_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ == null)
				cb_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_);
			return cb_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_;
		}

		static void n_AddStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddStateChangeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='addStateChangeListener' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener']]"
		[Register ("addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V", "GetAddStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_Handler")]
		public virtual unsafe void AddStateChangeListener (global::Com.Kaltura.Playkit.IPKEventListener p0)
		{
			if (id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ == IntPtr.Zero)
				id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ = JNIEnv.GetMethodID (class_ref, "addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_changeTrack_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChangeTrack_Ljava_lang_String_Handler ()
		{
			if (cb_changeTrack_Ljava_lang_String_ == null)
				cb_changeTrack_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ChangeTrack_Ljava_lang_String_);
			return cb_changeTrack_Ljava_lang_String_;
		}

		static void n_ChangeTrack_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeTrack (p0);
		}
#pragma warning restore 0169

		static IntPtr id_changeTrack_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='changeTrack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changeTrack", "(Ljava/lang/String;)V", "GetChangeTrack_Ljava_lang_String_Handler")]
		public virtual unsafe void ChangeTrack (string p0)
		{
			if (id_changeTrack_Ljava_lang_String_ == IntPtr.Zero)
				id_changeTrack_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "changeTrack", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeTrack_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "changeTrack", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_getSettings;
#pragma warning disable 0169
		static Delegate GetGetSettingsHandler ()
		{
			if (cb_getSettings == null)
				cb_getSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSettings);
			return cb_getSettings;
		}

		static IntPtr n_GetSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSettings ());
		}
#pragma warning restore 0169

		static IntPtr id_getSettings;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='getSettings' and count(parameter)=0]"
		[Register ("getSettings", "()Lcom/kaltura/playkit/Player$Settings;", "GetGetSettingsHandler")]
		public virtual unsafe global::Com.Kaltura.Playkit.IPlayerSettings GetSettings ()
		{
			if (id_getSettings == IntPtr.Zero)
				id_getSettings = JNIEnv.GetMethodID (class_ref, "getSettings", "()Lcom/kaltura/playkit/Player$Settings;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSettings), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSettings", "()Lcom/kaltura/playkit/Player$Settings;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onApplicationPaused;
#pragma warning disable 0169
		static Delegate GetOnApplicationPausedHandler ()
		{
			if (cb_onApplicationPaused == null)
				cb_onApplicationPaused = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnApplicationPaused);
			return cb_onApplicationPaused;
		}

		static void n_OnApplicationPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationPaused ();
		}
#pragma warning restore 0169

		static IntPtr id_onApplicationPaused;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='onApplicationPaused' and count(parameter)=0]"
		[Register ("onApplicationPaused", "()V", "GetOnApplicationPausedHandler")]
		public virtual unsafe void OnApplicationPaused ()
		{
			if (id_onApplicationPaused == IntPtr.Zero)
				id_onApplicationPaused = JNIEnv.GetMethodID (class_ref, "onApplicationPaused", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationPaused);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onApplicationPaused", "()V"));
			} finally {
			}
		}

		static Delegate cb_onApplicationResumed;
#pragma warning disable 0169
		static Delegate GetOnApplicationResumedHandler ()
		{
			if (cb_onApplicationResumed == null)
				cb_onApplicationResumed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnApplicationResumed);
			return cb_onApplicationResumed;
		}

		static void n_OnApplicationResumed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationResumed ();
		}
#pragma warning restore 0169

		static IntPtr id_onApplicationResumed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='onApplicationResumed' and count(parameter)=0]"
		[Register ("onApplicationResumed", "()V", "GetOnApplicationResumedHandler")]
		public virtual unsafe void OnApplicationResumed ()
		{
			if (id_onApplicationResumed == IntPtr.Zero)
				id_onApplicationResumed = JNIEnv.GetMethodID (class_ref, "onApplicationResumed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationResumed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onApplicationResumed", "()V"));
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_play;
#pragma warning disable 0169
		static Delegate GetPlayHandler ()
		{
			if (cb_play == null)
				cb_play = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Play);
			return cb_play;
		}

		static void n_Play (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Play ();
		}
#pragma warning restore 0169

		static IntPtr id_play;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()V", "GetPlayHandler")]
		public virtual unsafe void Play ()
		{
			if (id_play == IntPtr.Zero)
				id_play = JNIEnv.GetMethodID (class_ref, "play", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_play);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "play", "()V"));
			} finally {
			}
		}

		static Delegate cb_prepare_Lcom_kaltura_playkit_PKMediaConfig_;
#pragma warning disable 0169
		static Delegate GetPrepare_Lcom_kaltura_playkit_PKMediaConfig_Handler ()
		{
			if (cb_prepare_Lcom_kaltura_playkit_PKMediaConfig_ == null)
				cb_prepare_Lcom_kaltura_playkit_PKMediaConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prepare_Lcom_kaltura_playkit_PKMediaConfig_);
			return cb_prepare_Lcom_kaltura_playkit_PKMediaConfig_;
		}

		static void n_Prepare_Lcom_kaltura_playkit_PKMediaConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		static IntPtr id_prepare_Lcom_kaltura_playkit_PKMediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("prepare", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetPrepare_Lcom_kaltura_playkit_PKMediaConfig_Handler")]
		public virtual unsafe void Prepare (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_prepare_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_prepare_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/kaltura/playkit/PKMediaConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_kaltura_playkit_PKMediaConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "(Lcom/kaltura/playkit/PKMediaConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_;
#pragma warning disable 0169
		static Delegate GetPrepareNext_Lcom_kaltura_playkit_PKMediaConfig_Handler ()
		{
			if (cb_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_ == null)
				cb_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PrepareNext_Lcom_kaltura_playkit_PKMediaConfig_);
			return cb_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_;
		}

		static void n_PrepareNext_Lcom_kaltura_playkit_PKMediaConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareNext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='prepareNext' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("prepareNext", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetPrepareNext_Lcom_kaltura_playkit_PKMediaConfig_Handler")]
		public virtual unsafe void PrepareNext (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "prepareNext", "(Lcom/kaltura/playkit/PKMediaConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareNext", "(Lcom/kaltura/playkit/PKMediaConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_replay;
#pragma warning disable 0169
		static Delegate GetReplayHandler ()
		{
			if (cb_replay == null)
				cb_replay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Replay);
			return cb_replay;
		}

		static void n_Replay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Replay ();
		}
#pragma warning restore 0169

		static IntPtr id_replay;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='replay' and count(parameter)=0]"
		[Register ("replay", "()V", "GetReplayHandler")]
		public virtual unsafe void Replay ()
		{
			if (id_replay == IntPtr.Zero)
				id_replay = JNIEnv.GetMethodID (class_ref, "replay", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replay);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "replay", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekTo_J;
#pragma warning disable 0169
		static Delegate GetSeekTo_JHandler ()
		{
			if (cb_seekTo_J == null)
				cb_seekTo_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SeekTo_J);
			return cb_seekTo_J;
		}

		static void n_SeekTo_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_seekTo_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler")]
		public virtual unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekTo", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_;
#pragma warning disable 0169
		static Delegate GetSetEventListener_Lcom_kaltura_playkit_PKEvent_Listener_Handler ()
		{
			if (cb_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_ == null)
				cb_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventListener_Lcom_kaltura_playkit_PKEvent_Listener_);
			return cb_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_;
		}

		static void n_SetEventListener_Lcom_kaltura_playkit_PKEvent_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='setEventListener' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener']]"
		[Register ("setEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V", "GetSetEventListener_Lcom_kaltura_playkit_PKEvent_Listener_Handler")]
		public virtual unsafe void SetEventListener (global::Com.Kaltura.Playkit.IPKEventListener p0)
		{
			if (id_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_ == IntPtr.Zero)
				id_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_ = JNIEnv.GetMethodID (class_ref, "setEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventListener_Lcom_kaltura_playkit_PKEvent_Listener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMedia_Lcom_kaltura_playkit_PKMediaConfig_;
#pragma warning disable 0169
		static Delegate GetSetMedia_Lcom_kaltura_playkit_PKMediaConfig_Handler ()
		{
			if (cb_setMedia_Lcom_kaltura_playkit_PKMediaConfig_ == null)
				cb_setMedia_Lcom_kaltura_playkit_PKMediaConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetMedia_Lcom_kaltura_playkit_PKMediaConfig_);
			return cb_setMedia_Lcom_kaltura_playkit_PKMediaConfig_;
		}

		static bool n_SetMedia_Lcom_kaltura_playkit_PKMediaConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetMedia (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMedia_Lcom_kaltura_playkit_PKMediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='setMedia' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("setMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)Z", "GetSetMedia_Lcom_kaltura_playkit_PKMediaConfig_Handler")]
		public virtual unsafe bool SetMedia (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_setMedia_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_setMedia_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "setMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setMedia_Lcom_kaltura_playkit_PKMediaConfig_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setVolume_F;
#pragma warning disable 0169
		static Delegate GetSetVolume_FHandler ()
		{
			if (cb_setVolume_F == null)
				cb_setVolume_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVolume_F);
			return cb_setVolume_F;
		}

		static void n_SetVolume_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setVolume_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='setVolume' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVolume", "(F)V", "GetSetVolume_FHandler")]
		public virtual unsafe void SetVolume (float p0)
		{
			if (id_setVolume_F == IntPtr.Zero)
				id_setVolume_F = JNIEnv.GetMethodID (class_ref, "setVolume", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVolume", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_skip;
#pragma warning disable 0169
		static Delegate GetSkipHandler ()
		{
			if (cb_skip == null)
				cb_skip = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Skip);
			return cb_skip;
		}

		static void n_Skip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Skip ();
		}
#pragma warning restore 0169

		static IntPtr id_skip;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='skip' and count(parameter)=0]"
		[Register ("skip", "()V", "GetSkipHandler")]
		public virtual unsafe void Skip ()
		{
			if (id_skip == IntPtr.Zero)
				id_skip = JNIEnv.GetMethodID (class_ref, "skip", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skip);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

		static Delegate cb_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUpdatePluginConfig_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePluginConfig_Ljava_lang_String_Ljava_lang_Object_);
			return cb_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_UpdatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.Player.PlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePluginConfig (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PlayerController']/method[@name='updatePluginConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetUpdatePluginConfig_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void UpdatePluginConfig (string p0, global::Java.Lang.Object p1)
		{
			if (id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
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

		public event EventHandler<global::Com.Kaltura.Playkit.PKEventEventArgs> Event {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Kaltura.Playkit.IPKEventListener, global::Com.Kaltura.Playkit.IPKEventListenerImplementor>(
						ref weak_implementor_SetEventListener,
						__CreateIPKEventListenerImplementor,
						SetEventListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Kaltura.Playkit.IPKEventListener, global::Com.Kaltura.Playkit.IPKEventListenerImplementor>(
						ref weak_implementor_SetEventListener,
						global::Com.Kaltura.Playkit.IPKEventListenerImplementor.__IsEmpty,
						__v => SetEventListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddStateChangeListener;
		WeakReference weak_implementor_SetEventListener;

		global::Com.Kaltura.Playkit.IPKEventListenerImplementor __CreateIPKEventListenerImplementor ()
		{
			return new global::Com.Kaltura.Playkit.IPKEventListenerImplementor (this);
		}
#endregion
	}
}

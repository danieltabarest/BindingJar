using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player.Settings']"
	[Register ("com/kaltura/playkit/Player$Settings", "", "Com.Kaltura.Playkit.IPlayerSettingsInvoker")]
	public partial interface IPlayerSettings : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player.Settings']/method[@name='setCea608CaptionsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCea608CaptionsEnabled", "(Z)Lcom/kaltura/playkit/Player$Settings;", "GetSetCea608CaptionsEnabled_ZHandler:Com.Kaltura.Playkit.IPlayerSettingsInvoker, BindingJar")]
		global::Com.Kaltura.Playkit.IPlayerSettings SetCea608CaptionsEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player.Settings']/method[@name='setContentRequestAdapter' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKRequestParams.Adapter']]"
		[Register ("setContentRequestAdapter", "(Lcom/kaltura/playkit/PKRequestParams$Adapter;)Lcom/kaltura/playkit/Player$Settings;", "GetSetContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_Handler:Com.Kaltura.Playkit.IPlayerSettingsInvoker, BindingJar")]
		global::Com.Kaltura.Playkit.IPlayerSettings SetContentRequestAdapter (global::Com.Kaltura.Playkit.PKRequestParams.IAdapter p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player.Settings']/method[@name='useTextureView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("useTextureView", "(Z)Lcom/kaltura/playkit/Player$Settings;", "GetUseTextureView_ZHandler:Com.Kaltura.Playkit.IPlayerSettingsInvoker, BindingJar")]
		global::Com.Kaltura.Playkit.IPlayerSettings UseTextureView (bool p0);

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/Player$Settings", DoNotGenerateAcw=true)]
	internal class IPlayerSettingsInvoker : global::Java.Lang.Object, IPlayerSettings {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/Player$Settings");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerSettingsInvoker); }
		}

		IntPtr class_ref;

		public static IPlayerSettings GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayerSettings> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.Player.Settings"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerSettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Kaltura.Playkit.IPlayerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCea608CaptionsEnabled (p0));
		}
#pragma warning restore 0169

		IntPtr id_setCea608CaptionsEnabled_Z;
		public unsafe global::Com.Kaltura.Playkit.IPlayerSettings SetCea608CaptionsEnabled (bool p0)
		{
			if (id_setCea608CaptionsEnabled_Z == IntPtr.Zero)
				id_setCea608CaptionsEnabled_Z = JNIEnv.GetMethodID (class_ref, "setCea608CaptionsEnabled", "(Z)Lcom/kaltura/playkit/Player$Settings;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCea608CaptionsEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.IPlayerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKRequestParams.IAdapter p0 = (global::Com.Kaltura.Playkit.PKRequestParams.IAdapter)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams.IAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContentRequestAdapter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_;
		public unsafe global::Com.Kaltura.Playkit.IPlayerSettings SetContentRequestAdapter (global::Com.Kaltura.Playkit.PKRequestParams.IAdapter p0)
		{
			if (id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ == IntPtr.Zero)
				id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_ = JNIEnv.GetMethodID (class_ref, "setContentRequestAdapter", "(Lcom/kaltura/playkit/PKRequestParams$Adapter;)Lcom/kaltura/playkit/Player$Settings;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Kaltura.Playkit.IPlayerSettings __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentRequestAdapter_Lcom_kaltura_playkit_PKRequestParams_Adapter_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Com.Kaltura.Playkit.IPlayerSettings __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UseTextureView (p0));
		}
#pragma warning restore 0169

		IntPtr id_useTextureView_Z;
		public unsafe global::Com.Kaltura.Playkit.IPlayerSettings UseTextureView (bool p0)
		{
			if (id_useTextureView_Z == IntPtr.Zero)
				id_useTextureView_Z = JNIEnv.GetMethodID (class_ref, "useTextureView", "(Z)Lcom/kaltura/playkit/Player$Settings;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_useTextureView_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']"
	[Register ("com/kaltura/playkit/Player", "", "Com.Kaltura.Playkit.IPlayerInvoker")]
	public partial interface IPlayer : IJavaObject {

		global::Com.Kaltura.Playkit.Ads.IAdController AdController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getAdController' and count(parameter)=0]"
			[Register ("getAdController", "()Lcom/kaltura/playkit/ads/AdController;", "GetGetAdControllerHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		long BufferedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getBufferedPosition' and count(parameter)=0]"
			[Register ("getBufferedPosition", "()J", "GetGetBufferedPositionHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		long CurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getCurrentPosition' and count(parameter)=0]"
			[Register ("getCurrentPosition", "()J", "GetGetCurrentPositionHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		bool IsLiveStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='isLiveStream' and count(parameter)=0]"
			[Register ("isLiveStream", "()Z", "GetIsLiveStreamHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		bool IsPlaying {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='isPlaying' and count(parameter)=0]"
			[Register ("isPlaying", "()Z", "GetIsPlayingHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		global::Com.Kaltura.Playkit.IPlayerSettings Settings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getSettings' and count(parameter)=0]"
			[Register ("getSettings", "()Lcom/kaltura/playkit/Player$Settings;", "GetGetSettingsHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		global::Com.Kaltura.Playkit.Player.PlayerView View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Lcom/kaltura/playkit/player/PlayerView;", "GetGetViewHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='addEventListener' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener'] and parameter[2][@type='java.lang.Enum...']]"
		[Register ("addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V", "GetAddEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void AddEventListener (global::Com.Kaltura.Playkit.IPKEventListener p0, params global:: Java.Lang.Enum[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='addStateChangeListener' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener']]"
		[Register ("addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V", "GetAddStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_Handler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void AddStateChangeListener (global::Com.Kaltura.Playkit.IPKEventListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='changeTrack' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changeTrack", "(Ljava/lang/String;)V", "GetChangeTrack_Ljava_lang_String_Handler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void ChangeTrack (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Destroy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='onApplicationPaused' and count(parameter)=0]"
		[Register ("onApplicationPaused", "()V", "GetOnApplicationPausedHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void OnApplicationPaused ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='onApplicationResumed' and count(parameter)=0]"
		[Register ("onApplicationResumed", "()V", "GetOnApplicationResumedHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void OnApplicationResumed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='play' and count(parameter)=0]"
		[Register ("play", "()V", "GetPlayHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Play ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("prepare", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetPrepare_Lcom_kaltura_playkit_PKMediaConfig_Handler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Prepare (global::Com.Kaltura.Playkit.PKMediaConfig p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='prepareNext' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("prepareNext", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetPrepareNext_Lcom_kaltura_playkit_PKMediaConfig_Handler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void PrepareNext (global::Com.Kaltura.Playkit.PKMediaConfig p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='replay' and count(parameter)=0]"
		[Register ("replay", "()V", "GetReplayHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Replay ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='seekTo' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("seekTo", "(J)V", "GetSeekTo_JHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void SeekTo (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='setVolume' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVolume", "(F)V", "GetSetVolume_FHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void SetVolume (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='skip' and count(parameter)=0]"
		[Register ("skip", "()V", "GetSkipHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Skip ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void Stop ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='Player']/method[@name='updatePluginConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetUpdatePluginConfig_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Kaltura.Playkit.IPlayerInvoker, BindingJar")]
		void UpdatePluginConfig (string p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/Player", DoNotGenerateAcw=true)]
	internal class IPlayerInvoker : global::Java.Lang.Object, IPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/Player");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPlayerInvoker); }
		}

		IntPtr class_ref;

		public static IPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.Player"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdController);
		}
#pragma warning restore 0169

		IntPtr id_getAdController;
		public unsafe global::Com.Kaltura.Playkit.Ads.IAdController AdController {
			get {
				if (id_getAdController == IntPtr.Zero)
					id_getAdController = JNIEnv.GetMethodID (class_ref, "getAdController", "()Lcom/kaltura/playkit/ads/AdController;");
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IAdController> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdController), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedPosition;
		}
#pragma warning restore 0169

		IntPtr id_getBufferedPosition;
		public unsafe long BufferedPosition {
			get {
				if (id_getBufferedPosition == IntPtr.Zero)
					id_getBufferedPosition = JNIEnv.GetMethodID (class_ref, "getBufferedPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedPosition);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentPosition;
		public unsafe long CurrentPosition {
			get {
				if (id_getCurrentPosition == IntPtr.Zero)
					id_getCurrentPosition = JNIEnv.GetMethodID (class_ref, "getCurrentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentPosition);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public unsafe long Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLiveStream;
		}
#pragma warning restore 0169

		IntPtr id_isLiveStream;
		public unsafe bool IsLiveStream {
			get {
				if (id_isLiveStream == IntPtr.Zero)
					id_isLiveStream = JNIEnv.GetMethodID (class_ref, "isLiveStream", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLiveStream);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPlaying;
		}
#pragma warning restore 0169

		IntPtr id_isPlaying;
		public unsafe bool IsPlaying {
			get {
				if (id_isPlaying == IntPtr.Zero)
					id_isPlaying = JNIEnv.GetMethodID (class_ref, "isPlaying", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPlaying);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		IntPtr id_getSessionId;
		public unsafe string SessionId {
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Settings);
		}
#pragma warning restore 0169

		IntPtr id_getSettings;
		public unsafe global::Com.Kaltura.Playkit.IPlayerSettings Settings {
			get {
				if (id_getSettings == IntPtr.Zero)
					id_getSettings = JNIEnv.GetMethodID (class_ref, "getSettings", "()Lcom/kaltura/playkit/Player$Settings;");
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayerSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSettings), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		IntPtr id_getView;
		public unsafe global::Com.Kaltura.Playkit.Player.PlayerView View {
			get {
				if (id_getView == IntPtr.Zero)
					id_getView = JNIEnv.GetMethodID (class_ref, "getView", "()Lcom/kaltura/playkit/player/PlayerView;");
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PlayerView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Enum[] p1 = (global::Java.Lang.Enum[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Enum));
			__this.AddEventListener (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		public unsafe void AddEventListener (global::Com.Kaltura.Playkit.IPKEventListener p0, params global:: Java.Lang.Enum[] p1)
		{
			if (id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "addEventListener", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addEventListener_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddStateChangeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_;
		public unsafe void AddStateChangeListener (global::Com.Kaltura.Playkit.IPKEventListener p0)
		{
			if (id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ == IntPtr.Zero)
				id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_ = JNIEnv.GetMethodID (class_ref, "addStateChangeListener", "(Lcom/kaltura/playkit/PKEvent$Listener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addStateChangeListener_Lcom_kaltura_playkit_PKEvent_Listener_, __args);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChangeTrack (p0);
		}
#pragma warning restore 0169

		IntPtr id_changeTrack_Ljava_lang_String_;
		public unsafe void ChangeTrack (string p0)
		{
			if (id_changeTrack_Ljava_lang_String_ == IntPtr.Zero)
				id_changeTrack_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "changeTrack", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_changeTrack_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		IntPtr id_destroy;
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationPaused ();
		}
#pragma warning restore 0169

		IntPtr id_onApplicationPaused;
		public unsafe void OnApplicationPaused ()
		{
			if (id_onApplicationPaused == IntPtr.Zero)
				id_onApplicationPaused = JNIEnv.GetMethodID (class_ref, "onApplicationPaused", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationPaused);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationResumed ();
		}
#pragma warning restore 0169

		IntPtr id_onApplicationResumed;
		public unsafe void OnApplicationResumed ()
		{
			if (id_onApplicationResumed == IntPtr.Zero)
				id_onApplicationResumed = JNIEnv.GetMethodID (class_ref, "onApplicationResumed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationResumed);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Play ();
		}
#pragma warning restore 0169

		IntPtr id_play;
		public unsafe void Play ()
		{
			if (id_play == IntPtr.Zero)
				id_play = JNIEnv.GetMethodID (class_ref, "play", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_play);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		IntPtr id_prepare_Lcom_kaltura_playkit_PKMediaConfig_;
		public unsafe void Prepare (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_prepare_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_prepare_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Lcom/kaltura/playkit/PKMediaConfig;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Lcom_kaltura_playkit_PKMediaConfig_, __args);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrepareNext (p0);
		}
#pragma warning restore 0169

		IntPtr id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_;
		public unsafe void PrepareNext (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "prepareNext", "(Lcom/kaltura/playkit/PKMediaConfig;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareNext_Lcom_kaltura_playkit_PKMediaConfig_, __args);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Replay ();
		}
#pragma warning restore 0169

		IntPtr id_replay;
		public unsafe void Replay ()
		{
			if (id_replay == IntPtr.Zero)
				id_replay = JNIEnv.GetMethodID (class_ref, "replay", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_replay);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekTo (p0);
		}
#pragma warning restore 0169

		IntPtr id_seekTo_J;
		public unsafe void SeekTo (long p0)
		{
			if (id_seekTo_J == IntPtr.Zero)
				id_seekTo_J = JNIEnv.GetMethodID (class_ref, "seekTo", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekTo_J, __args);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVolume (p0);
		}
#pragma warning restore 0169

		IntPtr id_setVolume_F;
		public unsafe void SetVolume (float p0)
		{
			if (id_setVolume_F == IntPtr.Zero)
				id_setVolume_F = JNIEnv.GetMethodID (class_ref, "setVolume", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVolume_F, __args);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Skip ();
		}
#pragma warning restore 0169

		IntPtr id_skip;
		public unsafe void Skip ()
		{
			if (id_skip == IntPtr.Zero)
				id_skip = JNIEnv.GetMethodID (class_ref, "skip", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skip);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
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
			global::Com.Kaltura.Playkit.IPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePluginConfig (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void UpdatePluginConfig (string p0, global::Java.Lang.Object p1)
		{
			if (id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "updatePluginConfig", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updatePluginConfig_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}

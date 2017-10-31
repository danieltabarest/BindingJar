using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Playback {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.playback']/class[@name='KalturaPlaybackRequestAdapter']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/playback/KalturaPlaybackRequestAdapter", DoNotGenerateAcw=true)]
	public partial class KalturaPlaybackRequestAdapter : global::Java.Lang.Object, global::Com.Kaltura.Playkit.PKRequestParams.IAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/playback/KalturaPlaybackRequestAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalturaPlaybackRequestAdapter); }
		}

		protected KalturaPlaybackRequestAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_adapt_Lcom_kaltura_playkit_PKRequestParams_;
#pragma warning disable 0169
		static Delegate GetAdapt_Lcom_kaltura_playkit_PKRequestParams_Handler ()
		{
			if (cb_adapt_Lcom_kaltura_playkit_PKRequestParams_ == null)
				cb_adapt_Lcom_kaltura_playkit_PKRequestParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Adapt_Lcom_kaltura_playkit_PKRequestParams_);
			return cb_adapt_Lcom_kaltura_playkit_PKRequestParams_;
		}

		static IntPtr n_Adapt_Lcom_kaltura_playkit_PKRequestParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Playback.KalturaPlaybackRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Playback.KalturaPlaybackRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKRequestParams p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Adapt (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_adapt_Lcom_kaltura_playkit_PKRequestParams_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.playback']/class[@name='KalturaPlaybackRequestAdapter']/method[@name='adapt' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKRequestParams']]"
		[Register ("adapt", "(Lcom/kaltura/playkit/PKRequestParams;)Lcom/kaltura/playkit/PKRequestParams;", "GetAdapt_Lcom_kaltura_playkit_PKRequestParams_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKRequestParams Adapt (global::Com.Kaltura.Playkit.PKRequestParams p0)
		{
			if (id_adapt_Lcom_kaltura_playkit_PKRequestParams_ == IntPtr.Zero)
				id_adapt_Lcom_kaltura_playkit_PKRequestParams_ = JNIEnv.GetMethodID (class_ref, "adapt", "(Lcom/kaltura/playkit/PKRequestParams;)Lcom/kaltura/playkit/PKRequestParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Kaltura.Playkit.PKRequestParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adapt_Lcom_kaltura_playkit_PKRequestParams_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "adapt", "(Lcom/kaltura/playkit/PKRequestParams;)Lcom/kaltura/playkit/PKRequestParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_install_Lcom_kaltura_playkit_Player_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.playback']/class[@name='KalturaPlaybackRequestAdapter']/method[@name='install' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.Player'] and parameter[2][@type='java.lang.String']]"
		[Register ("install", "(Lcom/kaltura/playkit/Player;Ljava/lang/String;)V", "")]
		public static unsafe void Install (global::Com.Kaltura.Playkit.IPlayer p0, string p1)
		{
			if (id_install_Lcom_kaltura_playkit_Player_Ljava_lang_String_ == IntPtr.Zero)
				id_install_Lcom_kaltura_playkit_Player_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "install", "(Lcom/kaltura/playkit/Player;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_install_Lcom_kaltura_playkit_Player_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateParams_Lcom_kaltura_playkit_Player_;
#pragma warning disable 0169
		static Delegate GetUpdateParams_Lcom_kaltura_playkit_Player_Handler ()
		{
			if (cb_updateParams_Lcom_kaltura_playkit_Player_ == null)
				cb_updateParams_Lcom_kaltura_playkit_Player_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateParams_Lcom_kaltura_playkit_Player_);
			return cb_updateParams_Lcom_kaltura_playkit_Player_;
		}

		static void n_UpdateParams_Lcom_kaltura_playkit_Player_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Playback.KalturaPlaybackRequestAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Playback.KalturaPlaybackRequestAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPlayer p0 = (global::Com.Kaltura.Playkit.IPlayer)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateParams (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateParams_Lcom_kaltura_playkit_Player_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.playback']/class[@name='KalturaPlaybackRequestAdapter']/method[@name='updateParams' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.Player']]"
		[Register ("updateParams", "(Lcom/kaltura/playkit/Player;)V", "GetUpdateParams_Lcom_kaltura_playkit_Player_Handler")]
		public virtual unsafe void UpdateParams (global::Com.Kaltura.Playkit.IPlayer p0)
		{
			if (id_updateParams_Lcom_kaltura_playkit_Player_ == IntPtr.Zero)
				id_updateParams_Lcom_kaltura_playkit_Player_ = JNIEnv.GetMethodID (class_ref, "updateParams", "(Lcom/kaltura/playkit/Player;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateParams_Lcom_kaltura_playkit_Player_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateParams", "(Lcom/kaltura/playkit/Player;)V"), __args);
			} finally {
			}
		}

	}
}

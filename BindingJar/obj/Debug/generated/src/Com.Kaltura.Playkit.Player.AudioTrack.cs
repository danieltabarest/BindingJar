using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='AudioTrack']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/AudioTrack", DoNotGenerateAcw=true)]
	public partial class AudioTrack : global::Com.Kaltura.Playkit.Player.BaseTrack {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/AudioTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AudioTrack); }
		}

		protected AudioTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBitrate);
			return cb_getBitrate;
		}

		static long n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getBitrate;
		public virtual unsafe long Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='AudioTrack']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()J", "GetGetBitrateHandler")]
			get {
				if (id_getBitrate == IntPtr.Zero)
					id_getBitrate = JNIEnv.GetMethodID (class_ref, "getBitrate", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBitrate);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitrate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static IntPtr id_getLabel;
		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='AudioTrack']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.AudioTrack __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.AudioTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static IntPtr id_getLanguage;
		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='AudioTrack']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLanguage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='BaseTrack']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/BaseTrack", DoNotGenerateAcw=true)]
	public abstract partial class BaseTrack : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/BaseTrack", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTrack); }
		}

		protected BaseTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isAdaptive;
#pragma warning disable 0169
		static Delegate GetIsAdaptiveHandler ()
		{
			if (cb_isAdaptive == null)
				cb_isAdaptive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAdaptive);
			return cb_isAdaptive;
		}

		static bool n_IsAdaptive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.BaseTrack __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.BaseTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAdaptive;
		}
#pragma warning restore 0169

		static IntPtr id_isAdaptive;
		public virtual unsafe bool IsAdaptive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='BaseTrack']/method[@name='isAdaptive' and count(parameter)=0]"
			[Register ("isAdaptive", "()Z", "GetIsAdaptiveHandler")]
			get {
				if (id_isAdaptive == IntPtr.Zero)
					id_isAdaptive = JNIEnv.GetMethodID (class_ref, "isAdaptive", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAdaptive);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAdaptive", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getUniqueId;
#pragma warning disable 0169
		static Delegate GetGetUniqueIdHandler ()
		{
			if (cb_getUniqueId == null)
				cb_getUniqueId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUniqueId);
			return cb_getUniqueId;
		}

		static IntPtr n_GetUniqueId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.BaseTrack __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.BaseTrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UniqueId);
		}
#pragma warning restore 0169

		static IntPtr id_getUniqueId;
		public virtual unsafe string UniqueId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='BaseTrack']/method[@name='getUniqueId' and count(parameter)=0]"
			[Register ("getUniqueId", "()Ljava/lang/String;", "GetGetUniqueIdHandler")]
			get {
				if (id_getUniqueId == IntPtr.Zero)
					id_getUniqueId = JNIEnv.GetMethodID (class_ref, "getUniqueId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUniqueId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniqueId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/player/BaseTrack", DoNotGenerateAcw=true)]
	internal partial class BaseTrackInvoker : BaseTrack {

		public BaseTrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseTrackInvoker); }
		}

	}

}

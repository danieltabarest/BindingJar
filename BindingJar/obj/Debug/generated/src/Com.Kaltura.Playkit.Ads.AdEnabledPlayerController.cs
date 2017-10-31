using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdEnabledPlayerController']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/ads/AdEnabledPlayerController", DoNotGenerateAcw=true)]
	public partial class AdEnabledPlayerController : global::Com.Kaltura.Playkit.PlayerDecorator, global::Com.Kaltura.Playkit.Ads.IAdController, global::Com.Kaltura.Playkit.Ads.IPKAdProviderListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/ads/AdEnabledPlayerController", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdEnabledPlayerController); }
		}

		protected AdEnabledPlayerController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAdCurrentPosition;
#pragma warning disable 0169
		static Delegate GetGetAdCurrentPositionHandler ()
		{
			if (cb_getAdCurrentPosition == null)
				cb_getAdCurrentPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAdCurrentPosition);
			return cb_getAdCurrentPosition;
		}

		static long n_GetAdCurrentPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdCurrentPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getAdCurrentPosition;
		public virtual unsafe long AdCurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdEnabledPlayerController']/method[@name='getAdCurrentPosition' and count(parameter)=0]"
			[Register ("getAdCurrentPosition", "()J", "GetGetAdCurrentPositionHandler")]
			get {
				if (id_getAdCurrentPosition == IntPtr.Zero)
					id_getAdCurrentPosition = JNIEnv.GetMethodID (class_ref, "getAdCurrentPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdCurrentPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdCurrentPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdDuration;
#pragma warning disable 0169
		static Delegate GetGetAdDurationHandler ()
		{
			if (cb_getAdDuration == null)
				cb_getAdDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAdDuration);
			return cb_getAdDuration;
		}

		static long n_GetAdDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getAdDuration;
		public virtual unsafe long AdDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdEnabledPlayerController']/method[@name='getAdDuration' and count(parameter)=0]"
			[Register ("getAdDuration", "()J", "GetGetAdDurationHandler")]
			get {
				if (id_getAdDuration == IntPtr.Zero)
					id_getAdDuration = JNIEnv.GetMethodID (class_ref, "getAdDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_onAdLoadingFinished;
#pragma warning disable 0169
		static Delegate GetOnAdLoadingFinishedHandler ()
		{
			if (cb_onAdLoadingFinished == null)
				cb_onAdLoadingFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdLoadingFinished);
			return cb_onAdLoadingFinished;
		}

		static void n_OnAdLoadingFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadingFinished ();
		}
#pragma warning restore 0169

		static IntPtr id_onAdLoadingFinished;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdEnabledPlayerController']/method[@name='onAdLoadingFinished' and count(parameter)=0]"
		[Register ("onAdLoadingFinished", "()V", "GetOnAdLoadingFinishedHandler")]
		public virtual unsafe void OnAdLoadingFinished ()
		{
			if (id_onAdLoadingFinished == IntPtr.Zero)
				id_onAdLoadingFinished = JNIEnv.GetMethodID (class_ref, "onAdLoadingFinished", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadingFinished);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onAdLoadingFinished", "()V"));
			} finally {
			}
		}

		static Delegate cb_skipAd;
#pragma warning disable 0169
		static Delegate GetSkipAdHandler ()
		{
			if (cb_skipAd == null)
				cb_skipAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SkipAd);
			return cb_skipAd;
		}

		static void n_SkipAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdEnabledPlayerController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipAd ();
		}
#pragma warning restore 0169

		static IntPtr id_skipAd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdEnabledPlayerController']/method[@name='skipAd' and count(parameter)=0]"
		[Register ("skipAd", "()V", "GetSkipAdHandler")]
		public virtual unsafe void SkipAd ()
		{
			if (id_skipAd == IntPtr.Zero)
				id_skipAd = JNIEnv.GetMethodID (class_ref, "skipAd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipAd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipAd", "()V"));
			} finally {
			}
		}

	}
}

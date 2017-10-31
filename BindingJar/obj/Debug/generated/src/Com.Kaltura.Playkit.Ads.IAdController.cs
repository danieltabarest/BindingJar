using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='AdController']"
	[Register ("com/kaltura/playkit/ads/AdController", "", "Com.Kaltura.Playkit.Ads.IAdControllerInvoker")]
	public partial interface IAdController : IJavaObject {

		long AdCurrentPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='AdController']/method[@name='getAdCurrentPosition' and count(parameter)=0]"
			[Register ("getAdCurrentPosition", "()J", "GetGetAdCurrentPositionHandler:Com.Kaltura.Playkit.Ads.IAdControllerInvoker, BindingJar")] get;
		}

		long AdDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='AdController']/method[@name='getAdDuration' and count(parameter)=0]"
			[Register ("getAdDuration", "()J", "GetGetAdDurationHandler:Com.Kaltura.Playkit.Ads.IAdControllerInvoker, BindingJar")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='AdController']/method[@name='skipAd' and count(parameter)=0]"
		[Register ("skipAd", "()V", "GetSkipAdHandler:Com.Kaltura.Playkit.Ads.IAdControllerInvoker, BindingJar")]
		void SkipAd ();

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/ads/AdController", DoNotGenerateAcw=true)]
	internal class IAdControllerInvoker : global::Java.Lang.Object, IAdController {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/ads/AdController");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdControllerInvoker); }
		}

		IntPtr class_ref;

		public static IAdController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.ads.AdController"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Kaltura.Playkit.Ads.IAdController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IAdController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdCurrentPosition;
		}
#pragma warning restore 0169

		IntPtr id_getAdCurrentPosition;
		public unsafe long AdCurrentPosition {
			get {
				if (id_getAdCurrentPosition == IntPtr.Zero)
					id_getAdCurrentPosition = JNIEnv.GetMethodID (class_ref, "getAdCurrentPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdCurrentPosition);
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
			global::Com.Kaltura.Playkit.Ads.IAdController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IAdController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdDuration;
		}
#pragma warning restore 0169

		IntPtr id_getAdDuration;
		public unsafe long AdDuration {
			get {
				if (id_getAdDuration == IntPtr.Zero)
					id_getAdDuration = JNIEnv.GetMethodID (class_ref, "getAdDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdDuration);
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
			global::Com.Kaltura.Playkit.Ads.IAdController __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IAdController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipAd ();
		}
#pragma warning restore 0169

		IntPtr id_skipAd;
		public unsafe void SkipAd ()
		{
			if (id_skipAd == IntPtr.Zero)
				id_skipAd = JNIEnv.GetMethodID (class_ref, "skipAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipAd);
		}

	}

}

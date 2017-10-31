using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdProviderListener']"
	[Register ("com/kaltura/playkit/ads/PKAdProviderListener", "", "Com.Kaltura.Playkit.Ads.IPKAdProviderListenerInvoker")]
	public partial interface IPKAdProviderListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdProviderListener']/method[@name='onAdLoadingFinished' and count(parameter)=0]"
		[Register ("onAdLoadingFinished", "()V", "GetOnAdLoadingFinishedHandler:Com.Kaltura.Playkit.Ads.IPKAdProviderListenerInvoker, BindingJar")]
		void OnAdLoadingFinished ();

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/ads/PKAdProviderListener", DoNotGenerateAcw=true)]
	internal class IPKAdProviderListenerInvoker : global::Java.Lang.Object, IPKAdProviderListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/ads/PKAdProviderListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPKAdProviderListenerInvoker); }
		}

		IntPtr class_ref;

		public static IPKAdProviderListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPKAdProviderListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.ads.PKAdProviderListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPKAdProviderListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdProviderListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdProviderListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoadingFinished ();
		}
#pragma warning restore 0169

		IntPtr id_onAdLoadingFinished;
		public unsafe void OnAdLoadingFinished ()
		{
			if (id_onAdLoadingFinished == IntPtr.Zero)
				id_onAdLoadingFinished = JNIEnv.GetMethodID (class_ref, "onAdLoadingFinished", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoadingFinished);
		}

	}

	[global::Android.Runtime.Register ("mono/com/kaltura/playkit/ads/PKAdProviderListenerImplementor")]
	internal sealed partial class IPKAdProviderListenerImplementor : global::Java.Lang.Object, IPKAdProviderListener {

		object sender;

		public IPKAdProviderListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/ads/PKAdProviderListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnAdLoadingFinished ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IPKAdProviderListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}

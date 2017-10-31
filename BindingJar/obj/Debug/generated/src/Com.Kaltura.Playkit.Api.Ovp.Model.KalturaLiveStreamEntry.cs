using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Ovp.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaLiveStreamEntry']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/model/KalturaLiveStreamEntry", DoNotGenerateAcw=true)]
	public partial class KalturaLiveStreamEntry : global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/model/KalturaLiveStreamEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalturaLiveStreamEntry); }
		}

		protected KalturaLiveStreamEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaLiveStreamEntry']/constructor[@name='KalturaLiveStreamEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalturaLiveStreamEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KalturaLiveStreamEntry)) {
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

		static Delegate cb_isDvrStatus;
#pragma warning disable 0169
		static Delegate GetIsDvrStatusHandler ()
		{
			if (cb_isDvrStatus == null)
				cb_isDvrStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDvrStatus);
			return cb_isDvrStatus;
		}

		static bool n_IsDvrStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaLiveStreamEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaLiveStreamEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDvrStatus;
		}
#pragma warning restore 0169

		static IntPtr id_isDvrStatus;
		public virtual unsafe bool IsDvrStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaLiveStreamEntry']/method[@name='isDvrStatus' and count(parameter)=0]"
			[Register ("isDvrStatus", "()Z", "GetIsDvrStatusHandler")]
			get {
				if (id_isDvrStatus == IntPtr.Zero)
					id_isDvrStatus = JNIEnv.GetMethodID (class_ref, "isDvrStatus", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDvrStatus);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDvrStatus", "()Z"));
				} finally {
				}
			}
		}

	}
}

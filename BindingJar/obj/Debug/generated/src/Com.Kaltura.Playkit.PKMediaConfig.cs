using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaConfig']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKMediaConfig", DoNotGenerateAcw=true)]
	public partial class PKMediaConfig : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKMediaConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKMediaConfig); }
		}

		protected PKMediaConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaConfig']/constructor[@name='PKMediaConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKMediaConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PKMediaConfig)) {
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

		static Delegate cb_getMediaEntry;
#pragma warning disable 0169
		static Delegate GetGetMediaEntryHandler ()
		{
			if (cb_getMediaEntry == null)
				cb_getMediaEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaEntry);
			return cb_getMediaEntry;
		}

		static IntPtr n_GetMediaEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaEntry);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaEntry;
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry MediaEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaConfig']/method[@name='getMediaEntry' and count(parameter)=0]"
			[Register ("getMediaEntry", "()Lcom/kaltura/playkit/PKMediaEntry;", "GetGetMediaEntryHandler")]
			get {
				if (id_getMediaEntry == IntPtr.Zero)
					id_getMediaEntry = JNIEnv.GetMethodID (class_ref, "getMediaEntry", "()Lcom/kaltura/playkit/PKMediaEntry;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaEntry), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaEntry", "()Lcom/kaltura/playkit/PKMediaEntry;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartPosition;
#pragma warning disable 0169
		static Delegate GetGetStartPositionHandler ()
		{
			if (cb_getStartPosition == null)
				cb_getStartPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetStartPosition);
			return cb_getStartPosition;
		}

		static long n_GetStartPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getStartPosition;
		public virtual unsafe long StartPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaConfig']/method[@name='getStartPosition' and count(parameter)=0]"
			[Register ("getStartPosition", "()J", "GetGetStartPositionHandler")]
			get {
				if (id_getStartPosition == IntPtr.Zero)
					id_getStartPosition = JNIEnv.GetMethodID (class_ref, "getStartPosition", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getStartPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartPosition", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_;
#pragma warning disable 0169
		static Delegate GetSetMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_Handler ()
		{
			if (cb_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_ == null)
				cb_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_);
			return cb_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_;
		}

		static IntPtr n_SetMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaEntry p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMediaEntry (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaConfig']/method[@name='setMediaEntry' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaEntry']]"
		[Register ("setMediaEntry", "(Lcom/kaltura/playkit/PKMediaEntry;)Lcom/kaltura/playkit/PKMediaConfig;", "GetSetMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaConfig SetMediaEntry (global::Com.Kaltura.Playkit.PKMediaEntry p0)
		{
			if (id_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_ == IntPtr.Zero)
				id_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_ = JNIEnv.GetMethodID (class_ref, "setMediaEntry", "(Lcom/kaltura/playkit/PKMediaEntry;)Lcom/kaltura/playkit/PKMediaConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Kaltura.Playkit.PKMediaConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMediaEntry_Lcom_kaltura_playkit_PKMediaEntry_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediaEntry", "(Lcom/kaltura/playkit/PKMediaEntry;)Lcom/kaltura/playkit/PKMediaConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setStartPosition_J;
#pragma warning disable 0169
		static Delegate GetSetStartPosition_JHandler ()
		{
			if (cb_setStartPosition_J == null)
				cb_setStartPosition_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetStartPosition_J);
			return cb_setStartPosition_J;
		}

		static IntPtr n_SetStartPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Kaltura.Playkit.PKMediaConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStartPosition (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setStartPosition_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaConfig']/method[@name='setStartPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setStartPosition", "(J)Lcom/kaltura/playkit/PKMediaConfig;", "GetSetStartPosition_JHandler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaConfig SetStartPosition (long p0)
		{
			if (id_setStartPosition_J == IntPtr.Zero)
				id_setStartPosition_J = JNIEnv.GetMethodID (class_ref, "setStartPosition", "(J)Lcom/kaltura/playkit/PKMediaConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStartPosition_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartPosition", "(J)Lcom/kaltura/playkit/PKMediaConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

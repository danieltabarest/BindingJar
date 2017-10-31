using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ovp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig", DoNotGenerateAcw=true)]
	public partial class KavaAnalyticsConfig : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KavaAnalyticsConfig); }
		}

		protected KavaAnalyticsConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/constructor[@name='KavaAnalyticsConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KavaAnalyticsConfig ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KavaAnalyticsConfig)) {
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

		static Delegate cb_setBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setBaseUrl_Ljava_lang_String_ == null)
				cb_setBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetBaseUrl_Ljava_lang_String_);
			return cb_setBaseUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBaseUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBaseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBaseUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetBaseUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetBaseUrl (string p0)
		{
			if (id_setBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBaseUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBaseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaseUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCustomVar1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomVar1_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomVar1_Ljava_lang_String_ == null)
				cb_setCustomVar1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomVar1_Ljava_lang_String_);
			return cb_setCustomVar1_Ljava_lang_String_;
		}

		static IntPtr n_SetCustomVar1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomVar1 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomVar1_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setCustomVar1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomVar1", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetCustomVar1_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetCustomVar1 (string p0)
		{
			if (id_setCustomVar1_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomVar1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomVar1", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomVar1_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomVar1", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCustomVar2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomVar2_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomVar2_Ljava_lang_String_ == null)
				cb_setCustomVar2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomVar2_Ljava_lang_String_);
			return cb_setCustomVar2_Ljava_lang_String_;
		}

		static IntPtr n_SetCustomVar2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomVar2 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomVar2_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setCustomVar2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomVar2", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetCustomVar2_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetCustomVar2 (string p0)
		{
			if (id_setCustomVar2_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomVar2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomVar2", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomVar2_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomVar2", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCustomVar3_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomVar3_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomVar3_Ljava_lang_String_ == null)
				cb_setCustomVar3_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomVar3_Ljava_lang_String_);
			return cb_setCustomVar3_Ljava_lang_String_;
		}

		static IntPtr n_SetCustomVar3_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomVar3 (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomVar3_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setCustomVar3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomVar3", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetCustomVar3_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetCustomVar3 (string p0)
		{
			if (id_setCustomVar3_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomVar3_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomVar3", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomVar3_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomVar3", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setKs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKs_Ljava_lang_String_Handler ()
		{
			if (cb_setKs_Ljava_lang_String_ == null)
				cb_setKs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetKs_Ljava_lang_String_);
			return cb_setKs_Ljava_lang_String_;
		}

		static IntPtr n_SetKs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetKs (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setKs_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setKs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKs", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetKs_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetKs (string p0)
		{
			if (id_setKs_Ljava_lang_String_ == IntPtr.Zero)
				id_setKs_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKs", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setKs_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKs", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPartnerId_I;
#pragma warning disable 0169
		static Delegate GetSetPartnerId_IHandler ()
		{
			if (cb_setPartnerId_I == null)
				cb_setPartnerId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPartnerId_I);
			return cb_setPartnerId_I;
		}

		static IntPtr n_SetPartnerId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPartnerId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setPartnerId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setPartnerId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPartnerId", "(I)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetPartnerId_IHandler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetPartnerId (int p0)
		{
			if (id_setPartnerId_I == IntPtr.Zero)
				id_setPartnerId_I = JNIEnv.GetMethodID (class_ref, "setPartnerId", "(I)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPartnerId_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPartnerId", "(I)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPlaybackContext_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlaybackContext_Ljava_lang_String_Handler ()
		{
			if (cb_setPlaybackContext_Ljava_lang_String_ == null)
				cb_setPlaybackContext_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPlaybackContext_Ljava_lang_String_);
			return cb_setPlaybackContext_Ljava_lang_String_;
		}

		static IntPtr n_SetPlaybackContext_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPlaybackContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPlaybackContext_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setPlaybackContext' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPlaybackContext", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetPlaybackContext_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetPlaybackContext (string p0)
		{
			if (id_setPlaybackContext_Ljava_lang_String_ == IntPtr.Zero)
				id_setPlaybackContext_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlaybackContext", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPlaybackContext_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPlaybackContext", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setReferrer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReferrer_Ljava_lang_String_Handler ()
		{
			if (cb_setReferrer_Ljava_lang_String_ == null)
				cb_setReferrer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReferrer_Ljava_lang_String_);
			return cb_setReferrer_Ljava_lang_String_;
		}

		static IntPtr n_SetReferrer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetReferrer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setReferrer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setReferrer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setReferrer", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetReferrer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetReferrer (string p0)
		{
			if (id_setReferrer_Ljava_lang_String_ == IntPtr.Zero)
				id_setReferrer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReferrer", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReferrer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReferrer", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setUiConfId_I;
#pragma warning disable 0169
		static Delegate GetSetUiConfId_IHandler ()
		{
			if (cb_setUiConfId_I == null)
				cb_setUiConfId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetUiConfId_I);
			return cb_setUiConfId_I;
		}

		static IntPtr n_SetUiConfId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetUiConfId (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setUiConfId_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsConfig']/method[@name='setUiConfId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setUiConfId", "(I)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;", "GetSetUiConfId_IHandler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig SetUiConfId (int p0)
		{
			if (id_setUiConfId_I == IntPtr.Zero)
				id_setUiConfId_I = JNIEnv.GetMethodID (class_ref, "setUiConfId", "(I)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUiConfId_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsConfig> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUiConfId", "(I)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsConfig;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

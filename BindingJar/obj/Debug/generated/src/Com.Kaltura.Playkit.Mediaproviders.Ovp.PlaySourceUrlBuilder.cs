using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Mediaproviders.Ovp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder", DoNotGenerateAcw=true)]
	public partial class PlaySourceUrlBuilder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/field[@name='DefFormat']"
		[Register ("DefFormat")]
		public const string DefFormat = (string) "url";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlaySourceUrlBuilder); }
		}

		protected PlaySourceUrlBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Build ());
		}
#pragma warning restore 0169

		static IntPtr id_build;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Ljava/lang/String;", "GetBuildHandler")]
		public virtual unsafe string Build ()
		{
			if (id_build == IntPtr.Zero)
				id_build = JNIEnv.GetMethodID (class_ref, "build", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "build", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetBaseUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setBaseUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBaseUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetBaseUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetBaseUrl (string p0)
		{
			if (id_setBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBaseUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setBaseUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaseUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setEntryId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEntryId_Ljava_lang_String_Handler ()
		{
			if (cb_setEntryId_Ljava_lang_String_ == null)
				cb_setEntryId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEntryId_Ljava_lang_String_);
			return cb_setEntryId_Ljava_lang_String_;
		}

		static IntPtr n_SetEntryId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEntryId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setEntryId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setEntryId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEntryId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetEntryId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetEntryId (string p0)
		{
			if (id_setEntryId_Ljava_lang_String_ == IntPtr.Zero)
				id_setEntryId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEntryId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setEntryId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEntryId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setExtension_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtension_Ljava_lang_String_Handler ()
		{
			if (cb_setExtension_Ljava_lang_String_ == null)
				cb_setExtension_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExtension_Ljava_lang_String_);
			return cb_setExtension_Ljava_lang_String_;
		}

		static IntPtr n_SetExtension_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetExtension (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setExtension", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetExtension_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetExtension (string p0)
		{
			if (id_setExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_setExtension_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExtension", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setExtension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtension", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFlavorIds_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFlavorIds_Ljava_lang_String_Handler ()
		{
			if (cb_setFlavorIds_Ljava_lang_String_ == null)
				cb_setFlavorIds_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFlavorIds_Ljava_lang_String_);
			return cb_setFlavorIds_Ljava_lang_String_;
		}

		static IntPtr n_SetFlavorIds_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFlavorIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFlavorIds_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setFlavorIds' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFlavorIds", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetFlavorIds_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetFlavorIds (string p0)
		{
			if (id_setFlavorIds_Ljava_lang_String_ == IntPtr.Zero)
				id_setFlavorIds_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFlavorIds", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFlavorIds_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlavorIds", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFlavorIds_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetFlavorIds_Ljava_util_List_Handler ()
		{
			if (cb_setFlavorIds_Ljava_util_List_ == null)
				cb_setFlavorIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFlavorIds_Ljava_util_List_);
			return cb_setFlavorIds_Ljava_util_List_;
		}

		static IntPtr n_SetFlavorIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFlavorIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFlavorIds_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setFlavorIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("setFlavorIds", "(Ljava/util/List;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetFlavorIds_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetFlavorIds (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_setFlavorIds_Ljava_util_List_ == IntPtr.Zero)
				id_setFlavorIds_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setFlavorIds", "(Ljava/util/List;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFlavorIds_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFlavorIds", "(Ljava/util/List;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setFormat_Ljava_lang_String_ == null)
				cb_setFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFormat_Ljava_lang_String_);
			return cb_setFormat_Ljava_lang_String_;
		}

		static IntPtr n_SetFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFormat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFormat", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetFormat_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetFormat (string p0)
		{
			if (id_setFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_setFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFormat", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFormat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFormat", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetKs (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setKs_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setKs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setKs", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetKs_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetKs (string p0)
		{
			if (id_setKs_Ljava_lang_String_ == IntPtr.Zero)
				id_setKs_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKs", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setKs_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKs", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPartnerId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPartnerId_Ljava_lang_String_Handler ()
		{
			if (cb_setPartnerId_Ljava_lang_String_ == null)
				cb_setPartnerId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPartnerId_Ljava_lang_String_);
			return cb_setPartnerId_Ljava_lang_String_;
		}

		static IntPtr n_SetPartnerId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPartnerId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setPartnerId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setPartnerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPartnerId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetPartnerId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetPartnerId (string p0)
		{
			if (id_setPartnerId_Ljava_lang_String_ == IntPtr.Zero)
				id_setPartnerId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPartnerId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPartnerId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPartnerId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setProtocol_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProtocol_Ljava_lang_String_Handler ()
		{
			if (cb_setProtocol_Ljava_lang_String_ == null)
				cb_setProtocol_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProtocol_Ljava_lang_String_);
			return cb_setProtocol_Ljava_lang_String_;
		}

		static IntPtr n_SetProtocol_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProtocol (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setProtocol_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setProtocol", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetProtocol_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetProtocol (string p0)
		{
			if (id_setProtocol_Ljava_lang_String_ == IntPtr.Zero)
				id_setProtocol_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProtocol", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setProtocol_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProtocol", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setUiConfId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUiConfId_Ljava_lang_String_Handler ()
		{
			if (cb_setUiConfId_Ljava_lang_String_ == null)
				cb_setUiConfId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUiConfId_Ljava_lang_String_);
			return cb_setUiConfId_Ljava_lang_String_;
		}

		static IntPtr n_SetUiConfId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUiConfId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setUiConfId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.ovp']/class[@name='PlaySourceUrlBuilder']/method[@name='setUiConfId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUiConfId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;", "GetSetUiConfId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder SetUiConfId (string p0)
		{
			if (id_setUiConfId_Ljava_lang_String_ == IntPtr.Zero)
				id_setUiConfId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUiConfId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUiConfId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Ovp.PlaySourceUrlBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUiConfId", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/ovp/PlaySourceUrlBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

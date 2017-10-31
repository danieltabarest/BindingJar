using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.data']/class[@name='Options']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/data/Options", DoNotGenerateAcw=true)]
	public partial class Options : global::Android.Runtime.JavaDictionary {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/data/Options", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Options); }
		}

		protected Options (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.data']/class[@name='Options']/constructor[@name='Options' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Options ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Options)) {
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

		static Delegate cb_getFromMap_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFromMap_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getFromMap_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getFromMap_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFromMap_Ljava_lang_String_Ljava_lang_String_);
			return cb_getFromMap_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetFromMap_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Data.Options __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Data.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFromMap (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getFromMap_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.data']/class[@name='Options']/method[@name='getFromMap' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getFromMap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;", "GetGetFromMap_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetFromMap (string p0, string p1)
		{
			if (id_getFromMap_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getFromMap_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getFromMap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFromMap_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFromMap", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setOptions_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Ljava_lang_String_Handler ()
		{
			if (cb_setOptions_Ljava_lang_String_ == null)
				cb_setOptions_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptions_Ljava_lang_String_);
			return cb_setOptions_Ljava_lang_String_;
		}

		static void n_SetOptions_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Data.Options __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Data.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.data']/class[@name='Options']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOptions", "(Ljava/lang/String;)V", "GetSetOptions_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOptions (string p0)
		{
			if (id_setOptions_Ljava_lang_String_ == IntPtr.Zero)
				id_setOptions_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOptions_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Ljava_util_Map_Handler ()
		{
			if (cb_setOptions_Ljava_util_Map_ == null)
				cb_setOptions_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptions_Ljava_util_Map_);
			return cb_setOptions_Ljava_util_Map_;
		}

		static void n_SetOptions_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Data.Options __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Data.Options> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.data']/class[@name='Options']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setOptions", "(Ljava/util/Map;)V", "GetSetOptions_Ljava_util_Map_Handler")]
		public virtual unsafe void SetOptions (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_setOptions_Ljava_util_Map_ == IntPtr.Zero)
				id_setOptions_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

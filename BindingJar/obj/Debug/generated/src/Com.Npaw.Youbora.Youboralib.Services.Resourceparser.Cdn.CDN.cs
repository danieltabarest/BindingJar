using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN", DoNotGenerateAcw=true)]
	public partial class CDN : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/interface[@name='CDN.CDNInfoListener']"
		[Register ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener", "", "Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN/ICDNInfoListenerInvoker")]
		public partial interface ICDNInfoListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/interface[@name='CDN.CDNInfoListener']/method[@name='getCDNCode' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;java.lang.String&gt;&gt;'] and parameter[2][@type='java.lang.String']]"
			[Register ("getCDNCode", "(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;", "GetGetCDNCode_Ljava_util_Map_Ljava_lang_String_Handler:Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN/ICDNInfoListenerInvoker, BindingJar")]
			string GetCDNCode (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0, string p1);

		}

		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener", DoNotGenerateAcw=true)]
		internal class ICDNInfoListenerInvoker : global::Java.Lang.Object, ICDNInfoListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICDNInfoListenerInvoker); }
			}

			IntPtr class_ref;

			public static ICDNInfoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICDNInfoListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.npaw.youbora.youboralib.services.resourceparser.cdn.CDN.CDNInfoListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICDNInfoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getCDNCode_Ljava_util_Map_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetCDNCode_Ljava_util_Map_Ljava_lang_String_Handler ()
			{
				if (cb_getCDNCode_Ljava_util_Map_Ljava_lang_String_ == null)
					cb_getCDNCode_Ljava_util_Map_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCDNCode_Ljava_util_Map_Ljava_lang_String_);
				return cb_getCDNCode_Ljava_util_Map_Ljava_lang_String_;
			}

			static IntPtr n_GetCDNCode_Ljava_util_Map_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.GetCDNCode (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getCDNCode_Ljava_util_Map_Ljava_lang_String_;
			public unsafe string GetCDNCode (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0, string p1)
			{
				if (id_getCDNCode_Ljava_util_Map_Ljava_lang_String_ == IntPtr.Zero)
					id_getCDNCode_Ljava_util_Map_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCDNCode", "(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCDNCode_Ljava_util_Map_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}

		public delegate string CDNInfoHandler (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0, string p1);

		[global::Android.Runtime.Register ("mono/com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN_CDNInfoListenerImplementor")]
		internal sealed partial class ICDNInfoListenerImplementor : global::Java.Lang.Object, ICDNInfoListener {

			public ICDNInfoListenerImplementor ()
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN_CDNInfoListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			}

#pragma warning disable 0649
			public CDNInfoHandler Handler;
#pragma warning restore 0649

			public string GetCDNCode (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> p0, string p1)
			{
				var __h = Handler;
				return __h != null ? __h (p0, p1) : default (string);
			}

			internal static bool __IsEmpty (ICDNInfoListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDN", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CDN); }
		}

		protected CDN (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/constructor[@name='CDN' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.npaw.youbora.youboralib.services.resourceparser.cdn.CDNHeader&gt;'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V", "")]
		public unsafe CDN (string p0, global::System.Collections.Generic.IList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> p1, global::System.Collections.Generic.IDictionary<string, string> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (CDN)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCdnInfoListener;
#pragma warning disable 0169
		static Delegate GetGetCdnInfoListenerHandler ()
		{
			if (cb_getCdnInfoListener == null)
				cb_getCdnInfoListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCdnInfoListener);
			return cb_getCdnInfoListener;
		}

		static IntPtr n_GetCdnInfoListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CdnInfoListener);
		}
#pragma warning restore 0169

		static Delegate cb_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_;
#pragma warning disable 0169
		static Delegate GetSetCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_Handler ()
		{
			if (cb_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_ == null)
				cb_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_);
			return cb_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_;
		}

		static void n_SetCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener p0 = (global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CdnInfoListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCdnInfoListener;
		static IntPtr id_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener CdnInfoListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='getCdnInfoListener' and count(parameter)=0]"
			[Register ("getCdnInfoListener", "()Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener;", "GetGetCdnInfoListenerHandler")]
			get {
				if (id_getCdnInfoListener == IntPtr.Zero)
					id_getCdnInfoListener = JNIEnv.GetMethodID (class_ref, "getCdnInfoListener", "()Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCdnInfoListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCdnInfoListener", "()Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='setCdnInfoListener' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.services.resourceparser.cdn.CDN.CDNInfoListener']]"
			[Register ("setCdnInfoListener", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener;)V", "GetSetCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_Handler")]
			set {
				if (id_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_ == IntPtr.Zero)
					id_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_ = JNIEnv.GetMethodID (class_ref, "setCdnInfoListener", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCdnInfoListener_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDN_CDNInfoListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCdnInfoListener", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDN$CDNInfoListener;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCode);
			return cb_getCode;
		}

		static IntPtr n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Code);
		}
#pragma warning restore 0169

		static Delegate cb_setCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCode_Ljava_lang_String_ == null)
				cb_setCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCode_Ljava_lang_String_);
			return cb_setCode_Ljava_lang_String_;
		}

		static void n_SetCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Code = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCode;
		static IntPtr id_setCode_Ljava_lang_String_;
		public virtual unsafe string Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()Ljava/lang/String;", "GetGetCodeHandler")]
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='setCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCode", "(Ljava/lang/String;)V", "GetSetCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader>.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static Delegate cb_setHeaders_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetHeaders_Ljava_util_List_Handler ()
		{
			if (cb_setHeaders_Ljava_util_List_ == null)
				cb_setHeaders_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHeaders_Ljava_util_List_);
			return cb_setHeaders_Ljava_util_List_;
		}

		static void n_SetHeaders_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Headers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		static IntPtr id_setHeaders_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/List;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='setHeaders' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.npaw.youbora.youboralib.services.resourceparser.cdn.CDNHeader&gt;']]"
			[Register ("setHeaders", "(Ljava/util/List;)V", "GetSetHeaders_Ljava_util_List_Handler")]
			set {
				if (id_setHeaders_Ljava_util_List_ == IntPtr.Zero)
					id_setHeaders_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setHeaders", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHeaders_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHeaders", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRequestHeaders;
#pragma warning disable 0169
		static Delegate GetGetRequestHeadersHandler ()
		{
			if (cb_getRequestHeaders == null)
				cb_getRequestHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestHeaders);
			return cb_getRequestHeaders;
		}

		static IntPtr n_GetRequestHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestHeaders);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestHeaders_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetRequestHeaders_Ljava_util_Map_Handler ()
		{
			if (cb_setRequestHeaders_Ljava_util_Map_ == null)
				cb_setRequestHeaders_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestHeaders_Ljava_util_Map_);
			return cb_setRequestHeaders_Ljava_util_Map_;
		}

		static void n_SetRequestHeaders_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestHeaders = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestHeaders;
		static IntPtr id_setRequestHeaders_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> RequestHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='getRequestHeaders' and count(parameter)=0]"
			[Register ("getRequestHeaders", "()Ljava/util/Map;", "GetGetRequestHeadersHandler")]
			get {
				if (id_getRequestHeaders == IntPtr.Zero)
					id_getRequestHeaders = JNIEnv.GetMethodID (class_ref, "getRequestHeaders", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRequestHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDN']/method[@name='setRequestHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setRequestHeaders", "(Ljava/util/Map;)V", "GetSetRequestHeaders_Ljava_util_Map_Handler")]
			set {
				if (id_setRequestHeaders_Ljava_util_Map_ == IntPtr.Zero)
					id_setRequestHeaders_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setRequestHeaders", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestHeaders_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestHeaders", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

#region "Event implementation for Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListener"
		WeakReference weak_implementor_CdnInfo;
		global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor ImplCdnInfo {
			get {
				if (weak_implementor_CdnInfo == null || !weak_implementor_CdnInfo.IsAlive)
					return null;
				return weak_implementor_CdnInfo.Target as global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor;
			}
			set { weak_implementor_CdnInfo = new WeakReference (value, true); }
		}

		public global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.CDNInfoHandler CdnInfo {
			get {
				global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor impl = ImplCdnInfo;
				return impl == null ? null : impl.Handler;
			}
			set {
				global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor impl = ImplCdnInfo;
				if (impl == null) {
					impl = new global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor ();
					ImplCdnInfo = impl;
				} else
					impl.Handler = value;
			}
		}

		WeakReference weak_implementor___SetCdnInfoListener;

		global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor __CreateICDNInfoListenerImplementor ()
		{
			return new global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDN.ICDNInfoListenerImplementor ();
		}
#endregion
	}
}

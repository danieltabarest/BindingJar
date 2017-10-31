using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Services.Resourceparser {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/services/resourceparser/ResourceParser", DoNotGenerateAcw=true)]
	public partial class ResourceParser : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='CDN_AKAMAI']"
		[Register ("CDN_AKAMAI")]
		public const string CdnAkamai = (string) "Akamai";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='CDN_CUSTOM']"
		[Register ("CDN_CUSTOM")]
		public const string CdnCustom = (string) "cdn_custom";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='CDN_FASTLY']"
		[Register ("CDN_FASTLY")]
		public const string CdnFastly = (string) "Fastly";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='CDN_HIGHWINDS']"
		[Register ("CDN_HIGHWINDS")]
		public const string CdnHighwinds = (string) "Highwinds";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='CDN_LEVEL3']"
		[Register ("CDN_LEVEL3")]
		public const string CdnLevel3 = (string) "Level3";

		static IntPtr cdnsAvailable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='cdnsAvailable']"
		[Register ("cdnsAvailable")]
		public static global::System.Collections.IDictionary CdnsAvailable {
			get {
				if (cdnsAvailable_jfieldId == IntPtr.Zero)
					cdnsAvailable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cdnsAvailable", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, cdnsAvailable_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cdnsAvailable_jfieldId == IntPtr.Zero)
					cdnsAvailable_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cdnsAvailable", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, cdnsAvailable_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr cdnsEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/field[@name='cdnsEnabled']"
		[Register ("cdnsEnabled")]
		public static global::System.Collections.IList CdnsEnabled {
			get {
				if (cdnsEnabled_jfieldId == IntPtr.Zero)
					cdnsEnabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cdnsEnabled", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, cdnsEnabled_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cdnsEnabled_jfieldId == IntPtr.Zero)
					cdnsEnabled_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "cdnsEnabled", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, cdnsEnabled_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/services/resourceparser/ResourceParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResourceParser); }
		}

		protected ResourceParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_npaw_youbora_youboralib_managers_ViewManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/constructor[@name='ResourceParser' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.managers.ViewManager']]"
		[Register (".ctor", "(Lcom/npaw/youbora/youboralib/managers/ViewManager;)V", "")]
		public unsafe ResourceParser (global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ResourceParser)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/youboralib/managers/ViewManager;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/youboralib/managers/ViewManager;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_youboralib_managers_ViewManager_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_youboralib_managers_ViewManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/youboralib/managers/ViewManager;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_youboralib_managers_ViewManager_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_youboralib_managers_ViewManager_, __args);
			} finally {
			}
		}

		static Delegate cb_getCDNCode;
#pragma warning disable 0169
		static Delegate GetGetCDNCodeHandler ()
		{
			if (cb_getCDNCode == null)
				cb_getCDNCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCDNCode);
			return cb_getCDNCode;
		}

		static IntPtr n_GetCDNCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CDNCode);
		}
#pragma warning restore 0169

		static IntPtr id_getCDNCode;
		public virtual unsafe string CDNCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/method[@name='getCDNCode' and count(parameter)=0]"
			[Register ("getCDNCode", "()Ljava/lang/String;", "GetGetCDNCodeHandler")]
			get {
				if (id_getCDNCode == IntPtr.Zero)
					id_getCDNCode = JNIEnv.GetMethodID (class_ref, "getCDNCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCDNCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCDNCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNodeHost;
#pragma warning disable 0169
		static Delegate GetGetNodeHostHandler ()
		{
			if (cb_getNodeHost == null)
				cb_getNodeHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNodeHost);
			return cb_getNodeHost;
		}

		static IntPtr n_GetNodeHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NodeHost);
		}
#pragma warning restore 0169

		static IntPtr id_getNodeHost;
		public virtual unsafe string NodeHost {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/method[@name='getNodeHost' and count(parameter)=0]"
			[Register ("getNodeHost", "()Ljava/lang/String;", "GetGetNodeHostHandler")]
			get {
				if (id_getNodeHost == IntPtr.Zero)
					id_getNodeHost = JNIEnv.GetMethodID (class_ref, "getNodeHost", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNodeHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNodeType;
#pragma warning disable 0169
		static Delegate GetGetNodeTypeHandler ()
		{
			if (cb_getNodeType == null)
				cb_getNodeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNodeType);
			return cb_getNodeType;
		}

		static IntPtr n_GetNodeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NodeType);
		}
#pragma warning restore 0169

		static IntPtr id_getNodeType;
		public virtual unsafe string NodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/method[@name='getNodeType' and count(parameter)=0]"
			[Register ("getNodeType", "()Ljava/lang/String;", "GetGetNodeTypeHandler")]
			get {
				if (id_getNodeType == IntPtr.Zero)
					id_getNodeType = JNIEnv.GetMethodID (class_ref, "getNodeType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNodeType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNodeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRealResource;
#pragma warning disable 0169
		static Delegate GetGetRealResourceHandler ()
		{
			if (cb_getRealResource == null)
				cb_getRealResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRealResource);
			return cb_getRealResource;
		}

		static IntPtr n_GetRealResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RealResource);
		}
#pragma warning restore 0169

		static IntPtr id_getRealResource;
		public virtual unsafe string RealResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/method[@name='getRealResource' and count(parameter)=0]"
			[Register ("getRealResource", "()Ljava/lang/String;", "GetGetRealResourceHandler")]
			get {
				if (id_getRealResource == IntPtr.Zero)
					id_getRealResource = JNIEnv.GetMethodID (class_ref, "getRealResource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRealResource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRealResource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser']/class[@name='ResourceParser']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

	}
}

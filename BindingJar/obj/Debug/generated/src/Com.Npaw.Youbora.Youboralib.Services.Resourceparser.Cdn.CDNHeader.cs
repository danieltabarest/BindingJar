using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader", DoNotGenerateAcw=true)]
	public partial class CDNHeader : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']"
		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType", DoNotGenerateAcw=true)]
		public sealed partial class HeaderType : global::Java.Lang.Enum {


			static IntPtr kHeaderHost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/field[@name='kHeaderHost']"
			[Register ("kHeaderHost")]
			public static global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType KHeaderHost {
				get {
					if (kHeaderHost_jfieldId == IntPtr.Zero)
						kHeaderHost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kHeaderHost", "Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kHeaderHost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr kHeaderHostAndType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/field[@name='kHeaderHostAndType']"
			[Register ("kHeaderHostAndType")]
			public static global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType KHeaderHostAndType {
				get {
					if (kHeaderHostAndType_jfieldId == IntPtr.Zero)
						kHeaderHostAndType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kHeaderHostAndType", "Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kHeaderHostAndType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr kHeaderNone_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/field[@name='kHeaderNone']"
			[Register ("kHeaderNone")]
			public static global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType KHeaderNone {
				get {
					if (kHeaderNone_jfieldId == IntPtr.Zero)
						kHeaderNone_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kHeaderNone", "Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kHeaderNone_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr kHeaderType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/field[@name='kHeaderType']"
			[Register ("kHeaderType")]
			public static global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType KHeaderType {
				get {
					if (kHeaderType_jfieldId == IntPtr.Zero)
						kHeaderType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kHeaderType", "Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kHeaderType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr kHeaderTypeAndHost_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/field[@name='kHeaderTypeAndHost']"
			[Register ("kHeaderTypeAndHost")]
			public static global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType KHeaderTypeAndHost {
				get {
					if (kHeaderTypeAndHost_jfieldId == IntPtr.Zero)
						kHeaderTypeAndHost_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "kHeaderTypeAndHost", "Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, kHeaderTypeAndHost_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HeaderType); }
			}

			internal HeaderType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;", "")]
			public static unsafe global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType __ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader.HeaderType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;", "")]
			public static unsafe global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
				try {
					return (global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CDNHeader); }
		}

		protected CDNHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/constructor[@name='CDNHeader' and count(parameter)=3 and parameter[1][@type='com.npaw.youbora.youboralib.services.resourceparser.cdn.CDNHeader.HeaderType'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CDNHeader (global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (CDNHeader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRegexPattern;
#pragma warning disable 0169
		static Delegate GetGetRegexPatternHandler ()
		{
			if (cb_getRegexPattern == null)
				cb_getRegexPattern = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegexPattern);
			return cb_getRegexPattern;
		}

		static IntPtr n_GetRegexPattern (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegexPattern);
		}
#pragma warning restore 0169

		static Delegate cb_setRegexPattern_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegexPattern_Ljava_lang_String_Handler ()
		{
			if (cb_setRegexPattern_Ljava_lang_String_ == null)
				cb_setRegexPattern_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegexPattern_Ljava_lang_String_);
			return cb_setRegexPattern_Ljava_lang_String_;
		}

		static void n_SetRegexPattern_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegexPattern = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegexPattern;
		static IntPtr id_setRegexPattern_Ljava_lang_String_;
		public virtual unsafe string RegexPattern {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/method[@name='getRegexPattern' and count(parameter)=0]"
			[Register ("getRegexPattern", "()Ljava/lang/String;", "GetGetRegexPatternHandler")]
			get {
				if (id_getRegexPattern == IntPtr.Zero)
					id_getRegexPattern = JNIEnv.GetMethodID (class_ref, "getRegexPattern", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegexPattern), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegexPattern", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/method[@name='setRegexPattern' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegexPattern", "(Ljava/lang/String;)V", "GetSetRegexPattern_Ljava_lang_String_Handler")]
			set {
				if (id_setRegexPattern_Ljava_lang_String_ == IntPtr.Zero)
					id_setRegexPattern_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRegexPattern", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegexPattern_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegexPattern", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Handler ()
		{
			if (cb_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_ == null)
				cb_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_);
			return cb_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_;
		}

		static void n_SetType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType p0 = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.Cdn.CDNHeader.HeaderType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.services.resourceparser.cdn']/class[@name='CDNHeader']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.services.resourceparser.cdn.CDNHeader.HeaderType']]"
			[Register ("setType", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;)V", "GetSetType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_Handler")]
			set {
				if (id_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_ == IntPtr.Zero)
					id_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_ = JNIEnv.GetMethodID (class_ref, "setType", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Lcom_npaw_youbora_youboralib_services_resourceparser_cdn_CDNHeader_HeaderType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Lcom/npaw/youbora/youboralib/services/resourceparser/cdn/CDNHeader$HeaderType;)V"), __args);
				} finally {
				}
			}
		}

	}
}

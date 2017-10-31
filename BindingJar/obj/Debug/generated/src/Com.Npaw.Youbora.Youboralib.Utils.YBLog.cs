using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/utils/YBLog", DoNotGenerateAcw=true)]
	public partial class YBLog : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/field[@name='YBLogLevelDebug']"
		[Register ("YBLogLevelDebug")]
		public const int YBLogLevelDebug = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/field[@name='YBLogLevelError']"
		[Register ("YBLogLevelError")]
		public const int YBLogLevelError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/field[@name='YBLogLevelHTTPRequests']"
		[Register ("YBLogLevelHTTPRequests")]
		public const int YBLogLevelHTTPRequests = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/field[@name='YBLogLevelLifeCycle']"
		[Register ("YBLogLevelLifeCycle")]
		public const int YBLogLevelLifeCycle = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/field[@name='YBLogLevelSilent']"
		[Register ("YBLogLevelSilent")]
		public const int YBLogLevelSilent = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/field[@name='YBLogLevelWarning']"
		[Register ("YBLogLevelWarning")]
		public const int YBLogLevelWarning = (int) 2;
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/interface[@name='YBLog.YouboraLogger']"
		[Register ("com/npaw/youbora/youboralib/utils/YBLog$YouboraLogger", "", "Com.Npaw.Youbora.Youboralib.Utils.YBLog/IYouboraLoggerInvoker")]
		public partial interface IYouboraLogger : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/interface[@name='YBLog.YouboraLogger']/method[@name='logYouboraMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register ("logYouboraMessage", "(Ljava/lang/String;I)V", "GetLogYouboraMessage_Ljava_lang_String_IHandler:Com.Npaw.Youbora.Youboralib.Utils.YBLog/IYouboraLoggerInvoker, BindingJar")]
			void LogYouboraMessage (string p0, int p1);

		}

		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/utils/YBLog$YouboraLogger", DoNotGenerateAcw=true)]
		internal class IYouboraLoggerInvoker : global::Java.Lang.Object, IYouboraLogger {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/npaw/youbora/youboralib/utils/YBLog$YouboraLogger");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IYouboraLoggerInvoker); }
			}

			IntPtr class_ref;

			public static IYouboraLogger GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IYouboraLogger> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.npaw.youbora.youboralib.utils.YBLog.YouboraLogger"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IYouboraLoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_logYouboraMessage_Ljava_lang_String_I;
#pragma warning disable 0169
			static Delegate GetLogYouboraMessage_Ljava_lang_String_IHandler ()
			{
				if (cb_logYouboraMessage_Ljava_lang_String_I == null)
					cb_logYouboraMessage_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_LogYouboraMessage_Ljava_lang_String_I);
				return cb_logYouboraMessage_Ljava_lang_String_I;
			}

			static void n_LogYouboraMessage_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Npaw.Youbora.Youboralib.Utils.YBLog.IYouboraLogger __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.YBLog.IYouboraLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.LogYouboraMessage (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_logYouboraMessage_Ljava_lang_String_I;
			public unsafe void LogYouboraMessage (string p0, int p1)
			{
				if (id_logYouboraMessage_Ljava_lang_String_I == IntPtr.Zero)
					id_logYouboraMessage_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "logYouboraMessage", "(Ljava/lang/String;I)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logYouboraMessage_Ljava_lang_String_I, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/utils/YBLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (YBLog); }
		}

		protected YBLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/constructor[@name='YBLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe YBLog ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (YBLog)) {
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

		static IntPtr id_debug_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public static unsafe void Debug (string p0)
		{
			if (id_debug_Ljava_lang_String_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "debug", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_debug_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_debugLevel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='debugLevel' and count(parameter)=0]"
		[Register ("debugLevel", "()I", "")]
		public static unsafe int DebugLevel ()
		{
			if (id_debugLevel == IntPtr.Zero)
				id_debugLevel = JNIEnv.GetStaticMethodID (class_ref, "debugLevel", "()I");
			try {
				return JNIEnv.CallStaticIntMethod  (class_ref, id_debugLevel);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("error", "(Ljava/lang/Exception;)V", "")]
		public static unsafe void Error (global::Java.Lang.Exception p0)
		{
			if (id_error_Ljava_lang_Exception_ == IntPtr.Zero)
				id_error_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/Exception;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_error_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public static unsafe void Error (string p0)
		{
			if (id_error_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_error_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_notice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='notice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("notice", "(Ljava/lang/String;)V", "")]
		public static unsafe void Notice (string p0)
		{
			if (id_notice_Ljava_lang_String_ == IntPtr.Zero)
				id_notice_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "notice", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_notice_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_reportLogMessage_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='reportLogMessage' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportLogMessage", "(ILjava/lang/String;)V", "")]
		public static unsafe void ReportLogMessage (int p0, string p1)
		{
			if (id_reportLogMessage_ILjava_lang_String_ == IntPtr.Zero)
				id_reportLogMessage_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportLogMessage", "(ILjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportLogMessage_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_requestLog_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='requestLog' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestLog", "(Ljava/lang/String;)V", "")]
		public static unsafe void RequestLog (string p0)
		{
			if (id_requestLog_Ljava_lang_String_ == IntPtr.Zero)
				id_requestLog_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "requestLog", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestLog_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setDebugLevel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDebugLevel", "(I)V", "")]
		public static unsafe void SetDebugLevel (int p0)
		{
			if (id_setDebugLevel_I == IntPtr.Zero)
				id_setDebugLevel_I = JNIEnv.GetStaticMethodID (class_ref, "setDebugLevel", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugLevel_I, __args);
			} finally {
			}
		}

		static IntPtr id_setLogger_Lcom_npaw_youbora_youboralib_utils_YBLog_YouboraLogger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.utils.YBLog.YouboraLogger']]"
		[Register ("setLogger", "(Lcom/npaw/youbora/youboralib/utils/YBLog$YouboraLogger;)V", "")]
		public static unsafe void SetLogger (global::Com.Npaw.Youbora.Youboralib.Utils.YBLog.IYouboraLogger p0)
		{
			if (id_setLogger_Lcom_npaw_youbora_youboralib_utils_YBLog_YouboraLogger_ == IntPtr.Zero)
				id_setLogger_Lcom_npaw_youbora_youboralib_utils_YBLog_YouboraLogger_ = JNIEnv.GetStaticMethodID (class_ref, "setLogger", "(Lcom/npaw/youbora/youboralib/utils/YBLog$YouboraLogger;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogger_Lcom_npaw_youbora_youboralib_utils_YBLog_YouboraLogger_, __args);
			} finally {
			}
		}

		static IntPtr id_warn_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='YBLog']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public static unsafe void Warn (string p0)
		{
			if (id_warn_Ljava_lang_String_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "warn", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_warn_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

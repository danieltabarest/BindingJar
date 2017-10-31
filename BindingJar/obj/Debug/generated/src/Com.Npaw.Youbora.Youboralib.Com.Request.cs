using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Com {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Request", DoNotGenerateAcw=true)]
	public partial class Request : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/field[@name='OPTIONS_KEY_MAX_RETRIES']"
		[Register ("OPTIONS_KEY_MAX_RETRIES")]
		public const string OptionsKeyMaxRetries = (string) "maxRetries";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/field[@name='OPTIONS_KEY_METHOD']"
		[Register ("OPTIONS_KEY_METHOD")]
		public const string OptionsKeyMethod = (string) "method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/field[@name='OPTIONS_KEY_REQUEST_HEADERS']"
		[Register ("OPTIONS_KEY_REQUEST_HEADERS")]
		public const string OptionsKeyRequestHeaders = (string) "requestHeaders";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/field[@name='OPTIONS_KEY_RETRY_AFTER']"
		[Register ("OPTIONS_KEY_RETRY_AFTER")]
		public const string OptionsKeyRetryAfter = (string) "retryAfter";

		static IntPtr defaultConfig_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/field[@name='defaultConfig']"
		[Register ("defaultConfig")]
		public static global::System.Collections.IDictionary DefaultConfig {
			get {
				if (defaultConfig_jfieldId == IntPtr.Zero)
					defaultConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultConfig", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, defaultConfig_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (defaultConfig_jfieldId == IntPtr.Zero)
					defaultConfig_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "defaultConfig", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, defaultConfig_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request.DefaultOnFailureListener']"
		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Request$DefaultOnFailureListener", DoNotGenerateAcw=true)]
		public partial class DefaultOnFailureListener : global::Java.Lang.Object, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Request$DefaultOnFailureListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultOnFailureListener); }
			}

			protected DefaultOnFailureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_npaw_youbora_youboralib_com_Request_Lcom_npaw_youbora_youboralib_com_Request_IJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request.DefaultOnFailureListener']/constructor[@name='Request.DefaultOnFailureListener' and count(parameter)=4 and parameter[1][@type='com.npaw.youbora.youboralib.com.Request'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
			[Register (".ctor", "(Lcom/npaw/youbora/youboralib/com/Request;Lcom/npaw/youbora/youboralib/com/Request;IJ)V", "")]
			public unsafe DefaultOnFailureListener (global::Com.Npaw.Youbora.Youboralib.Com.Request __self, global::Com.Npaw.Youbora.Youboralib.Com.Request p1, int p2, long p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					if (((object) this).GetType () != typeof (DefaultOnFailureListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/npaw/youbora/youboralib/com/Request;IJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/npaw/youbora/youboralib/com/Request;IJ)V", __args);
						return;
					}

					if (id_ctor_Lcom_npaw_youbora_youboralib_com_Request_Lcom_npaw_youbora_youboralib_com_Request_IJ == IntPtr.Zero)
						id_ctor_Lcom_npaw_youbora_youboralib_com_Request_Lcom_npaw_youbora_youboralib_com_Request_IJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/youboralib/com/Request;Lcom/npaw/youbora/youboralib/com/Request;IJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_youboralib_com_Request_Lcom_npaw_youbora_youboralib_com_Request_IJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_youboralib_com_Request_Lcom_npaw_youbora_youboralib_com_Request_IJ, __args);
				} finally {
				}
			}

			static Delegate cb_onFailure_Ljava_net_HttpURLConnection_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Ljava_net_HttpURLConnection_Handler ()
			{
				if (cb_onFailure_Ljava_net_HttpURLConnection_ == null)
					cb_onFailure_Ljava_net_HttpURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_net_HttpURLConnection_);
				return cb_onFailure_Ljava_net_HttpURLConnection_;
			}

			static void n_OnFailure_Ljava_net_HttpURLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Npaw.Youbora.Youboralib.Com.Request.DefaultOnFailureListener __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.DefaultOnFailureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.HttpURLConnection p0 = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onFailure_Ljava_net_HttpURLConnection_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request.DefaultOnFailureListener']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
			[Register ("onFailure", "(Ljava/net/HttpURLConnection;)V", "GetOnFailure_Ljava_net_HttpURLConnection_Handler")]
			public virtual unsafe void OnFailure (global::Java.Net.HttpURLConnection p0)
			{
				if (id_onFailure_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
					id_onFailure_Ljava_net_HttpURLConnection_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/net/HttpURLConnection;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_net_HttpURLConnection_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onFailure", "(Ljava/net/HttpURLConnection;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/interface[@name='Request.OnFailureListener']"
		[Register ("com/npaw/youbora/youboralib/com/Request$OnFailureListener", "", "Com.Npaw.Youbora.Youboralib.Com.Request/IOnFailureListenerInvoker")]
		public partial interface IOnFailureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/interface[@name='Request.OnFailureListener']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
			[Register ("onFailure", "(Ljava/net/HttpURLConnection;)V", "GetOnFailure_Ljava_net_HttpURLConnection_Handler:Com.Npaw.Youbora.Youboralib.Com.Request/IOnFailureListenerInvoker, BindingJar")]
			void OnFailure (global::Java.Net.HttpURLConnection p0);

		}

		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Request$OnFailureListener", DoNotGenerateAcw=true)]
		internal class IOnFailureListenerInvoker : global::Java.Lang.Object, IOnFailureListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Request$OnFailureListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnFailureListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnFailureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnFailureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.npaw.youbora.youboralib.com.Request.OnFailureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnFailureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFailure_Ljava_net_HttpURLConnection_;
#pragma warning disable 0169
			static Delegate GetOnFailure_Ljava_net_HttpURLConnection_Handler ()
			{
				if (cb_onFailure_Ljava_net_HttpURLConnection_ == null)
					cb_onFailure_Ljava_net_HttpURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_net_HttpURLConnection_);
				return cb_onFailure_Ljava_net_HttpURLConnection_;
			}

			static void n_OnFailure_Ljava_net_HttpURLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.HttpURLConnection p0 = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailure (p0);
			}
#pragma warning restore 0169

			IntPtr id_onFailure_Ljava_net_HttpURLConnection_;
			public unsafe void OnFailure (global::Java.Net.HttpURLConnection p0)
			{
				if (id_onFailure_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
					id_onFailure_Ljava_net_HttpURLConnection_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/net/HttpURLConnection;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_net_HttpURLConnection_, __args);
			}

		}

		public partial class FailureEventArgs : global::System.EventArgs {

			public FailureEventArgs (global::Java.Net.HttpURLConnection p0)
			{
				this.p0 = p0;
			}

			global::Java.Net.HttpURLConnection p0;
			public global::Java.Net.HttpURLConnection P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/npaw/youbora/youboralib/com/Request_OnFailureListenerImplementor")]
		internal sealed partial class IOnFailureListenerImplementor : global::Java.Lang.Object, IOnFailureListener {

			object sender;

			public IOnFailureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/npaw/youbora/youboralib/com/Request_OnFailureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FailureEventArgs> Handler;
#pragma warning restore 0649

			public void OnFailure (global::Java.Net.HttpURLConnection p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new FailureEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnFailureListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/interface[@name='Request.OnSuccessListener']"
		[Register ("com/npaw/youbora/youboralib/com/Request$OnSuccessListener", "", "Com.Npaw.Youbora.Youboralib.Com.Request/IOnSuccessListenerInvoker")]
		public partial interface IOnSuccessListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/interface[@name='Request.OnSuccessListener']/method[@name='onSuccess' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.net.HttpURLConnection']]"
			[Register ("onSuccess", "(Ljava/lang/String;Ljava/net/HttpURLConnection;)V", "GetOnSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_Handler:Com.Npaw.Youbora.Youboralib.Com.Request/IOnSuccessListenerInvoker, BindingJar")]
			void OnSuccess (string p0, global::Java.Net.HttpURLConnection p1);

		}

		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Request$OnSuccessListener", DoNotGenerateAcw=true)]
		internal class IOnSuccessListenerInvoker : global::Java.Lang.Object, IOnSuccessListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Request$OnSuccessListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnSuccessListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnSuccessListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSuccessListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.npaw.youbora.youboralib.com.Request.OnSuccessListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSuccessListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_ == null)
					cb_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_);
				return cb_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_;
			}

			static void n_OnSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Net.HttpURLConnection p1 = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_;
			public unsafe void OnSuccess (string p0, global::Java.Net.HttpURLConnection p1)
			{
				if (id_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
					id_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Ljava/lang/String;Ljava/net/HttpURLConnection;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Ljava_lang_String_Ljava_net_HttpURLConnection_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class SuccessEventArgs : global::System.EventArgs {

			public SuccessEventArgs (string p0, global::Java.Net.HttpURLConnection p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Java.Net.HttpURLConnection p1;
			public global::Java.Net.HttpURLConnection P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/npaw/youbora/youboralib/com/Request_OnSuccessListenerImplementor")]
		internal sealed partial class IOnSuccessListenerImplementor : global::Java.Lang.Object, IOnSuccessListener {

			object sender;

			public IOnSuccessListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/npaw/youbora/youboralib/com/Request_OnSuccessListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SuccessEventArgs> Handler;
#pragma warning restore 0649

			public void OnSuccess (string p0, global::Java.Net.HttpURLConnection p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SuccessEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnSuccessListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request.SendHttpRequestTask']"
		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Request$SendHttpRequestTask", DoNotGenerateAcw=true)]
		public partial class SendHttpRequestTask : global::Android.OS.AsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Request$SendHttpRequestTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SendHttpRequestTask); }
			}

			protected SendHttpRequestTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Npaw.Youbora.Youboralib.Com.Request.SendHttpRequestTask __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.SendHttpRequestTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request.SendHttpRequestTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_String_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_String_ == null)
					cb_doInBackground_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_String_);
				return cb_doInBackground_arrayLjava_lang_String_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Npaw.Youbora.Youboralib.Com.Request.SendHttpRequestTask __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.SendHttpRequestTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
				IntPtr __ret = JNIEnv.NewString (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request.SendHttpRequestTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
			[Register ("doInBackground", "([Ljava/lang/String;)Ljava/lang/String;", "GetDoInBackground_arrayLjava_lang_String_Handler")]
			protected virtual unsafe string DoInBackground (params  string[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_String_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/String;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/constructor[@name='Request' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe Request (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (Request)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/constructor[@name='Request' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[4][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", "")]
		public unsafe Request (string p0, string p1, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p2, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (((object) this).GetType () != typeof (Request)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_getGlobalSuccessListener;
		static IntPtr id_setGlobalSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		public static unsafe global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener GlobalSuccessListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='getGlobalSuccessListener' and count(parameter)=0]"
			[Register ("getGlobalSuccessListener", "()Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;", "GetGetGlobalSuccessListenerHandler")]
			get {
				if (id_getGlobalSuccessListener == IntPtr.Zero)
					id_getGlobalSuccessListener = JNIEnv.GetStaticMethodID (class_ref, "getGlobalSuccessListener", "()Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getGlobalSuccessListener), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='setGlobalSuccessListener' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
			[Register ("setGlobalSuccessListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSetGlobalSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
			set {
				if (id_setGlobalSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
					id_setGlobalSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetStaticMethodID (class_ref, "setGlobalSuccessListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setGlobalSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHost;
#pragma warning disable 0169
		static Delegate GetGetHostHandler ()
		{
			if (cb_getHost == null)
				cb_getHost = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHost);
			return cb_getHost;
		}

		static IntPtr n_GetHost (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Host);
		}
#pragma warning restore 0169

		static Delegate cb_setHost_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHost_Ljava_lang_String_Handler ()
		{
			if (cb_setHost_Ljava_lang_String_ == null)
				cb_setHost_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHost_Ljava_lang_String_);
			return cb_setHost_Ljava_lang_String_;
		}

		static void n_SetHost_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Host = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHost;
		static IntPtr id_setHost_Ljava_lang_String_;
		public virtual unsafe string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='getHost' and count(parameter)=0]"
			[Register ("getHost", "()Ljava/lang/String;", "GetGetHostHandler")]
			get {
				if (id_getHost == IntPtr.Zero)
					id_getHost = JNIEnv.GetMethodID (class_ref, "getHost", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHost), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHost", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setHost", "(Ljava/lang/String;)V", "GetSetHost_Ljava_lang_String_Handler")]
			set {
				if (id_setHost_Ljava_lang_String_ == IntPtr.Zero)
					id_setHost_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHost", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHost_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHost", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParameters;
#pragma warning disable 0169
		static Delegate GetGetParametersHandler ()
		{
			if (cb_getParameters == null)
				cb_getParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParameters);
			return cb_getParameters;
		}

		static IntPtr n_GetParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.Parameters);
		}
#pragma warning restore 0169

		static IntPtr id_getParameters;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Ljava/util/Map;", "GetGetParametersHandler")]
			get {
				if (id_getParameters == IntPtr.Zero)
					id_getParameters = JNIEnv.GetMethodID (class_ref, "getParameters", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParameters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParameters", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getQuery;
#pragma warning disable 0169
		static Delegate GetGetQueryHandler ()
		{
			if (cb_getQuery == null)
				cb_getQuery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetQuery);
			return cb_getQuery;
		}

		static IntPtr n_GetQuery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Query);
		}
#pragma warning restore 0169

		static IntPtr id_getQuery;
		public virtual unsafe string Query {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='getQuery' and count(parameter)=0]"
			[Register ("getQuery", "()Ljava/lang/String;", "GetGetQueryHandler")]
			get {
				if (id_getQuery == IntPtr.Zero)
					id_getQuery = JNIEnv.GetMethodID (class_ref, "getQuery", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getQuery), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQuery", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getService;
#pragma warning disable 0169
		static Delegate GetGetServiceHandler ()
		{
			if (cb_getService == null)
				cb_getService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetService);
			return cb_getService;
		}

		static IntPtr n_GetService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Service);
		}
#pragma warning restore 0169

		static Delegate cb_setService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetService_Ljava_lang_String_Handler ()
		{
			if (cb_setService_Ljava_lang_String_ == null)
				cb_setService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetService_Ljava_lang_String_);
			return cb_setService_Ljava_lang_String_;
		}

		static void n_SetService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Service = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getService;
		static IntPtr id_setService_Ljava_lang_String_;
		public virtual unsafe string Service {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='getService' and count(parameter)=0]"
			[Register ("getService", "()Ljava/lang/String;", "GetGetServiceHandler")]
			get {
				if (id_getService == IntPtr.Zero)
					id_getService = JNIEnv.GetMethodID (class_ref, "getService", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getService", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='setService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setService", "(Ljava/lang/String;)V", "GetSetService_Ljava_lang_String_Handler")]
			set {
				if (id_setService_Ljava_lang_String_ == IntPtr.Zero)
					id_setService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setService", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setService_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setService", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Send);
			return cb_send;
		}

		static void n_Send (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send ();
		}
#pragma warning restore 0169

		static IntPtr id_send;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()V", "GetSendHandler")]
		public virtual unsafe void Send ()
		{
			if (id_send == IntPtr.Zero)
				id_send = JNIEnv.GetMethodID (class_ref, "send", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "()V"));
			} finally {
			}
		}

		static Delegate cb_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_;
#pragma warning disable 0169
		static Delegate GetSetFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_Handler ()
		{
			if (cb_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_ == null)
				cb_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_);
			return cb_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_;
		}

		static IntPtr n_SetFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener p0 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFailureListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='setFailureListener' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.com.Request.OnFailureListener']]"
		[Register ("setFailureListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnFailureListener;)Lcom/npaw/youbora/youboralib/com/Request;", "GetSetFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_Handler")]
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Com.Request SetFailureListener (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnFailureListener p0)
		{
			if (id_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_ == IntPtr.Zero)
				id_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_ = JNIEnv.GetMethodID (class_ref, "setFailureListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnFailureListener;)Lcom/npaw/youbora/youboralib/com/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Npaw.Youbora.Youboralib.Com.Request __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFailureListener_Lcom_npaw_youbora_youboralib_com_Request_OnFailureListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFailureListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnFailureListener;)Lcom/npaw/youbora/youboralib/com/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setParam_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetParam_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setParam_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setParam_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetParam_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setParam_Ljava_lang_String_Ljava_lang_Object_;
		}

		static IntPtr n_SetParam_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetParam (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setParam_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='setParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setParam", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/npaw/youbora/youboralib/com/Request;", "GetSetParam_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Com.Request SetParam (string p0, global::Java.Lang.Object p1)
		{
			if (id_setParam_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setParam_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setParam", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/npaw/youbora/youboralib/com/Request;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Npaw.Youbora.Youboralib.Com.Request __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setParam_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParam", "(Ljava/lang/String;Ljava/lang/Object;)Lcom/npaw/youbora/youboralib/com/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSetSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static IntPtr n_SetSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Request __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p0 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSuccessListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Request']/method[@name='setSuccessListener' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("setSuccessListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)Lcom/npaw/youbora/youboralib/com/Request;", "GetSetSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Com.Request SetSuccessListener (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p0)
		{
			if (id_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "setSuccessListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)Lcom/npaw/youbora/youboralib/com/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Npaw.Youbora.Youboralib.Com.Request __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSuccessListener_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuccessListener", "(Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)Lcom/npaw/youbora/youboralib/com/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

#region "Event implementation for Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener"
		public event EventHandler<global::Com.Npaw.Youbora.Youboralib.Com.Request.SuccessEventArgs> GlobalSuccess {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListenerImplementor>(
						ref weak_implementor___SetGlobalSuccessListener,
						__CreateIOnSuccessListenerImplementor,
						__v => GlobalSuccessListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListenerImplementor>(
						ref weak_implementor___SetGlobalSuccessListener,
						global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListenerImplementor.__IsEmpty,
						__v => GlobalSuccessListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetGlobalSuccessListener;

		global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListenerImplementor __CreateIOnSuccessListenerImplementor ()
		{
			return new global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListenerImplementor (this);
		}
#endregion
	}
}

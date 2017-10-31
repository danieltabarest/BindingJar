using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Com {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Communication", DoNotGenerateAcw=true)]
	public partial class Communication : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/interface[@name='Communication.ExtraOperationsListener']"
		[Register ("com/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener", "", "Com.Npaw.Youbora.Youboralib.Com.Communication/IExtraOperationsListenerInvoker")]
		public partial interface IExtraOperationsListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/interface[@name='Communication.ExtraOperationsListener']/method[@name='onExtraOperations' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("onExtraOperations", "(Ljava/util/Map;)V", "GetOnExtraOperations_Ljava_util_Map_Handler:Com.Npaw.Youbora.Youboralib.Com.Communication/IExtraOperationsListenerInvoker, BindingJar")]
			void OnExtraOperations (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0);

		}

		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener", DoNotGenerateAcw=true)]
		internal class IExtraOperationsListenerInvoker : global::Java.Lang.Object, IExtraOperationsListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IExtraOperationsListenerInvoker); }
			}

			IntPtr class_ref;

			public static IExtraOperationsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IExtraOperationsListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.npaw.youbora.youboralib.com.Communication.ExtraOperationsListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IExtraOperationsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onExtraOperations_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetOnExtraOperations_Ljava_util_Map_Handler ()
			{
				if (cb_onExtraOperations_Ljava_util_Map_ == null)
					cb_onExtraOperations_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnExtraOperations_Ljava_util_Map_);
				return cb_onExtraOperations_Ljava_util_Map_;
			}

			static void n_OnExtraOperations_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnExtraOperations (p0);
			}
#pragma warning restore 0169

			IntPtr id_onExtraOperations_Ljava_util_Map_;
			public unsafe void OnExtraOperations (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				if (id_onExtraOperations_Ljava_util_Map_ == IntPtr.Zero)
					id_onExtraOperations_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onExtraOperations", "(Ljava/util/Map;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onExtraOperations_Ljava_util_Map_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class ExtraOperationsEventArgs : global::System.EventArgs {

			public ExtraOperationsEventArgs (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				this.p0 = p0;
			}

			global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0;
			public global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/npaw/youbora/youboralib/com/Communication_ExtraOperationsListenerImplementor")]
		internal sealed partial class IExtraOperationsListenerImplementor : global::Java.Lang.Object, IExtraOperationsListener {

			object sender;

			public IExtraOperationsListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/npaw/youbora/youboralib/com/Communication_ExtraOperationsListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ExtraOperationsEventArgs> Handler;
#pragma warning restore 0649

			public void OnExtraOperations (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ExtraOperationsEventArgs (p0));
			}

			internal static bool __IsEmpty (IExtraOperationsListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/com/Communication", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Communication); }
		}

		protected Communication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/constructor[@name='Communication' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public unsafe Communication (string p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Communication)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Z)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Z == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getExtraOperationsListener;
#pragma warning disable 0169
		static Delegate GetGetExtraOperationsListenerHandler ()
		{
			if (cb_getExtraOperationsListener == null)
				cb_getExtraOperationsListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraOperationsListener);
			return cb_getExtraOperationsListener;
		}

		static IntPtr n_GetExtraOperationsListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtraOperationsListener);
		}
#pragma warning restore 0169

		static Delegate cb_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_;
#pragma warning disable 0169
		static Delegate GetSetExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_Handler ()
		{
			if (cb_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_ == null)
				cb_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_);
			return cb_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_;
		}

		static void n_SetExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener p0 = (global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtraOperationsListener = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtraOperationsListener;
		static IntPtr id_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener ExtraOperationsListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='getExtraOperationsListener' and count(parameter)=0]"
			[Register ("getExtraOperationsListener", "()Lcom/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener;", "GetGetExtraOperationsListenerHandler")]
			get {
				if (id_getExtraOperationsListener == IntPtr.Zero)
					id_getExtraOperationsListener = JNIEnv.GetMethodID (class_ref, "getExtraOperationsListener", "()Lcom/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtraOperationsListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtraOperationsListener", "()Lcom/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='setExtraOperationsListener' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.com.Communication.ExtraOperationsListener']]"
			[Register ("setExtraOperationsListener", "(Lcom/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener;)V", "GetSetExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_Handler")]
			set {
				if (id_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_ == IntPtr.Zero)
					id_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_ = JNIEnv.GetMethodID (class_ref, "setExtraOperationsListener", "(Lcom/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExtraOperationsListener_Lcom_npaw_youbora_youboralib_com_Communication_ExtraOperationsListener_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtraOperationsListener", "(Lcom/npaw/youbora/youboralib/com/Communication$ExtraOperationsListener;)V"), __args);
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
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Host = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHost;
		static IntPtr id_setHost_Ljava_lang_String_;
		public virtual unsafe string Host {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='getHost' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='setHost' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getPingTime;
#pragma warning disable 0169
		static Delegate GetGetPingTimeHandler ()
		{
			if (cb_getPingTime == null)
				cb_getPingTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPingTime);
			return cb_getPingTime;
		}

		static int n_GetPingTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PingTime;
		}
#pragma warning restore 0169

		static IntPtr id_getPingTime;
		public virtual unsafe int PingTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='getPingTime' and count(parameter)=0]"
			[Register ("getPingTime", "()I", "GetGetPingTimeHandler")]
			get {
				if (id_getPingTime == IntPtr.Zero)
					id_getPingTime = JNIEnv.GetMethodID (class_ref, "getPingTime", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPingTime);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPingTime", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getViewCode;
#pragma warning disable 0169
		static Delegate GetGetViewCodeHandler ()
		{
			if (cb_getViewCode == null)
				cb_getViewCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewCode);
			return cb_getViewCode;
		}

		static IntPtr n_GetViewCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ViewCode);
		}
#pragma warning restore 0169

		static IntPtr id_getViewCode;
		public virtual unsafe string ViewCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='getViewCode' and count(parameter)=0]"
			[Register ("getViewCode", "()Ljava/lang/String;", "GetGetViewCodeHandler")]
			get {
				if (id_getViewCode == IntPtr.Zero)
					id_getViewCode = JNIEnv.GetMethodID (class_ref, "getViewCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addPreloader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddPreloader_Ljava_lang_String_Handler ()
		{
			if (cb_addPreloader_Ljava_lang_String_ == null)
				cb_addPreloader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddPreloader_Ljava_lang_String_);
			return cb_addPreloader_Ljava_lang_String_;
		}

		static void n_AddPreloader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddPreloader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addPreloader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='addPreloader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addPreloader", "(Ljava/lang/String;)V", "GetAddPreloader_Ljava_lang_String_Handler")]
		public virtual unsafe void AddPreloader (string p0)
		{
			if (id_addPreloader_Ljava_lang_String_ == IntPtr.Zero)
				id_addPreloader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addPreloader", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addPreloader_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addPreloader", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addProtocol_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='addProtocol' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("addProtocol", "(Ljava/lang/String;Z)Ljava/lang/String;", "")]
		public static unsafe string AddProtocol (string p0, bool p1)
		{
			if (id_addProtocol_Ljava_lang_String_Z == IntPtr.Zero)
				id_addProtocol_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "addProtocol", "(Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_addProtocol_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasPreloader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasPreloader_Ljava_lang_String_Handler ()
		{
			if (cb_hasPreloader_Ljava_lang_String_ == null)
				cb_hasPreloader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_HasPreloader_Ljava_lang_String_);
			return cb_hasPreloader_Ljava_lang_String_;
		}

		static bool n_HasPreloader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasPreloader (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_hasPreloader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='hasPreloader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasPreloader", "(Ljava/lang/String;)Z", "GetHasPreloader_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasPreloader (string p0)
		{
			if (id_hasPreloader_Ljava_lang_String_ == IntPtr.Zero)
				id_hasPreloader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "hasPreloader", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPreloader_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasPreloader", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nextView_Z;
#pragma warning disable 0169
		static Delegate GetNextView_ZHandler ()
		{
			if (cb_nextView_Z == null)
				cb_nextView_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_NextView_Z);
			return cb_nextView_Z;
		}

		static IntPtr n_NextView_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_nextView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='nextView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("nextView", "(Z)Ljava/lang/String;", "GetNextView_ZHandler")]
		public virtual unsafe string NextView (bool p0)
		{
			if (id_nextView_Z == IntPtr.Zero)
				id_nextView_Z = JNIEnv.GetMethodID (class_ref, "nextView", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextView_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextView", "(Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nextView_C;
#pragma warning disable 0169
		static Delegate GetNextView_CHandler ()
		{
			if (cb_nextView_C == null)
				cb_nextView_C = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char, IntPtr>) n_NextView_C);
			return cb_nextView_C;
		}

		static IntPtr n_NextView_C (IntPtr jnienv, IntPtr native__this, char p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextView (p0));
		}
#pragma warning restore 0169

		static IntPtr id_nextView_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='nextView' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("nextView", "(C)Ljava/lang/String;", "GetNextView_CHandler")]
		public virtual unsafe string NextView (char p0)
		{
			if (id_nextView_C == IntPtr.Zero)
				id_nextView_C = JNIEnv.GetMethodID (class_ref, "nextView", "(C)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextView_C, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextView", "(C)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_receiveData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReceiveData_Ljava_lang_String_Handler ()
		{
			if (cb_receiveData_Ljava_lang_String_ == null)
				cb_receiveData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReceiveData_Ljava_lang_String_);
			return cb_receiveData_Ljava_lang_String_;
		}

		static void n_ReceiveData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReceiveData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_receiveData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='receiveData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("receiveData", "(Ljava/lang/String;)V", "GetReceiveData_Ljava_lang_String_Handler")]
		public virtual unsafe void ReceiveData (string p0)
		{
			if (id_receiveData_Ljava_lang_String_ == IntPtr.Zero)
				id_receiveData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "receiveData", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_receiveData_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "receiveData", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removePreloader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemovePreloader_Ljava_lang_String_Handler ()
		{
			if (cb_removePreloader_Ljava_lang_String_ == null)
				cb_removePreloader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemovePreloader_Ljava_lang_String_);
			return cb_removePreloader_Ljava_lang_String_;
		}

		static void n_RemovePreloader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemovePreloader (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removePreloader_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='removePreloader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removePreloader", "(Ljava/lang/String;)V", "GetRemovePreloader_Ljava_lang_String_Handler")]
		public virtual unsafe void RemovePreloader (string p0)
		{
			if (id_removePreloader_Ljava_lang_String_ == IntPtr.Zero)
				id_removePreloader_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removePreloader", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removePreloader_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removePreloader", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_removeProtocol_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='removeProtocol' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeProtocol", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string RemoveProtocol (string p0)
		{
			if (id_removeProtocol_Ljava_lang_String_ == IntPtr.Zero)
				id_removeProtocol_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeProtocol", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_removeProtocol_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_requestData_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetRequestData_Ljava_util_Map_Handler ()
		{
			if (cb_requestData_Ljava_util_Map_ == null)
				cb_requestData_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestData_Ljava_util_Map_);
			return cb_requestData_Ljava_util_Map_;
		}

		static void n_RequestData_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_requestData_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='requestData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("requestData", "(Ljava/util/Map;)V", "GetRequestData_Ljava_util_Map_Handler")]
		public virtual unsafe void RequestData (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_requestData_Ljava_util_Map_ == IntPtr.Zero)
				id_requestData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "requestData", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestData_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestData", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetRequestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RequestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_RequestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RequestData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='requestData' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("requestData", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetRequestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void RequestData (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "requestData", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestData_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestData", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p2 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendRequest (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='sendRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendRequest", "(Ljava/lang/String;Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendRequest (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p2)
		{
			if (id_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendRequest", "(Ljava/lang/String;Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendRequest_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendRequest", "(Ljava/lang/String;Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendService_Ljava_lang_String_Handler ()
		{
			if (cb_sendService_Ljava_lang_String_ == null)
				cb_sendService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendService_Ljava_lang_String_);
			return cb_sendService_Ljava_lang_String_;
		}

		static void n_SendService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendService (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendService_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='sendService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendService", "(Ljava/lang/String;)V", "GetSendService_Ljava_lang_String_Handler")]
		public virtual unsafe void SendService (string p0)
		{
			if (id_sendService_Ljava_lang_String_ == IntPtr.Zero)
				id_sendService_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendService", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendService_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendService", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Npaw.Youbora.Youboralib.Com.Communication __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p2 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendService (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.com']/class[@name='Communication']/method[@name='sendService' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendService", "(Ljava/lang/String;Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendService (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p2)
		{
			if (id_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendService", "(Ljava/lang/String;Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendService_Ljava_lang_String_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendService", "(Ljava/lang/String;Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

#region "Event implementation for Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener"
		public event EventHandler<global::Com.Npaw.Youbora.Youboralib.Com.Communication.ExtraOperationsEventArgs> ExtraOperations {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener, global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListenerImplementor>(
						ref weak_implementor___SetExtraOperationsListener,
						__CreateIExtraOperationsListenerImplementor,
						__v => ExtraOperationsListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListener, global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListenerImplementor>(
						ref weak_implementor___SetExtraOperationsListener,
						global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListenerImplementor.__IsEmpty,
						__v => ExtraOperationsListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetExtraOperationsListener;

		global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListenerImplementor __CreateIExtraOperationsListenerImplementor ()
		{
			return new global::Com.Npaw.Youbora.Youboralib.Com.Communication.IExtraOperationsListenerImplementor (this);
		}
#endregion
	}
}

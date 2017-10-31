using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKLog", DoNotGenerateAcw=true)]
	public partial class PKLog : global::Java.Lang.Object {


		static IntPtr tag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/field[@name='tag']"
		[Register ("tag")]
		public string Tag {
			get {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tag_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (tag_jfieldId == IntPtr.Zero)
					tag_jfieldId = JNIEnv.GetFieldID (class_ref, "tag", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tag_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PKLog$Level", DoNotGenerateAcw=true)]
		public sealed partial class Level : global::Java.Lang.Enum {


			static IntPtr debug_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/field[@name='debug']"
			[Register ("debug")]
			public static global::Com.Kaltura.Playkit.PKLog.Level Debug {
				get {
					if (debug_jfieldId == IntPtr.Zero)
						debug_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "debug", "Lcom/kaltura/playkit/PKLog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, debug_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/field[@name='error']"
			[Register ("error")]
			public static global::Com.Kaltura.Playkit.PKLog.Level Error {
				get {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "error", "Lcom/kaltura/playkit/PKLog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr info_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/field[@name='info']"
			[Register ("info")]
			public static global::Com.Kaltura.Playkit.PKLog.Level Info {
				get {
					if (info_jfieldId == IntPtr.Zero)
						info_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "info", "Lcom/kaltura/playkit/PKLog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, info_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr off_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/field[@name='off']"
			[Register ("off")]
			public static global::Com.Kaltura.Playkit.PKLog.Level Off {
				get {
					if (off_jfieldId == IntPtr.Zero)
						off_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "off", "Lcom/kaltura/playkit/PKLog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, off_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr verbose_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/field[@name='verbose']"
			[Register ("verbose")]
			public static global::Com.Kaltura.Playkit.PKLog.Level Verbose {
				get {
					if (verbose_jfieldId == IntPtr.Zero)
						verbose_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "verbose", "Lcom/kaltura/playkit/PKLog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, verbose_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr warn_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/field[@name='warn']"
			[Register ("warn")]
			public static global::Com.Kaltura.Playkit.PKLog.Level Warn {
				get {
					if (warn_jfieldId == IntPtr.Zero)
						warn_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "warn", "Lcom/kaltura/playkit/PKLog$Level;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, warn_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PKLog$Level", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Level); }
			}

			internal Level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKLog$Level;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PKLog.Level ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKLog$Level;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.PKLog.Level __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog.Level']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/PKLog$Level;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PKLog.Level[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/PKLog$Level;");
				try {
					return (global::Com.Kaltura.Playkit.PKLog.Level[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.PKLog.Level));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKLog", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKLog); }
		}

		protected PKLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_d_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.D (p0);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "GetD_Ljava_lang_String_Handler")]
		public virtual unsafe void D (string p0)
		{
			if (id_d_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_d_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_d_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetD_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void D (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "(Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_e_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.E (p0);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "GetE_Ljava_lang_String_Handler")]
		public virtual unsafe void E (string p0)
		{
			if (id_e_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_e_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void E (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "(Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKLog;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PKLog Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKLog;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.PKLog __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_i_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.I (p0);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "GetI_Ljava_lang_String_Handler")]
		public virtual unsafe void I (string p0)
		{
			if (id_i_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string p0, string p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_i_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_i_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetI_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void I (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "(Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setGlobalLevel_Lcom_kaltura_playkit_PKLog_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='setGlobalLevel' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKLog.Level']]"
		[Register ("setGlobalLevel", "(Lcom/kaltura/playkit/PKLog$Level;)V", "")]
		public static unsafe void SetGlobalLevel (global::Com.Kaltura.Playkit.PKLog.Level p0)
		{
			if (id_setGlobalLevel_Lcom_kaltura_playkit_PKLog_Level_ == IntPtr.Zero)
				id_setGlobalLevel_Lcom_kaltura_playkit_PKLog_Level_ = JNIEnv.GetStaticMethodID (class_ref, "setGlobalLevel", "(Lcom/kaltura/playkit/PKLog$Level;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setGlobalLevel_Lcom_kaltura_playkit_PKLog_Level_, __args);
			} finally {
			}
		}

		static Delegate cb_setLevel_Lcom_kaltura_playkit_PKLog_Level_;
#pragma warning disable 0169
		static Delegate GetSetLevel_Lcom_kaltura_playkit_PKLog_Level_Handler ()
		{
			if (cb_setLevel_Lcom_kaltura_playkit_PKLog_Level_ == null)
				cb_setLevel_Lcom_kaltura_playkit_PKLog_Level_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLevel_Lcom_kaltura_playkit_PKLog_Level_);
			return cb_setLevel_Lcom_kaltura_playkit_PKLog_Level_;
		}

		static void n_SetLevel_Lcom_kaltura_playkit_PKLog_Level_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKLog.Level p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog.Level> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLevel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLevel_Lcom_kaltura_playkit_PKLog_Level_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKLog.Level']]"
		[Register ("setLevel", "(Lcom/kaltura/playkit/PKLog$Level;)V", "GetSetLevel_Lcom_kaltura_playkit_PKLog_Level_Handler")]
		public virtual unsafe void SetLevel (global::Com.Kaltura.Playkit.PKLog.Level p0)
		{
			if (id_setLevel_Lcom_kaltura_playkit_PKLog_Level_ == IntPtr.Zero)
				id_setLevel_Lcom_kaltura_playkit_PKLog_Level_ = JNIEnv.GetMethodID (class_ref, "setLevel", "(Lcom/kaltura/playkit/PKLog$Level;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLevel_Lcom_kaltura_playkit_PKLog_Level_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLevel", "(Lcom/kaltura/playkit/PKLog$Level;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_v_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Handler ()
		{
			if (cb_v_Ljava_lang_String_ == null)
				cb_v_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_);
			return cb_v_Ljava_lang_String_;
		}

		static void n_V_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.V (p0);
		}
#pragma warning restore 0169

		static IntPtr id_v_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "GetV_Ljava_lang_String_Handler")]
		public virtual unsafe void V (string p0)
		{
			if (id_v_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_v_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "v", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void V (string p0, string p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_v_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_v_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.V (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetV_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void V (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_v_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "v", "(Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_w_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.W (p0);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "GetW_Ljava_lang_String_Handler")]
		public virtual unsafe void W (string p0)
		{
			if (id_w_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_w_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "w", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string p0, string p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_w_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_w_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.PKLog __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKLog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetW_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void W (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_w_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "w", "(Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/Assert", DoNotGenerateAcw=true)]
	public partial class Assert : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/Assert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Assert); }
		}

		protected Assert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/constructor[@name='Assert' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Assert ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Assert)) {
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

		static IntPtr id_checkArgument_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkArgument", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkArgument_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/method[@name='checkNotEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotEmpty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string CheckNotEmpty (string p0, global::Java.Lang.Object p1)
		{
			if (id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotEmpty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkState_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkState", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkState_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_failState_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/method[@name='failState' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("failState", "(Ljava/lang/Object;)V", "")]
		public static unsafe void FailState (global::Java.Lang.Object p0)
		{
			if (id_failState_Ljava_lang_Object_ == IntPtr.Zero)
				id_failState_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "failState", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_failState_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_shouldNeverHappen;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='Assert']/method[@name='shouldNeverHappen' and count(parameter)=0]"
		[Register ("shouldNeverHappen", "()V", "")]
		public static unsafe void ShouldNeverHappen ()
		{
			if (id_shouldNeverHappen == IntPtr.Zero)
				id_shouldNeverHappen = JNIEnv.GetStaticMethodID (class_ref, "shouldNeverHappen", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_shouldNeverHappen);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/utils/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/utils/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Utils)) {
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

		static IntPtr id_buildRenditionString_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Utils']/method[@name='buildRenditionString' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("buildRenditionString", "(D)Ljava/lang/String;", "")]
		public static unsafe string BuildRenditionString (double p0)
		{
			if (id_buildRenditionString_D == IntPtr.Zero)
				id_buildRenditionString_D = JNIEnv.GetStaticMethodID (class_ref, "buildRenditionString", "(D)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildRenditionString_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_buildRenditionString_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Utils']/method[@name='buildRenditionString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("buildRenditionString", "(II)Ljava/lang/String;", "")]
		public static unsafe string BuildRenditionString (int p0, int p1)
		{
			if (id_buildRenditionString_II == IntPtr.Zero)
				id_buildRenditionString_II = JNIEnv.GetStaticMethodID (class_ref, "buildRenditionString", "(II)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildRenditionString_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_buildRenditionString_IID;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Utils']/method[@name='buildRenditionString' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double']]"
		[Register ("buildRenditionString", "(IID)Ljava/lang/String;", "")]
		public static unsafe string BuildRenditionString (int p0, int p1, double p2)
		{
			if (id_buildRenditionString_IID == IntPtr.Zero)
				id_buildRenditionString_IID = JNIEnv.GetStaticMethodID (class_ref, "buildRenditionString", "(IID)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildRenditionString_IID, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

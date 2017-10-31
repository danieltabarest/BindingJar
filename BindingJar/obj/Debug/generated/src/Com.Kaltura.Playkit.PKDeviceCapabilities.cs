using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDeviceCapabilities']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKDeviceCapabilities", DoNotGenerateAcw=true)]
	public partial class PKDeviceCapabilities : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKDeviceCapabilities", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKDeviceCapabilities); }
		}

		protected PKDeviceCapabilities (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getReport_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDeviceCapabilities']/method[@name='getReport' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getReport", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetReport (global::Android.Content.Context p0)
		{
			if (id_getReport_Landroid_content_Context_ == IntPtr.Zero)
				id_getReport_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getReport", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getReport_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}

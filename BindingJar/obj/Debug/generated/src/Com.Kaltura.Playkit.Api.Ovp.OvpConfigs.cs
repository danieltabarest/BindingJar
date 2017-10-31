using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Ovp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='OvpConfigs']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/OvpConfigs", DoNotGenerateAcw=true)]
	public partial class OvpConfigs : global::Java.Lang.Object {


		static IntPtr ApiPrefix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='OvpConfigs']/field[@name='ApiPrefix']"
		[Register ("ApiPrefix")]
		public static string ApiPrefix {
			get {
				if (ApiPrefix_jfieldId == IntPtr.Zero)
					ApiPrefix_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ApiPrefix", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ApiPrefix_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ApiPrefix_jfieldId == IntPtr.Zero)
					ApiPrefix_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ApiPrefix", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ApiPrefix_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ApiVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='OvpConfigs']/field[@name='ApiVersion']"
		[Register ("ApiVersion")]
		public static string ApiVersion {
			get {
				if (ApiVersion_jfieldId == IntPtr.Zero)
					ApiVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ApiVersion", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ApiVersion_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ApiVersion_jfieldId == IntPtr.Zero)
					ApiVersion_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ApiVersion", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ApiVersion_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='OvpConfigs']/field[@name='DefaultHttpProtocol']"
		[Register ("DefaultHttpProtocol")]
		public const string DefaultHttpProtocol = (string) "http";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/OvpConfigs", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OvpConfigs); }
		}

		protected OvpConfigs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='OvpConfigs']/constructor[@name='OvpConfigs' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OvpConfigs ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OvpConfigs)) {
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

	}
}

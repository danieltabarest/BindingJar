using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Drm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DeviceUuidFactory']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/drm/DeviceUuidFactory", DoNotGenerateAcw=true)]
	public partial class DeviceUuidFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DeviceUuidFactory']/field[@name='PREFS_DEVICE_ID']"
		[Register ("PREFS_DEVICE_ID")]
		protected const string PrefsDeviceId = (string) "device_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DeviceUuidFactory']/field[@name='PREFS_FILE']"
		[Register ("PREFS_FILE")]
		protected const string PrefsFile = (string) "device_id.xml";

		static IntPtr uuid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DeviceUuidFactory']/field[@name='uuid']"
		[Register ("uuid")]
		protected static global::Java.Util.UUID Uuid {
			get {
				if (uuid_jfieldId == IntPtr.Zero)
					uuid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "uuid", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, uuid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (uuid_jfieldId == IntPtr.Zero)
					uuid_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "uuid", "Ljava/util/UUID;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, uuid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/drm/DeviceUuidFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DeviceUuidFactory); }
		}

		protected DeviceUuidFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DeviceUuidFactory']/constructor[@name='DeviceUuidFactory' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DeviceUuidFactory (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (DeviceUuidFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getDeviceUuid;
#pragma warning disable 0169
		static Delegate GetGetDeviceUuidHandler ()
		{
			if (cb_getDeviceUuid == null)
				cb_getDeviceUuid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceUuid);
			return cb_getDeviceUuid;
		}

		static IntPtr n_GetDeviceUuid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Drm.DeviceUuidFactory __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DeviceUuidFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceUuid);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceUuid;
		public virtual unsafe global::Java.Util.UUID DeviceUuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DeviceUuidFactory']/method[@name='getDeviceUuid' and count(parameter)=0]"
			[Register ("getDeviceUuid", "()Ljava/util/UUID;", "GetGetDeviceUuidHandler")]
			get {
				if (id_getDeviceUuid == IntPtr.Zero)
					id_getDeviceUuid = JNIEnv.GetMethodID (class_ref, "getDeviceUuid", "()Ljava/util/UUID;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceUuid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceUuid", "()Ljava/util/UUID;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

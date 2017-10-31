using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PlayKitManager", DoNotGenerateAcw=true)]
	public partial class PlayKitManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']/field[@name='CLIENT_TAG']"
		[Register ("CLIENT_TAG")]
		public const string ClientTag = (string) "playkit/android-dev.";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']/field[@name='VERSION_STRING']"
		[Register ("VERSION_STRING")]
		public const string VersionString = (string) "dev.";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PlayKitManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayKitManager); }
		}

		protected PlayKitManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']/constructor[@name='PlayKitManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PlayKitManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PlayKitManager)) {
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

		static IntPtr id_disableDeviceCapabilitiesReport;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']/method[@name='disableDeviceCapabilitiesReport' and count(parameter)=0]"
		[Register ("disableDeviceCapabilitiesReport", "()V", "")]
		public static unsafe void DisableDeviceCapabilitiesReport ()
		{
			if (id_disableDeviceCapabilitiesReport == IntPtr.Zero)
				id_disableDeviceCapabilitiesReport = JNIEnv.GetStaticMethodID (class_ref, "disableDeviceCapabilitiesReport", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disableDeviceCapabilitiesReport);
			} finally {
			}
		}

		static IntPtr id_loadPlayer_Landroid_content_Context_Lcom_kaltura_playkit_PKPluginConfigs_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']/method[@name='loadPlayer' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.kaltura.playkit.PKPluginConfigs']]"
		[Register ("loadPlayer", "(Landroid/content/Context;Lcom/kaltura/playkit/PKPluginConfigs;)Lcom/kaltura/playkit/Player;", "")]
		public static unsafe global::Com.Kaltura.Playkit.IPlayer LoadPlayer (global::Android.Content.Context p0, global::Com.Kaltura.Playkit.PKPluginConfigs p1)
		{
			if (id_loadPlayer_Landroid_content_Context_Lcom_kaltura_playkit_PKPluginConfigs_ == IntPtr.Zero)
				id_loadPlayer_Landroid_content_Context_Lcom_kaltura_playkit_PKPluginConfigs_ = JNIEnv.GetStaticMethodID (class_ref, "loadPlayer", "(Landroid/content/Context;Lcom/kaltura/playkit/PKPluginConfigs;)Lcom/kaltura/playkit/Player;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Kaltura.Playkit.IPlayer __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadPlayer_Landroid_content_Context_Lcom_kaltura_playkit_PKPluginConfigs_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_registerPlugins_Landroid_content_Context_arrayLcom_kaltura_playkit_PKPlugin_Factory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayKitManager']/method[@name='registerPlugins' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.kaltura.playkit.PKPlugin.Factory...']]"
		[Register ("registerPlugins", "(Landroid/content/Context;[Lcom/kaltura/playkit/PKPlugin$Factory;)V", "")]
		public static unsafe void RegisterPlugins (global::Android.Content.Context p0, params global:: Com.Kaltura.Playkit.PKPlugin.IFactory[] p1)
		{
			if (id_registerPlugins_Landroid_content_Context_arrayLcom_kaltura_playkit_PKPlugin_Factory_ == IntPtr.Zero)
				id_registerPlugins_Landroid_content_Context_arrayLcom_kaltura_playkit_PKPlugin_Factory_ = JNIEnv.GetStaticMethodID (class_ref, "registerPlugins", "(Landroid/content/Context;[Lcom/kaltura/playkit/PKPlugin$Factory;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerPlugins_Landroid_content_Context_arrayLcom_kaltura_playkit_PKPlugin_Factory_, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}

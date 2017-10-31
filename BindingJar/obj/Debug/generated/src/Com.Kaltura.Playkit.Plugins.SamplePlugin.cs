using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/SamplePlugin", DoNotGenerateAcw=true)]
	public partial class SamplePlugin : global::Com.Kaltura.Playkit.PKPlugin {


		static IntPtr factory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/field[@name='factory']"
		[Register ("factory")]
		public static global::Com.Kaltura.Playkit.PKPlugin.IFactory Factory {
			get {
				if (factory_jfieldId == IntPtr.Zero)
					factory_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "factory", "Lcom/kaltura/playkit/PKPlugin$Factory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, factory_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin.IFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/SamplePlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SamplePlugin); }
		}

		protected SamplePlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/constructor[@name='SamplePlugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SamplePlugin ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SamplePlugin)) {
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

		static Delegate cb_onApplicationPaused;
#pragma warning disable 0169
		static Delegate GetOnApplicationPausedHandler ()
		{
			if (cb_onApplicationPaused == null)
				cb_onApplicationPaused = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnApplicationPaused);
			return cb_onApplicationPaused;
		}

		static void n_OnApplicationPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.SamplePlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.SamplePlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationPaused ();
		}
#pragma warning restore 0169

		static IntPtr id_onApplicationPaused;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/method[@name='onApplicationPaused' and count(parameter)=0]"
		[Register ("onApplicationPaused", "()V", "GetOnApplicationPausedHandler")]
		protected override unsafe void OnApplicationPaused ()
		{
			if (id_onApplicationPaused == IntPtr.Zero)
				id_onApplicationPaused = JNIEnv.GetMethodID (class_ref, "onApplicationPaused", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationPaused);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onApplicationPaused", "()V"));
			} finally {
			}
		}

		static Delegate cb_onApplicationResumed;
#pragma warning disable 0169
		static Delegate GetOnApplicationResumedHandler ()
		{
			if (cb_onApplicationResumed == null)
				cb_onApplicationResumed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnApplicationResumed);
			return cb_onApplicationResumed;
		}

		static void n_OnApplicationResumed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.SamplePlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.SamplePlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationResumed ();
		}
#pragma warning restore 0169

		static IntPtr id_onApplicationResumed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/method[@name='onApplicationResumed' and count(parameter)=0]"
		[Register ("onApplicationResumed", "()V", "GetOnApplicationResumedHandler")]
		protected override unsafe void OnApplicationResumed ()
		{
			if (id_onApplicationResumed == IntPtr.Zero)
				id_onApplicationResumed = JNIEnv.GetMethodID (class_ref, "onApplicationResumed", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationResumed);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onApplicationResumed", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.SamplePlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.SamplePlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
        protected override unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_Handler ()
		{
			if (cb_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_ == null)
				cb_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_);
			return cb_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_;
		}

		static void n_OnLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Kaltura.Playkit.Plugins.SamplePlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.SamplePlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPlayer p0 = (global::Com.Kaltura.Playkit.IPlayer)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.MessageBus p2 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.MessageBus> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/method[@name='onLoad' and count(parameter)=4 and parameter[1][@type='com.kaltura.playkit.Player'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.kaltura.playkit.MessageBus'] and parameter[4][@type='android.content.Context']]"
		[Register ("onLoad", "(Lcom/kaltura/playkit/Player;Ljava/lang/Object;Lcom/kaltura/playkit/MessageBus;Landroid/content/Context;)V", "GetOnLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_Handler")]
		protected override unsafe void OnLoad (global::Com.Kaltura.Playkit.IPlayer p0, global::Java.Lang.Object p1, global::Com.Kaltura.Playkit.MessageBus p2, global::Android.Content.Context p3)
		{
			if (id_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_ == IntPtr.Zero)
				id_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "onLoad", "(Lcom/kaltura/playkit/Player;Ljava/lang/Object;Lcom/kaltura/playkit/MessageBus;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLoad", "(Lcom/kaltura/playkit/Player;Ljava/lang/Object;Lcom/kaltura/playkit/MessageBus;Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUpdateConfig_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnUpdateConfig_Ljava_lang_Object_Handler ()
		{
			if (cb_onUpdateConfig_Ljava_lang_Object_ == null)
				cb_onUpdateConfig_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateConfig_Ljava_lang_Object_);
			return cb_onUpdateConfig_Ljava_lang_Object_;
		}

		static void n_OnUpdateConfig_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.SamplePlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.SamplePlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateConfig (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUpdateConfig_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/method[@name='onUpdateConfig' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onUpdateConfig", "(Ljava/lang/Object;)V", "GetOnUpdateConfig_Ljava_lang_Object_Handler")]
		protected override unsafe void OnUpdateConfig (global::Java.Lang.Object p0)
		{
			if (id_onUpdateConfig_Ljava_lang_Object_ == IntPtr.Zero)
				id_onUpdateConfig_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onUpdateConfig", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateConfig_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpdateConfig", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_;
#pragma warning disable 0169
		static Delegate GetOnUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_Handler ()
		{
			if (cb_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ == null)
				cb_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_);
			return cb_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_;
		}

		static void n_OnUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Plugins.SamplePlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.SamplePlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateMedia (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins']/class[@name='SamplePlugin']/method[@name='onUpdateMedia' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("onUpdateMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetOnUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_Handler")]
		protected override unsafe void OnUpdateMedia (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "onUpdateMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onUpdateMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)V"), __args);
			} finally {
			}
		}

      
    }
}

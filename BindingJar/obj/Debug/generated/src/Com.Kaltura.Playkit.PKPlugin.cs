using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKPlugin", DoNotGenerateAcw=true)]
	public abstract partial class PKPlugin : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKPlugin.Factory']"
		[Register ("com/kaltura/playkit/PKPlugin$Factory", "", "Com.Kaltura.Playkit.PKPlugin/IFactoryInvoker")]
		public partial interface IFactory : IJavaObject {

			string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKPlugin.Factory']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Kaltura.Playkit.PKPlugin/IFactoryInvoker, BindingJar")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKPlugin.Factory']/method[@name='newInstance' and count(parameter)=0]"
			[Register ("newInstance", "()Lcom/kaltura/playkit/PKPlugin;", "GetNewInstanceHandler:Com.Kaltura.Playkit.PKPlugin/IFactoryInvoker, BindingJar")]
			global::Com.Kaltura.Playkit.PKPlugin NewInstance ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKPlugin.Factory']/method[@name='warmUp' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register ("warmUp", "(Landroid/content/Context;)V", "GetWarmUp_Landroid_content_Context_Handler:Com.Kaltura.Playkit.PKPlugin/IFactoryInvoker, BindingJar")]
			void WarmUp (global::Android.Content.Context p0);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/PKPlugin$Factory", DoNotGenerateAcw=true)]
		internal class IFactoryInvoker : global::Java.Lang.Object, IFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/PKPlugin$Factory");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFactoryInvoker); }
			}

			IntPtr class_ref;

			public static IFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.PKPlugin.Factory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getName;
#pragma warning disable 0169
			static Delegate GetGetNameHandler ()
			{
				if (cb_getName == null)
					cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
				return cb_getName;
			}

			static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Kaltura.Playkit.PKPlugin.IFactory __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin.IFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Name);
			}
#pragma warning restore 0169

			IntPtr id_getName;
			public unsafe string Name {
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				}
			}

			static Delegate cb_newInstance;
#pragma warning disable 0169
			static Delegate GetNewInstanceHandler ()
			{
				if (cb_newInstance == null)
					cb_newInstance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewInstance);
				return cb_newInstance;
			}

			static IntPtr n_NewInstance (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Kaltura.Playkit.PKPlugin.IFactory __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin.IFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NewInstance ());
			}
#pragma warning restore 0169

			IntPtr id_newInstance;
			public unsafe global::Com.Kaltura.Playkit.PKPlugin NewInstance ()
			{
				if (id_newInstance == IntPtr.Zero)
					id_newInstance = JNIEnv.GetMethodID (class_ref, "newInstance", "()Lcom/kaltura/playkit/PKPlugin;");
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newInstance), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_warmUp_Landroid_content_Context_;
#pragma warning disable 0169
			static Delegate GetWarmUp_Landroid_content_Context_Handler ()
			{
				if (cb_warmUp_Landroid_content_Context_ == null)
					cb_warmUp_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WarmUp_Landroid_content_Context_);
				return cb_warmUp_Landroid_content_Context_;
			}

			static void n_WarmUp_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.PKPlugin.IFactory __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin.IFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.WarmUp (p0);
			}
#pragma warning restore 0169

			IntPtr id_warmUp_Landroid_content_Context_;
			public unsafe void WarmUp (global::Android.Content.Context p0)
			{
				if (id_warmUp_Landroid_content_Context_ == IntPtr.Zero)
					id_warmUp_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "warmUp", "(Landroid/content/Context;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warmUp_Landroid_content_Context_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKPlugin", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKPlugin); }
		}

		protected PKPlugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/constructor[@name='PKPlugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKPlugin ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PKPlugin)) {
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

		static Delegate cb_getPlayerDecorator;
#pragma warning disable 0169
		static Delegate GetGetPlayerDecoratorHandler ()
		{
			if (cb_getPlayerDecorator == null)
				cb_getPlayerDecorator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerDecorator);
			return cb_getPlayerDecorator;
		}

		static IntPtr n_GetPlayerDecorator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlayerDecorator);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerDecorator;
		protected virtual unsafe global::Com.Kaltura.Playkit.PlayerDecorator PlayerDecorator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='getPlayerDecorator' and count(parameter)=0]"
			[Register ("getPlayerDecorator", "()Lcom/kaltura/playkit/PlayerDecorator;", "GetGetPlayerDecoratorHandler")]
			get {
				if (id_getPlayerDecorator == IntPtr.Zero)
					id_getPlayerDecorator = JNIEnv.GetMethodID (class_ref, "getPlayerDecorator", "()Lcom/kaltura/playkit/PlayerDecorator;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerDecorator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayerDecorator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerDecorator> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayerDecorator", "()Lcom/kaltura/playkit/PlayerDecorator;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationPaused ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onApplicationPaused' and count(parameter)=0]"
		[Register ("onApplicationPaused", "()V", "GetOnApplicationPausedHandler")]
		protected abstract void OnApplicationPaused ();

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
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationResumed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onApplicationResumed' and count(parameter)=0]"
		[Register ("onApplicationResumed", "()V", "GetOnApplicationResumedHandler")]
		protected abstract void OnApplicationResumed ();

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
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		protected abstract void OnDestroy ();

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
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPlayer p0 = (global::Com.Kaltura.Playkit.IPlayer)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.MessageBus p2 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.MessageBus> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnLoad (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onLoad' and count(parameter)=4 and parameter[1][@type='com.kaltura.playkit.Player'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.kaltura.playkit.MessageBus'] and parameter[4][@type='android.content.Context']]"
		[Register ("onLoad", "(Lcom/kaltura/playkit/Player;Ljava/lang/Object;Lcom/kaltura/playkit/MessageBus;Landroid/content/Context;)V", "GetOnLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_Handler")]
		protected abstract void OnLoad (global::Com.Kaltura.Playkit.IPlayer p0, global::Java.Lang.Object p1, global::Com.Kaltura.Playkit.MessageBus p2, global::Android.Content.Context p3);

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
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateConfig (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onUpdateConfig' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onUpdateConfig", "(Ljava/lang/Object;)V", "GetOnUpdateConfig_Ljava_lang_Object_Handler")]
		protected abstract void OnUpdateConfig (global::Java.Lang.Object p0);

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
			global::Com.Kaltura.Playkit.PKPlugin __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaConfig p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaConfig> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateMedia (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onUpdateMedia' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("onUpdateMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetOnUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_Handler")]
		protected abstract void OnUpdateMedia (global::Com.Kaltura.Playkit.PKMediaConfig p0);

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/PKPlugin", DoNotGenerateAcw=true)]
	internal partial class PKPluginInvoker : PKPlugin {

		public PKPluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKPluginInvoker); }
		}

		static IntPtr id_onApplicationPaused;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onApplicationPaused' and count(parameter)=0]"
		[Register ("onApplicationPaused", "()V", "GetOnApplicationPausedHandler")]
		protected override unsafe void OnApplicationPaused ()
		{
			if (id_onApplicationPaused == IntPtr.Zero)
				id_onApplicationPaused = JNIEnv.GetMethodID (class_ref, "onApplicationPaused", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationPaused);
			} finally {
			}
		}

		static IntPtr id_onApplicationResumed;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onApplicationResumed' and count(parameter)=0]"
		[Register ("onApplicationResumed", "()V", "GetOnApplicationResumedHandler")]
		protected override unsafe void OnApplicationResumed ()
		{
			if (id_onApplicationResumed == IntPtr.Zero)
				id_onApplicationResumed = JNIEnv.GetMethodID (class_ref, "onApplicationResumed", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationResumed);
			} finally {
			}
		}

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		protected override unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
			} finally {
			}
		}

		static IntPtr id_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onLoad' and count(parameter)=4 and parameter[1][@type='com.kaltura.playkit.Player'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.kaltura.playkit.MessageBus'] and parameter[4][@type='android.content.Context']]"
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
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoad_Lcom_kaltura_playkit_Player_Ljava_lang_Object_Lcom_kaltura_playkit_MessageBus_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_onUpdateConfig_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onUpdateConfig' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("onUpdateConfig", "(Ljava/lang/Object;)V", "GetOnUpdateConfig_Ljava_lang_Object_Handler")]
		protected override unsafe void OnUpdateConfig (global::Java.Lang.Object p0)
		{
			if (id_onUpdateConfig_Ljava_lang_Object_ == IntPtr.Zero)
				id_onUpdateConfig_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onUpdateConfig", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateConfig_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKPlugin']/method[@name='onUpdateMedia' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaConfig']]"
		[Register ("onUpdateMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)V", "GetOnUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_Handler")]
		protected override unsafe void OnUpdateMedia (global::Com.Kaltura.Playkit.PKMediaConfig p0)
		{
			if (id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ == IntPtr.Zero)
				id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_ = JNIEnv.GetMethodID (class_ref, "onUpdateMedia", "(Lcom/kaltura/playkit/PKMediaConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateMedia_Lcom_kaltura_playkit_PKMediaConfig_, __args);
			} finally {
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/LocalAssetsManager", DoNotGenerateAcw=true)]
	public partial class LocalAssetsManager : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetRegistrationListener']"
		[Register ("com/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener", "", "Com.Kaltura.Playkit.LocalAssetsManager/IAssetRegistrationListenerInvoker")]
		public partial interface IAssetRegistrationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetRegistrationListener']/method[@name='onFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onFailed", "(Ljava/lang/String;Ljava/lang/Exception;)V", "GetOnFailed_Ljava_lang_String_Ljava_lang_Exception_Handler:Com.Kaltura.Playkit.LocalAssetsManager/IAssetRegistrationListenerInvoker, BindingJar")]
			void OnFailed (string p0, global::Java.Lang.Exception p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetRegistrationListener']/method[@name='onRegistered' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onRegistered", "(Ljava/lang/String;)V", "GetOnRegistered_Ljava_lang_String_Handler:Com.Kaltura.Playkit.LocalAssetsManager/IAssetRegistrationListenerInvoker, BindingJar")]
			void OnRegistered (string p0);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener", DoNotGenerateAcw=true)]
		internal class IAssetRegistrationListenerInvoker : global::Java.Lang.Object, IAssetRegistrationListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAssetRegistrationListenerInvoker); }
			}

			IntPtr class_ref;

			public static IAssetRegistrationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAssetRegistrationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAssetRegistrationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFailed_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnFailed_Ljava_lang_String_Ljava_lang_Exception_Handler ()
			{
				if (cb_onFailed_Ljava_lang_String_Ljava_lang_Exception_ == null)
					cb_onFailed_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailed_Ljava_lang_String_Ljava_lang_Exception_);
				return cb_onFailed_Ljava_lang_String_Ljava_lang_Exception_;
			}

			static void n_OnFailed_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFailed_Ljava_lang_String_Ljava_lang_Exception_;
			public unsafe void OnFailed (string p0, global::Java.Lang.Exception p1)
			{
				if (id_onFailed_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
					id_onFailed_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Ljava/lang/String;Ljava/lang/Exception;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Ljava_lang_String_Ljava_lang_Exception_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onRegistered_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRegistered_Ljava_lang_String_Handler ()
			{
				if (cb_onRegistered_Ljava_lang_String_ == null)
					cb_onRegistered_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRegistered_Ljava_lang_String_);
				return cb_onRegistered_Ljava_lang_String_;
			}

			static void n_OnRegistered_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRegistered (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRegistered_Ljava_lang_String_;
			public unsafe void OnRegistered (string p0)
			{
				if (id_onRegistered_Ljava_lang_String_ == IntPtr.Zero)
					id_onRegistered_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRegistered", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRegistered_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class FailedEventArgs : global::System.EventArgs {

			public FailedEventArgs (string p0, global::Java.Lang.Exception p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			global::Java.Lang.Exception p1;
			public global::Java.Lang.Exception P1 {
				get { return p1; }
			}
		}

		public partial class RegisteredEventArgs : global::System.EventArgs {

			public RegisteredEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/kaltura/playkit/LocalAssetsManager_AssetRegistrationListenerImplementor")]
		internal sealed partial class IAssetRegistrationListenerImplementor : global::Java.Lang.Object, IAssetRegistrationListener {

			object sender;

			public IAssetRegistrationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/LocalAssetsManager_AssetRegistrationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

			public void OnFailed (string p0, global::Java.Lang.Exception p1)
			{
				var __h = OnFailedHandler;
				if (__h != null)
					__h (sender, new FailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler<RegisteredEventArgs> OnRegisteredHandler;
#pragma warning restore 0649

			public void OnRegistered (string p0)
			{
				var __h = OnRegisteredHandler;
				if (__h != null)
					__h (sender, new RegisteredEventArgs (p0));
			}

			internal static bool __IsEmpty (IAssetRegistrationListenerImplementor value)
			{
				return value.OnFailedHandler == null && value.OnRegisteredHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetRemovalListener']"
		[Register ("com/kaltura/playkit/LocalAssetsManager$AssetRemovalListener", "", "Com.Kaltura.Playkit.LocalAssetsManager/IAssetRemovalListenerInvoker")]
		public partial interface IAssetRemovalListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetRemovalListener']/method[@name='onRemoved' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onRemoved", "(Ljava/lang/String;)V", "GetOnRemoved_Ljava_lang_String_Handler:Com.Kaltura.Playkit.LocalAssetsManager/IAssetRemovalListenerInvoker, BindingJar")]
			void OnRemoved (string p0);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/LocalAssetsManager$AssetRemovalListener", DoNotGenerateAcw=true)]
		internal class IAssetRemovalListenerInvoker : global::Java.Lang.Object, IAssetRemovalListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/LocalAssetsManager$AssetRemovalListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAssetRemovalListenerInvoker); }
			}

			IntPtr class_ref;

			public static IAssetRemovalListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAssetRemovalListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.LocalAssetsManager.AssetRemovalListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAssetRemovalListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onRemoved_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnRemoved_Ljava_lang_String_Handler ()
			{
				if (cb_onRemoved_Ljava_lang_String_ == null)
					cb_onRemoved_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRemoved_Ljava_lang_String_);
				return cb_onRemoved_Ljava_lang_String_;
			}

			static void n_OnRemoved_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnRemoved (p0);
			}
#pragma warning restore 0169

			IntPtr id_onRemoved_Ljava_lang_String_;
			public unsafe void OnRemoved (string p0)
			{
				if (id_onRemoved_Ljava_lang_String_ == IntPtr.Zero)
					id_onRemoved_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRemoved", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoved_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class AssetRemovalEventArgs : global::System.EventArgs {

			public AssetRemovalEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/kaltura/playkit/LocalAssetsManager_AssetRemovalListenerImplementor")]
		internal sealed partial class IAssetRemovalListenerImplementor : global::Java.Lang.Object, IAssetRemovalListener {

			object sender;

			public IAssetRemovalListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/LocalAssetsManager_AssetRemovalListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AssetRemovalEventArgs> Handler;
#pragma warning restore 0649

			public void OnRemoved (string p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AssetRemovalEventArgs (p0));
			}

			internal static bool __IsEmpty (IAssetRemovalListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetStatusListener']"
		[Register ("com/kaltura/playkit/LocalAssetsManager$AssetStatusListener", "", "Com.Kaltura.Playkit.LocalAssetsManager/IAssetStatusListenerInvoker")]
		public partial interface IAssetStatusListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalAssetsManager.AssetStatusListener']/method[@name='onStatus' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='boolean']]"
			[Register ("onStatus", "(Ljava/lang/String;JJZ)V", "GetOnStatus_Ljava_lang_String_JJZHandler:Com.Kaltura.Playkit.LocalAssetsManager/IAssetStatusListenerInvoker, BindingJar")]
			void OnStatus (string p0, long p1, long p2, bool p3);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/LocalAssetsManager$AssetStatusListener", DoNotGenerateAcw=true)]
		internal class IAssetStatusListenerInvoker : global::Java.Lang.Object, IAssetStatusListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/LocalAssetsManager$AssetStatusListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAssetStatusListenerInvoker); }
			}

			IntPtr class_ref;

			public static IAssetStatusListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAssetStatusListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.LocalAssetsManager.AssetStatusListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAssetStatusListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onStatus_Ljava_lang_String_JJZ;
#pragma warning disable 0169
			static Delegate GetOnStatus_Ljava_lang_String_JJZHandler ()
			{
				if (cb_onStatus_Ljava_lang_String_JJZ == null)
					cb_onStatus_Ljava_lang_String_JJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, bool>) n_OnStatus_Ljava_lang_String_JJZ);
				return cb_onStatus_Ljava_lang_String_JJZ;
			}

			static void n_OnStatus_Ljava_lang_String_JJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, bool p3)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnStatus (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_onStatus_Ljava_lang_String_JJZ;
			public unsafe void OnStatus (string p0, long p1, long p2, bool p3)
			{
				if (id_onStatus_Ljava_lang_String_JJZ == IntPtr.Zero)
					id_onStatus_Ljava_lang_String_JJZ = JNIEnv.GetMethodID (class_ref, "onStatus", "(Ljava/lang/String;JJZ)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStatus_Ljava_lang_String_JJZ, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class AssetStatusEventArgs : global::System.EventArgs {

			public AssetStatusEventArgs (string p0, long p1, long p2, bool p3)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
				this.p3 = p3;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}

			long p1;
			public long P1 {
				get { return p1; }
			}

			long p2;
			public long P2 {
				get { return p2; }
			}

			bool p3;
			public bool P3 {
				get { return p3; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/kaltura/playkit/LocalAssetsManager_AssetStatusListenerImplementor")]
		internal sealed partial class IAssetStatusListenerImplementor : global::Java.Lang.Object, IAssetStatusListener {

			object sender;

			public IAssetStatusListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/LocalAssetsManager_AssetStatusListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AssetStatusEventArgs> Handler;
#pragma warning restore 0649

			public void OnStatus (string p0, long p1, long p2, bool p3)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new AssetStatusEventArgs (p0, p1, p2, p3));
			}

			internal static bool __IsEmpty (IAssetStatusListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.DefaultLocalDataStore']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/LocalAssetsManager$DefaultLocalDataStore", DoNotGenerateAcw=true)]
		public partial class DefaultLocalDataStore : global::Java.Lang.Object, global::Com.Kaltura.Playkit.ILocalDataStore {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/LocalAssetsManager$DefaultLocalDataStore", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DefaultLocalDataStore); }
			}

			protected DefaultLocalDataStore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.DefaultLocalDataStore']/constructor[@name='LocalAssetsManager.DefaultLocalDataStore' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe DefaultLocalDataStore (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (DefaultLocalDataStore)) {
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

			static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetLoad_Ljava_lang_String_Handler ()
			{
				if (cb_load_Ljava_lang_String_ == null)
					cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
				return cb_load_Ljava_lang_String_;
			}

			static IntPtr n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.DefaultLocalDataStore __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.DefaultLocalDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewArray (__this.Load (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_load_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.DefaultLocalDataStore']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("load", "(Ljava/lang/String;)[B", "GetLoad_Ljava_lang_String_Handler")]
			public virtual unsafe byte[] Load (string p0)
			{
				if (id_load_Ljava_lang_String_ == IntPtr.Zero)
					id_load_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;)[B");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					byte[] __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					else
						__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "load", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetRemove_Ljava_lang_String_Handler ()
			{
				if (cb_remove_Ljava_lang_String_ == null)
					cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
				return cb_remove_Ljava_lang_String_;
			}

			static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.DefaultLocalDataStore __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.DefaultLocalDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Remove (p0);
			}
#pragma warning restore 0169

			static IntPtr id_remove_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.DefaultLocalDataStore']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler")]
			public virtual unsafe void Remove (string p0)
			{
				if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
					id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_save_Ljava_lang_String_arrayB;
#pragma warning disable 0169
			static Delegate GetSave_Ljava_lang_String_arrayBHandler ()
			{
				if (cb_save_Ljava_lang_String_arrayB == null)
					cb_save_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_arrayB);
				return cb_save_Ljava_lang_String_arrayB;
			}

			static void n_Save_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.DefaultLocalDataStore __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.DefaultLocalDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
				__this.Save (p0, p1);
				if (p1 != null)
					JNIEnv.CopyArray (p1, native_p1);
			}
#pragma warning restore 0169

			static IntPtr id_save_Ljava_lang_String_arrayB;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.DefaultLocalDataStore']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
			[Register ("save", "(Ljava/lang/String;[B)V", "GetSave_Ljava_lang_String_arrayBHandler")]
			public virtual unsafe void Save (string p0, byte[] p1)
			{
				if (id_save_Ljava_lang_String_arrayB == IntPtr.Zero)
					id_save_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;[B)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_arrayB, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "save", "(Ljava/lang/String;[B)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.LocalMediaSource']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/LocalAssetsManager$LocalMediaSource", DoNotGenerateAcw=true)]
		public partial class LocalMediaSource : global::Com.Kaltura.Playkit.PKMediaSource {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/LocalAssetsManager$LocalMediaSource", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocalMediaSource); }
			}

			protected LocalMediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getStorage;
#pragma warning disable 0169
			static Delegate GetGetStorageHandler ()
			{
				if (cb_getStorage == null)
					cb_getStorage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStorage);
				return cb_getStorage;
			}

			static IntPtr n_GetStorage (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Kaltura.Playkit.LocalAssetsManager.LocalMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.LocalMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Storage);
			}
#pragma warning restore 0169

			static IntPtr id_getStorage;
			public virtual unsafe global::Com.Kaltura.Playkit.ILocalDataStore Storage {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager.LocalMediaSource']/method[@name='getStorage' and count(parameter)=0]"
				[Register ("getStorage", "()Lcom/kaltura/playkit/LocalDataStore;", "GetGetStorageHandler")]
				get {
					if (id_getStorage == IntPtr.Zero)
						id_getStorage = JNIEnv.GetMethodID (class_ref, "getStorage", "()Lcom/kaltura/playkit/LocalDataStore;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.ILocalDataStore> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStorage), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.ILocalDataStore> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStorage", "()Lcom/kaltura/playkit/LocalDataStore;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/LocalAssetsManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocalAssetsManager); }
		}

		protected LocalAssetsManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']/constructor[@name='LocalAssetsManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe LocalAssetsManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (LocalAssetsManager)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']/constructor[@name='LocalAssetsManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.kaltura.playkit.LocalDataStore']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/kaltura/playkit/LocalDataStore;)V", "")]
		public unsafe LocalAssetsManager (global::Android.Content.Context p0, global::Com.Kaltura.Playkit.ILocalDataStore p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (LocalAssetsManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/kaltura/playkit/LocalDataStore;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/kaltura/playkit/LocalDataStore;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/kaltura/playkit/LocalDataStore;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_, __args);
			} finally {
			}
		}

		static Delegate cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
#pragma warning disable 0169
		static Delegate GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler ()
		{
			if (cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ == null)
				cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_);
			return cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
		}

		static void n_CheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Kaltura.Playkit.LocalAssetsManager __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CheckAssetStatus (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']/method[@name='checkAssetStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetStatusListener']]"
		[Register ("checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)V", "GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler")]
		public virtual unsafe void CheckAssetStatus (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2)
		{
			if (id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ == IntPtr.Zero)
				id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ = JNIEnv.GetMethodID (class_ref, "checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLocalMediaSource_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLocalMediaSource_Ljava_lang_String_Ljava_lang_String_);
			return cb_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetLocalMediaSource_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.LocalAssetsManager __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetLocalMediaSource (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']/method[@name='getLocalMediaSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLocalMediaSource", "(Ljava/lang/String;Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;", "GetGetLocalMediaSource_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaSource GetLocalMediaSource (string p0, string p1)
		{
			if (id_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLocalMediaSource", "(Ljava/lang/String;Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Kaltura.Playkit.PKMediaSource __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalMediaSource_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalMediaSource", "(Ljava/lang/String;Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
#pragma warning disable 0169
		static Delegate GetRegisterAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler ()
		{
			if (cb_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == null)
				cb_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_);
			return cb_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
		}

		static void n_RegisterAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Kaltura.Playkit.LocalAssetsManager __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaSource p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.RegisterAsset (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']/method[@name='registerAsset' and count(parameter)=4 and parameter[1][@type='com.kaltura.playkit.PKMediaSource'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
		[Register ("registerAsset", "(Lcom/kaltura/playkit/PKMediaSource;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)V", "GetRegisterAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
		public virtual unsafe void RegisterAsset (global::Com.Kaltura.Playkit.PKMediaSource p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3)
		{
			if (id_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == IntPtr.Zero)
				id_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNIEnv.GetMethodID (class_ref, "registerAsset", "(Lcom/kaltura/playkit/PKMediaSource;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerAsset_Lcom_kaltura_playkit_PKMediaSource_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerAsset", "(Lcom/kaltura/playkit/PKMediaSource;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler ()
		{
			if (cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ == null)
				cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_);
			return cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
		}

		static void n_UnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Kaltura.Playkit.LocalAssetsManager __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterAsset (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='LocalAssetsManager']/method[@name='unregisterAsset' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetRemovalListener']]"
		[Register ("unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)V", "GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler")]
		public virtual unsafe void UnregisterAsset (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2)
		{
			if (id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ == IntPtr.Zero)
				id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ = JNIEnv.GetMethodID (class_ref, "unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

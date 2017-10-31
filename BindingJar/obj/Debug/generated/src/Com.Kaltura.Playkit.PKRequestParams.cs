using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKRequestParams']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKRequestParams", DoNotGenerateAcw=true)]
	public partial class PKRequestParams : global::Java.Lang.Object {


		static IntPtr headers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKRequestParams']/field[@name='headers']"
		[Register ("headers")]
		public global::System.Collections.IDictionary Headers {
			get {
				if (headers_jfieldId == IntPtr.Zero)
					headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, headers_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headers_jfieldId == IntPtr.Zero)
					headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, headers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKRequestParams']/field[@name='url']"
		[Register ("url")]
		public global::Android.Net.Uri Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Landroid/net/Uri;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Landroid/net/Uri;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKRequestParams.Adapter']"
		[Register ("com/kaltura/playkit/PKRequestParams$Adapter", "", "Com.Kaltura.Playkit.PKRequestParams/IAdapterInvoker")]
		public partial interface IAdapter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKRequestParams.Adapter']/method[@name='adapt' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKRequestParams']]"
			[Register ("adapt", "(Lcom/kaltura/playkit/PKRequestParams;)Lcom/kaltura/playkit/PKRequestParams;", "GetAdapt_Lcom_kaltura_playkit_PKRequestParams_Handler:Com.Kaltura.Playkit.PKRequestParams/IAdapterInvoker, BindingJar")]
			global::Com.Kaltura.Playkit.PKRequestParams Adapt (global::Com.Kaltura.Playkit.PKRequestParams p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKRequestParams.Adapter']/method[@name='updateParams' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.Player']]"
			[Register ("updateParams", "(Lcom/kaltura/playkit/Player;)V", "GetUpdateParams_Lcom_kaltura_playkit_Player_Handler:Com.Kaltura.Playkit.PKRequestParams/IAdapterInvoker, BindingJar")]
			void UpdateParams (global::Com.Kaltura.Playkit.IPlayer p0);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/PKRequestParams$Adapter", DoNotGenerateAcw=true)]
		internal class IAdapterInvoker : global::Java.Lang.Object, IAdapter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/PKRequestParams$Adapter");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IAdapterInvoker); }
			}

			IntPtr class_ref;

			public static IAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAdapter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.PKRequestParams.Adapter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_adapt_Lcom_kaltura_playkit_PKRequestParams_;
#pragma warning disable 0169
			static Delegate GetAdapt_Lcom_kaltura_playkit_PKRequestParams_Handler ()
			{
				if (cb_adapt_Lcom_kaltura_playkit_PKRequestParams_ == null)
					cb_adapt_Lcom_kaltura_playkit_PKRequestParams_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Adapt_Lcom_kaltura_playkit_PKRequestParams_);
				return cb_adapt_Lcom_kaltura_playkit_PKRequestParams_;
			}

			static IntPtr n_Adapt_Lcom_kaltura_playkit_PKRequestParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.PKRequestParams.IAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams.IAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.PKRequestParams p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Adapt (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_adapt_Lcom_kaltura_playkit_PKRequestParams_;
			public unsafe global::Com.Kaltura.Playkit.PKRequestParams Adapt (global::Com.Kaltura.Playkit.PKRequestParams p0)
			{
				if (id_adapt_Lcom_kaltura_playkit_PKRequestParams_ == IntPtr.Zero)
					id_adapt_Lcom_kaltura_playkit_PKRequestParams_ = JNIEnv.GetMethodID (class_ref, "adapt", "(Lcom/kaltura/playkit/PKRequestParams;)Lcom/kaltura/playkit/PKRequestParams;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Kaltura.Playkit.PKRequestParams __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adapt_Lcom_kaltura_playkit_PKRequestParams_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

			static Delegate cb_updateParams_Lcom_kaltura_playkit_Player_;
#pragma warning disable 0169
			static Delegate GetUpdateParams_Lcom_kaltura_playkit_Player_Handler ()
			{
				if (cb_updateParams_Lcom_kaltura_playkit_Player_ == null)
					cb_updateParams_Lcom_kaltura_playkit_Player_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateParams_Lcom_kaltura_playkit_Player_);
				return cb_updateParams_Lcom_kaltura_playkit_Player_;
			}

			static void n_UpdateParams_Lcom_kaltura_playkit_Player_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.PKRequestParams.IAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKRequestParams.IAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.IPlayer p0 = (global::Com.Kaltura.Playkit.IPlayer)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.UpdateParams (p0);
			}
#pragma warning restore 0169

			IntPtr id_updateParams_Lcom_kaltura_playkit_Player_;
			public unsafe void UpdateParams (global::Com.Kaltura.Playkit.IPlayer p0)
			{
				if (id_updateParams_Lcom_kaltura_playkit_Player_ == IntPtr.Zero)
					id_updateParams_Lcom_kaltura_playkit_Player_ = JNIEnv.GetMethodID (class_ref, "updateParams", "(Lcom/kaltura/playkit/Player;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateParams_Lcom_kaltura_playkit_Player_, __args);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKRequestParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKRequestParams); }
		}

		protected PKRequestParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_net_Uri_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKRequestParams']/constructor[@name='PKRequestParams' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Landroid/net/Uri;Ljava/util/Map;)V", "")]
		public unsafe PKRequestParams (global::Android.Net.Uri p0, global::System.Collections.Generic.IDictionary<string, string> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (PKRequestParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/net/Uri;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/net/Uri;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Landroid_net_Uri_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Landroid_net_Uri_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/net/Uri;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_net_Uri_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_net_Uri_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}

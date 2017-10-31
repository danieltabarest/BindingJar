using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Drm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/drm/DrmAdapter", DoNotGenerateAcw=true)]
	public abstract partial class DrmAdapter : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter.NullDrmAdapter']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/drm/DrmAdapter$NullDrmAdapter", DoNotGenerateAcw=true)]
		public partial class NullDrmAdapter : global::Com.Kaltura.Playkit.Drm.DrmAdapter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/drm/DrmAdapter$NullDrmAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NullDrmAdapter); }
			}

			protected NullDrmAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
#pragma warning disable 0169
			static Delegate GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler ()
			{
				if (cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ == null)
					cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_);
				return cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
			}

			static bool n_CheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.CheckAssetStatus (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter.NullDrmAdapter']/method[@name='checkAssetStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetStatusListener']]"
			[Register ("checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)Z", "GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler")]
			public override unsafe bool CheckAssetStatus (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2)
			{
				if (id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ == IntPtr.Zero)
					id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ = JNIEnv.GetMethodID (class_ref, "checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			static Delegate cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
#pragma warning disable 0169
			static Delegate GetRefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler ()
			{
				if (cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == null)
					cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_);
				return cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
			}

			static bool n_RefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (native_p3, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RefreshAsset (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter.NullDrmAdapter']/method[@name='refreshAsset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
			[Register ("refreshAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z", "GetRefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
			public override unsafe bool RefreshAsset (string p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3)
			{
				if (id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == IntPtr.Zero)
					id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNIEnv.GetMethodID (class_ref, "refreshAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
#pragma warning disable 0169
			static Delegate GetRegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler ()
			{
				if (cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == null)
					cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_);
				return cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
			}

			static bool n_RegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
			{
				global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (native_p3, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.RegisterAsset (p0, p1, p2, p3);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter.NullDrmAdapter']/method[@name='registerAsset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
			[Register ("registerAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z", "GetRegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
			public override unsafe bool RegisterAsset (string p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3)
			{
				if (id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == IntPtr.Zero)
					id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNIEnv.GetMethodID (class_ref, "registerAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				try {
					JValue* __args = stackalloc JValue [4];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (p3);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}

			static Delegate cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
#pragma warning disable 0169
			static Delegate GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler ()
			{
				if (cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ == null)
					cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_);
				return cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
			}

			static bool n_UnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter.NullDrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener> (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.UnregisterAsset (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter.NullDrmAdapter']/method[@name='unregisterAsset' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetRemovalListener']]"
			[Register ("unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)Z", "GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler")]
			public override unsafe bool UnregisterAsset (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2)
			{
				if (id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ == IntPtr.Zero)
					id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ = JNIEnv.GetMethodID (class_ref, "unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					__args [2] = new JValue (p2);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)Z"), __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/drm/DrmAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrmAdapter); }
		}

		protected DrmAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/constructor[@name='DrmAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrmAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DrmAdapter)) {
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

		static Delegate cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
#pragma warning disable 0169
		static Delegate GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler ()
		{
			if (cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ == null)
				cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_CheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_);
			return cb_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
		}

		static bool n_CheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Kaltura.Playkit.Drm.DrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CheckAssetStatus (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='checkAssetStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetStatusListener']]"
		[Register ("checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)Z", "GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler")]
		public abstract bool CheckAssetStatus (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2);

		static IntPtr id_getDrmAdapter_Lcom_kaltura_playkit_PKDrmParams_Scheme_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='getDrmAdapter' and count(parameter)=3 and parameter[1][@type='com.kaltura.playkit.PKDrmParams.Scheme'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='com.kaltura.playkit.LocalDataStore']]"
		[Register ("getDrmAdapter", "(Lcom/kaltura/playkit/PKDrmParams$Scheme;Landroid/content/Context;Lcom/kaltura/playkit/LocalDataStore;)Lcom/kaltura/playkit/drm/DrmAdapter;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Drm.DrmAdapter GetDrmAdapter (global::Com.Kaltura.Playkit.PKDrmParams.Scheme p0, global::Android.Content.Context p1, global::Com.Kaltura.Playkit.ILocalDataStore p2)
		{
			if (id_getDrmAdapter_Lcom_kaltura_playkit_PKDrmParams_Scheme_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_ == IntPtr.Zero)
				id_getDrmAdapter_Lcom_kaltura_playkit_PKDrmParams_Scheme_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_ = JNIEnv.GetStaticMethodID (class_ref, "getDrmAdapter", "(Lcom/kaltura/playkit/PKDrmParams$Scheme;Landroid/content/Context;Lcom/kaltura/playkit/LocalDataStore;)Lcom/kaltura/playkit/drm/DrmAdapter;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Kaltura.Playkit.Drm.DrmAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDrmAdapter_Lcom_kaltura_playkit_PKDrmParams_Scheme_Landroid_content_Context_Lcom_kaltura_playkit_LocalDataStore_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
#pragma warning disable 0169
		static Delegate GetRefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler ()
		{
			if (cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == null)
				cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_);
			return cb_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
		}

		static bool n_RefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Kaltura.Playkit.Drm.DrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RefreshAsset (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='refreshAsset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
		[Register ("refreshAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z", "GetRefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
		public abstract bool RefreshAsset (string p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3);

		static Delegate cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
#pragma warning disable 0169
		static Delegate GetRegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler ()
		{
			if (cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == null)
				cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_);
			return cb_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
		}

		static bool n_RegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Kaltura.Playkit.Drm.DrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RegisterAsset (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='registerAsset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
		[Register ("registerAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z", "GetRegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
		public abstract bool RegisterAsset (string p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3);

		static Delegate cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
#pragma warning disable 0169
		static Delegate GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler ()
		{
			if (cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ == null)
				cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_);
			return cb_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
		}

		static bool n_UnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Kaltura.Playkit.Drm.DrmAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.DrmAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2 = (global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.UnregisterAsset (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='unregisterAsset' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetRemovalListener']]"
		[Register ("unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)Z", "GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler")]
		public abstract bool UnregisterAsset (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2);

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/drm/DrmAdapter", DoNotGenerateAcw=true)]
	internal partial class DrmAdapterInvoker : DrmAdapter {

		public DrmAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrmAdapterInvoker); }
		}

		static IntPtr id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='checkAssetStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetStatusListener']]"
		[Register ("checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)Z", "GetCheckAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_Handler")]
		public override unsafe bool CheckAssetStatus (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetStatusListener p2)
		{
			if (id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ == IntPtr.Zero)
				id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_ = JNIEnv.GetMethodID (class_ref, "checkAssetStatus", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetStatusListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_checkAssetStatus_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetStatusListener_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='refreshAsset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
		[Register ("refreshAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z", "GetRefreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
		public override unsafe bool RefreshAsset (string p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3)
		{
			if (id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == IntPtr.Zero)
				id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNIEnv.GetMethodID (class_ref, "refreshAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_refreshAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='registerAsset' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.kaltura.playkit.LocalAssetsManager.AssetRegistrationListener']]"
		[Register ("registerAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z", "GetRegisterAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_Handler")]
		public override unsafe bool RegisterAsset (string p0, string p1, string p2, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRegistrationListener p3)
		{
			if (id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ == IntPtr.Zero)
				id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_ = JNIEnv.GetMethodID (class_ref, "registerAsset", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRegistrationListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_registerAsset_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRegistrationListener_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='DrmAdapter']/method[@name='unregisterAsset' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.kaltura.playkit.LocalAssetsManager.AssetRemovalListener']]"
		[Register ("unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)Z", "GetUnregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_Handler")]
		public override unsafe bool UnregisterAsset (string p0, string p1, global::Com.Kaltura.Playkit.LocalAssetsManager.IAssetRemovalListener p2)
		{
			if (id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ == IntPtr.Zero)
				id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_ = JNIEnv.GetMethodID (class_ref, "unregisterAsset", "(Ljava/lang/String;Ljava/lang/String;Lcom/kaltura/playkit/LocalAssetsManager$AssetRemovalListener;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_unregisterAsset_Ljava_lang_String_Ljava_lang_String_Lcom_kaltura_playkit_LocalAssetsManager_AssetRemovalListener_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}

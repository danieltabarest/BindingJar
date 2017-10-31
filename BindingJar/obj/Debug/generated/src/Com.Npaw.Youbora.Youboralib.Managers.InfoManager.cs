using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Managers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/managers/InfoManager", DoNotGenerateAcw=true)]
	public partial class InfoManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/managers/InfoManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InfoManager); }
		}

		protected InfoManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/constructor[@name='InfoManager' and count(parameter)=2 and parameter[1][@type='com.npaw.youbora.plugins.PluginGeneric'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/lang/String;)V", "")]
		public unsafe InfoManager (global::Com.Npaw.Youbora.Plugins.PluginGeneric p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (InfoManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/constructor[@name='InfoManager' and count(parameter)=2 and parameter[1][@type='com.npaw.youbora.plugins.PluginGeneric'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/util/Map;)V", "")]
		public unsafe InfoManager (global::Com.Npaw.Youbora.Plugins.PluginGeneric p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (InfoManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/plugins/PluginGeneric;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/constructor[@name='InfoManager' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.plugins.PluginGeneric']]"
		[Register (".ctor", "(Lcom/npaw/youbora/plugins/PluginGeneric;)V", "")]
		public unsafe InfoManager (global::Com.Npaw.Youbora.Plugins.PluginGeneric p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (InfoManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/plugins/PluginGeneric;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/plugins/PluginGeneric;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/plugins/PluginGeneric;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdBitrate;
#pragma warning disable 0169
		static Delegate GetGetAdBitrateHandler ()
		{
			if (cb_getAdBitrate == null)
				cb_getAdBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdBitrate);
			return cb_getAdBitrate;
		}

		static IntPtr n_GetAdBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdBitrate);
		}
#pragma warning restore 0169

		static IntPtr id_getAdBitrate;
		public virtual unsafe global::Java.Lang.Double AdBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdBitrate' and count(parameter)=0]"
			[Register ("getAdBitrate", "()Ljava/lang/Double;", "GetGetAdBitrateHandler")]
			get {
				if (id_getAdBitrate == IntPtr.Zero)
					id_getAdBitrate = JNIEnv.GetMethodID (class_ref, "getAdBitrate", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdBitrate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdBitrate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdBufferEndParams;
#pragma warning disable 0169
		static Delegate GetGetAdBufferEndParamsHandler ()
		{
			if (cb_getAdBufferEndParams == null)
				cb_getAdBufferEndParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdBufferEndParams);
			return cb_getAdBufferEndParams;
		}

		static IntPtr n_GetAdBufferEndParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdBufferEndParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdBufferEndParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdBufferEndParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdBufferEndParams' and count(parameter)=0]"
			[Register ("getAdBufferEndParams", "()Ljava/util/Map;", "GetGetAdBufferEndParamsHandler")]
			get {
				if (id_getAdBufferEndParams == IntPtr.Zero)
					id_getAdBufferEndParams = JNIEnv.GetMethodID (class_ref, "getAdBufferEndParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdBufferEndParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdBufferEndParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdDuration;
#pragma warning disable 0169
		static Delegate GetGetAdDurationHandler ()
		{
			if (cb_getAdDuration == null)
				cb_getAdDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdDuration);
			return cb_getAdDuration;
		}

		static IntPtr n_GetAdDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdDuration);
		}
#pragma warning restore 0169

		static IntPtr id_getAdDuration;
		public virtual unsafe global::Java.Lang.Double AdDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdDuration' and count(parameter)=0]"
			[Register ("getAdDuration", "()Ljava/lang/Double;", "GetGetAdDurationHandler")]
			get {
				if (id_getAdDuration == IntPtr.Zero)
					id_getAdDuration = JNIEnv.GetMethodID (class_ref, "getAdDuration", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdDuration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdDuration", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdJoinParams;
#pragma warning disable 0169
		static Delegate GetGetAdJoinParamsHandler ()
		{
			if (cb_getAdJoinParams == null)
				cb_getAdJoinParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdJoinParams);
			return cb_getAdJoinParams;
		}

		static IntPtr n_GetAdJoinParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdJoinParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdJoinParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdJoinParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdJoinParams' and count(parameter)=0]"
			[Register ("getAdJoinParams", "()Ljava/util/Map;", "GetGetAdJoinParamsHandler")]
			get {
				if (id_getAdJoinParams == IntPtr.Zero)
					id_getAdJoinParams = JNIEnv.GetMethodID (class_ref, "getAdJoinParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdJoinParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdJoinParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdPauseParams;
#pragma warning disable 0169
		static Delegate GetGetAdPauseParamsHandler ()
		{
			if (cb_getAdPauseParams == null)
				cb_getAdPauseParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPauseParams);
			return cb_getAdPauseParams;
		}

		static IntPtr n_GetAdPauseParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdPauseParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPauseParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdPauseParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPauseParams' and count(parameter)=0]"
			[Register ("getAdPauseParams", "()Ljava/util/Map;", "GetGetAdPauseParamsHandler")]
			get {
				if (id_getAdPauseParams == IntPtr.Zero)
					id_getAdPauseParams = JNIEnv.GetMethodID (class_ref, "getAdPauseParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPauseParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPauseParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdPingParams;
#pragma warning disable 0169
		static Delegate GetGetAdPingParamsHandler ()
		{
			if (cb_getAdPingParams == null)
				cb_getAdPingParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPingParams);
			return cb_getAdPingParams;
		}

		static IntPtr n_GetAdPingParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdPingParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPingParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdPingParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPingParams' and count(parameter)=0]"
			[Register ("getAdPingParams", "()Ljava/util/Map;", "GetGetAdPingParamsHandler")]
			get {
				if (id_getAdPingParams == IntPtr.Zero)
					id_getAdPingParams = JNIEnv.GetMethodID (class_ref, "getAdPingParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPingParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPingParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdPlayerVersion;
#pragma warning disable 0169
		static Delegate GetGetAdPlayerVersionHandler ()
		{
			if (cb_getAdPlayerVersion == null)
				cb_getAdPlayerVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPlayerVersion);
			return cb_getAdPlayerVersion;
		}

		static IntPtr n_GetAdPlayerVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdPlayerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPlayerVersion;
		public virtual unsafe string AdPlayerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPlayerVersion' and count(parameter)=0]"
			[Register ("getAdPlayerVersion", "()Ljava/lang/String;", "GetGetAdPlayerVersionHandler")]
			get {
				if (id_getAdPlayerVersion == IntPtr.Zero)
					id_getAdPlayerVersion = JNIEnv.GetMethodID (class_ref, "getAdPlayerVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPlayerVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPlayerVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdPlayhead;
#pragma warning disable 0169
		static Delegate GetGetAdPlayheadHandler ()
		{
			if (cb_getAdPlayhead == null)
				cb_getAdPlayhead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPlayhead);
			return cb_getAdPlayhead;
		}

		static IntPtr n_GetAdPlayhead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPlayhead);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPlayhead;
		public virtual unsafe global::Java.Lang.Double AdPlayhead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPlayhead' and count(parameter)=0]"
			[Register ("getAdPlayhead", "()Ljava/lang/Double;", "GetGetAdPlayheadHandler")]
			get {
				if (id_getAdPlayhead == IntPtr.Zero)
					id_getAdPlayhead = JNIEnv.GetMethodID (class_ref, "getAdPlayhead", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPlayhead), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPlayhead", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdPosition;
#pragma warning disable 0169
		static Delegate GetGetAdPositionHandler ()
		{
			if (cb_getAdPosition == null)
				cb_getAdPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPosition);
			return cb_getAdPosition;
		}

		static IntPtr n_GetAdPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPosition;
		public virtual unsafe string AdPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPosition' and count(parameter)=0]"
			[Register ("getAdPosition", "()Ljava/lang/String;", "GetGetAdPositionHandler")]
			get {
				if (id_getAdPosition == IntPtr.Zero)
					id_getAdPosition = JNIEnv.GetMethodID (class_ref, "getAdPosition", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPosition), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPosition", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdResource;
#pragma warning disable 0169
		static Delegate GetGetAdResourceHandler ()
		{
			if (cb_getAdResource == null)
				cb_getAdResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdResource);
			return cb_getAdResource;
		}

		static IntPtr n_GetAdResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdResource);
		}
#pragma warning restore 0169

		static IntPtr id_getAdResource;
		public virtual unsafe string AdResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdResource' and count(parameter)=0]"
			[Register ("getAdResource", "()Ljava/lang/String;", "GetGetAdResourceHandler")]
			get {
				if (id_getAdResource == IntPtr.Zero)
					id_getAdResource = JNIEnv.GetMethodID (class_ref, "getAdResource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdResource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdResource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdResumeParams;
#pragma warning disable 0169
		static Delegate GetGetAdResumeParamsHandler ()
		{
			if (cb_getAdResumeParams == null)
				cb_getAdResumeParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdResumeParams);
			return cb_getAdResumeParams;
		}

		static IntPtr n_GetAdResumeParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdResumeParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdResumeParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdResumeParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdResumeParams' and count(parameter)=0]"
			[Register ("getAdResumeParams", "()Ljava/util/Map;", "GetGetAdResumeParamsHandler")]
			get {
				if (id_getAdResumeParams == IntPtr.Zero)
					id_getAdResumeParams = JNIEnv.GetMethodID (class_ref, "getAdResumeParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdResumeParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdResumeParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdStartParams;
#pragma warning disable 0169
		static Delegate GetGetAdStartParamsHandler ()
		{
			if (cb_getAdStartParams == null)
				cb_getAdStartParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdStartParams);
			return cb_getAdStartParams;
		}

		static IntPtr n_GetAdStartParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdStartParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdStartParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdStartParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdStartParams' and count(parameter)=0]"
			[Register ("getAdStartParams", "()Ljava/util/Map;", "GetGetAdStartParamsHandler")]
			get {
				if (id_getAdStartParams == IntPtr.Zero)
					id_getAdStartParams = JNIEnv.GetMethodID (class_ref, "getAdStartParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdStartParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdStartParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdStopParams;
#pragma warning disable 0169
		static Delegate GetGetAdStopParamsHandler ()
		{
			if (cb_getAdStopParams == null)
				cb_getAdStopParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdStopParams);
			return cb_getAdStopParams;
		}

		static IntPtr n_GetAdStopParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.AdStopParams);
		}
#pragma warning restore 0169

		static IntPtr id_getAdStopParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> AdStopParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdStopParams' and count(parameter)=0]"
			[Register ("getAdStopParams", "()Ljava/util/Map;", "GetGetAdStopParamsHandler")]
			get {
				if (id_getAdStopParams == IntPtr.Zero)
					id_getAdStopParams = JNIEnv.GetMethodID (class_ref, "getAdStopParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdStopParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdStopParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdTitle;
#pragma warning disable 0169
		static Delegate GetGetAdTitleHandler ()
		{
			if (cb_getAdTitle == null)
				cb_getAdTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdTitle);
			return cb_getAdTitle;
		}

		static IntPtr n_GetAdTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getAdTitle;
		public virtual unsafe string AdTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdTitle' and count(parameter)=0]"
			[Register ("getAdTitle", "()Ljava/lang/String;", "GetGetAdTitleHandler")]
			get {
				if (id_getAdTitle == IntPtr.Zero)
					id_getAdTitle = JNIEnv.GetMethodID (class_ref, "getAdTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitrate);
			return cb_getBitrate;
		}

		static IntPtr n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitrate);
		}
#pragma warning restore 0169

		static IntPtr id_getBitrate;
		public virtual unsafe global::Java.Lang.Double Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()Ljava/lang/Double;", "GetGetBitrateHandler")]
			get {
				if (id_getBitrate == IntPtr.Zero)
					id_getBitrate = JNIEnv.GetMethodID (class_ref, "getBitrate", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitrate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitrate", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBufferEndParams;
#pragma warning disable 0169
		static Delegate GetGetBufferEndParamsHandler ()
		{
			if (cb_getBufferEndParams == null)
				cb_getBufferEndParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferEndParams);
			return cb_getBufferEndParams;
		}

		static IntPtr n_GetBufferEndParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.BufferEndParams);
		}
#pragma warning restore 0169

		static IntPtr id_getBufferEndParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> BufferEndParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getBufferEndParams' and count(parameter)=0]"
			[Register ("getBufferEndParams", "()Ljava/util/Map;", "GetGetBufferEndParamsHandler")]
			get {
				if (id_getBufferEndParams == IntPtr.Zero)
					id_getBufferEndParams = JNIEnv.GetMethodID (class_ref, "getBufferEndParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBufferEndParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferEndParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCDN;
#pragma warning disable 0169
		static Delegate GetGetCDNHandler ()
		{
			if (cb_getCDN == null)
				cb_getCDN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCDN);
			return cb_getCDN;
		}

		static IntPtr n_GetCDN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CDN);
		}
#pragma warning restore 0169

		static IntPtr id_getCDN;
		public virtual unsafe string CDN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getCDN' and count(parameter)=0]"
			[Register ("getCDN", "()Ljava/lang/String;", "GetGetCDNHandler")]
			get {
				if (id_getCDN == IntPtr.Zero)
					id_getCDN = JNIEnv.GetMethodID (class_ref, "getCDN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCDN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCDN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataParams;
#pragma warning disable 0169
		static Delegate GetGetDataParamsHandler ()
		{
			if (cb_getDataParams == null)
				cb_getDataParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataParams);
			return cb_getDataParams;
		}

		static IntPtr n_GetDataParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.DataParams);
		}
#pragma warning restore 0169

		static IntPtr id_getDataParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> DataParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getDataParams' and count(parameter)=0]"
			[Register ("getDataParams", "()Ljava/util/Map;", "GetGetDataParamsHandler")]
			get {
				if (id_getDataParams == IntPtr.Zero)
					id_getDataParams = JNIEnv.GetMethodID (class_ref, "getDataParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorParams;
#pragma warning disable 0169
		static Delegate GetGetErrorParamsHandler ()
		{
			if (cb_getErrorParams == null)
				cb_getErrorParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorParams);
			return cb_getErrorParams;
		}

		static IntPtr n_GetErrorParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ErrorParams);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ErrorParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getErrorParams' and count(parameter)=0]"
			[Register ("getErrorParams", "()Ljava/util/Map;", "GetGetErrorParamsHandler")]
			get {
				if (id_getErrorParams == IntPtr.Zero)
					id_getErrorParams = JNIEnv.GetMethodID (class_ref, "getErrorParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIsLive;
#pragma warning disable 0169
		static Delegate GetGetIsLiveHandler ()
		{
			if (cb_getIsLive == null)
				cb_getIsLive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIsLive);
			return cb_getIsLive;
		}

		static IntPtr n_GetIsLive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsLive);
		}
#pragma warning restore 0169

		static IntPtr id_getIsLive;
		public virtual unsafe global::Java.Lang.Boolean IsLive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getIsLive' and count(parameter)=0]"
			[Register ("getIsLive", "()Ljava/lang/Boolean;", "GetGetIsLiveHandler")]
			get {
				if (id_getIsLive == IntPtr.Zero)
					id_getIsLive = JNIEnv.GetMethodID (class_ref, "getIsLive", "()Ljava/lang/Boolean;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIsLive), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIsLive", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getJoinParams;
#pragma warning disable 0169
		static Delegate GetGetJoinParamsHandler ()
		{
			if (cb_getJoinParams == null)
				cb_getJoinParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJoinParams);
			return cb_getJoinParams;
		}

		static IntPtr n_GetJoinParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.JoinParams);
		}
#pragma warning restore 0169

		static IntPtr id_getJoinParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> JoinParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getJoinParams' and count(parameter)=0]"
			[Register ("getJoinParams", "()Ljava/util/Map;", "GetGetJoinParamsHandler")]
			get {
				if (id_getJoinParams == IntPtr.Zero)
					id_getJoinParams = JNIEnv.GetMethodID (class_ref, "getJoinParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJoinParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJoinParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaDuration;
#pragma warning disable 0169
		static Delegate GetGetMediaDurationHandler ()
		{
			if (cb_getMediaDuration == null)
				cb_getMediaDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaDuration);
			return cb_getMediaDuration;
		}

		static IntPtr n_GetMediaDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaDuration);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaDuration;
		public virtual unsafe global::Java.Lang.Double MediaDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getMediaDuration' and count(parameter)=0]"
			[Register ("getMediaDuration", "()Ljava/lang/Double;", "GetGetMediaDurationHandler")]
			get {
				if (id_getMediaDuration == IntPtr.Zero)
					id_getMediaDuration = JNIEnv.GetMethodID (class_ref, "getMediaDuration", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaDuration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaDuration", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOptions;
#pragma warning disable 0169
		static Delegate GetGetOptionsHandler ()
		{
			if (cb_getOptions == null)
				cb_getOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOptions);
			return cb_getOptions;
		}

		static IntPtr n_GetOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Options);
		}
#pragma warning restore 0169

		static IntPtr id_getOptions;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Data.Options Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()Lcom/npaw/youbora/youboralib/data/Options;", "GetGetOptionsHandler")]
			get {
				if (id_getOptions == IntPtr.Zero)
					id_getOptions = JNIEnv.GetMethodID (class_ref, "getOptions", "()Lcom/npaw/youbora/youboralib/data/Options;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Data.Options> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOptions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Data.Options> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptions", "()Lcom/npaw/youbora/youboralib/data/Options;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPauseParams;
#pragma warning disable 0169
		static Delegate GetGetPauseParamsHandler ()
		{
			if (cb_getPauseParams == null)
				cb_getPauseParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPauseParams);
			return cb_getPauseParams;
		}

		static IntPtr n_GetPauseParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.PauseParams);
		}
#pragma warning restore 0169

		static IntPtr id_getPauseParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> PauseParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getPauseParams' and count(parameter)=0]"
			[Register ("getPauseParams", "()Ljava/util/Map;", "GetGetPauseParamsHandler")]
			get {
				if (id_getPauseParams == IntPtr.Zero)
					id_getPauseParams = JNIEnv.GetMethodID (class_ref, "getPauseParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPauseParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPauseParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPingParams;
#pragma warning disable 0169
		static Delegate GetGetPingParamsHandler ()
		{
			if (cb_getPingParams == null)
				cb_getPingParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPingParams);
			return cb_getPingParams;
		}

		static IntPtr n_GetPingParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.PingParams);
		}
#pragma warning restore 0169

		static IntPtr id_getPingParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> PingParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getPingParams' and count(parameter)=0]"
			[Register ("getPingParams", "()Ljava/util/Map;", "GetGetPingParamsHandler")]
			get {
				if (id_getPingParams == IntPtr.Zero)
					id_getPingParams = JNIEnv.GetMethodID (class_ref, "getPingParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPingParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPingParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlayerVersion;
#pragma warning disable 0169
		static Delegate GetGetPlayerVersionHandler ()
		{
			if (cb_getPlayerVersion == null)
				cb_getPlayerVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayerVersion);
			return cb_getPlayerVersion;
		}

		static IntPtr n_GetPlayerVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerVersion;
		public virtual unsafe string PlayerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getPlayerVersion' and count(parameter)=0]"
			[Register ("getPlayerVersion", "()Ljava/lang/String;", "GetGetPlayerVersionHandler")]
			get {
				if (id_getPlayerVersion == IntPtr.Zero)
					id_getPlayerVersion = JNIEnv.GetMethodID (class_ref, "getPlayerVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayerVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayerVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlayhead;
#pragma warning disable 0169
		static Delegate GetGetPlayheadHandler ()
		{
			if (cb_getPlayhead == null)
				cb_getPlayhead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayhead);
			return cb_getPlayhead;
		}

		static IntPtr n_GetPlayhead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Playhead);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayhead;
		public virtual unsafe global::Java.Lang.Double Playhead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getPlayhead' and count(parameter)=0]"
			[Register ("getPlayhead", "()Ljava/lang/Double;", "GetGetPlayheadHandler")]
			get {
				if (id_getPlayhead == IntPtr.Zero)
					id_getPlayhead = JNIEnv.GetMethodID (class_ref, "getPlayhead", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayhead), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlayhead", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRendition;
#pragma warning disable 0169
		static Delegate GetGetRenditionHandler ()
		{
			if (cb_getRendition == null)
				cb_getRendition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRendition);
			return cb_getRendition;
		}

		static IntPtr n_GetRendition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Rendition);
		}
#pragma warning restore 0169

		static IntPtr id_getRendition;
		public virtual unsafe string Rendition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getRendition' and count(parameter)=0]"
			[Register ("getRendition", "()Ljava/lang/String;", "GetGetRenditionHandler")]
			get {
				if (id_getRendition == IntPtr.Zero)
					id_getRendition = JNIEnv.GetMethodID (class_ref, "getRendition", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRendition), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRendition", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResource;
#pragma warning disable 0169
		static Delegate GetGetResourceHandler ()
		{
			if (cb_getResource == null)
				cb_getResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResource);
			return cb_getResource;
		}

		static IntPtr n_GetResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Resource);
		}
#pragma warning restore 0169

		static IntPtr id_getResource;
		public virtual unsafe string Resource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getResource' and count(parameter)=0]"
			[Register ("getResource", "()Ljava/lang/String;", "GetGetResourceHandler")]
			get {
				if (id_getResource == IntPtr.Zero)
					id_getResource = JNIEnv.GetMethodID (class_ref, "getResource", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResource), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResource", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResumeParams;
#pragma warning disable 0169
		static Delegate GetGetResumeParamsHandler ()
		{
			if (cb_getResumeParams == null)
				cb_getResumeParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResumeParams);
			return cb_getResumeParams;
		}

		static IntPtr n_GetResumeParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ResumeParams);
		}
#pragma warning restore 0169

		static IntPtr id_getResumeParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ResumeParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getResumeParams' and count(parameter)=0]"
			[Register ("getResumeParams", "()Ljava/util/Map;", "GetGetResumeParamsHandler")]
			get {
				if (id_getResumeParams == IntPtr.Zero)
					id_getResumeParams = JNIEnv.GetMethodID (class_ref, "getResumeParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResumeParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResumeParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSeekEndParams;
#pragma warning disable 0169
		static Delegate GetGetSeekEndParamsHandler ()
		{
			if (cb_getSeekEndParams == null)
				cb_getSeekEndParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSeekEndParams);
			return cb_getSeekEndParams;
		}

		static IntPtr n_GetSeekEndParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.SeekEndParams);
		}
#pragma warning restore 0169

		static IntPtr id_getSeekEndParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> SeekEndParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getSeekEndParams' and count(parameter)=0]"
			[Register ("getSeekEndParams", "()Ljava/util/Map;", "GetGetSeekEndParamsHandler")]
			get {
				if (id_getSeekEndParams == IntPtr.Zero)
					id_getSeekEndParams = JNIEnv.GetMethodID (class_ref, "getSeekEndParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeekEndParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeekEndParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStartParams;
#pragma warning disable 0169
		static Delegate GetGetStartParamsHandler ()
		{
			if (cb_getStartParams == null)
				cb_getStartParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartParams);
			return cb_getStartParams;
		}

		static IntPtr n_GetStartParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.StartParams);
		}
#pragma warning restore 0169

		static IntPtr id_getStartParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> StartParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getStartParams' and count(parameter)=0]"
			[Register ("getStartParams", "()Ljava/util/Map;", "GetGetStartParamsHandler")]
			get {
				if (id_getStartParams == IntPtr.Zero)
					id_getStartParams = JNIEnv.GetMethodID (class_ref, "getStartParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStopParams;
#pragma warning disable 0169
		static Delegate GetGetStopParamsHandler ()
		{
			if (cb_getStopParams == null)
				cb_getStopParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStopParams);
			return cb_getStopParams;
		}

		static IntPtr n_GetStopParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.StopParams);
		}
#pragma warning restore 0169

		static IntPtr id_getStopParams;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> StopParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getStopParams' and count(parameter)=0]"
			[Register ("getStopParams", "()Ljava/util/Map;", "GetGetStopParamsHandler")]
			get {
				if (id_getStopParams == IntPtr.Zero)
					id_getStopParams = JNIEnv.GetMethodID (class_ref, "getStopParams", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStopParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStopParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThroughput;
#pragma warning disable 0169
		static Delegate GetGetThroughputHandler ()
		{
			if (cb_getThroughput == null)
				cb_getThroughput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThroughput);
			return cb_getThroughput;
		}

		static IntPtr n_GetThroughput (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throughput);
		}
#pragma warning restore 0169

		static IntPtr id_getThroughput;
		public virtual unsafe global::Java.Lang.Double Throughput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getThroughput' and count(parameter)=0]"
			[Register ("getThroughput", "()Ljava/lang/Double;", "GetGetThroughputHandler")]
			get {
				if (id_getThroughput == IntPtr.Zero)
					id_getThroughput = JNIEnv.GetMethodID (class_ref, "getThroughput", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThroughput), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThroughput", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdBufferEndParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdBufferEndParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdBufferEndParams_Ljava_util_Map_ == null)
				cb_getAdBufferEndParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdBufferEndParams_Ljava_util_Map_);
			return cb_getAdBufferEndParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdBufferEndParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdBufferEndParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdBufferEndParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdBufferEndParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdBufferEndParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdBufferEndParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdBufferEndParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdBufferEndParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdBufferEndParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdBufferEndParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdBufferEndParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdBufferEndParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdJoinParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdJoinParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdJoinParams_Ljava_util_Map_ == null)
				cb_getAdJoinParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdJoinParams_Ljava_util_Map_);
			return cb_getAdJoinParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdJoinParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdJoinParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdJoinParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdJoinParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdJoinParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdJoinParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdJoinParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdJoinParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdJoinParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdJoinParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdJoinParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdJoinParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdPauseParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdPauseParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdPauseParams_Ljava_util_Map_ == null)
				cb_getAdPauseParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdPauseParams_Ljava_util_Map_);
			return cb_getAdPauseParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdPauseParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdPauseParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdPauseParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPauseParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdPauseParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdPauseParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdPauseParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdPauseParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdPauseParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdPauseParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPauseParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPauseParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdPingParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdPingParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdPingParams_Ljava_util_Map_ == null)
				cb_getAdPingParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdPingParams_Ljava_util_Map_);
			return cb_getAdPingParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdPingParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdPingParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdPingParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdPingParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdPingParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdPingParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdPingParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdPingParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdPingParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdPingParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPingParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPingParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdResumeParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdResumeParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdResumeParams_Ljava_util_Map_ == null)
				cb_getAdResumeParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdResumeParams_Ljava_util_Map_);
			return cb_getAdResumeParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdResumeParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdResumeParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdResumeParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdResumeParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdResumeParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdResumeParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdResumeParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdResumeParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdResumeParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdResumeParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdResumeParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdResumeParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdStartParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdStartParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdStartParams_Ljava_util_Map_ == null)
				cb_getAdStartParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdStartParams_Ljava_util_Map_);
			return cb_getAdStartParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdStartParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdStartParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdStartParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdStartParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdStartParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdStartParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdStartParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdStartParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdStartParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdStartParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdStartParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdStartParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAdStopParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetAdStopParams_Ljava_util_Map_Handler ()
		{
			if (cb_getAdStopParams_Ljava_util_Map_ == null)
				cb_getAdStopParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAdStopParams_Ljava_util_Map_);
			return cb_getAdStopParams_Ljava_util_Map_;
		}

		static IntPtr n_GetAdStopParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetAdStopParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getAdStopParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getAdStopParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getAdStopParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetAdStopParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetAdStopParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getAdStopParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getAdStopParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getAdStopParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdStopParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdStopParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBufferEndParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBufferEndParams_Ljava_util_Map_Handler ()
		{
			if (cb_getBufferEndParams_Ljava_util_Map_ == null)
				cb_getBufferEndParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBufferEndParams_Ljava_util_Map_);
			return cb_getBufferEndParams_Ljava_util_Map_;
		}

		static IntPtr n_GetBufferEndParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetBufferEndParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferEndParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getBufferEndParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getBufferEndParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetBufferEndParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetBufferEndParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getBufferEndParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getBufferEndParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBufferEndParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBufferEndParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferEndParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDataParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetDataParams_Ljava_util_Map_Handler ()
		{
			if (cb_getDataParams_Ljava_util_Map_ == null)
				cb_getDataParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataParams_Ljava_util_Map_);
			return cb_getDataParams_Ljava_util_Map_;
		}

		static IntPtr n_GetDataParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetDataParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDataParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getDataParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getDataParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetDataParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetDataParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getDataParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getDataParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getDataParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getErrorParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetErrorParams_Ljava_util_Map_Handler ()
		{
			if (cb_getErrorParams_Ljava_util_Map_ == null)
				cb_getErrorParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetErrorParams_Ljava_util_Map_);
			return cb_getErrorParams_Ljava_util_Map_;
		}

		static IntPtr n_GetErrorParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetErrorParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getErrorParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getErrorParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetErrorParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetErrorParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getErrorParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getErrorParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getErrorParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getJoinParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetJoinParams_Ljava_util_Map_Handler ()
		{
			if (cb_getJoinParams_Ljava_util_Map_ == null)
				cb_getJoinParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetJoinParams_Ljava_util_Map_);
			return cb_getJoinParams_Ljava_util_Map_;
		}

		static IntPtr n_GetJoinParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetJoinParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getJoinParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getJoinParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getJoinParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetJoinParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetJoinParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getJoinParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getJoinParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getJoinParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJoinParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJoinParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPauseParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetPauseParams_Ljava_util_Map_Handler ()
		{
			if (cb_getPauseParams_Ljava_util_Map_ == null)
				cb_getPauseParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPauseParams_Ljava_util_Map_);
			return cb_getPauseParams_Ljava_util_Map_;
		}

		static IntPtr n_GetPauseParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetPauseParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPauseParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getPauseParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getPauseParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetPauseParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetPauseParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getPauseParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getPauseParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getPauseParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPauseParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPauseParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPingParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetPingParams_Ljava_util_Map_Handler ()
		{
			if (cb_getPingParams_Ljava_util_Map_ == null)
				cb_getPingParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPingParams_Ljava_util_Map_);
			return cb_getPingParams_Ljava_util_Map_;
		}

		static IntPtr n_GetPingParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetPingParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPingParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getPingParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getPingParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetPingParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetPingParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getPingParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getPingParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getPingParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPingParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPingParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getResumeParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetResumeParams_Ljava_util_Map_Handler ()
		{
			if (cb_getResumeParams_Ljava_util_Map_ == null)
				cb_getResumeParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResumeParams_Ljava_util_Map_);
			return cb_getResumeParams_Ljava_util_Map_;
		}

		static IntPtr n_GetResumeParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetResumeParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResumeParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getResumeParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getResumeParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetResumeParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetResumeParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getResumeParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getResumeParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getResumeParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResumeParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResumeParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getSeekEndParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetSeekEndParams_Ljava_util_Map_Handler ()
		{
			if (cb_getSeekEndParams_Ljava_util_Map_ == null)
				cb_getSeekEndParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSeekEndParams_Ljava_util_Map_);
			return cb_getSeekEndParams_Ljava_util_Map_;
		}

		static IntPtr n_GetSeekEndParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetSeekEndParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSeekEndParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getSeekEndParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getSeekEndParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetSeekEndParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetSeekEndParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getSeekEndParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getSeekEndParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getSeekEndParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSeekEndParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSeekEndParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getStartParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetStartParams_Ljava_util_Map_Handler ()
		{
			if (cb_getStartParams_Ljava_util_Map_ == null)
				cb_getStartParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStartParams_Ljava_util_Map_);
			return cb_getStartParams_Ljava_util_Map_;
		}

		static IntPtr n_GetStartParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetStartParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStartParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getStartParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getStartParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetStartParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetStartParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getStartParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getStartParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getStartParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getStopParams_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetStopParams_Ljava_util_Map_Handler ()
		{
			if (cb_getStopParams_Ljava_util_Map_ == null)
				cb_getStopParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStopParams_Ljava_util_Map_);
			return cb_getStopParams_Ljava_util_Map_;
		}

		static IntPtr n_GetStopParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.GetStopParams (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getStopParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='getStopParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("getStopParams", "(Ljava/util/Map;)Ljava/util/Map;", "GetGetStopParams_Ljava_util_Map_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> GetStopParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_getStopParams_Ljava_util_Map_ == IntPtr.Zero)
				id_getStopParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getStopParams", "(Ljava/util/Map;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStopParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStopParams", "(Ljava/util/Map;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOptions_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Ljava_lang_String_Handler ()
		{
			if (cb_setOptions_Ljava_lang_String_ == null)
				cb_setOptions_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptions_Ljava_lang_String_);
			return cb_setOptions_Ljava_lang_String_;
		}

		static void n_SetOptions_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOptions", "(Ljava/lang/String;)V", "GetSetOptions_Ljava_lang_String_Handler")]
		public virtual unsafe void SetOptions (string p0)
		{
			if (id_setOptions_Ljava_lang_String_ == IntPtr.Zero)
				id_setOptions_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOptions_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetOptions_Ljava_util_Map_Handler ()
		{
			if (cb_setOptions_Ljava_util_Map_ == null)
				cb_setOptions_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptions_Ljava_util_Map_);
			return cb_setOptions_Ljava_util_Map_;
		}

		static void n_SetOptions_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='InfoManager']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setOptions", "(Ljava/util/Map;)V", "GetSetOptions_Ljava_util_Map_Handler")]
		public virtual unsafe void SetOptions (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_setOptions_Ljava_util_Map_ == IntPtr.Zero)
				id_setOptions_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setOptions", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptions_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptions", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

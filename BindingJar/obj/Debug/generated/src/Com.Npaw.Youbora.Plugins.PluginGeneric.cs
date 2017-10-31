using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Plugins {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']"
	[global::Android.Runtime.Register ("com/npaw/youbora/plugins/PluginGeneric", DoNotGenerateAcw=true)]
	public partial class PluginGeneric : global::Java.Lang.Object {


		static IntPtr infoManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/field[@name='infoManager']"
		[Register ("infoManager")]
		protected global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager InfoManager {
			get {
				if (infoManager_jfieldId == IntPtr.Zero)
					infoManager_jfieldId = JNIEnv.GetFieldID (class_ref, "infoManager", "Lcom/npaw/youbora/youboralib/managers/InfoManager;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, infoManager_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (infoManager_jfieldId == IntPtr.Zero)
					infoManager_jfieldId = JNIEnv.GetFieldID (class_ref, "infoManager", "Lcom/npaw/youbora/youboralib/managers/InfoManager;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, infoManager_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr player_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/field[@name='player']"
		[Register ("player")]
		protected global::Java.Lang.Object Player {
			get {
				if (player_jfieldId == IntPtr.Zero)
					player_jfieldId = JNIEnv.GetFieldID (class_ref, "player", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, player_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (player_jfieldId == IntPtr.Zero)
					player_jfieldId = JNIEnv.GetFieldID (class_ref, "player", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, player_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr startAutoDetectionEnabled_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/field[@name='startAutoDetectionEnabled']"
		[Register ("startAutoDetectionEnabled")]
		protected bool StartAutoDetectionEnabled {
			get {
				if (startAutoDetectionEnabled_jfieldId == IntPtr.Zero)
					startAutoDetectionEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "startAutoDetectionEnabled", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, startAutoDetectionEnabled_jfieldId);
			}
			set {
				if (startAutoDetectionEnabled_jfieldId == IntPtr.Zero)
					startAutoDetectionEnabled_jfieldId = JNIEnv.GetFieldID (class_ref, "startAutoDetectionEnabled", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startAutoDetectionEnabled_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/plugins/PluginGeneric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PluginGeneric); }
		}

		protected PluginGeneric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/constructor[@name='PluginGeneric' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe PluginGeneric (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (PluginGeneric)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/constructor[@name='PluginGeneric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PluginGeneric (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (PluginGeneric)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/constructor[@name='PluginGeneric' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe PluginGeneric ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PluginGeneric)) {
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

		static Delegate cb_getAdnalyzer;
#pragma warning disable 0169
		static Delegate GetGetAdnalyzerHandler ()
		{
			if (cb_getAdnalyzer == null)
				cb_getAdnalyzer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdnalyzer);
			return cb_getAdnalyzer;
		}

		static IntPtr n_GetAdnalyzer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Adnalyzer);
		}
#pragma warning restore 0169

		static Delegate cb_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_;
#pragma warning disable 0169
		static Delegate GetSetAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_Handler ()
		{
			if (cb_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_ == null)
				cb_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_);
			return cb_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_;
		}

		static void n_SetAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric p0 = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Adnalyzer = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdnalyzer;
		static IntPtr id_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_;
		public virtual unsafe global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric Adnalyzer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getAdnalyzer' and count(parameter)=0]"
			[Register ("getAdnalyzer", "()Lcom/npaw/youbora/adnalyzers/AdnalyzerGeneric;", "GetGetAdnalyzerHandler")]
			get {
				if (id_getAdnalyzer == IntPtr.Zero)
					id_getAdnalyzer = JNIEnv.GetMethodID (class_ref, "getAdnalyzer", "()Lcom/npaw/youbora/adnalyzers/AdnalyzerGeneric;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdnalyzer), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdnalyzer", "()Lcom/npaw/youbora/adnalyzers/AdnalyzerGeneric;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='setAdnalyzer' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.adnalyzers.AdnalyzerGeneric']]"
			[Register ("setAdnalyzer", "(Lcom/npaw/youbora/adnalyzers/AdnalyzerGeneric;)V", "GetSetAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_Handler")]
			set {
				if (id_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_ == IntPtr.Zero)
					id_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_ = JNIEnv.GetMethodID (class_ref, "setAdnalyzer", "(Lcom/npaw/youbora/adnalyzers/AdnalyzerGeneric;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdnalyzer_Lcom_npaw_youbora_adnalyzers_AdnalyzerGeneric_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdnalyzer", "(Lcom/npaw/youbora/adnalyzers/AdnalyzerGeneric;)V"), __args);
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitrate);
		}
#pragma warning restore 0169

		static IntPtr id_getBitrate;
		public virtual unsafe global::Java.Lang.Double Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getBitrate' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsLive);
		}
#pragma warning restore 0169

		static IntPtr id_getIsLive;
		public virtual unsafe global::Java.Lang.Boolean IsLive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getIsLive' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaDuration);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaDuration;
		public virtual unsafe global::Java.Lang.Double MediaDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getMediaDuration' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Options);
		}
#pragma warning restore 0169

		static IntPtr id_getOptions;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Data.Options Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getOptions' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayerVersion;
		public virtual unsafe string PlayerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getPlayerVersion' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Playhead);
		}
#pragma warning restore 0169

		static IntPtr id_getPlayhead;
		public virtual unsafe global::Java.Lang.Double Playhead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getPlayhead' and count(parameter)=0]"
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

		static IntPtr id_getPluginName;
		public unsafe string PluginName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getPluginName' and count(parameter)=0]"
			[Register ("getPluginName", "()Ljava/lang/String;", "GetGetPluginNameHandler")]
			get {
				if (id_getPluginName == IntPtr.Zero)
					id_getPluginName = JNIEnv.GetMethodID (class_ref, "getPluginName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPluginName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPluginVersion;
		public unsafe string PluginVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getPluginVersion' and count(parameter)=0]"
			[Register ("getPluginVersion", "()Ljava/lang/String;", "GetGetPluginVersionHandler")]
			get {
				if (id_getPluginVersion == IntPtr.Zero)
					id_getPluginVersion = JNIEnv.GetMethodID (class_ref, "getPluginVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPluginVersion), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Rendition);
		}
#pragma warning restore 0169

		static IntPtr id_getRendition;
		public virtual unsafe string Rendition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getRendition' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Resource);
		}
#pragma warning restore 0169

		static IntPtr id_getResource;
		public virtual unsafe string Resource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getResource' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throughput);
		}
#pragma warning restore 0169

		static IntPtr id_getThroughput;
		public virtual unsafe global::Java.Lang.Double Throughput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getThroughput' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getTitle' and count(parameter)=0]"
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

		static Delegate cb_getViewManager;
#pragma warning disable 0169
		static Delegate GetGetViewManagerHandler ()
		{
			if (cb_getViewManager == null)
				cb_getViewManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewManager);
			return cb_getViewManager;
		}

		static IntPtr n_GetViewManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewManager);
		}
#pragma warning restore 0169

		static IntPtr id_getViewManager;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager ViewManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='getViewManager' and count(parameter)=0]"
			[Register ("getViewManager", "()Lcom/npaw/youbora/youboralib/managers/ViewManager;", "GetGetViewManagerHandler")]
			get {
				if (id_getViewManager == IntPtr.Zero)
					id_getViewManager = JNIEnv.GetMethodID (class_ref, "getViewManager", "()Lcom/npaw/youbora/youboralib/managers/ViewManager;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getViewManager), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getViewManager", "()Lcom/npaw/youbora/youboralib/managers/ViewManager;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bufferedHandler;
#pragma warning disable 0169
		static Delegate GetBufferedHandlerHandler ()
		{
			if (cb_bufferedHandler == null)
				cb_bufferedHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BufferedHandler);
			return cb_bufferedHandler;
		}

		static void n_BufferedHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BufferedHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_bufferedHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='bufferedHandler' and count(parameter)=0]"
		[Register ("bufferedHandler", "()V", "GetBufferedHandlerHandler")]
		public virtual unsafe void BufferedHandler ()
		{
			if (id_bufferedHandler == IntPtr.Zero)
				id_bufferedHandler = JNIEnv.GetMethodID (class_ref, "bufferedHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bufferedHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bufferedHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_bufferingHandler;
#pragma warning disable 0169
		static Delegate GetBufferingHandlerHandler ()
		{
			if (cb_bufferingHandler == null)
				cb_bufferingHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BufferingHandler);
			return cb_bufferingHandler;
		}

		static void n_BufferingHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BufferingHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_bufferingHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='bufferingHandler' and count(parameter)=0]"
		[Register ("bufferingHandler", "()V", "GetBufferingHandlerHandler")]
		public virtual unsafe void BufferingHandler ()
		{
			if (id_bufferingHandler == IntPtr.Zero)
				id_bufferingHandler = JNIEnv.GetMethodID (class_ref, "bufferingHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bufferingHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bufferingHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableBufferMonitor;
#pragma warning disable 0169
		static Delegate GetEnableBufferMonitorHandler ()
		{
			if (cb_enableBufferMonitor == null)
				cb_enableBufferMonitor = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableBufferMonitor);
			return cb_enableBufferMonitor;
		}

		static void n_EnableBufferMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableBufferMonitor ();
		}
#pragma warning restore 0169

		static IntPtr id_enableBufferMonitor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='enableBufferMonitor' and count(parameter)=0]"
		[Register ("enableBufferMonitor", "()V", "GetEnableBufferMonitorHandler")]
		public virtual unsafe void EnableBufferMonitor ()
		{
			if (id_enableBufferMonitor == IntPtr.Zero)
				id_enableBufferMonitor = JNIEnv.GetMethodID (class_ref, "enableBufferMonitor", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableBufferMonitor);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableBufferMonitor", "()V"));
			} finally {
			}
		}

		static Delegate cb_enableSeekMonitor;
#pragma warning disable 0169
		static Delegate GetEnableSeekMonitorHandler ()
		{
			if (cb_enableSeekMonitor == null)
				cb_enableSeekMonitor = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableSeekMonitor);
			return cb_enableSeekMonitor;
		}

		static void n_EnableSeekMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableSeekMonitor ();
		}
#pragma warning restore 0169

		static IntPtr id_enableSeekMonitor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='enableSeekMonitor' and count(parameter)=0]"
		[Register ("enableSeekMonitor", "()V", "GetEnableSeekMonitorHandler")]
		public virtual unsafe void EnableSeekMonitor ()
		{
			if (id_enableSeekMonitor == IntPtr.Zero)
				id_enableSeekMonitor = JNIEnv.GetMethodID (class_ref, "enableSeekMonitor", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableSeekMonitor);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableSeekMonitor", "()V"));
			} finally {
			}
		}

		static Delegate cb_endedHandler;
#pragma warning disable 0169
		static Delegate GetEndedHandlerHandler ()
		{
			if (cb_endedHandler == null)
				cb_endedHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndedHandler);
			return cb_endedHandler;
		}

		static void n_EndedHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndedHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_endedHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='endedHandler' and count(parameter)=0]"
		[Register ("endedHandler", "()V", "GetEndedHandlerHandler")]
		public virtual unsafe void EndedHandler ()
		{
			if (id_endedHandler == IntPtr.Zero)
				id_endedHandler = JNIEnv.GetMethodID (class_ref, "endedHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endedHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endedHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_errorHandler_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetErrorHandler_Ljava_lang_String_Handler ()
		{
			if (cb_errorHandler_Ljava_lang_String_ == null)
				cb_errorHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ErrorHandler_Ljava_lang_String_);
			return cb_errorHandler_Ljava_lang_String_;
		}

		static void n_ErrorHandler_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_errorHandler_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='errorHandler' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("errorHandler", "(Ljava/lang/String;)V", "GetErrorHandler_Ljava_lang_String_Handler")]
		public virtual unsafe void ErrorHandler (string p0)
		{
			if (id_errorHandler_Ljava_lang_String_ == IntPtr.Zero)
				id_errorHandler_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "errorHandler", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorHandler_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "errorHandler", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_errorHandler_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetErrorHandler_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_errorHandler_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_errorHandler_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ErrorHandler_Ljava_lang_String_Ljava_lang_String_);
			return cb_errorHandler_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ErrorHandler_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ErrorHandler (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_errorHandler_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='errorHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("errorHandler", "(Ljava/lang/String;Ljava/lang/String;)V", "GetErrorHandler_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ErrorHandler (string p0, string p1)
		{
			if (id_errorHandler_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_errorHandler_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "errorHandler", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorHandler_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "errorHandler", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetErrorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ErrorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_ErrorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ErrorHandler (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='errorHandler' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("errorHandler", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetErrorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void ErrorHandler (string p0, string p1, string p2)
		{
			if (id_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "errorHandler", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_errorHandler_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "errorHandler", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_ignoredAdHandler;
#pragma warning disable 0169
		static Delegate GetIgnoredAdHandlerHandler ()
		{
			if (cb_ignoredAdHandler == null)
				cb_ignoredAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IgnoredAdHandler);
			return cb_ignoredAdHandler;
		}

		static void n_IgnoredAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IgnoredAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_ignoredAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='ignoredAdHandler' and count(parameter)=0]"
		[Register ("ignoredAdHandler", "()V", "GetIgnoredAdHandlerHandler")]
		public virtual unsafe void IgnoredAdHandler ()
		{
			if (id_ignoredAdHandler == IntPtr.Zero)
				id_ignoredAdHandler = JNIEnv.GetMethodID (class_ref, "ignoredAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ignoredAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ignoredAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_ignoringAdHandler;
#pragma warning disable 0169
		static Delegate GetIgnoringAdHandlerHandler ()
		{
			if (cb_ignoringAdHandler == null)
				cb_ignoringAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IgnoringAdHandler);
			return cb_ignoringAdHandler;
		}

		static void n_IgnoringAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IgnoringAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_ignoringAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='ignoringAdHandler' and count(parameter)=0]"
		[Register ("ignoringAdHandler", "()V", "GetIgnoringAdHandlerHandler")]
		public virtual unsafe void IgnoringAdHandler ()
		{
			if (id_ignoringAdHandler == IntPtr.Zero)
				id_ignoringAdHandler = JNIEnv.GetMethodID (class_ref, "ignoringAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ignoringAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ignoringAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
			} finally {
			}
		}

		static Delegate cb_joinHandler;
#pragma warning disable 0169
		static Delegate GetJoinHandlerHandler ()
		{
			if (cb_joinHandler == null)
				cb_joinHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_JoinHandler);
			return cb_joinHandler;
		}

		static void n_JoinHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.JoinHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_joinHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='joinHandler' and count(parameter)=0]"
		[Register ("joinHandler", "()V", "GetJoinHandlerHandler")]
		public virtual unsafe void JoinHandler ()
		{
			if (id_joinHandler == IntPtr.Zero)
				id_joinHandler = JNIEnv.GetMethodID (class_ref, "joinHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_joinHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "joinHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseHandler;
#pragma warning disable 0169
		static Delegate GetPauseHandlerHandler ()
		{
			if (cb_pauseHandler == null)
				cb_pauseHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseHandler);
			return cb_pauseHandler;
		}

		static void n_PauseHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='pauseHandler' and count(parameter)=0]"
		[Register ("pauseHandler", "()V", "GetPauseHandlerHandler")]
		public virtual unsafe void PauseHandler ()
		{
			if (id_pauseHandler == IntPtr.Zero)
				id_pauseHandler = JNIEnv.GetMethodID (class_ref, "pauseHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseMonitoring;
#pragma warning disable 0169
		static Delegate GetPauseMonitoringHandler ()
		{
			if (cb_pauseMonitoring == null)
				cb_pauseMonitoring = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseMonitoring);
			return cb_pauseMonitoring;
		}

		static void n_PauseMonitoring (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseMonitoring ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseMonitoring;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='pauseMonitoring' and count(parameter)=0]"
		[Register ("pauseMonitoring", "()V", "GetPauseMonitoringHandler")]
		public virtual unsafe void PauseMonitoring ()
		{
			if (id_pauseMonitoring == IntPtr.Zero)
				id_pauseMonitoring = JNIEnv.GetMethodID (class_ref, "pauseMonitoring", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseMonitoring);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseMonitoring", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseToggleHandler;
#pragma warning disable 0169
		static Delegate GetPauseToggleHandlerHandler ()
		{
			if (cb_pauseToggleHandler == null)
				cb_pauseToggleHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseToggleHandler);
			return cb_pauseToggleHandler;
		}

		static void n_PauseToggleHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseToggleHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseToggleHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='pauseToggleHandler' and count(parameter)=0]"
		[Register ("pauseToggleHandler", "()V", "GetPauseToggleHandlerHandler")]
		public virtual unsafe void PauseToggleHandler ()
		{
			if (id_pauseToggleHandler == IntPtr.Zero)
				id_pauseToggleHandler = JNIEnv.GetMethodID (class_ref, "pauseToggleHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseToggleHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseToggleHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_playHandler;
#pragma warning disable 0169
		static Delegate GetPlayHandlerHandler ()
		{
			if (cb_playHandler == null)
				cb_playHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PlayHandler);
			return cb_playHandler;
		}

		static void n_PlayHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_playHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='playHandler' and count(parameter)=0]"
		[Register ("playHandler", "()V", "GetPlayHandlerHandler")]
		public virtual unsafe void PlayHandler ()
		{
			if (id_playHandler == IntPtr.Zero)
				id_playHandler = JNIEnv.GetMethodID (class_ref, "playHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_playingHandler;
#pragma warning disable 0169
		static Delegate GetPlayingHandlerHandler ()
		{
			if (cb_playingHandler == null)
				cb_playingHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PlayingHandler);
			return cb_playingHandler;
		}

		static void n_PlayingHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayingHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_playingHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='playingHandler' and count(parameter)=0]"
		[Register ("playingHandler", "()V", "GetPlayingHandlerHandler")]
		public virtual unsafe void PlayingHandler ()
		{
			if (id_playingHandler == IntPtr.Zero)
				id_playingHandler = JNIEnv.GetMethodID (class_ref, "playingHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playingHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playingHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_resumeHandler;
#pragma warning disable 0169
		static Delegate GetResumeHandlerHandler ()
		{
			if (cb_resumeHandler == null)
				cb_resumeHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeHandler);
			return cb_resumeHandler;
		}

		static void n_ResumeHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='resumeHandler' and count(parameter)=0]"
		[Register ("resumeHandler", "()V", "GetResumeHandlerHandler")]
		public virtual unsafe void ResumeHandler ()
		{
			if (id_resumeHandler == IntPtr.Zero)
				id_resumeHandler = JNIEnv.GetMethodID (class_ref, "resumeHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_resumeMonitoring;
#pragma warning disable 0169
		static Delegate GetResumeMonitoringHandler ()
		{
			if (cb_resumeMonitoring == null)
				cb_resumeMonitoring = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeMonitoring);
			return cb_resumeMonitoring;
		}

		static void n_ResumeMonitoring (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeMonitoring ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeMonitoring;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='resumeMonitoring' and count(parameter)=0]"
		[Register ("resumeMonitoring", "()V", "GetResumeMonitoringHandler")]
		public virtual unsafe void ResumeMonitoring ()
		{
			if (id_resumeMonitoring == IntPtr.Zero)
				id_resumeMonitoring = JNIEnv.GetMethodID (class_ref, "resumeMonitoring", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeMonitoring);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeMonitoring", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekedHandler;
#pragma warning disable 0169
		static Delegate GetSeekedHandlerHandler ()
		{
			if (cb_seekedHandler == null)
				cb_seekedHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SeekedHandler);
			return cb_seekedHandler;
		}

		static void n_SeekedHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekedHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_seekedHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='seekedHandler' and count(parameter)=0]"
		[Register ("seekedHandler", "()V", "GetSeekedHandlerHandler")]
		public virtual unsafe void SeekedHandler ()
		{
			if (id_seekedHandler == IntPtr.Zero)
				id_seekedHandler = JNIEnv.GetMethodID (class_ref, "seekedHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekedHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekedHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_seekingHandler;
#pragma warning disable 0169
		static Delegate GetSeekingHandlerHandler ()
		{
			if (cb_seekingHandler == null)
				cb_seekingHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SeekingHandler);
			return cb_seekingHandler;
		}

		static void n_SeekingHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SeekingHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_seekingHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='seekingHandler' and count(parameter)=0]"
		[Register ("seekingHandler", "()V", "GetSeekingHandlerHandler")]
		public virtual unsafe void SeekingHandler ()
		{
			if (id_seekingHandler == IntPtr.Zero)
				id_seekingHandler = JNIEnv.GetMethodID (class_ref, "seekingHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekingHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "seekingHandler", "()V"));
			} finally {
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOptions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOptions_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
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

		static Delegate cb_setStartAutoDetection_Z;
#pragma warning disable 0169
		static Delegate GetSetStartAutoDetection_ZHandler ()
		{
			if (cb_setStartAutoDetection_Z == null)
				cb_setStartAutoDetection_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStartAutoDetection_Z);
			return cb_setStartAutoDetection_Z;
		}

		static void n_SetStartAutoDetection_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStartAutoDetection (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStartAutoDetection_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='setStartAutoDetection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStartAutoDetection", "(Z)V", "GetSetStartAutoDetection_ZHandler")]
		public virtual unsafe void SetStartAutoDetection (bool p0)
		{
			if (id_setStartAutoDetection_Z == IntPtr.Zero)
				id_setStartAutoDetection_Z = JNIEnv.GetMethodID (class_ref, "setStartAutoDetection", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStartAutoDetection_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartAutoDetection", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startMonitoring_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetStartMonitoring_Ljava_lang_Object_Handler ()
		{
			if (cb_startMonitoring_Ljava_lang_Object_ == null)
				cb_startMonitoring_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartMonitoring_Ljava_lang_Object_);
			return cb_startMonitoring_Ljava_lang_Object_;
		}

		static void n_StartMonitoring_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoring (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startMonitoring_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='startMonitoring' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("startMonitoring", "(Ljava/lang/Object;)V", "GetStartMonitoring_Ljava_lang_Object_Handler")]
		public virtual unsafe void StartMonitoring (global::Java.Lang.Object p0)
		{
			if (id_startMonitoring_Ljava_lang_Object_ == IntPtr.Zero)
				id_startMonitoring_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "startMonitoring", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startMonitoring_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startMonitoring", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startMonitoring_Ljava_lang_Object_Z;
#pragma warning disable 0169
		static Delegate GetStartMonitoring_Ljava_lang_Object_ZHandler ()
		{
			if (cb_startMonitoring_Ljava_lang_Object_Z == null)
				cb_startMonitoring_Ljava_lang_Object_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_StartMonitoring_Ljava_lang_Object_Z);
			return cb_startMonitoring_Ljava_lang_Object_Z;
		}

		static void n_StartMonitoring_Ljava_lang_Object_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoring (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startMonitoring_Ljava_lang_Object_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='startMonitoring' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='boolean']]"
		[Register ("startMonitoring", "(Ljava/lang/Object;Z)V", "GetStartMonitoring_Ljava_lang_Object_ZHandler")]
		public virtual unsafe void StartMonitoring (global::Java.Lang.Object p0, bool p1)
		{
			if (id_startMonitoring_Ljava_lang_Object_Z == IntPtr.Zero)
				id_startMonitoring_Ljava_lang_Object_Z = JNIEnv.GetMethodID (class_ref, "startMonitoring", "(Ljava/lang/Object;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startMonitoring_Ljava_lang_Object_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startMonitoring", "(Ljava/lang/Object;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopMonitoring;
#pragma warning disable 0169
		static Delegate GetStopMonitoringHandler ()
		{
			if (cb_stopMonitoring == null)
				cb_stopMonitoring = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopMonitoring);
			return cb_stopMonitoring;
		}

		static void n_StopMonitoring (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Plugins.PluginGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMonitoring ();
		}
#pragma warning restore 0169

		static IntPtr id_stopMonitoring;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.plugins']/class[@name='PluginGeneric']/method[@name='stopMonitoring' and count(parameter)=0]"
		[Register ("stopMonitoring", "()V", "GetStopMonitoringHandler")]
		public virtual unsafe void StopMonitoring ()
		{
			if (id_stopMonitoring == IntPtr.Zero)
				id_stopMonitoring = JNIEnv.GetMethodID (class_ref, "stopMonitoring", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopMonitoring);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopMonitoring", "()V"));
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Adnalyzers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']"
	[global::Android.Runtime.Register ("com/npaw/youbora/adnalyzers/AdnalyzerGeneric", DoNotGenerateAcw=true)]
	public partial class AdnalyzerGeneric : global::Java.Lang.Object {


		static IntPtr adsPlayer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/field[@name='adsPlayer']"
		[Register ("adsPlayer")]
		protected global::Java.Lang.Object AdsPlayer {
			get {
				if (adsPlayer_jfieldId == IntPtr.Zero)
					adsPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "adsPlayer", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adsPlayer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (adsPlayer_jfieldId == IntPtr.Zero)
					adsPlayer_jfieldId = JNIEnv.GetFieldID (class_ref, "adsPlayer", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adsPlayer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr plugin_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/field[@name='plugin']"
		[Register ("plugin")]
		protected global::Com.Npaw.Youbora.Plugins.PluginGeneric Plugin {
			get {
				if (plugin_jfieldId == IntPtr.Zero)
					plugin_jfieldId = JNIEnv.GetFieldID (class_ref, "plugin", "Lcom/npaw/youbora/plugins/PluginGeneric;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, plugin_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Plugins.PluginGeneric> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (plugin_jfieldId == IntPtr.Zero)
					plugin_jfieldId = JNIEnv.GetFieldID (class_ref, "plugin", "Lcom/npaw/youbora/plugins/PluginGeneric;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, plugin_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/adnalyzers/AdnalyzerGeneric", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdnalyzerGeneric); }
		}

		protected AdnalyzerGeneric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_npaw_youbora_plugins_PluginGeneric_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/constructor[@name='AdnalyzerGeneric' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.plugins.PluginGeneric']]"
		[Register (".ctor", "(Lcom/npaw/youbora/plugins/PluginGeneric;)V", "")]
		public unsafe AdnalyzerGeneric (global::Com.Npaw.Youbora.Plugins.PluginGeneric p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AdnalyzerGeneric)) {
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdBitrate);
		}
#pragma warning restore 0169

		static IntPtr id_getAdBitrate;
		public virtual unsafe global::Java.Lang.Double AdBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdBitrate' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdDuration);
		}
#pragma warning restore 0169

		static IntPtr id_getAdDuration;
		public virtual unsafe global::Java.Lang.Double AdDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdDuration' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdPlayerVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPlayerVersion;
		public virtual unsafe string AdPlayerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdPlayerVersion' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPlayhead);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPlayhead;
		public virtual unsafe global::Java.Lang.Double AdPlayhead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdPlayhead' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPosition;
		public virtual unsafe string AdPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdPosition' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdResource);
		}
#pragma warning restore 0169

		static IntPtr id_getAdResource;
		public virtual unsafe string AdResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdResource' and count(parameter)=0]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getAdTitle;
		public virtual unsafe string AdTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdTitle' and count(parameter)=0]"
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

		static IntPtr id_getAdnalyzerVersion;
		public unsafe string AdnalyzerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getAdnalyzerVersion' and count(parameter)=0]"
			[Register ("getAdnalyzerVersion", "()Ljava/lang/String;", "GetGetAdnalyzerVersionHandler")]
			get {
				if (id_getAdnalyzerVersion == IntPtr.Zero)
					id_getAdnalyzerVersion = JNIEnv.GetMethodID (class_ref, "getAdnalyzerVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdnalyzerVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaPlayhead;
#pragma warning disable 0169
		static Delegate GetGetMediaPlayheadHandler ()
		{
			if (cb_getMediaPlayhead == null)
				cb_getMediaPlayhead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaPlayhead);
			return cb_getMediaPlayhead;
		}

		static IntPtr n_GetMediaPlayhead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaPlayhead);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaPlayhead;
		public virtual unsafe global::Java.Lang.Double MediaPlayhead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='getMediaPlayhead' and count(parameter)=0]"
			[Register ("getMediaPlayhead", "()Ljava/lang/Double;", "GetGetMediaPlayheadHandler")]
			get {
				if (id_getMediaPlayhead == IntPtr.Zero)
					id_getMediaPlayhead = JNIEnv.GetMethodID (class_ref, "getMediaPlayhead", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaPlayhead), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaPlayhead", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bufferedAdHandler;
#pragma warning disable 0169
		static Delegate GetBufferedAdHandlerHandler ()
		{
			if (cb_bufferedAdHandler == null)
				cb_bufferedAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BufferedAdHandler);
			return cb_bufferedAdHandler;
		}

		static void n_BufferedAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BufferedAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_bufferedAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='bufferedAdHandler' and count(parameter)=0]"
		[Register ("bufferedAdHandler", "()V", "GetBufferedAdHandlerHandler")]
		public virtual unsafe void BufferedAdHandler ()
		{
			if (id_bufferedAdHandler == IntPtr.Zero)
				id_bufferedAdHandler = JNIEnv.GetMethodID (class_ref, "bufferedAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bufferedAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bufferedAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_bufferingAdHandler;
#pragma warning disable 0169
		static Delegate GetBufferingAdHandlerHandler ()
		{
			if (cb_bufferingAdHandler == null)
				cb_bufferingAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BufferingAdHandler);
			return cb_bufferingAdHandler;
		}

		static void n_BufferingAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BufferingAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_bufferingAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='bufferingAdHandler' and count(parameter)=0]"
		[Register ("bufferingAdHandler", "()V", "GetBufferingAdHandlerHandler")]
		public virtual unsafe void BufferingAdHandler ()
		{
			if (id_bufferingAdHandler == IntPtr.Zero)
				id_bufferingAdHandler = JNIEnv.GetMethodID (class_ref, "bufferingAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bufferingAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "bufferingAdHandler", "()V"));
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableBufferMonitor ();
		}
#pragma warning restore 0169

		static IntPtr id_enableBufferMonitor;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='enableBufferMonitor' and count(parameter)=0]"
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

		static Delegate cb_endedAdHandler;
#pragma warning disable 0169
		static Delegate GetEndedAdHandlerHandler ()
		{
			if (cb_endedAdHandler == null)
				cb_endedAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndedAdHandler);
			return cb_endedAdHandler;
		}

		static void n_EndedAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndedAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_endedAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='endedAdHandler' and count(parameter)=0]"
		[Register ("endedAdHandler", "()V", "GetEndedAdHandlerHandler")]
		public virtual unsafe void EndedAdHandler ()
		{
			if (id_endedAdHandler == IntPtr.Zero)
				id_endedAdHandler = JNIEnv.GetMethodID (class_ref, "endedAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endedAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endedAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_joinAdHandler;
#pragma warning disable 0169
		static Delegate GetJoinAdHandlerHandler ()
		{
			if (cb_joinAdHandler == null)
				cb_joinAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_JoinAdHandler);
			return cb_joinAdHandler;
		}

		static void n_JoinAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.JoinAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_joinAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='joinAdHandler' and count(parameter)=0]"
		[Register ("joinAdHandler", "()V", "GetJoinAdHandlerHandler")]
		public virtual unsafe void JoinAdHandler ()
		{
			if (id_joinAdHandler == IntPtr.Zero)
				id_joinAdHandler = JNIEnv.GetMethodID (class_ref, "joinAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_joinAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "joinAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_pauseAdHandler;
#pragma warning disable 0169
		static Delegate GetPauseAdHandlerHandler ()
		{
			if (cb_pauseAdHandler == null)
				cb_pauseAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseAdHandler);
			return cb_pauseAdHandler;
		}

		static void n_PauseAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='pauseAdHandler' and count(parameter)=0]"
		[Register ("pauseAdHandler", "()V", "GetPauseAdHandlerHandler")]
		public virtual unsafe void PauseAdHandler ()
		{
			if (id_pauseAdHandler == IntPtr.Zero)
				id_pauseAdHandler = JNIEnv.GetMethodID (class_ref, "pauseAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pauseAdHandler", "()V"));
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseToggleHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_pauseToggleHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='pauseToggleHandler' and count(parameter)=0]"
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

		static Delegate cb_playAdHandler;
#pragma warning disable 0169
		static Delegate GetPlayAdHandlerHandler ()
		{
			if (cb_playAdHandler == null)
				cb_playAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PlayAdHandler);
			return cb_playAdHandler;
		}

		static void n_PlayAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_playAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='playAdHandler' and count(parameter)=0]"
		[Register ("playAdHandler", "()V", "GetPlayAdHandlerHandler")]
		public virtual unsafe void PlayAdHandler ()
		{
			if (id_playAdHandler == IntPtr.Zero)
				id_playAdHandler = JNIEnv.GetMethodID (class_ref, "playAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "playAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_resumeAdHandler;
#pragma warning disable 0169
		static Delegate GetResumeAdHandlerHandler ()
		{
			if (cb_resumeAdHandler == null)
				cb_resumeAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeAdHandler);
			return cb_resumeAdHandler;
		}

		static void n_ResumeAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_resumeAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='resumeAdHandler' and count(parameter)=0]"
		[Register ("resumeAdHandler", "()V", "GetResumeAdHandlerHandler")]
		public virtual unsafe void ResumeAdHandler ()
		{
			if (id_resumeAdHandler == IntPtr.Zero)
				id_resumeAdHandler = JNIEnv.GetMethodID (class_ref, "resumeAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resumeAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_skipAdHandler;
#pragma warning disable 0169
		static Delegate GetSkipAdHandlerHandler ()
		{
			if (cb_skipAdHandler == null)
				cb_skipAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SkipAdHandler);
			return cb_skipAdHandler;
		}

		static void n_SkipAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_skipAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='skipAdHandler' and count(parameter)=0]"
		[Register ("skipAdHandler", "()V", "GetSkipAdHandlerHandler")]
		public virtual unsafe void SkipAdHandler ()
		{
			if (id_skipAdHandler == IntPtr.Zero)
				id_skipAdHandler = JNIEnv.GetMethodID (class_ref, "skipAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipAdHandler", "()V"));
			} finally {
			}
		}

		static Delegate cb_startJoinAdHandler;
#pragma warning disable 0169
		static Delegate GetStartJoinAdHandlerHandler ()
		{
			if (cb_startJoinAdHandler == null)
				cb_startJoinAdHandler = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartJoinAdHandler);
			return cb_startJoinAdHandler;
		}

		static void n_StartJoinAdHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartJoinAdHandler ();
		}
#pragma warning restore 0169

		static IntPtr id_startJoinAdHandler;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='startJoinAdHandler' and count(parameter)=0]"
		[Register ("startJoinAdHandler", "()V", "GetStartJoinAdHandlerHandler")]
		public virtual unsafe void StartJoinAdHandler ()
		{
			if (id_startJoinAdHandler == IntPtr.Zero)
				id_startJoinAdHandler = JNIEnv.GetMethodID (class_ref, "startJoinAdHandler", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startJoinAdHandler);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startJoinAdHandler", "()V"));
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoring (p0);
		}
#pragma warning restore 0169

		static IntPtr id_startMonitoring_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='startMonitoring' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
			global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Adnalyzers.AdnalyzerGeneric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMonitoring ();
		}
#pragma warning restore 0169

		static IntPtr id_stopMonitoring;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.adnalyzers']/class[@name='AdnalyzerGeneric']/method[@name='stopMonitoring' and count(parameter)=0]"
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

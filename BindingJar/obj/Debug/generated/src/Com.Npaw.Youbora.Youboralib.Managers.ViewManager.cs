using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Managers {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/managers/ViewManager", DoNotGenerateAcw=true)]
	public partial class ViewManager : global::Java.Lang.Object {


		static IntPtr chronoAdBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoAdBuffer']"
		[Register ("chronoAdBuffer")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoAdBuffer {
			get {
				if (chronoAdBuffer_jfieldId == IntPtr.Zero)
					chronoAdBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdBuffer", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoAdBuffer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoAdBuffer_jfieldId == IntPtr.Zero)
					chronoAdBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdBuffer", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoAdBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoAdJoinTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoAdJoinTime']"
		[Register ("chronoAdJoinTime")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoAdJoinTime {
			get {
				if (chronoAdJoinTime_jfieldId == IntPtr.Zero)
					chronoAdJoinTime_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdJoinTime", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoAdJoinTime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoAdJoinTime_jfieldId == IntPtr.Zero)
					chronoAdJoinTime_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdJoinTime", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoAdJoinTime_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoAdPause_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoAdPause']"
		[Register ("chronoAdPause")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoAdPause {
			get {
				if (chronoAdPause_jfieldId == IntPtr.Zero)
					chronoAdPause_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdPause", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoAdPause_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoAdPause_jfieldId == IntPtr.Zero)
					chronoAdPause_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdPause", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoAdPause_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoAdTotal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoAdTotal']"
		[Register ("chronoAdTotal")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoAdTotal {
			get {
				if (chronoAdTotal_jfieldId == IntPtr.Zero)
					chronoAdTotal_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdTotal", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoAdTotal_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoAdTotal_jfieldId == IntPtr.Zero)
					chronoAdTotal_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoAdTotal", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoAdTotal_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoBuffer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoBuffer']"
		[Register ("chronoBuffer")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoBuffer {
			get {
				if (chronoBuffer_jfieldId == IntPtr.Zero)
					chronoBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoBuffer", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoBuffer_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoBuffer_jfieldId == IntPtr.Zero)
					chronoBuffer_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoBuffer", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoBuffer_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoGenericAd_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoGenericAd']"
		[Register ("chronoGenericAd")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoGenericAd {
			get {
				if (chronoGenericAd_jfieldId == IntPtr.Zero)
					chronoGenericAd_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoGenericAd", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoGenericAd_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoGenericAd_jfieldId == IntPtr.Zero)
					chronoGenericAd_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoGenericAd", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoGenericAd_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoJoinTime_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoJoinTime']"
		[Register ("chronoJoinTime")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoJoinTime {
			get {
				if (chronoJoinTime_jfieldId == IntPtr.Zero)
					chronoJoinTime_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoJoinTime", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoJoinTime_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoJoinTime_jfieldId == IntPtr.Zero)
					chronoJoinTime_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoJoinTime", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoJoinTime_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoPause_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoPause']"
		[Register ("chronoPause")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoPause {
			get {
				if (chronoPause_jfieldId == IntPtr.Zero)
					chronoPause_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoPause", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoPause_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoPause_jfieldId == IntPtr.Zero)
					chronoPause_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoPause", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoPause_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr chronoSeek_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='chronoSeek']"
		[Register ("chronoSeek")]
		public global::Com.Npaw.Youbora.Youboralib.Utils.Chrono ChronoSeek {
			get {
				if (chronoSeek_jfieldId == IntPtr.Zero)
					chronoSeek_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoSeek", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chronoSeek_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chronoSeek_jfieldId == IntPtr.Zero)
					chronoSeek_jfieldId = JNIEnv.GetFieldID (class_ref, "chronoSeek", "Lcom/npaw/youbora/youboralib/utils/Chrono;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chronoSeek_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr communication_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='communication']"
		[Register ("communication")]
		public global::Com.Npaw.Youbora.Youboralib.Com.Communication Communication {
			get {
				if (communication_jfieldId == IntPtr.Zero)
					communication_jfieldId = JNIEnv.GetFieldID (class_ref, "communication", "Lcom/npaw/youbora/youboralib/com/Communication;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, communication_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Communication> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (communication_jfieldId == IntPtr.Zero)
					communication_jfieldId = JNIEnv.GetFieldID (class_ref, "communication", "Lcom/npaw/youbora/youboralib/com/Communication;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, communication_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr enableAdBufferMonitor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='enableAdBufferMonitor']"
		[Register ("enableAdBufferMonitor")]
		public bool EnableAdBufferMonitor {
			get {
				if (enableAdBufferMonitor_jfieldId == IntPtr.Zero)
					enableAdBufferMonitor_jfieldId = JNIEnv.GetFieldID (class_ref, "enableAdBufferMonitor", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enableAdBufferMonitor_jfieldId);
			}
			set {
				if (enableAdBufferMonitor_jfieldId == IntPtr.Zero)
					enableAdBufferMonitor_jfieldId = JNIEnv.GetFieldID (class_ref, "enableAdBufferMonitor", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enableAdBufferMonitor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr enableBufferMonitor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='enableBufferMonitor']"
		[Register ("enableBufferMonitor")]
		public bool EnableBufferMonitor {
			get {
				if (enableBufferMonitor_jfieldId == IntPtr.Zero)
					enableBufferMonitor_jfieldId = JNIEnv.GetFieldID (class_ref, "enableBufferMonitor", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enableBufferMonitor_jfieldId);
			}
			set {
				if (enableBufferMonitor_jfieldId == IntPtr.Zero)
					enableBufferMonitor_jfieldId = JNIEnv.GetFieldID (class_ref, "enableBufferMonitor", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enableBufferMonitor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr enableSeekMonitor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='enableSeekMonitor']"
		[Register ("enableSeekMonitor")]
		public bool EnableSeekMonitor {
			get {
				if (enableSeekMonitor_jfieldId == IntPtr.Zero)
					enableSeekMonitor_jfieldId = JNIEnv.GetFieldID (class_ref, "enableSeekMonitor", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, enableSeekMonitor_jfieldId);
			}
			set {
				if (enableSeekMonitor_jfieldId == IntPtr.Zero)
					enableSeekMonitor_jfieldId = JNIEnv.GetFieldID (class_ref, "enableSeekMonitor", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, enableSeekMonitor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr infoManager_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='infoManager']"
		[Register ("infoManager")]
		public global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager InfoManager {
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

		static IntPtr isAdBuffering_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isAdBuffering']"
		[Register ("isAdBuffering")]
		public bool IsAdBuffering {
			get {
				if (isAdBuffering_jfieldId == IntPtr.Zero)
					isAdBuffering_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdBuffering", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isAdBuffering_jfieldId);
			}
			set {
				if (isAdBuffering_jfieldId == IntPtr.Zero)
					isAdBuffering_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdBuffering", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isAdBuffering_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isAdJoinSent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isAdJoinSent']"
		[Register ("isAdJoinSent")]
		public bool IsAdJoinSent {
			get {
				if (isAdJoinSent_jfieldId == IntPtr.Zero)
					isAdJoinSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdJoinSent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isAdJoinSent_jfieldId);
			}
			set {
				if (isAdJoinSent_jfieldId == IntPtr.Zero)
					isAdJoinSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdJoinSent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isAdJoinSent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isAdPaused_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isAdPaused']"
		[Register ("isAdPaused")]
		public bool IsAdPaused {
			get {
				if (isAdPaused_jfieldId == IntPtr.Zero)
					isAdPaused_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdPaused", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isAdPaused_jfieldId);
			}
			set {
				if (isAdPaused_jfieldId == IntPtr.Zero)
					isAdPaused_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdPaused", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isAdPaused_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isAdStartSent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isAdStartSent']"
		[Register ("isAdStartSent")]
		public bool IsAdStartSent {
			get {
				if (isAdStartSent_jfieldId == IntPtr.Zero)
					isAdStartSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdStartSent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isAdStartSent_jfieldId);
			}
			set {
				if (isAdStartSent_jfieldId == IntPtr.Zero)
					isAdStartSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isAdStartSent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isAdStartSent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isBuffering_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isBuffering']"
		[Register ("isBuffering")]
		public bool IsBuffering {
			get {
				if (isBuffering_jfieldId == IntPtr.Zero)
					isBuffering_jfieldId = JNIEnv.GetFieldID (class_ref, "isBuffering", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isBuffering_jfieldId);
			}
			set {
				if (isBuffering_jfieldId == IntPtr.Zero)
					isBuffering_jfieldId = JNIEnv.GetFieldID (class_ref, "isBuffering", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isBuffering_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isErrorSent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isErrorSent']"
		[Register ("isErrorSent")]
		public bool IsErrorSent {
			get {
				if (isErrorSent_jfieldId == IntPtr.Zero)
					isErrorSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isErrorSent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isErrorSent_jfieldId);
			}
			set {
				if (isErrorSent_jfieldId == IntPtr.Zero)
					isErrorSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isErrorSent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isErrorSent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isJoinSent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isJoinSent']"
		[Register ("isJoinSent")]
		public bool IsJoinSent {
			get {
				if (isJoinSent_jfieldId == IntPtr.Zero)
					isJoinSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isJoinSent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isJoinSent_jfieldId);
			}
			set {
				if (isJoinSent_jfieldId == IntPtr.Zero)
					isJoinSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isJoinSent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isJoinSent_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isPaused_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isPaused']"
		[Register ("isPaused")]
		public bool IsPaused {
			get {
				if (isPaused_jfieldId == IntPtr.Zero)
					isPaused_jfieldId = JNIEnv.GetFieldID (class_ref, "isPaused", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isPaused_jfieldId);
			}
			set {
				if (isPaused_jfieldId == IntPtr.Zero)
					isPaused_jfieldId = JNIEnv.GetFieldID (class_ref, "isPaused", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isPaused_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isSeeking_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isSeeking']"
		[Register ("isSeeking")]
		public bool IsSeeking {
			get {
				if (isSeeking_jfieldId == IntPtr.Zero)
					isSeeking_jfieldId = JNIEnv.GetFieldID (class_ref, "isSeeking", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isSeeking_jfieldId);
			}
			set {
				if (isSeeking_jfieldId == IntPtr.Zero)
					isSeeking_jfieldId = JNIEnv.GetFieldID (class_ref, "isSeeking", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isSeeking_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isShowingAds_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isShowingAds']"
		[Register ("isShowingAds")]
		public bool IsShowingAds {
			get {
				if (isShowingAds_jfieldId == IntPtr.Zero)
					isShowingAds_jfieldId = JNIEnv.GetFieldID (class_ref, "isShowingAds", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isShowingAds_jfieldId);
			}
			set {
				if (isShowingAds_jfieldId == IntPtr.Zero)
					isShowingAds_jfieldId = JNIEnv.GetFieldID (class_ref, "isShowingAds", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isShowingAds_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isStartSent_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/field[@name='isStartSent']"
		[Register ("isStartSent")]
		public bool IsStartSent {
			get {
				if (isStartSent_jfieldId == IntPtr.Zero)
					isStartSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isStartSent", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isStartSent_jfieldId);
			}
			set {
				if (isStartSent_jfieldId == IntPtr.Zero)
					isStartSent_jfieldId = JNIEnv.GetFieldID (class_ref, "isStartSent", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isStartSent_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/managers/ViewManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ViewManager); }
		}

		protected ViewManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_npaw_youbora_youboralib_managers_InfoManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/constructor[@name='ViewManager' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.managers.InfoManager']]"
		[Register (".ctor", "(Lcom/npaw/youbora/youboralib/managers/InfoManager;)V", "")]
		public unsafe ViewManager (global::Com.Npaw.Youbora.Youboralib.Managers.InfoManager p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ViewManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/youboralib/managers/InfoManager;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/youboralib/managers/InfoManager;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_youboralib_managers_InfoManager_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_youboralib_managers_InfoManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/youboralib/managers/InfoManager;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_youboralib_managers_InfoManager_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_youboralib_managers_InfoManager_, __args);
			} finally {
			}
		}

		static IntPtr id_getMonitoringInterval;
		static IntPtr id_setMonitoringInterval_J;
		public static unsafe long MonitoringInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='getMonitoringInterval' and count(parameter)=0]"
			[Register ("getMonitoringInterval", "()J", "GetGetMonitoringIntervalHandler")]
			get {
				if (id_getMonitoringInterval == IntPtr.Zero)
					id_getMonitoringInterval = JNIEnv.GetStaticMethodID (class_ref, "getMonitoringInterval", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getMonitoringInterval);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='setMonitoringInterval' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMonitoringInterval", "(J)V", "GetSetMonitoringInterval_JHandler")]
			set {
				if (id_setMonitoringInterval_J == IntPtr.Zero)
					id_setMonitoringInterval_J = JNIEnv.GetStaticMethodID (class_ref, "setMonitoringInterval", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setMonitoringInterval_J, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResourceParser;
#pragma warning disable 0169
		static Delegate GetGetResourceParserHandler ()
		{
			if (cb_getResourceParser == null)
				cb_getResourceParser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceParser);
			return cb_getResourceParser;
		}

		static IntPtr n_GetResourceParser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ResourceParser);
		}
#pragma warning restore 0169

		static IntPtr id_getResourceParser;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser ResourceParser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='getResourceParser' and count(parameter)=0]"
			[Register ("getResourceParser", "()Lcom/npaw/youbora/youboralib/services/resourceparser/ResourceParser;", "GetGetResourceParserHandler")]
			get {
				if (id_getResourceParser == IntPtr.Zero)
					id_getResourceParser = JNIEnv.GetMethodID (class_ref, "getResourceParser", "()Lcom/npaw/youbora/youboralib/services/resourceparser/ResourceParser;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceParser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Services.Resourceparser.ResourceParser> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceParser", "()Lcom/npaw/youbora/youboralib/services/resourceparser/ResourceParser;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkAdPlayhead;
#pragma warning disable 0169
		static Delegate GetCheckAdPlayheadHandler ()
		{
			if (cb_checkAdPlayhead == null)
				cb_checkAdPlayhead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckAdPlayhead);
			return cb_checkAdPlayhead;
		}

		static void n_CheckAdPlayhead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckAdPlayhead ();
		}
#pragma warning restore 0169

		static IntPtr id_checkAdPlayhead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='checkAdPlayhead' and count(parameter)=0]"
		[Register ("checkAdPlayhead", "()V", "GetCheckAdPlayheadHandler")]
		protected virtual unsafe void CheckAdPlayhead ()
		{
			if (id_checkAdPlayhead == IntPtr.Zero)
				id_checkAdPlayhead = JNIEnv.GetMethodID (class_ref, "checkAdPlayhead", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkAdPlayhead);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAdPlayhead", "()V"));
			} finally {
			}
		}

		static Delegate cb_checkPlayhead;
#pragma warning disable 0169
		static Delegate GetCheckPlayheadHandler ()
		{
			if (cb_checkPlayhead == null)
				cb_checkPlayhead = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckPlayhead);
			return cb_checkPlayhead;
		}

		static void n_CheckPlayhead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckPlayhead ();
		}
#pragma warning restore 0169

		static IntPtr id_checkPlayhead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='checkPlayhead' and count(parameter)=0]"
		[Register ("checkPlayhead", "()V", "GetCheckPlayheadHandler")]
		protected virtual unsafe void CheckPlayhead ()
		{
			if (id_checkPlayhead == IntPtr.Zero)
				id_checkPlayhead = JNIEnv.GetMethodID (class_ref, "checkPlayhead", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkPlayhead);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkPlayhead", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdBufferEnd;
#pragma warning disable 0169
		static Delegate GetSendAdBufferEndHandler ()
		{
			if (cb_sendAdBufferEnd == null)
				cb_sendAdBufferEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdBufferEnd);
			return cb_sendAdBufferEnd;
		}

		static void n_SendAdBufferEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdBufferEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdBufferEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdBufferEnd' and count(parameter)=0]"
		[Register ("sendAdBufferEnd", "()V", "GetSendAdBufferEndHandler")]
		public virtual unsafe void SendAdBufferEnd ()
		{
			if (id_sendAdBufferEnd == IntPtr.Zero)
				id_sendAdBufferEnd = JNIEnv.GetMethodID (class_ref, "sendAdBufferEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdBufferEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdBufferEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdBufferEnd_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendAdBufferEnd_Ljava_util_Map_Handler ()
		{
			if (cb_sendAdBufferEnd_Ljava_util_Map_ == null)
				cb_sendAdBufferEnd_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAdBufferEnd_Ljava_util_Map_);
			return cb_sendAdBufferEnd_Ljava_util_Map_;
		}

		static void n_SendAdBufferEnd_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAdBufferEnd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdBufferEnd_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdBufferEnd' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendAdBufferEnd", "(Ljava/util/Map;)V", "GetSendAdBufferEnd_Ljava_util_Map_Handler")]
		public virtual unsafe void SendAdBufferEnd (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendAdBufferEnd_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAdBufferEnd_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendAdBufferEnd", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdBufferEnd_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdBufferEnd", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendAdBufferEnd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdBufferEnd' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendAdBufferEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendAdBufferEnd (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendAdBufferEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdBufferEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdBufferStart;
#pragma warning disable 0169
		static Delegate GetSendAdBufferStartHandler ()
		{
			if (cb_sendAdBufferStart == null)
				cb_sendAdBufferStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdBufferStart);
			return cb_sendAdBufferStart;
		}

		static void n_SendAdBufferStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdBufferStart ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdBufferStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdBufferStart' and count(parameter)=0]"
		[Register ("sendAdBufferStart", "()V", "GetSendAdBufferStartHandler")]
		public virtual unsafe void SendAdBufferStart ()
		{
			if (id_sendAdBufferStart == IntPtr.Zero)
				id_sendAdBufferStart = JNIEnv.GetMethodID (class_ref, "sendAdBufferStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdBufferStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdBufferStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdJoin;
#pragma warning disable 0169
		static Delegate GetSendAdJoinHandler ()
		{
			if (cb_sendAdJoin == null)
				cb_sendAdJoin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdJoin);
			return cb_sendAdJoin;
		}

		static void n_SendAdJoin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdJoin ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdJoin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdJoin' and count(parameter)=0]"
		[Register ("sendAdJoin", "()V", "GetSendAdJoinHandler")]
		public virtual unsafe void SendAdJoin ()
		{
			if (id_sendAdJoin == IntPtr.Zero)
				id_sendAdJoin = JNIEnv.GetMethodID (class_ref, "sendAdJoin", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdJoin);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdJoin", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdJoin_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendAdJoin_Ljava_util_Map_Handler ()
		{
			if (cb_sendAdJoin_Ljava_util_Map_ == null)
				cb_sendAdJoin_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAdJoin_Ljava_util_Map_);
			return cb_sendAdJoin_Ljava_util_Map_;
		}

		static void n_SendAdJoin_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAdJoin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdJoin_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdJoin' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendAdJoin", "(Ljava/util/Map;)V", "GetSendAdJoin_Ljava_util_Map_Handler")]
		public virtual unsafe void SendAdJoin (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendAdJoin_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAdJoin_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendAdJoin", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdJoin_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdJoin", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendAdJoin (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdJoin' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendAdJoin", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendAdJoin (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendAdJoin", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdJoin", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdPause;
#pragma warning disable 0169
		static Delegate GetSendAdPauseHandler ()
		{
			if (cb_sendAdPause == null)
				cb_sendAdPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdPause);
			return cb_sendAdPause;
		}

		static void n_SendAdPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdPause ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdPause' and count(parameter)=0]"
		[Register ("sendAdPause", "()V", "GetSendAdPauseHandler")]
		public virtual unsafe void SendAdPause ()
		{
			if (id_sendAdPause == IntPtr.Zero)
				id_sendAdPause = JNIEnv.GetMethodID (class_ref, "sendAdPause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdPause_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendAdPause_Ljava_util_Map_Handler ()
		{
			if (cb_sendAdPause_Ljava_util_Map_ == null)
				cb_sendAdPause_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAdPause_Ljava_util_Map_);
			return cb_sendAdPause_Ljava_util_Map_;
		}

		static void n_SendAdPause_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAdPause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdPause_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdPause' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendAdPause", "(Ljava/util/Map;)V", "GetSendAdPause_Ljava_util_Map_Handler")]
		public virtual unsafe void SendAdPause (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendAdPause_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAdPause_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendAdPause", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdPause_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdPause", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendAdPause (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdPause' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendAdPause", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendAdPause (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendAdPause", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdPause", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdResume;
#pragma warning disable 0169
		static Delegate GetSendAdResumeHandler ()
		{
			if (cb_sendAdResume == null)
				cb_sendAdResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdResume);
			return cb_sendAdResume;
		}

		static void n_SendAdResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdResume ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdResume' and count(parameter)=0]"
		[Register ("sendAdResume", "()V", "GetSendAdResumeHandler")]
		public virtual unsafe void SendAdResume ()
		{
			if (id_sendAdResume == IntPtr.Zero)
				id_sendAdResume = JNIEnv.GetMethodID (class_ref, "sendAdResume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdResume_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendAdResume_Ljava_util_Map_Handler ()
		{
			if (cb_sendAdResume_Ljava_util_Map_ == null)
				cb_sendAdResume_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAdResume_Ljava_util_Map_);
			return cb_sendAdResume_Ljava_util_Map_;
		}

		static void n_SendAdResume_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAdResume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdResume_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdResume' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendAdResume", "(Ljava/util/Map;)V", "GetSendAdResume_Ljava_util_Map_Handler")]
		public virtual unsafe void SendAdResume (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendAdResume_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAdResume_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendAdResume", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdResume_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdResume", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendAdResume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdResume' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendAdResume", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendAdResume (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendAdResume", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdResume", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdStart;
#pragma warning disable 0169
		static Delegate GetSendAdStartHandler ()
		{
			if (cb_sendAdStart == null)
				cb_sendAdStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdStart);
			return cb_sendAdStart;
		}

		static void n_SendAdStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdStart ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdStart' and count(parameter)=0]"
		[Register ("sendAdStart", "()V", "GetSendAdStartHandler")]
		public virtual unsafe void SendAdStart ()
		{
			if (id_sendAdStart == IntPtr.Zero)
				id_sendAdStart = JNIEnv.GetMethodID (class_ref, "sendAdStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdStart_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendAdStart_Ljava_util_Map_Handler ()
		{
			if (cb_sendAdStart_Ljava_util_Map_ == null)
				cb_sendAdStart_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAdStart_Ljava_util_Map_);
			return cb_sendAdStart_Ljava_util_Map_;
		}

		static void n_SendAdStart_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAdStart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdStart_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdStart' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendAdStart", "(Ljava/util/Map;)V", "GetSendAdStart_Ljava_util_Map_Handler")]
		public virtual unsafe void SendAdStart (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendAdStart_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAdStart_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendAdStart", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdStart_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdStart", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendAdStart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdStart' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendAdStart", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendAdStart (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendAdStart", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdStart", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdStop;
#pragma warning disable 0169
		static Delegate GetSendAdStopHandler ()
		{
			if (cb_sendAdStop == null)
				cb_sendAdStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendAdStop);
			return cb_sendAdStop;
		}

		static void n_SendAdStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendAdStop ();
		}
#pragma warning restore 0169

		static IntPtr id_sendAdStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdStop' and count(parameter)=0]"
		[Register ("sendAdStop", "()V", "GetSendAdStopHandler")]
		public virtual unsafe void SendAdStop ()
		{
			if (id_sendAdStop == IntPtr.Zero)
				id_sendAdStop = JNIEnv.GetMethodID (class_ref, "sendAdStop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdStop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdStop", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendAdStop_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendAdStop_Ljava_util_Map_Handler ()
		{
			if (cb_sendAdStop_Ljava_util_Map_ == null)
				cb_sendAdStop_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendAdStop_Ljava_util_Map_);
			return cb_sendAdStop_Ljava_util_Map_;
		}

		static void n_SendAdStop_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendAdStop (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdStop_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdStop' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendAdStop", "(Ljava/util/Map;)V", "GetSendAdStop_Ljava_util_Map_Handler")]
		public virtual unsafe void SendAdStop (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendAdStop_Ljava_util_Map_ == IntPtr.Zero)
				id_sendAdStop_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendAdStop", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdStop_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdStop", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendAdStop (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendAdStop' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendAdStop", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendAdStop (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendAdStop", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendAdStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendAdStop", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendBufferEnd;
#pragma warning disable 0169
		static Delegate GetSendBufferEndHandler ()
		{
			if (cb_sendBufferEnd == null)
				cb_sendBufferEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendBufferEnd);
			return cb_sendBufferEnd;
		}

		static void n_SendBufferEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendBufferEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_sendBufferEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendBufferEnd' and count(parameter)=0]"
		[Register ("sendBufferEnd", "()V", "GetSendBufferEndHandler")]
		public virtual unsafe void SendBufferEnd ()
		{
			if (id_sendBufferEnd == IntPtr.Zero)
				id_sendBufferEnd = JNIEnv.GetMethodID (class_ref, "sendBufferEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBufferEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendBufferEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendBufferEnd_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendBufferEnd_Ljava_util_Map_Handler ()
		{
			if (cb_sendBufferEnd_Ljava_util_Map_ == null)
				cb_sendBufferEnd_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendBufferEnd_Ljava_util_Map_);
			return cb_sendBufferEnd_Ljava_util_Map_;
		}

		static void n_SendBufferEnd_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendBufferEnd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendBufferEnd_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendBufferEnd' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendBufferEnd", "(Ljava/util/Map;)V", "GetSendBufferEnd_Ljava_util_Map_Handler")]
		public virtual unsafe void SendBufferEnd (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendBufferEnd_Ljava_util_Map_ == IntPtr.Zero)
				id_sendBufferEnd_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendBufferEnd", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBufferEnd_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendBufferEnd", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendBufferEnd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendBufferEnd' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendBufferEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendBufferEnd (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendBufferEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBufferEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendBufferEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendBufferStart;
#pragma warning disable 0169
		static Delegate GetSendBufferStartHandler ()
		{
			if (cb_sendBufferStart == null)
				cb_sendBufferStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendBufferStart);
			return cb_sendBufferStart;
		}

		static void n_SendBufferStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendBufferStart ();
		}
#pragma warning restore 0169

		static IntPtr id_sendBufferStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendBufferStart' and count(parameter)=0]"
		[Register ("sendBufferStart", "()V", "GetSendBufferStartHandler")]
		public virtual unsafe void SendBufferStart ()
		{
			if (id_sendBufferStart == IntPtr.Zero)
				id_sendBufferStart = JNIEnv.GetMethodID (class_ref, "sendBufferStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendBufferStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendBufferStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendError;
#pragma warning disable 0169
		static Delegate GetSendErrorHandler ()
		{
			if (cb_sendError == null)
				cb_sendError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendError);
			return cb_sendError;
		}

		static void n_SendError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendError ();
		}
#pragma warning restore 0169

		static IntPtr id_sendError;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendError' and count(parameter)=0]"
		[Register ("sendError", "()V", "GetSendErrorHandler")]
		public virtual unsafe void SendError ()
		{
			if (id_sendError == IntPtr.Zero)
				id_sendError = JNIEnv.GetMethodID (class_ref, "sendError", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendError);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendError", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendError_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendError_Ljava_util_Map_Handler ()
		{
			if (cb_sendError_Ljava_util_Map_ == null)
				cb_sendError_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendError_Ljava_util_Map_);
			return cb_sendError_Ljava_util_Map_;
		}

		static void n_SendError_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendError_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendError' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendError", "(Ljava/util/Map;)V", "GetSendError_Ljava_util_Map_Handler")]
		public virtual unsafe void SendError (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendError_Ljava_util_Map_ == IntPtr.Zero)
				id_sendError_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendError", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendError_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendError", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendError' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendError", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendError (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendError", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendError_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendError", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendIgnoreAdEnd;
#pragma warning disable 0169
		static Delegate GetSendIgnoreAdEndHandler ()
		{
			if (cb_sendIgnoreAdEnd == null)
				cb_sendIgnoreAdEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendIgnoreAdEnd);
			return cb_sendIgnoreAdEnd;
		}

		static void n_SendIgnoreAdEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendIgnoreAdEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_sendIgnoreAdEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendIgnoreAdEnd' and count(parameter)=0]"
		[Register ("sendIgnoreAdEnd", "()V", "GetSendIgnoreAdEndHandler")]
		public virtual unsafe void SendIgnoreAdEnd ()
		{
			if (id_sendIgnoreAdEnd == IntPtr.Zero)
				id_sendIgnoreAdEnd = JNIEnv.GetMethodID (class_ref, "sendIgnoreAdEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendIgnoreAdEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendIgnoreAdEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendIgnoreAdStart;
#pragma warning disable 0169
		static Delegate GetSendIgnoreAdStartHandler ()
		{
			if (cb_sendIgnoreAdStart == null)
				cb_sendIgnoreAdStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendIgnoreAdStart);
			return cb_sendIgnoreAdStart;
		}

		static void n_SendIgnoreAdStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendIgnoreAdStart ();
		}
#pragma warning restore 0169

		static IntPtr id_sendIgnoreAdStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendIgnoreAdStart' and count(parameter)=0]"
		[Register ("sendIgnoreAdStart", "()V", "GetSendIgnoreAdStartHandler")]
		public virtual unsafe void SendIgnoreAdStart ()
		{
			if (id_sendIgnoreAdStart == IntPtr.Zero)
				id_sendIgnoreAdStart = JNIEnv.GetMethodID (class_ref, "sendIgnoreAdStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendIgnoreAdStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendIgnoreAdStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendJoin;
#pragma warning disable 0169
		static Delegate GetSendJoinHandler ()
		{
			if (cb_sendJoin == null)
				cb_sendJoin = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendJoin);
			return cb_sendJoin;
		}

		static void n_SendJoin (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendJoin ();
		}
#pragma warning restore 0169

		static IntPtr id_sendJoin;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendJoin' and count(parameter)=0]"
		[Register ("sendJoin", "()V", "GetSendJoinHandler")]
		public virtual unsafe void SendJoin ()
		{
			if (id_sendJoin == IntPtr.Zero)
				id_sendJoin = JNIEnv.GetMethodID (class_ref, "sendJoin", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendJoin);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendJoin", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendJoin_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendJoin_Ljava_util_Map_Handler ()
		{
			if (cb_sendJoin_Ljava_util_Map_ == null)
				cb_sendJoin_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendJoin_Ljava_util_Map_);
			return cb_sendJoin_Ljava_util_Map_;
		}

		static void n_SendJoin_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendJoin (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendJoin_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendJoin' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendJoin", "(Ljava/util/Map;)V", "GetSendJoin_Ljava_util_Map_Handler")]
		public virtual unsafe void SendJoin (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendJoin_Ljava_util_Map_ == IntPtr.Zero)
				id_sendJoin_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendJoin", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendJoin_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendJoin", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendJoin (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendJoin' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendJoin", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendJoin (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendJoin", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendJoin_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendJoin", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendPause;
#pragma warning disable 0169
		static Delegate GetSendPauseHandler ()
		{
			if (cb_sendPause == null)
				cb_sendPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendPause);
			return cb_sendPause;
		}

		static void n_SendPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendPause ();
		}
#pragma warning restore 0169

		static IntPtr id_sendPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendPause' and count(parameter)=0]"
		[Register ("sendPause", "()V", "GetSendPauseHandler")]
		public virtual unsafe void SendPause ()
		{
			if (id_sendPause == IntPtr.Zero)
				id_sendPause = JNIEnv.GetMethodID (class_ref, "sendPause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendPause_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendPause_Ljava_util_Map_Handler ()
		{
			if (cb_sendPause_Ljava_util_Map_ == null)
				cb_sendPause_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendPause_Ljava_util_Map_);
			return cb_sendPause_Ljava_util_Map_;
		}

		static void n_SendPause_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendPause (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendPause_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendPause' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendPause", "(Ljava/util/Map;)V", "GetSendPause_Ljava_util_Map_Handler")]
		public virtual unsafe void SendPause (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendPause_Ljava_util_Map_ == IntPtr.Zero)
				id_sendPause_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendPause", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPause_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPause", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendPause (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendPause' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendPause", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendPause (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendPause", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPause_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPause", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendPing_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendPing_Ljava_util_Map_Handler ()
		{
			if (cb_sendPing_Ljava_util_Map_ == null)
				cb_sendPing_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendPing_Ljava_util_Map_);
			return cb_sendPing_Ljava_util_Map_;
		}

		static void n_SendPing_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendPing (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendPing_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendPing' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendPing", "(Ljava/util/Map;)V", "GetSendPing_Ljava_util_Map_Handler")]
		public virtual unsafe void SendPing (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendPing_Ljava_util_Map_ == IntPtr.Zero)
				id_sendPing_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendPing", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPing_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPing", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendPing (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendPing' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendPing", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendPing (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendPing", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPing_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPing", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendResume;
#pragma warning disable 0169
		static Delegate GetSendResumeHandler ()
		{
			if (cb_sendResume == null)
				cb_sendResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendResume);
			return cb_sendResume;
		}

		static void n_SendResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendResume ();
		}
#pragma warning restore 0169

		static IntPtr id_sendResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendResume' and count(parameter)=0]"
		[Register ("sendResume", "()V", "GetSendResumeHandler")]
		public virtual unsafe void SendResume ()
		{
			if (id_sendResume == IntPtr.Zero)
				id_sendResume = JNIEnv.GetMethodID (class_ref, "sendResume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendResume_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendResume_Ljava_util_Map_Handler ()
		{
			if (cb_sendResume_Ljava_util_Map_ == null)
				cb_sendResume_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendResume_Ljava_util_Map_);
			return cb_sendResume_Ljava_util_Map_;
		}

		static void n_SendResume_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendResume (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendResume_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendResume' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendResume", "(Ljava/util/Map;)V", "GetSendResume_Ljava_util_Map_Handler")]
		public virtual unsafe void SendResume (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendResume_Ljava_util_Map_ == IntPtr.Zero)
				id_sendResume_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendResume", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendResume_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendResume", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendResume (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendResume' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendResume", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendResume (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendResume", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendResume_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendResume", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendSeekEnd;
#pragma warning disable 0169
		static Delegate GetSendSeekEndHandler ()
		{
			if (cb_sendSeekEnd == null)
				cb_sendSeekEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendSeekEnd);
			return cb_sendSeekEnd;
		}

		static void n_SendSeekEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendSeekEnd ();
		}
#pragma warning restore 0169

		static IntPtr id_sendSeekEnd;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendSeekEnd' and count(parameter)=0]"
		[Register ("sendSeekEnd", "()V", "GetSendSeekEndHandler")]
		public virtual unsafe void SendSeekEnd ()
		{
			if (id_sendSeekEnd == IntPtr.Zero)
				id_sendSeekEnd = JNIEnv.GetMethodID (class_ref, "sendSeekEnd", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSeekEnd);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSeekEnd", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendSeekEnd_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendSeekEnd_Ljava_util_Map_Handler ()
		{
			if (cb_sendSeekEnd_Ljava_util_Map_ == null)
				cb_sendSeekEnd_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendSeekEnd_Ljava_util_Map_);
			return cb_sendSeekEnd_Ljava_util_Map_;
		}

		static void n_SendSeekEnd_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendSeekEnd (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendSeekEnd_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendSeekEnd' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendSeekEnd", "(Ljava/util/Map;)V", "GetSendSeekEnd_Ljava_util_Map_Handler")]
		public virtual unsafe void SendSeekEnd (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendSeekEnd_Ljava_util_Map_ == IntPtr.Zero)
				id_sendSeekEnd_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendSeekEnd", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSeekEnd_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSeekEnd", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendSeekEnd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendSeekEnd' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendSeekEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendSeekEnd (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendSeekEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSeekEnd_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSeekEnd", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendSeekStart;
#pragma warning disable 0169
		static Delegate GetSendSeekStartHandler ()
		{
			if (cb_sendSeekStart == null)
				cb_sendSeekStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendSeekStart);
			return cb_sendSeekStart;
		}

		static void n_SendSeekStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendSeekStart ();
		}
#pragma warning restore 0169

		static IntPtr id_sendSeekStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendSeekStart' and count(parameter)=0]"
		[Register ("sendSeekStart", "()V", "GetSendSeekStartHandler")]
		public virtual unsafe void SendSeekStart ()
		{
			if (id_sendSeekStart == IntPtr.Zero)
				id_sendSeekStart = JNIEnv.GetMethodID (class_ref, "sendSeekStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSeekStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSeekStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendStart;
#pragma warning disable 0169
		static Delegate GetSendStartHandler ()
		{
			if (cb_sendStart == null)
				cb_sendStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendStart);
			return cb_sendStart;
		}

		static void n_SendStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendStart ();
		}
#pragma warning restore 0169

		static IntPtr id_sendStart;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendStart' and count(parameter)=0]"
		[Register ("sendStart", "()V", "GetSendStartHandler")]
		public virtual unsafe void SendStart ()
		{
			if (id_sendStart == IntPtr.Zero)
				id_sendStart = JNIEnv.GetMethodID (class_ref, "sendStart", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStart);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStart", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendStart_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendStart_Ljava_util_Map_Handler ()
		{
			if (cb_sendStart_Ljava_util_Map_ == null)
				cb_sendStart_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendStart_Ljava_util_Map_);
			return cb_sendStart_Ljava_util_Map_;
		}

		static void n_SendStart_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendStart (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendStart_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendStart' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendStart", "(Ljava/util/Map;)V", "GetSendStart_Ljava_util_Map_Handler")]
		public virtual unsafe void SendStart (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendStart_Ljava_util_Map_ == IntPtr.Zero)
				id_sendStart_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendStart", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStart_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStart", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendStart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendStart' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendStart", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendStart (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendStart", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStart_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStart", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendStop;
#pragma warning disable 0169
		static Delegate GetSendStopHandler ()
		{
			if (cb_sendStop == null)
				cb_sendStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendStop);
			return cb_sendStop;
		}

		static void n_SendStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendStop ();
		}
#pragma warning restore 0169

		static IntPtr id_sendStop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendStop' and count(parameter)=0]"
		[Register ("sendStop", "()V", "GetSendStopHandler")]
		public virtual unsafe void SendStop ()
		{
			if (id_sendStop == IntPtr.Zero)
				id_sendStop = JNIEnv.GetMethodID (class_ref, "sendStop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStop", "()V"));
			} finally {
			}
		}

		static Delegate cb_sendStop_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSendStop_Ljava_util_Map_Handler ()
		{
			if (cb_sendStop_Ljava_util_Map_ == null)
				cb_sendStop_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendStop_Ljava_util_Map_);
			return cb_sendStop_Ljava_util_Map_;
		}

		static void n_SendStop_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendStop (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendStop_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendStop' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("sendStop", "(Ljava/util/Map;)V", "GetSendStop_Ljava_util_Map_Handler")]
		public virtual unsafe void SendStop (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_sendStop_Ljava_util_Map_ == IntPtr.Zero)
				id_sendStop_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "sendStop", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStop_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStop", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
#pragma warning disable 0169
		static Delegate GetSendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler ()
		{
			if (cb_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == null)
				cb_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_);
			return cb_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		}

		static void n_SendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1 = (global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener)global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendStop (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='sendStop' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[2][@type='com.npaw.youbora.youboralib.com.Request.OnSuccessListener']]"
		[Register ("sendStop", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V", "GetSendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_Handler")]
		public virtual unsafe void SendStop (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0, global::Com.Npaw.Youbora.Youboralib.Com.Request.IOnSuccessListener p1)
		{
			if (id_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ == IntPtr.Zero)
				id_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_ = JNIEnv.GetMethodID (class_ref, "sendStop", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendStop_Ljava_util_Map_Lcom_npaw_youbora_youboralib_com_Request_OnSuccessListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendStop", "(Ljava/util/Map;Lcom/npaw/youbora/youboralib/com/Request$OnSuccessListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetChangedEntity_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetChangedEntity_Ljava_lang_String_Ljava_lang_Object_);
			return cb_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_SetChangedEntity_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetChangedEntity (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='setChangedEntity' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setChangedEntity", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetSetChangedEntity_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetChangedEntity (string p0, global::Java.Lang.Object p1)
		{
			if (id_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setChangedEntity", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChangedEntity_Ljava_lang_String_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChangedEntity", "(Ljava/lang/String;Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startTimers;
#pragma warning disable 0169
		static Delegate GetStartTimersHandler ()
		{
			if (cb_startTimers == null)
				cb_startTimers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartTimers);
			return cb_startTimers;
		}

		static void n_StartTimers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTimers ();
		}
#pragma warning restore 0169

		static IntPtr id_startTimers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='startTimers' and count(parameter)=0]"
		[Register ("startTimers", "()V", "GetStartTimersHandler")]
		public virtual unsafe void StartTimers ()
		{
			if (id_startTimers == IntPtr.Zero)
				id_startTimers = JNIEnv.GetMethodID (class_ref, "startTimers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startTimers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startTimers", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopTimers;
#pragma warning disable 0169
		static Delegate GetStopTimersHandler ()
		{
			if (cb_stopTimers == null)
				cb_stopTimers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopTimers);
			return cb_stopTimers;
		}

		static void n_StopTimers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Managers.ViewManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTimers ();
		}
#pragma warning restore 0169

		static IntPtr id_stopTimers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.managers']/class[@name='ViewManager']/method[@name='stopTimers' and count(parameter)=0]"
		[Register ("stopTimers", "()V", "GetStopTimersHandler")]
		public virtual unsafe void StopTimers ()
		{
			if (id_stopTimers == IntPtr.Zero)
				id_stopTimers = JNIEnv.GetMethodID (class_ref, "stopTimers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopTimers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopTimers", "()V"));
			} finally {
			}
		}

	}
}

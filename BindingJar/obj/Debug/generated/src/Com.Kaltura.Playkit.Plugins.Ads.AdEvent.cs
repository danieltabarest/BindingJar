using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent", DoNotGenerateAcw=true)]
	public partial class AdEvent : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPKEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdCuePointsUpdateEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdCuePointsUpdateEvent", DoNotGenerateAcw=true)]
		public partial class AdCuePointsUpdateEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr cuePoints_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdCuePointsUpdateEvent']/field[@name='cuePoints']"
			[Register ("cuePoints")]
			public global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints CuePoints {
				get {
					if (cuePoints_jfieldId == IntPtr.Zero)
						cuePoints_jfieldId = JNIEnv.GetFieldID (class_ref, "cuePoints", "Lcom/kaltura/playkit/plugins/ads/AdCuePoints;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, cuePoints_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (cuePoints_jfieldId == IntPtr.Zero)
						cuePoints_jfieldId = JNIEnv.GetFieldID (class_ref, "cuePoints", "Lcom/kaltura/playkit/plugins/ads/AdCuePoints;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, cuePoints_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdCuePointsUpdateEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdCuePointsUpdateEvent); }
			}

			protected AdCuePointsUpdateEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdCuePoints_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdCuePointsUpdateEvent']/constructor[@name='AdEvent.AdCuePointsUpdateEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdCuePoints']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdCuePoints;)V", "")]
			public unsafe AdCuePointsUpdateEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdCuePointsUpdateEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdCuePoints;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdCuePoints;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdCuePoints_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_plugins_ads_AdCuePoints_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdCuePoints;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdCuePoints_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdCuePoints_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdLoadedEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdLoadedEvent", DoNotGenerateAcw=true)]
		public partial class AdLoadedEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdLoadedEvent']/field[@name='adInfo']"
			[Register ("adInfo")]
			public global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo AdInfo {
				get {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdLoadedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdLoadedEvent); }
			}

			protected AdLoadedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdLoadedEvent']/constructor[@name='AdEvent.AdLoadedEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdInfo']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", "")]
			public unsafe AdLoadedEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdLoadedEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdPausedEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdPausedEvent", DoNotGenerateAcw=true)]
		public partial class AdPausedEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdPausedEvent']/field[@name='adInfo']"
			[Register ("adInfo")]
			public global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo AdInfo {
				get {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdPausedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdPausedEvent); }
			}

			protected AdPausedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdPausedEvent']/constructor[@name='AdEvent.AdPausedEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdInfo']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", "")]
			public unsafe AdPausedEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdPausedEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdPlayHeadEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdPlayHeadEvent", DoNotGenerateAcw=true)]
		public partial class AdPlayHeadEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adPlayHead_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdPlayHeadEvent']/field[@name='adPlayHead']"
			[Register ("adPlayHead")]
			public long AdPlayHead {
				get {
					if (adPlayHead_jfieldId == IntPtr.Zero)
						adPlayHead_jfieldId = JNIEnv.GetFieldID (class_ref, "adPlayHead", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, adPlayHead_jfieldId);
				}
				set {
					if (adPlayHead_jfieldId == IntPtr.Zero)
						adPlayHead_jfieldId = JNIEnv.GetFieldID (class_ref, "adPlayHead", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adPlayHead_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdPlayHeadEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdPlayHeadEvent); }
			}

			protected AdPlayHeadEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdPlayHeadEvent']/constructor[@name='AdEvent.AdPlayHeadEvent' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe AdPlayHeadEvent (long p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdPlayHeadEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
						return;
					}

					if (id_ctor_J == IntPtr.Zero)
						id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdRequestedEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdRequestedEvent", DoNotGenerateAcw=true)]
		public partial class AdRequestedEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adTagUrl_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdRequestedEvent']/field[@name='adTagUrl']"
			[Register ("adTagUrl")]
			public string AdTagUrl {
				get {
					if (adTagUrl_jfieldId == IntPtr.Zero)
						adTagUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "adTagUrl", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adTagUrl_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adTagUrl_jfieldId == IntPtr.Zero)
						adTagUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "adTagUrl", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adTagUrl_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdRequestedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdRequestedEvent); }
			}

			protected AdRequestedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdRequestedEvent']/constructor[@name='AdEvent.AdRequestedEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe AdRequestedEvent (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (AdRequestedEvent)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdResumedEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdResumedEvent", DoNotGenerateAcw=true)]
		public partial class AdResumedEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdResumedEvent']/field[@name='adInfo']"
			[Register ("adInfo")]
			public global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo AdInfo {
				get {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdResumedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdResumedEvent); }
			}

			protected AdResumedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdResumedEvent']/constructor[@name='AdEvent.AdResumedEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdInfo']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", "")]
			public unsafe AdResumedEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdResumedEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdSkippedEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdSkippedEvent", DoNotGenerateAcw=true)]
		public partial class AdSkippedEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdSkippedEvent']/field[@name='adInfo']"
			[Register ("adInfo")]
			public global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo AdInfo {
				get {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdSkippedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdSkippedEvent); }
			}

			protected AdSkippedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdSkippedEvent']/constructor[@name='AdEvent.AdSkippedEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdInfo']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", "")]
			public unsafe AdSkippedEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdSkippedEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdStartedEvent']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$AdStartedEvent", DoNotGenerateAcw=true)]
		public partial class AdStartedEvent : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr adInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdStartedEvent']/field[@name='adInfo']"
			[Register ("adInfo")]
			public global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo AdInfo {
				get {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (adInfo_jfieldId == IntPtr.Zero)
						adInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "adInfo", "Lcom/kaltura/playkit/plugins/ads/AdInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$AdStartedEvent", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AdStartedEvent); }
			}

			protected AdStartedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.AdStartedEvent']/constructor[@name='AdEvent.AdStartedEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdInfo']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", "")]
			public unsafe AdStartedEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AdStartedEvent)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Error']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$Error", DoNotGenerateAcw=true)]
		public partial class Error : global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent {


			static IntPtr error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Error']/field[@name='error']"
			[Register ("error")]
			public global::Com.Kaltura.Playkit.PKError pluginsError
            {
				get {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lcom/kaltura/playkit/PKError;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lcom/kaltura/playkit/PKError;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, error_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$Error", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Error); }
			}

			protected Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_PKError_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Error']/constructor[@name='AdEvent.Error' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKError']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/PKError;)V", "")]
			public unsafe Error (global::Com.Kaltura.Playkit.PKError p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Error)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PKError;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PKError;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_PKError_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_PKError_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PKError;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PKError_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PKError_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr AD_BREAK_ENDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_BREAK_ENDED']"
			[Register ("AD_BREAK_ENDED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdBreakEnded {
				get {
					if (AD_BREAK_ENDED_jfieldId == IntPtr.Zero)
						AD_BREAK_ENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_ENDED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_ENDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_BREAK_IGNORED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_BREAK_IGNORED']"
			[Register ("AD_BREAK_IGNORED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdBreakIgnored {
				get {
					if (AD_BREAK_IGNORED_jfieldId == IntPtr.Zero)
						AD_BREAK_IGNORED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_IGNORED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_IGNORED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_BREAK_READY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_BREAK_READY']"
			[Register ("AD_BREAK_READY")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdBreakReady {
				get {
					if (AD_BREAK_READY_jfieldId == IntPtr.Zero)
						AD_BREAK_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_READY", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_READY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_BREAK_STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_BREAK_STARTED']"
			[Register ("AD_BREAK_STARTED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdBreakStarted {
				get {
					if (AD_BREAK_STARTED_jfieldId == IntPtr.Zero)
						AD_BREAK_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_STARTED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_DISPLAYED_AFTER_CONTENT_PAUSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_DISPLAYED_AFTER_CONTENT_PAUSE']"
			[Register ("AD_DISPLAYED_AFTER_CONTENT_PAUSE")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdDisplayedAfterContentPause {
				get {
					if (AD_DISPLAYED_AFTER_CONTENT_PAUSE_jfieldId == IntPtr.Zero)
						AD_DISPLAYED_AFTER_CONTENT_PAUSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_DISPLAYED_AFTER_CONTENT_PAUSE", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_DISPLAYED_AFTER_CONTENT_PAUSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_LOAD_TIMEOUT_TIMER_STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_LOAD_TIMEOUT_TIMER_STARTED']"
			[Register ("AD_LOAD_TIMEOUT_TIMER_STARTED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdLoadTimeoutTimerStarted {
				get {
					if (AD_LOAD_TIMEOUT_TIMER_STARTED_jfieldId == IntPtr.Zero)
						AD_LOAD_TIMEOUT_TIMER_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_LOAD_TIMEOUT_TIMER_STARTED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_LOAD_TIMEOUT_TIMER_STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_PROGRESS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_PROGRESS']"
			[Register ("AD_PROGRESS")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdProgress {
				get {
					if (AD_PROGRESS_jfieldId == IntPtr.Zero)
						AD_PROGRESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_PROGRESS", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_PROGRESS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AD_REQUESTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='AD_REQUESTED']"
			[Register ("AD_REQUESTED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AdRequested {
				get {
					if (AD_REQUESTED_jfieldId == IntPtr.Zero)
						AD_REQUESTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_REQUESTED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_REQUESTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ALL_ADS_COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='ALL_ADS_COMPLETED']"
			[Register ("ALL_ADS_COMPLETED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type AllAdsCompleted {
				get {
					if (ALL_ADS_COMPLETED_jfieldId == IntPtr.Zero)
						ALL_ADS_COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_ADS_COMPLETED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_ADS_COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLICKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='CLICKED']"
			[Register ("CLICKED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Clicked {
				get {
					if (CLICKED_jfieldId == IntPtr.Zero)
						CLICKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLICKED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLICKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr COMPLETED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Completed {
				get {
					if (COMPLETED_jfieldId == IntPtr.Zero)
						COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTENT_PAUSE_REQUESTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='CONTENT_PAUSE_REQUESTED']"
			[Register ("CONTENT_PAUSE_REQUESTED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type ContentPauseRequested {
				get {
					if (CONTENT_PAUSE_REQUESTED_jfieldId == IntPtr.Zero)
						CONTENT_PAUSE_REQUESTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_PAUSE_REQUESTED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_PAUSE_REQUESTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTENT_RESUME_REQUESTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='CONTENT_RESUME_REQUESTED']"
			[Register ("CONTENT_RESUME_REQUESTED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type ContentResumeRequested {
				get {
					if (CONTENT_RESUME_REQUESTED_jfieldId == IntPtr.Zero)
						CONTENT_RESUME_REQUESTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_RESUME_REQUESTED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_RESUME_REQUESTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CUEPOINTS_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='CUEPOINTS_CHANGED']"
			[Register ("CUEPOINTS_CHANGED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type CuepointsChanged {
				get {
					if (CUEPOINTS_CHANGED_jfieldId == IntPtr.Zero)
						CUEPOINTS_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CUEPOINTS_CHANGED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CUEPOINTS_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FIRST_QUARTILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='FIRST_QUARTILE']"
			[Register ("FIRST_QUARTILE")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type FirstQuartile {
				get {
					if (FIRST_QUARTILE_jfieldId == IntPtr.Zero)
						FIRST_QUARTILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIRST_QUARTILE", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIRST_QUARTILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ICON_TAPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='ICON_TAPPED']"
			[Register ("ICON_TAPPED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type IconTapped {
				get {
					if (ICON_TAPPED_jfieldId == IntPtr.Zero)
						ICON_TAPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ICON_TAPPED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ICON_TAPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='LOADED']"
			[Register ("LOADED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Loaded {
				get {
					if (LOADED_jfieldId == IntPtr.Zero)
						LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MIDPOINT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='MIDPOINT']"
			[Register ("MIDPOINT")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Midpoint {
				get {
					if (MIDPOINT_jfieldId == IntPtr.Zero)
						MIDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIDPOINT", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIDPOINT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='PAUSED']"
			[Register ("PAUSED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Paused {
				get {
					if (PAUSED_jfieldId == IntPtr.Zero)
						PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAY_HEAD_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='PLAY_HEAD_CHANGED']"
			[Register ("PLAY_HEAD_CHANGED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type PlayHeadChanged {
				get {
					if (PLAY_HEAD_CHANGED_jfieldId == IntPtr.Zero)
						PLAY_HEAD_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY_HEAD_CHANGED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_HEAD_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RESUMED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='RESUMED']"
			[Register ("RESUMED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Resumed {
				get {
					if (RESUMED_jfieldId == IntPtr.Zero)
						RESUMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESUMED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESUMED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SKIPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='SKIPPED']"
			[Register ("SKIPPED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Skipped {
				get {
					if (SKIPPED_jfieldId == IntPtr.Zero)
						SKIPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SKIPPED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SKIPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STARTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Started {
				get {
					if (STARTED_jfieldId == IntPtr.Zero)
						STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TAPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='TAPPED']"
			[Register ("TAPPED")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type Tapped {
				get {
					if (TAPPED_jfieldId == IntPtr.Zero)
						TAPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAPPED", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr THIRD_QUARTILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/field[@name='THIRD_QUARTILE']"
			[Register ("THIRD_QUARTILE")]
			public static global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type ThirdQuartile {
				get {
					if (THIRD_QUARTILE_jfieldId == IntPtr.Zero)
						THIRD_QUARTILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THIRD_QUARTILE", "Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THIRD_QUARTILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;");
				try {
					return (global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdEvent); }
		}

		protected AdEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ads_AdEvent_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent']/constructor[@name='AdEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ads.AdEvent.Type']]"
		[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;)V", "")]
		public unsafe AdEvent (global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent.Type p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AdEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;)V", __args);
					return;
				}

				if (id_ctor_Lcom_kaltura_playkit_plugins_ads_AdEvent_Type_ == IntPtr.Zero)
					id_ctor_Lcom_kaltura_playkit_plugins_ads_AdEvent_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ads/AdEvent$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdEvent_Type_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ads_AdEvent_Type_, __args);
			} finally {
			}
		}

		static Delegate cb_eventType;
#pragma warning disable 0169
		static Delegate GetEventTypeHandler ()
		{
			if (cb_eventType == null)
				cb_eventType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EventType);
			return cb_eventType;
		}

		static IntPtr n_EventType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		static IntPtr id_eventType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdEvent']/method[@name='eventType' and count(parameter)=0]"
		[Register ("eventType", "()Ljava/lang/Enum;", "GetEventTypeHandler")]
		public virtual unsafe global::Java.Lang.Enum EventType ()
		{
			if (id_eventType == IntPtr.Zero)
				id_eventType = JNIEnv.GetMethodID (class_ref, "eventType", "()Ljava/lang/Enum;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "eventType", "()Ljava/lang/Enum;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

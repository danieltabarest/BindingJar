using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/ads/PKAdErrorType", DoNotGenerateAcw=true)]
	public sealed partial class PKAdErrorType : global::Java.Lang.Enum {


		static IntPtr ADS_REQUEST_NETWORK_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='ADS_REQUEST_NETWORK_ERROR']"
		[Register ("ADS_REQUEST_NETWORK_ERROR")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType AdsRequestNetworkError {
			get {
				if (ADS_REQUEST_NETWORK_ERROR_jfieldId == IntPtr.Zero)
					ADS_REQUEST_NETWORK_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ADS_REQUEST_NETWORK_ERROR", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ADS_REQUEST_NETWORK_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPANION_AD_LOADING_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='COMPANION_AD_LOADING_FAILED']"
		[Register ("COMPANION_AD_LOADING_FAILED")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType CompanionAdLoadingFailed {
			get {
				if (COMPANION_AD_LOADING_FAILED_jfieldId == IntPtr.Zero)
					COMPANION_AD_LOADING_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPANION_AD_LOADING_FAILED", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPANION_AD_LOADING_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FAILED_TO_REQUEST_ADS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='FAILED_TO_REQUEST_ADS']"
		[Register ("FAILED_TO_REQUEST_ADS")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType FailedToRequestAds {
			get {
				if (FAILED_TO_REQUEST_ADS_jfieldId == IntPtr.Zero)
					FAILED_TO_REQUEST_ADS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FAILED_TO_REQUEST_ADS", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FAILED_TO_REQUEST_ADS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTERNAL_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType InternalError {
			get {
				if (INTERNAL_ERROR_jfieldId == IntPtr.Zero)
					INTERNAL_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTERNAL_ERROR", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTERNAL_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INVALID_ARGUMENTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='INVALID_ARGUMENTS']"
		[Register ("INVALID_ARGUMENTS")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType InvalidArguments {
			get {
				if (INVALID_ARGUMENTS_jfieldId == IntPtr.Zero)
					INVALID_ARGUMENTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID_ARGUMENTS", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_ARGUMENTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OVERLAY_AD_LOADING_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='OVERLAY_AD_LOADING_FAILED']"
		[Register ("OVERLAY_AD_LOADING_FAILED")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType OverlayAdLoadingFailed {
			get {
				if (OVERLAY_AD_LOADING_FAILED_jfieldId == IntPtr.Zero)
					OVERLAY_AD_LOADING_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OVERLAY_AD_LOADING_FAILED", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OVERLAY_AD_LOADING_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr OVERLAY_AD_PLAYING_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='OVERLAY_AD_PLAYING_FAILED']"
		[Register ("OVERLAY_AD_PLAYING_FAILED")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType OverlayAdPlayingFailed {
			get {
				if (OVERLAY_AD_PLAYING_FAILED_jfieldId == IntPtr.Zero)
					OVERLAY_AD_PLAYING_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OVERLAY_AD_PLAYING_FAILED", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OVERLAY_AD_PLAYING_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAYLIST_NO_CONTENT_TRACKING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='PLAYLIST_NO_CONTENT_TRACKING']"
		[Register ("PLAYLIST_NO_CONTENT_TRACKING")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType PlaylistNoContentTracking {
			get {
				if (PLAYLIST_NO_CONTENT_TRACKING_jfieldId == IntPtr.Zero)
					PLAYLIST_NO_CONTENT_TRACKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYLIST_NO_CONTENT_TRACKING", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYLIST_NO_CONTENT_TRACKING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr QUIET_LOG_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='QUIET_LOG_ERROR']"
		[Register ("QUIET_LOG_ERROR")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType QuietLogError {
			get {
				if (QUIET_LOG_ERROR_jfieldId == IntPtr.Zero)
					QUIET_LOG_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUIET_LOG_ERROR", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUIET_LOG_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_AD_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='UNKNOWN_AD_RESPONSE']"
		[Register ("UNKNOWN_AD_RESPONSE")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType UnknownAdResponse {
			get {
				if (UNKNOWN_AD_RESPONSE_jfieldId == IntPtr.Zero)
					UNKNOWN_AD_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_AD_RESPONSE", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_AD_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType UnknownError {
			get {
				if (UNKNOWN_ERROR_jfieldId == IntPtr.Zero)
					UNKNOWN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN_ERROR", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_ASSET_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_ASSET_NOT_FOUND']"
		[Register ("VAST_ASSET_NOT_FOUND")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastAssetNotFound {
			get {
				if (VAST_ASSET_NOT_FOUND_jfieldId == IntPtr.Zero)
					VAST_ASSET_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_ASSET_NOT_FOUND", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_ASSET_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_EMPTY_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_EMPTY_RESPONSE']"
		[Register ("VAST_EMPTY_RESPONSE")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastEmptyResponse {
			get {
				if (VAST_EMPTY_RESPONSE_jfieldId == IntPtr.Zero)
					VAST_EMPTY_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_EMPTY_RESPONSE", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_EMPTY_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_LINEAR_ASSET_MISMATCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_LINEAR_ASSET_MISMATCH']"
		[Register ("VAST_LINEAR_ASSET_MISMATCH")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastLinearAssetMismatch {
			get {
				if (VAST_LINEAR_ASSET_MISMATCH_jfieldId == IntPtr.Zero)
					VAST_LINEAR_ASSET_MISMATCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_LINEAR_ASSET_MISMATCH", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_LINEAR_ASSET_MISMATCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_LOAD_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_LOAD_TIMEOUT']"
		[Register ("VAST_LOAD_TIMEOUT")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastLoadTimeout {
			get {
				if (VAST_LOAD_TIMEOUT_jfieldId == IntPtr.Zero)
					VAST_LOAD_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_LOAD_TIMEOUT", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_LOAD_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_MALFORMED_RESPONSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_MALFORMED_RESPONSE']"
		[Register ("VAST_MALFORMED_RESPONSE")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastMalformedResponse {
			get {
				if (VAST_MALFORMED_RESPONSE_jfieldId == IntPtr.Zero)
					VAST_MALFORMED_RESPONSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_MALFORMED_RESPONSE", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_MALFORMED_RESPONSE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_MEDIA_LOAD_TIMEOUT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_MEDIA_LOAD_TIMEOUT']"
		[Register ("VAST_MEDIA_LOAD_TIMEOUT")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastMediaLoadTimeout {
			get {
				if (VAST_MEDIA_LOAD_TIMEOUT_jfieldId == IntPtr.Zero)
					VAST_MEDIA_LOAD_TIMEOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_MEDIA_LOAD_TIMEOUT", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_MEDIA_LOAD_TIMEOUT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_NONLINEAR_ASSET_MISMATCH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_NONLINEAR_ASSET_MISMATCH']"
		[Register ("VAST_NONLINEAR_ASSET_MISMATCH")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastNonlinearAssetMismatch {
			get {
				if (VAST_NONLINEAR_ASSET_MISMATCH_jfieldId == IntPtr.Zero)
					VAST_NONLINEAR_ASSET_MISMATCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_NONLINEAR_ASSET_MISMATCH", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_NONLINEAR_ASSET_MISMATCH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_TOO_MANY_REDIRECTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VAST_TOO_MANY_REDIRECTS']"
		[Register ("VAST_TOO_MANY_REDIRECTS")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VastTooManyRedirects {
			get {
				if (VAST_TOO_MANY_REDIRECTS_jfieldId == IntPtr.Zero)
					VAST_TOO_MANY_REDIRECTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST_TOO_MANY_REDIRECTS", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_TOO_MANY_REDIRECTS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VIDEO_PLAY_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='VIDEO_PLAY_ERROR']"
		[Register ("VIDEO_PLAY_ERROR")]
		public static global::Com.Kaltura.Playkit.Ads.PKAdErrorType VideoPlayError {
			get {
				if (VIDEO_PLAY_ERROR_jfieldId == IntPtr.Zero)
					VIDEO_PLAY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_PLAY_ERROR", "Lcom/kaltura/playkit/ads/PKAdErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_PLAY_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr errorCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/field[@name='errorCode']"
		[Register ("errorCode")]
		public int ErrorCode {
			get {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, errorCode_jfieldId);
			}
			set {
				if (errorCode_jfieldId == IntPtr.Zero)
					errorCode_jfieldId = JNIEnv.GetFieldID (class_ref, "errorCode", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, errorCode_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/ads/PKAdErrorType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKAdErrorType); }
		}

		internal PKAdErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/ads/PKAdErrorType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Ads.PKAdErrorType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/ads/PKAdErrorType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.Ads.PKAdErrorType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.PKAdErrorType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='PKAdErrorType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/ads/PKAdErrorType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Ads.PKAdErrorType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/ads/PKAdErrorType;");
			try {
				return (global::Com.Kaltura.Playkit.Ads.PKAdErrorType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Ads.PKAdErrorType));
			} finally {
			}
		}

	}
}

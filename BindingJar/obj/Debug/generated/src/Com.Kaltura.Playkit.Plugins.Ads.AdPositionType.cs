using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdPositionType", DoNotGenerateAcw=true)]
	public sealed partial class AdPositionType : global::Java.Lang.Enum {


		static IntPtr MID_ROLL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']/field[@name='MID_ROLL']"
		[Register ("MID_ROLL")]
		public static global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType MidRoll {
			get {
				if (MID_ROLL_jfieldId == IntPtr.Zero)
					MID_ROLL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MID_ROLL", "Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MID_ROLL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr POST_ROLL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']/field[@name='POST_ROLL']"
		[Register ("POST_ROLL")]
		public static global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType PostRoll {
			get {
				if (POST_ROLL_jfieldId == IntPtr.Zero)
					POST_ROLL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST_ROLL", "Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_ROLL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRE_ROLL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']/field[@name='PRE_ROLL']"
		[Register ("PRE_ROLL")]
		public static global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType PreRoll {
			get {
				if (PRE_ROLL_jfieldId == IntPtr.Zero)
					PRE_ROLL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRE_ROLL", "Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRE_ROLL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdPositionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdPositionType); }
		}

		internal AdPositionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ads/AdPositionType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdPositionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/plugins/ads/AdPositionType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
			try {
				return (global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType));
			} finally {
			}
		}

	}
}

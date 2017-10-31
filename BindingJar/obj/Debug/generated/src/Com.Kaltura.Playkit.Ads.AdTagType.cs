using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/ads/AdTagType", DoNotGenerateAcw=true)]
	public sealed partial class AdTagType : global::Java.Lang.Enum {


		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Com.Kaltura.Playkit.Ads.AdTagType Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/kaltura/playkit/ads/AdTagType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdTagType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']/field[@name='VAST']"
		[Register ("VAST")]
		public static global::Com.Kaltura.Playkit.Ads.AdTagType Vast {
			get {
				if (VAST_jfieldId == IntPtr.Zero)
					VAST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST", "Lcom/kaltura/playkit/ads/AdTagType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdTagType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VMAP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']/field[@name='VMAP']"
		[Register ("VMAP")]
		public static global::Com.Kaltura.Playkit.Ads.AdTagType Vmap {
			get {
				if (VMAP_jfieldId == IntPtr.Zero)
					VMAP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VMAP", "Lcom/kaltura/playkit/ads/AdTagType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VMAP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdTagType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VPAID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']/field[@name='VPAID']"
		[Register ("VPAID")]
		public static global::Com.Kaltura.Playkit.Ads.AdTagType Vpaid {
			get {
				if (VPAID_jfieldId == IntPtr.Zero)
					VPAID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VPAID", "Lcom/kaltura/playkit/ads/AdTagType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VPAID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdTagType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/ads/AdTagType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdTagType); }
		}

		internal AdTagType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/ads/AdTagType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Ads.AdTagType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/ads/AdTagType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.Ads.AdTagType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.AdTagType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/class[@name='AdTagType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/ads/AdTagType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Ads.AdTagType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/ads/AdTagType;");
			try {
				return (global::Com.Kaltura.Playkit.Ads.AdTagType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Ads.AdTagType));
			} finally {
			}
		}

	}
}

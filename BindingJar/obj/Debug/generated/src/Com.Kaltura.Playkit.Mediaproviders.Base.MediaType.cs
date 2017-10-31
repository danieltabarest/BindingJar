using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Mediaproviders.Base {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/mediaproviders/base/MediaType", DoNotGenerateAcw=true)]
	public sealed partial class MediaType : global::Java.Lang.Enum {


		static IntPtr Channel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/field[@name='Channel']"
		[Register ("Channel")]
		public static global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType Channel {
			get {
				if (Channel_jfieldId == IntPtr.Zero)
					Channel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Channel", "Lcom/kaltura/playkit/mediaproviders/base/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Channel_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EPG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/field[@name='EPG']"
		[Register ("EPG")]
		public static global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType Epg {
			get {
				if (EPG_jfieldId == IntPtr.Zero)
					EPG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPG", "Lcom/kaltura/playkit/mediaproviders/base/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EPG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Recording_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/field[@name='Recording']"
		[Register ("Recording")]
		public static global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType Recording {
			get {
				if (Recording_jfieldId == IntPtr.Zero)
					Recording_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Recording", "Lcom/kaltura/playkit/mediaproviders/base/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Recording_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr Vod_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/field[@name='Vod']"
		[Register ("Vod")]
		public static global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType Vod {
			get {
				if (Vod_jfieldId == IntPtr.Zero)
					Vod_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Vod", "Lcom/kaltura/playkit/mediaproviders/base/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Vod_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/mediaproviders/base/MediaType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaType); }
		}

		internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAssetType;
		public unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType AssetType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/method[@name='getAssetType' and count(parameter)=0]"
			[Register ("getAssetType", "()Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;", "GetGetAssetTypeHandler")]
			get {
				if (id_getAssetType == IntPtr.Zero)
					id_getAssetType = JNIEnv.GetMethodID (class_ref, "getAssetType", "()Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAssetType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMediaEntryType;
		public unsafe global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType MediaEntryType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/method[@name='getMediaEntryType' and count(parameter)=0]"
			[Register ("getMediaEntryType", "()Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;", "GetGetMediaEntryTypeHandler")]
			get {
				if (id_getMediaEntryType == IntPtr.Zero)
					id_getMediaEntryType = JNIEnv.GetMethodID (class_ref, "getMediaEntryType", "()Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaEntryType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/base/MediaType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/mediaproviders/base/MediaType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.mediaproviders.base']/class[@name='MediaType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/mediaproviders/base/MediaType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/mediaproviders/base/MediaType;");
			try {
				return (global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Mediaproviders.Base.MediaType));
			} finally {
			}
		}

	}
}

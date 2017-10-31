using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Ovp.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/model/KalturaEntryType", DoNotGenerateAcw=true)]
	public sealed partial class KalturaEntryType : global::Java.Lang.Enum {


		static IntPtr AUTOMATIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/field[@name='AUTOMATIC']"
		[Register ("AUTOMATIC")]
		public static global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType Automatic {
			get {
				if (AUTOMATIC_jfieldId == IntPtr.Zero)
					AUTOMATIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTOMATIC", "Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTOMATIC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LIVE_STREAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/field[@name='LIVE_STREAM']"
		[Register ("LIVE_STREAM")]
		public static global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType LiveStream {
			get {
				if (LIVE_STREAM_jfieldId == IntPtr.Zero)
					LIVE_STREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LIVE_STREAM", "Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LIVE_STREAM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MEDIA_CLIP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/field[@name='MEDIA_CLIP']"
		[Register ("MEDIA_CLIP")]
		public static global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType MediaClip {
			get {
				if (MEDIA_CLIP_jfieldId == IntPtr.Zero)
					MEDIA_CLIP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MEDIA_CLIP", "Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MEDIA_CLIP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAYLIST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/field[@name='PLAYLIST']"
		[Register ("PLAYLIST")]
		public static global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType Playlist {
			get {
				if (PLAYLIST_jfieldId == IntPtr.Zero)
					PLAYLIST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYLIST", "Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYLIST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/field[@name='type']"
		[Register ("type")]
		public string Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/model/KalturaEntryType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalturaEntryType); }
		}

		internal KalturaEntryType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaEntryType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
			try {
				return (global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType));
			} finally {
			}
		}

	}
}

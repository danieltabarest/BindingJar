using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Phoenix {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/phoenix/APIDefines", DoNotGenerateAcw=true)]
	public partial class APIDefines : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType", DoNotGenerateAcw=true)]
		public sealed partial class AssetReferenceType : global::Java.Lang.Enum {


			static IntPtr ExternalEpg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']/field[@name='ExternalEpg']"
			[Register ("ExternalEpg")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType ExternalEpg {
				get {
					if (ExternalEpg_jfieldId == IntPtr.Zero)
						ExternalEpg_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ExternalEpg", "Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ExternalEpg_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr InternalEpg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']/field[@name='InternalEpg']"
			[Register ("InternalEpg")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType InternalEpg {
				get {
					if (InternalEpg_jfieldId == IntPtr.Zero)
						InternalEpg_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "InternalEpg", "Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, InternalEpg_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Media_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']/field[@name='Media']"
			[Register ("Media")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType Media {
				get {
					if (Media_jfieldId == IntPtr.Zero)
						Media_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Media", "Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Media_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AssetReferenceType); }
			}

			internal AssetReferenceType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.AssetReferenceType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$AssetReferenceType;");
				try {
					return (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.AssetReferenceType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType", DoNotGenerateAcw=true)]
		public sealed partial class KalturaAssetType : global::Java.Lang.Enum {


			static IntPtr Epg_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']/field[@name='Epg']"
			[Register ("Epg")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType Epg {
				get {
					if (Epg_jfieldId == IntPtr.Zero)
						Epg_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Epg", "Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Epg_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Media_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']/field[@name='Media']"
			[Register ("Media")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType Media {
				get {
					if (Media_jfieldId == IntPtr.Zero)
						Media_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Media", "Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Media_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Recording_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']/field[@name='Recording']"
			[Register ("Recording")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType Recording {
				get {
					if (Recording_jfieldId == IntPtr.Zero)
						Recording_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Recording", "Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Recording_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KalturaAssetType); }
			}

			internal KalturaAssetType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.KalturaAssetType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$KalturaAssetType;");
				try {
					return (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.KalturaAssetType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType", DoNotGenerateAcw=true)]
		public sealed partial class LiveStreamType : global::Java.Lang.Enum {


			static IntPtr Catchup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']/field[@name='Catchup']"
			[Register ("Catchup")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType Catchup {
				get {
					if (Catchup_jfieldId == IntPtr.Zero)
						Catchup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Catchup", "Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Catchup_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr StartOver_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']/field[@name='StartOver']"
			[Register ("StartOver")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType StartOver {
				get {
					if (StartOver_jfieldId == IntPtr.Zero)
						StartOver_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StartOver", "Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, StartOver_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TrickPlay_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']/field[@name='TrickPlay']"
			[Register ("TrickPlay")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType TrickPlay {
				get {
					if (TrickPlay_jfieldId == IntPtr.Zero)
						TrickPlay_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TrickPlay", "Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TrickPlay_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LiveStreamType); }
			}

			internal LiveStreamType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.LiveStreamType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$LiveStreamType;");
				try {
					return (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.LiveStreamType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/api/phoenix/APIDefines$MediaType", DoNotGenerateAcw=true)]
		public sealed partial class MediaType : global::Java.Lang.Enum {


			static IntPtr Channel_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/field[@name='Channel']"
			[Register ("Channel")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType Channel {
				get {
					if (Channel_jfieldId == IntPtr.Zero)
						Channel_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Channel", "Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Channel_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr EPG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/field[@name='EPG']"
			[Register ("EPG")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType Epg {
				get {
					if (EPG_jfieldId == IntPtr.Zero)
						EPG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EPG", "Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EPG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Recording_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/field[@name='Recording']"
			[Register ("Recording")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType Recording {
				get {
					if (Recording_jfieldId == IntPtr.Zero)
						Recording_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Recording", "Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Recording_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Vod_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/field[@name='Vod']"
			[Register ("Vod")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType Vod {
				get {
					if (Vod_jfieldId == IntPtr.Zero)
						Vod_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Vod", "Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Vod_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/api/phoenix/APIDefines$MediaType", ref java_class_handle);
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/method[@name='getAssetType' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/method[@name='getMediaEntryType' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.MediaType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$MediaType;");
				try {
					return (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.MediaType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType", DoNotGenerateAcw=true)]
		public sealed partial class PlaybackContextType : global::Java.Lang.Enum {


			static IntPtr Catchup_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/field[@name='Catchup']"
			[Register ("Catchup")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType Catchup {
				get {
					if (Catchup_jfieldId == IntPtr.Zero)
						Catchup_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Catchup", "Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Catchup_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Playback_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/field[@name='Playback']"
			[Register ("Playback")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType Playback {
				get {
					if (Playback_jfieldId == IntPtr.Zero)
						Playback_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Playback", "Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Playback_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr StartOver_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/field[@name='StartOver']"
			[Register ("StartOver")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType StartOver {
				get {
					if (StartOver_jfieldId == IntPtr.Zero)
						StartOver_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "StartOver", "Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, StartOver_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Trailer_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/field[@name='Trailer']"
			[Register ("Trailer")]
			public static global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType Trailer {
				get {
					if (Trailer_jfieldId == IntPtr.Zero)
						Trailer_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Trailer", "Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Trailer_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/field[@name='value']"
			[Register ("value")]
			public string Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PlaybackContextType); }
			}

			internal PlaybackContextType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines.PlaybackContextType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/api/phoenix/APIDefines$PlaybackContextType;");
				try {
					return (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Api.Phoenix.APIDefines.PlaybackContextType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/phoenix/APIDefines", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (APIDefines); }
		}

		protected APIDefines (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.phoenix']/class[@name='APIDefines']/constructor[@name='APIDefines' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe APIDefines ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (APIDefines)) {
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

	}
}

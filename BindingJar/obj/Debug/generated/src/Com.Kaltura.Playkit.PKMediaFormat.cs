using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKMediaFormat", DoNotGenerateAcw=true)]
	public sealed partial class PKMediaFormat : global::Java.Lang.Enum {


		static IntPtr dash_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='dash']"
		[Register ("dash")]
		public static global::Com.Kaltura.Playkit.PKMediaFormat Dash {
			get {
				if (dash_jfieldId == IntPtr.Zero)
					dash_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "dash", "Lcom/kaltura/playkit/PKMediaFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, dash_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr hls_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='hls']"
		[Register ("hls")]
		public static global::Com.Kaltura.Playkit.PKMediaFormat Hls {
			get {
				if (hls_jfieldId == IntPtr.Zero)
					hls_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "hls", "Lcom/kaltura/playkit/PKMediaFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, hls_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='mimeType']"
		[Register ("mimeType")]
		public string MimeType {
			get {
				if (mimeType_jfieldId == IntPtr.Zero)
					mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mimeType_jfieldId == IntPtr.Zero)
					mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mp3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='mp3']"
		[Register ("mp3")]
		public static global::Com.Kaltura.Playkit.PKMediaFormat Mp3 {
			get {
				if (mp3_jfieldId == IntPtr.Zero)
					mp3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mp3", "Lcom/kaltura/playkit/PKMediaFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mp3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr mp4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='mp4']"
		[Register ("mp4")]
		public static global::Com.Kaltura.Playkit.PKMediaFormat Mp4 {
			get {
				if (mp4_jfieldId == IntPtr.Zero)
					mp4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mp4", "Lcom/kaltura/playkit/PKMediaFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mp4_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr pathExt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='pathExt']"
		[Register ("pathExt")]
		public string PathExt {
			get {
				if (pathExt_jfieldId == IntPtr.Zero)
					pathExt_jfieldId = JNIEnv.GetFieldID (class_ref, "pathExt", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, pathExt_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pathExt_jfieldId == IntPtr.Zero)
					pathExt_jfieldId = JNIEnv.GetFieldID (class_ref, "pathExt", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pathExt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr unknown_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='unknown']"
		[Register ("unknown")]
		public static global::Com.Kaltura.Playkit.PKMediaFormat Unknown {
			get {
				if (unknown_jfieldId == IntPtr.Zero)
					unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "unknown", "Lcom/kaltura/playkit/PKMediaFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, unknown_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr wvm_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/field[@name='wvm']"
		[Register ("wvm")]
		public static global::Com.Kaltura.Playkit.PKMediaFormat Wvm {
			get {
				if (wvm_jfieldId == IntPtr.Zero)
					wvm_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "wvm", "Lcom/kaltura/playkit/PKMediaFormat;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, wvm_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKMediaFormat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKMediaFormat); }
		}

		internal PKMediaFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaFormat;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PKMediaFormat ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.PKMediaFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOfExt_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/method[@name='valueOfExt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOfExt", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaFormat;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PKMediaFormat ValueOfExt (string p0)
		{
			if (id_valueOfExt_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOfExt_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOfExt", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.PKMediaFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOfExt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOfUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/method[@name='valueOfUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOfUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaFormat;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PKMediaFormat ValueOfUrl (string p0)
		{
			if (id_valueOfUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOfUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOfUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.PKMediaFormat __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOfUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/PKMediaFormat;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PKMediaFormat[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/PKMediaFormat;");
			try {
				return (global::Com.Kaltura.Playkit.PKMediaFormat[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.PKMediaFormat));
			} finally {
			}
		}

	}
}

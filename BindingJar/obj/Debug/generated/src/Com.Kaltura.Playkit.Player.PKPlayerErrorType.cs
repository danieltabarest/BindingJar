using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/PKPlayerErrorType", DoNotGenerateAcw=true)]
	public sealed partial class PKPlayerErrorType : global::Java.Lang.Enum {


		static IntPtr DRM_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/field[@name='DRM_ERROR']"
		[Register ("DRM_ERROR")]
		public static global::Com.Kaltura.Playkit.Player.PKPlayerErrorType DrmError {
			get {
				if (DRM_ERROR_jfieldId == IntPtr.Zero)
					DRM_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DRM_ERROR", "Lcom/kaltura/playkit/player/PKPlayerErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DRM_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKPlayerErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RENDERER_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/field[@name='RENDERER_ERROR']"
		[Register ("RENDERER_ERROR")]
		public static global::Com.Kaltura.Playkit.Player.PKPlayerErrorType RendererError {
			get {
				if (RENDERER_ERROR_jfieldId == IntPtr.Zero)
					RENDERER_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENDERER_ERROR", "Lcom/kaltura/playkit/player/PKPlayerErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RENDERER_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKPlayerErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SOURCE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/field[@name='SOURCE_ERROR']"
		[Register ("SOURCE_ERROR")]
		public static global::Com.Kaltura.Playkit.Player.PKPlayerErrorType SourceError {
			get {
				if (SOURCE_ERROR_jfieldId == IntPtr.Zero)
					SOURCE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOURCE_ERROR", "Lcom/kaltura/playkit/player/PKPlayerErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOURCE_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKPlayerErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SOURCE_SELECTION_FAILED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/field[@name='SOURCE_SELECTION_FAILED']"
		[Register ("SOURCE_SELECTION_FAILED")]
		public static global::Com.Kaltura.Playkit.Player.PKPlayerErrorType SourceSelectionFailed {
			get {
				if (SOURCE_SELECTION_FAILED_jfieldId == IntPtr.Zero)
					SOURCE_SELECTION_FAILED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOURCE_SELECTION_FAILED", "Lcom/kaltura/playkit/player/PKPlayerErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOURCE_SELECTION_FAILED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKPlayerErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNEXPECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/field[@name='UNEXPECTED']"
		[Register ("UNEXPECTED")]
		public static global::Com.Kaltura.Playkit.Player.PKPlayerErrorType Unexpected {
			get {
				if (UNEXPECTED_jfieldId == IntPtr.Zero)
					UNEXPECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNEXPECTED", "Lcom/kaltura/playkit/player/PKPlayerErrorType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNEXPECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKPlayerErrorType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr errorCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/field[@name='errorCode']"
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
				return JNIEnv.FindClass ("com/kaltura/playkit/player/PKPlayerErrorType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKPlayerErrorType); }
		}

		internal PKPlayerErrorType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/player/PKPlayerErrorType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Player.PKPlayerErrorType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/player/PKPlayerErrorType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.Player.PKPlayerErrorType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKPlayerErrorType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKPlayerErrorType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/player/PKPlayerErrorType;", "")]
		public static unsafe global::Com.Kaltura.Playkit.Player.PKPlayerErrorType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/player/PKPlayerErrorType;");
			try {
				return (global::Com.Kaltura.Playkit.Player.PKPlayerErrorType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Player.PKPlayerErrorType));
			} finally {
			}
		}

	}
}

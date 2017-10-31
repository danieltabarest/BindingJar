using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerState", DoNotGenerateAcw=true)]
	public sealed partial class PlayerState : global::Java.Lang.Enum {


		static IntPtr BUFFERING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']/field[@name='BUFFERING']"
		[Register ("BUFFERING")]
		public static global::Com.Kaltura.Playkit.PlayerState Buffering {
			get {
				if (BUFFERING_jfieldId == IntPtr.Zero)
					BUFFERING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUFFERING", "Lcom/kaltura/playkit/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUFFERING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IDLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']/field[@name='IDLE']"
		[Register ("IDLE")]
		public static global::Com.Kaltura.Playkit.PlayerState Idle {
			get {
				if (IDLE_jfieldId == IntPtr.Zero)
					IDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDLE", "Lcom/kaltura/playkit/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOADING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']/field[@name='LOADING']"
		[Register ("LOADING")]
		public static global::Com.Kaltura.Playkit.PlayerState Loading {
			get {
				if (LOADING_jfieldId == IntPtr.Zero)
					LOADING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADING", "Lcom/kaltura/playkit/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr READY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']/field[@name='READY']"
		[Register ("READY")]
		public static global::Com.Kaltura.Playkit.PlayerState Ready {
			get {
				if (READY_jfieldId == IntPtr.Zero)
					READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READY", "Lcom/kaltura/playkit/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PlayerState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerState); }
		}

		internal PlayerState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PlayerState;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PlayerState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PlayerState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Kaltura.Playkit.PlayerState __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/kaltura/playkit/PlayerState;", "")]
		public static unsafe global::Com.Kaltura.Playkit.PlayerState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/PlayerState;");
			try {
				return (global::Com.Kaltura.Playkit.PlayerState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.PlayerState));
			} finally {
			}
		}

	}
}

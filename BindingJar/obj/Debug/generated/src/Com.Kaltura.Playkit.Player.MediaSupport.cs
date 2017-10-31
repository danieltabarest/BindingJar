using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/MediaSupport", DoNotGenerateAcw=true)]
	public partial class MediaSupport : global::Java.Lang.Object {


		static IntPtr WIDEVINE_UUID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/field[@name='WIDEVINE_UUID']"
		[Register ("WIDEVINE_UUID")]
		public static global::Java.Util.UUID WidevineUuid {
			get {
				if (WIDEVINE_UUID_jfieldId == IntPtr.Zero)
					WIDEVINE_UUID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIDEVINE_UUID", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIDEVINE_UUID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/MediaSupport", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaSupport); }
		}

		protected MediaSupport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/constructor[@name='MediaSupport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaSupport ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MediaSupport)) {
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

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initialize_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_playReady;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/method[@name='playReady' and count(parameter)=0]"
		[Register ("playReady", "()Z", "")]
		public static unsafe bool PlayReady ()
		{
			if (id_playReady == IntPtr.Zero)
				id_playReady = JNIEnv.GetStaticMethodID (class_ref, "playReady", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_playReady);
			} finally {
			}
		}

		static IntPtr id_supportedDrmSchemes_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/method[@name='supportedDrmSchemes' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("supportedDrmSchemes", "(Landroid/content/Context;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> SupportedDrmSchemes (global::Android.Content.Context p0)
		{
			if (id_supportedDrmSchemes_Landroid_content_Context_ == IntPtr.Zero)
				id_supportedDrmSchemes_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "supportedDrmSchemes", "(Landroid/content/Context;)Ljava/util/Set;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.ICollection<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> __ret = global::Android.Runtime.JavaSet<global::Com.Kaltura.Playkit.PKDrmParams.Scheme>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_supportedDrmSchemes_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_widevineClassic;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/method[@name='widevineClassic' and count(parameter)=0]"
		[Register ("widevineClassic", "()Z", "")]
		public static unsafe bool WidevineClassic ()
		{
			if (id_widevineClassic == IntPtr.Zero)
				id_widevineClassic = JNIEnv.GetStaticMethodID (class_ref, "widevineClassic", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_widevineClassic);
			} finally {
			}
		}

		static IntPtr id_widevineModular;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='MediaSupport']/method[@name='widevineModular' and count(parameter)=0]"
		[Register ("widevineModular", "()Z", "")]
		public static unsafe bool WidevineModular ()
		{
			if (id_widevineModular == IntPtr.Zero)
				id_widevineModular = JNIEnv.GetStaticMethodID (class_ref, "widevineModular", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_widevineModular);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKDrmParams", DoNotGenerateAcw=true)]
	public partial class PKDrmParams : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PKDrmParams$Scheme", DoNotGenerateAcw=true)]
		public sealed partial class Scheme : global::Java.Lang.Enum {


			static IntPtr FairPlay_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/field[@name='FairPlay']"
			[Register ("FairPlay")]
			public static global::Com.Kaltura.Playkit.PKDrmParams.Scheme FairPlay {
				get {
					if (FairPlay_jfieldId == IntPtr.Zero)
						FairPlay_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FairPlay", "Lcom/kaltura/playkit/PKDrmParams$Scheme;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FairPlay_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PlayReadyCENC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/field[@name='PlayReadyCENC']"
			[Register ("PlayReadyCENC")]
			public static global::Com.Kaltura.Playkit.PKDrmParams.Scheme PlayReadyCENC {
				get {
					if (PlayReadyCENC_jfieldId == IntPtr.Zero)
						PlayReadyCENC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PlayReadyCENC", "Lcom/kaltura/playkit/PKDrmParams$Scheme;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PlayReadyCENC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PlayReadyClassic_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/field[@name='PlayReadyClassic']"
			[Register ("PlayReadyClassic")]
			public static global::Com.Kaltura.Playkit.PKDrmParams.Scheme PlayReadyClassic {
				get {
					if (PlayReadyClassic_jfieldId == IntPtr.Zero)
						PlayReadyClassic_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PlayReadyClassic", "Lcom/kaltura/playkit/PKDrmParams$Scheme;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PlayReadyClassic_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/field[@name='Unknown']"
			[Register ("Unknown")]
			public static global::Com.Kaltura.Playkit.PKDrmParams.Scheme Unknown {
				get {
					if (Unknown_jfieldId == IntPtr.Zero)
						Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lcom/kaltura/playkit/PKDrmParams$Scheme;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WidevineCENC_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/field[@name='WidevineCENC']"
			[Register ("WidevineCENC")]
			public static global::Com.Kaltura.Playkit.PKDrmParams.Scheme WidevineCENC {
				get {
					if (WidevineCENC_jfieldId == IntPtr.Zero)
						WidevineCENC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WidevineCENC", "Lcom/kaltura/playkit/PKDrmParams$Scheme;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WidevineCENC_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WidevineClassic_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/field[@name='WidevineClassic']"
			[Register ("WidevineClassic")]
			public static global::Com.Kaltura.Playkit.PKDrmParams.Scheme WidevineClassic {
				get {
					if (WidevineClassic_jfieldId == IntPtr.Zero)
						WidevineClassic_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WidevineClassic", "Lcom/kaltura/playkit/PKDrmParams$Scheme;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WidevineClassic_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PKDrmParams$Scheme", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Scheme); }
			}

			internal Scheme (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_isSupported;
			public unsafe bool IsSupported {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/method[@name='isSupported' and count(parameter)=0]"
				[Register ("isSupported", "()Z", "GetIsSupportedHandler")]
				get {
					if (id_isSupported == IntPtr.Zero)
						id_isSupported = JNIEnv.GetMethodID (class_ref, "isSupported", "()Z");
					try {
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupported);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKDrmParams$Scheme;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PKDrmParams.Scheme ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKDrmParams$Scheme;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.PKDrmParams.Scheme __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams.Scheme']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/PKDrmParams$Scheme;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PKDrmParams.Scheme[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/PKDrmParams$Scheme;");
				try {
					return (global::Com.Kaltura.Playkit.PKDrmParams.Scheme[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.PKDrmParams.Scheme));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKDrmParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKDrmParams); }
		}

		protected PKDrmParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_kaltura_playkit_PKDrmParams_Scheme_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/constructor[@name='PKDrmParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.kaltura.playkit.PKDrmParams.Scheme']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/kaltura/playkit/PKDrmParams$Scheme;)V", "")]
		public unsafe PKDrmParams (string p0, global::Com.Kaltura.Playkit.PKDrmParams.Scheme p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (PKDrmParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lcom/kaltura/playkit/PKDrmParams$Scheme;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/kaltura/playkit/PKDrmParams$Scheme;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_kaltura_playkit_PKDrmParams_Scheme_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_kaltura_playkit_PKDrmParams_Scheme_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/kaltura/playkit/PKDrmParams$Scheme;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_kaltura_playkit_PKDrmParams_Scheme_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_kaltura_playkit_PKDrmParams_Scheme_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/constructor[@name='PKDrmParams' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe PKDrmParams (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PKDrmParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_isSchemeSupported;
#pragma warning disable 0169
		static Delegate GetIsSchemeSupportedHandler ()
		{
			if (cb_isSchemeSupported == null)
				cb_isSchemeSupported = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSchemeSupported);
			return cb_isSchemeSupported;
		}

		static bool n_IsSchemeSupported (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSchemeSupported;
		}
#pragma warning restore 0169

		static IntPtr id_isSchemeSupported;
		public virtual unsafe bool IsSchemeSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='isSchemeSupported' and count(parameter)=0]"
			[Register ("isSchemeSupported", "()Z", "GetIsSchemeSupportedHandler")]
			get {
				if (id_isSchemeSupported == IntPtr.Zero)
					id_isSchemeSupported = JNIEnv.GetMethodID (class_ref, "isSchemeSupported", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSchemeSupported);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSchemeSupported", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLicenseUri;
#pragma warning disable 0169
		static Delegate GetGetLicenseUriHandler ()
		{
			if (cb_getLicenseUri == null)
				cb_getLicenseUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLicenseUri);
			return cb_getLicenseUri;
		}

		static IntPtr n_GetLicenseUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LicenseUri);
		}
#pragma warning restore 0169

		static Delegate cb_setLicenseUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLicenseUri_Ljava_lang_String_Handler ()
		{
			if (cb_setLicenseUri_Ljava_lang_String_ == null)
				cb_setLicenseUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLicenseUri_Ljava_lang_String_);
			return cb_setLicenseUri_Ljava_lang_String_;
		}

		static void n_SetLicenseUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LicenseUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLicenseUri;
		static IntPtr id_setLicenseUri_Ljava_lang_String_;
		public virtual unsafe string LicenseUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='getLicenseUri' and count(parameter)=0]"
			[Register ("getLicenseUri", "()Ljava/lang/String;", "GetGetLicenseUriHandler")]
			get {
				if (id_getLicenseUri == IntPtr.Zero)
					id_getLicenseUri = JNIEnv.GetMethodID (class_ref, "getLicenseUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLicenseUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLicenseUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='setLicenseUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLicenseUri", "(Ljava/lang/String;)V", "GetSetLicenseUri_Ljava_lang_String_Handler")]
			set {
				if (id_setLicenseUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setLicenseUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLicenseUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLicenseUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLicenseUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getScheme;
#pragma warning disable 0169
		static Delegate GetGetSchemeHandler ()
		{
			if (cb_getScheme == null)
				cb_getScheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScheme);
			return cb_getScheme;
		}

		static IntPtr n_GetScheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetScheme ());
		}
#pragma warning restore 0169

		static IntPtr id_getScheme;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='getScheme' and count(parameter)=0]"
		[Register ("getScheme", "()Lcom/kaltura/playkit/PKDrmParams$Scheme;", "GetGetSchemeHandler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKDrmParams.Scheme GetScheme ()
		{
			if (id_getScheme == IntPtr.Zero)
				id_getScheme = JNIEnv.GetMethodID (class_ref, "getScheme", "()Lcom/kaltura/playkit/PKDrmParams$Scheme;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScheme), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScheme", "()Lcom/kaltura/playkit/PKDrmParams$Scheme;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_;
#pragma warning disable 0169
		static Delegate GetSetScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_Handler ()
		{
			if (cb_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_ == null)
				cb_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_);
			return cb_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_;
		}

		static void n_SetScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKDrmParams.Scheme p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams.Scheme> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheme (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='setScheme' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKDrmParams.Scheme']]"
		[Register ("setScheme", "(Lcom/kaltura/playkit/PKDrmParams$Scheme;)V", "GetSetScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_Handler")]
		public virtual unsafe void SetScheme (global::Com.Kaltura.Playkit.PKDrmParams.Scheme p0)
		{
			if (id_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_ == IntPtr.Zero)
				id_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_ = JNIEnv.GetMethodID (class_ref, "setScheme", "(Lcom/kaltura/playkit/PKDrmParams$Scheme;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScheme_Lcom_kaltura_playkit_PKDrmParams_Scheme_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScheme", "(Lcom/kaltura/playkit/PKDrmParams$Scheme;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Kaltura.Playkit.PKDrmParams __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKDrmParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKDrmParams']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}

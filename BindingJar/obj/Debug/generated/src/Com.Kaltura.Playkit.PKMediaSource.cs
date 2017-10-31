using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKMediaSource", DoNotGenerateAcw=true)]
	public partial class PKMediaSource : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKMediaSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKMediaSource); }
		}

		protected PKMediaSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/constructor[@name='PKMediaSource' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKMediaSource ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PKMediaSource)) {
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

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/constructor[@name='PKMediaSource' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe PKMediaSource (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PKMediaSource)) {
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

		static Delegate cb_getDrmData;
#pragma warning disable 0169
		static Delegate GetGetDrmDataHandler ()
		{
			if (cb_getDrmData == null)
				cb_getDrmData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrmData);
			return cb_getDrmData;
		}

		static IntPtr n_GetDrmData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKDrmParams>.ToLocalJniHandle (__this.DrmData);
		}
#pragma warning restore 0169

		static IntPtr id_getDrmData;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.PKDrmParams> DrmData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='getDrmData' and count(parameter)=0]"
			[Register ("getDrmData", "()Ljava/util/List;", "GetGetDrmDataHandler")]
			get {
				if (id_getDrmData == IntPtr.Zero)
					id_getDrmData = JNIEnv.GetMethodID (class_ref, "getDrmData", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKDrmParams>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDrmData), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKDrmParams>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrmData", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasDrmParams;
#pragma warning disable 0169
		static Delegate GetHasDrmParamsHandler ()
		{
			if (cb_hasDrmParams == null)
				cb_hasDrmParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDrmParams);
			return cb_hasDrmParams;
		}

		static bool n_HasDrmParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDrmParams;
		}
#pragma warning restore 0169

		static IntPtr id_hasDrmParams;
		public virtual unsafe bool HasDrmParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='hasDrmParams' and count(parameter)=0]"
			[Register ("hasDrmParams", "()Z", "GetHasDrmParamsHandler")]
			get {
				if (id_hasDrmParams == IntPtr.Zero)
					id_hasDrmParams = JNIEnv.GetMethodID (class_ref, "hasDrmParams", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDrmParams);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasDrmParams", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMediaFormat;
#pragma warning disable 0169
		static Delegate GetGetMediaFormatHandler ()
		{
			if (cb_getMediaFormat == null)
				cb_getMediaFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaFormat);
			return cb_getMediaFormat;
		}

		static IntPtr n_GetMediaFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaFormat);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaFormat;
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaFormat MediaFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='getMediaFormat' and count(parameter)=0]"
			[Register ("getMediaFormat", "()Lcom/kaltura/playkit/PKMediaFormat;", "GetGetMediaFormatHandler")]
			get {
				if (id_getMediaFormat == IntPtr.Zero)
					id_getMediaFormat = JNIEnv.GetMethodID (class_ref, "getMediaFormat", "()Lcom/kaltura/playkit/PKMediaFormat;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaFormat", "()Lcom/kaltura/playkit/PKMediaFormat;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_setDrmData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDrmData_Ljava_util_List_Handler ()
		{
			if (cb_setDrmData_Ljava_util_List_ == null)
				cb_setDrmData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDrmData_Ljava_util_List_);
			return cb_setDrmData_Ljava_util_List_;
		}

		static IntPtr n_SetDrmData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKDrmParams>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDrmData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDrmData_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='setDrmData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.kaltura.playkit.PKDrmParams&gt;']]"
		[Register ("setDrmData", "(Ljava/util/List;)Lcom/kaltura/playkit/PKMediaSource;", "GetSetDrmData_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaSource SetDrmData (global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.PKDrmParams> p0)
		{
			if (id_setDrmData_Ljava_util_List_ == IntPtr.Zero)
				id_setDrmData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDrmData", "(Ljava/util/List;)Lcom/kaltura/playkit/PKMediaSource;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKDrmParams>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaSource __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDrmData_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrmData", "(Ljava/util/List;)Lcom/kaltura/playkit/PKMediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static IntPtr n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setId", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;", "GetSetId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaSource SetId (string p0)
		{
			if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
				id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaSource __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_;
#pragma warning disable 0169
		static Delegate GetSetMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_Handler ()
		{
			if (cb_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_ == null)
				cb_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_);
			return cb_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_;
		}

		static IntPtr n_SetMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaFormat p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMediaFormat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='setMediaFormat' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaFormat']]"
		[Register ("setMediaFormat", "(Lcom/kaltura/playkit/PKMediaFormat;)Lcom/kaltura/playkit/PKMediaSource;", "GetSetMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaSource SetMediaFormat (global::Com.Kaltura.Playkit.PKMediaFormat p0)
		{
			if (id_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_ == IntPtr.Zero)
				id_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_ = JNIEnv.GetMethodID (class_ref, "setMediaFormat", "(Lcom/kaltura/playkit/PKMediaFormat;)Lcom/kaltura/playkit/PKMediaSource;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Kaltura.Playkit.PKMediaSource __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMediaFormat_Lcom_kaltura_playkit_PKMediaFormat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediaFormat", "(Lcom/kaltura/playkit/PKMediaFormat;)Lcom/kaltura/playkit/PKMediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static IntPtr n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;", "GetSetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaSource SetUrl (string p0)
		{
			if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaSource __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaSource;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Kaltura.Playkit.PKMediaSource __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaSource']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

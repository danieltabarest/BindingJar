using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PKMediaEntry", DoNotGenerateAcw=true)]
	public partial class PKMediaEntry : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry.MediaEntryType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PKMediaEntry$MediaEntryType", DoNotGenerateAcw=true)]
		public sealed partial class MediaEntryType : global::Java.Lang.Enum {


			static IntPtr Live_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry.MediaEntryType']/field[@name='Live']"
			[Register ("Live")]
			public static global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType Live {
				get {
					if (Live_jfieldId == IntPtr.Zero)
						Live_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Live", "Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Live_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Unknown_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry.MediaEntryType']/field[@name='Unknown']"
			[Register ("Unknown")]
			public static global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType Unknown {
				get {
					if (Unknown_jfieldId == IntPtr.Zero)
						Unknown_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Unknown", "Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Unknown_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr Vod_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry.MediaEntryType']/field[@name='Vod']"
			[Register ("Vod")]
			public static global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType Vod {
				get {
					if (Vod_jfieldId == IntPtr.Zero)
						Vod_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Vod", "Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Vod_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PKMediaEntry$MediaEntryType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MediaEntryType); }
			}

			internal MediaEntryType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry.MediaEntryType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry.MediaEntryType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
				try {
					return (global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PKMediaEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKMediaEntry); }
		}

		protected PKMediaEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/constructor[@name='PKMediaEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PKMediaEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PKMediaEntry)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/constructor[@name='PKMediaEntry' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe PKMediaEntry (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PKMediaEntry)) {
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

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_hasSources;
#pragma warning disable 0169
		static Delegate GetHasSourcesHandler ()
		{
			if (cb_hasSources == null)
				cb_hasSources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSources);
			return cb_hasSources;
		}

		static bool n_HasSources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSources;
		}
#pragma warning restore 0169

		static IntPtr id_hasSources;
		public virtual unsafe bool HasSources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='hasSources' and count(parameter)=0]"
			[Register ("hasSources", "()Z", "GetHasSourcesHandler")]
			get {
				if (id_hasSources == IntPtr.Zero)
					id_hasSources = JNIEnv.GetMethodID (class_ref, "hasSources", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSources);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSources", "()Z"));
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
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='getId' and count(parameter)=0]"
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

		static Delegate cb_getMediaType;
#pragma warning disable 0169
		static Delegate GetGetMediaTypeHandler ()
		{
			if (cb_getMediaType == null)
				cb_getMediaType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMediaType);
			return cb_getMediaType;
		}

		static IntPtr n_GetMediaType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MediaType);
		}
#pragma warning restore 0169

		static IntPtr id_getMediaType;
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType MediaType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='getMediaType' and count(parameter)=0]"
			[Register ("getMediaType", "()Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;", "GetGetMediaTypeHandler")]
			get {
				if (id_getMediaType == IntPtr.Zero)
					id_getMediaType = JNIEnv.GetMethodID (class_ref, "getMediaType", "()Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMediaType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediaType", "()Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSources;
#pragma warning disable 0169
		static Delegate GetGetSourcesHandler ()
		{
			if (cb_getSources == null)
				cb_getSources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSources);
			return cb_getSources;
		}

		static IntPtr n_GetSources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKMediaSource>.ToLocalJniHandle (__this.Sources);
		}
#pragma warning restore 0169

		static IntPtr id_getSources;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.PKMediaSource> Sources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='getSources' and count(parameter)=0]"
			[Register ("getSources", "()Ljava/util/List;", "GetGetSourcesHandler")]
			get {
				if (id_getSources == IntPtr.Zero)
					id_getSources = JNIEnv.GetMethodID (class_ref, "getSources", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKMediaSource>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSources), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKMediaSource>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSources", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static IntPtr n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDuration (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setDuration_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)Lcom/kaltura/playkit/PKMediaEntry;", "GetSetDuration_JHandler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry SetDuration (long p0)
		{
			if (id_setDuration_J == IntPtr.Zero)
				id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)Lcom/kaltura/playkit/PKMediaEntry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(J)Lcom/kaltura/playkit/PKMediaEntry;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setId", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry;", "GetSetId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry SetId (string p0)
		{
			if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
				id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaEntry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_;
#pragma warning disable 0169
		static Delegate GetSetMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_Handler ()
		{
			if (cb_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_ == null)
				cb_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_);
			return cb_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_;
		}

		static IntPtr n_SetMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType p0 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMediaType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='setMediaType' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaEntry.MediaEntryType']]"
		[Register ("setMediaType", "(Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;)Lcom/kaltura/playkit/PKMediaEntry;", "GetSetMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry SetMediaType (global::Com.Kaltura.Playkit.PKMediaEntry.MediaEntryType p0)
		{
			if (id_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_ == IntPtr.Zero)
				id_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_ = JNIEnv.GetMethodID (class_ref, "setMediaType", "(Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;)Lcom/kaltura/playkit/PKMediaEntry;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Kaltura.Playkit.PKMediaEntry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMediaType_Lcom_kaltura_playkit_PKMediaEntry_MediaEntryType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediaType", "(Lcom/kaltura/playkit/PKMediaEntry$MediaEntryType;)Lcom/kaltura/playkit/PKMediaEntry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setMetadata_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Ljava_util_Map_Handler ()
		{
			if (cb_setMetadata_Ljava_util_Map_ == null)
				cb_setMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMetadata_Ljava_util_Map_);
			return cb_setMetadata_Ljava_util_Map_;
		}

		static IntPtr n_SetMetadata_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMetadata (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMetadata_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setMetadata", "(Ljava/util/Map;)Lcom/kaltura/playkit/PKMediaEntry;", "GetSetMetadata_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry SetMetadata (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setMetadata_Ljava_util_Map_ == IntPtr.Zero)
				id_setMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Ljava/util/Map;)Lcom/kaltura/playkit/PKMediaEntry;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaEntry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMetadata_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadata", "(Ljava/util/Map;)Lcom/kaltura/playkit/PKMediaEntry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static IntPtr n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setName", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry;", "GetSetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry SetName (string p0)
		{
			if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
				id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaEntry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)Lcom/kaltura/playkit/PKMediaEntry;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setSources_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSources_Ljava_util_List_Handler ()
		{
			if (cb_setSources_Ljava_util_List_ == null)
				cb_setSources_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSources_Ljava_util_List_);
			return cb_setSources_Ljava_util_List_;
		}

		static IntPtr n_SetSources_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKMediaSource>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSources (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setSources_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='setSources' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.kaltura.playkit.PKMediaSource&gt;']]"
		[Register ("setSources", "(Ljava/util/List;)Lcom/kaltura/playkit/PKMediaEntry;", "GetSetSources_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.PKMediaEntry SetSources (global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.PKMediaSource> p0)
		{
			if (id_setSources_Ljava_util_List_ == IntPtr.Zero)
				id_setSources_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSources", "(Ljava/util/List;)Lcom/kaltura/playkit/PKMediaEntry;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.PKMediaSource>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.PKMediaEntry __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setSources_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSources", "(Ljava/util/List;)Lcom/kaltura/playkit/PKMediaEntry;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.PKMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PKMediaEntry']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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

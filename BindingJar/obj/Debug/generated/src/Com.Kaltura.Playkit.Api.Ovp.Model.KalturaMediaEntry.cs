using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Ovp.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/model/KalturaMediaEntry", DoNotGenerateAcw=true)]
	public partial class KalturaMediaEntry : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/model/KalturaMediaEntry", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalturaMediaEntry); }
		}

		protected KalturaMediaEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/constructor[@name='KalturaMediaEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalturaMediaEntry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KalturaMediaEntry)) {
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

		static Delegate cb_getDataUrl;
#pragma warning disable 0169
		static Delegate GetGetDataUrlHandler ()
		{
			if (cb_getDataUrl == null)
				cb_getDataUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataUrl);
			return cb_getDataUrl;
		}

		static IntPtr n_GetDataUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DataUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getDataUrl;
		public virtual unsafe string DataUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getDataUrl' and count(parameter)=0]"
			[Register ("getDataUrl", "()Ljava/lang/String;", "GetGetDataUrlHandler")]
			get {
				if (id_getDataUrl == IntPtr.Zero)
					id_getDataUrl = JNIEnv.GetMethodID (class_ref, "getDataUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDataUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDataUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFlavorParamsIds;
#pragma warning disable 0169
		static Delegate GetGetFlavorParamsIdsHandler ()
		{
			if (cb_getFlavorParamsIds == null)
				cb_getFlavorParamsIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlavorParamsIds);
			return cb_getFlavorParamsIds;
		}

		static IntPtr n_GetFlavorParamsIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FlavorParamsIds);
		}
#pragma warning restore 0169

		static IntPtr id_getFlavorParamsIds;
		public virtual unsafe string FlavorParamsIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getFlavorParamsIds' and count(parameter)=0]"
			[Register ("getFlavorParamsIds", "()Ljava/lang/String;", "GetGetFlavorParamsIdsHandler")]
			get {
				if (id_getFlavorParamsIds == IntPtr.Zero)
					id_getFlavorParamsIds = JNIEnv.GetMethodID (class_ref, "getFlavorParamsIds", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFlavorParamsIds), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlavorParamsIds", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFlavorParamsIdsList;
#pragma warning disable 0169
		static Delegate GetGetFlavorParamsIdsListHandler ()
		{
			if (cb_getFlavorParamsIdsList == null)
				cb_getFlavorParamsIdsList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlavorParamsIdsList);
			return cb_getFlavorParamsIdsList;
		}

		static IntPtr n_GetFlavorParamsIdsList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.FlavorParamsIdsList);
		}
#pragma warning restore 0169

		static IntPtr id_getFlavorParamsIdsList;
		public virtual unsafe global::System.Collections.Generic.IList<string> FlavorParamsIdsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getFlavorParamsIdsList' and count(parameter)=0]"
			[Register ("getFlavorParamsIdsList", "()Ljava/util/List;", "GetGetFlavorParamsIdsListHandler")]
			get {
				if (id_getFlavorParamsIdsList == IntPtr.Zero)
					id_getFlavorParamsIdsList = JNIEnv.GetMethodID (class_ref, "getFlavorParamsIdsList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFlavorParamsIdsList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlavorParamsIdsList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMsDuration;
#pragma warning disable 0169
		static Delegate GetGetMsDurationHandler ()
		{
			if (cb_getMsDuration == null)
				cb_getMsDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMsDuration);
			return cb_getMsDuration;
		}

		static int n_GetMsDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MsDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getMsDuration;
		public virtual unsafe int MsDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getMsDuration' and count(parameter)=0]"
			[Register ("getMsDuration", "()I", "GetGetMsDurationHandler")]
			get {
				if (id_getMsDuration == IntPtr.Zero)
					id_getMsDuration = JNIEnv.GetMethodID (class_ref, "getMsDuration", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMsDuration);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMsDuration", "()I"));
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
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getName' and count(parameter)=0]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaMediaEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaMediaEntry']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaEntryType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Lcom/kaltura/playkit/api/ovp/model/KalturaEntryType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

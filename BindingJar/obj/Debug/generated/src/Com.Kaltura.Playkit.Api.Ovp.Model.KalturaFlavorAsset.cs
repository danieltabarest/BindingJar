using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Lang;

namespace Com.Kaltura.Playkit.Api.Ovp.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/model/KalturaFlavorAsset", DoNotGenerateAcw=true)]
	public partial class KalturaFlavorAsset : global::Java.Lang.Object, FlavorAssetsFilter.IFilterable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/model/KalturaFlavorAsset", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalturaFlavorAsset); }
		}

		protected KalturaFlavorAsset (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/constructor[@name='KalturaFlavorAsset' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalturaFlavorAsset ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KalturaFlavorAsset)) {
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

		static Delegate cb_getBitrate;
#pragma warning disable 0169
		static Delegate GetGetBitrateHandler ()
		{
			if (cb_getBitrate == null)
				cb_getBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBitrate);
			return cb_getBitrate;
		}

		static int n_GetBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getBitrate;
		public virtual unsafe int Bitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getBitrate' and count(parameter)=0]"
			[Register ("getBitrate", "()I", "GetGetBitrateHandler")]
			get {
				if (id_getBitrate == IntPtr.Zero)
					id_getBitrate = JNIEnv.GetMethodID (class_ref, "getBitrate", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBitrate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitrate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFileExt;
#pragma warning disable 0169
		static Delegate GetGetFileExtHandler ()
		{
			if (cb_getFileExt == null)
				cb_getFileExt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileExt);
			return cb_getFileExt;
		}

		static IntPtr n_GetFileExt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileExt);
		}
#pragma warning restore 0169

		static IntPtr id_getFileExt;
		public virtual unsafe string FileExt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getFileExt' and count(parameter)=0]"
			[Register ("getFileExt", "()Ljava/lang/String;", "GetGetFileExtHandler")]
			get {
				if (id_getFileExt == IntPtr.Zero)
					id_getFileExt = JNIEnv.GetMethodID (class_ref, "getFileExt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileExt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileExt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFlavorParamsId;
#pragma warning disable 0169
		static Delegate GetGetFlavorParamsIdHandler ()
		{
			if (cb_getFlavorParamsId == null)
				cb_getFlavorParamsId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlavorParamsId);
			return cb_getFlavorParamsId;
		}

		static IntPtr n_GetFlavorParamsId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FlavorParamsId);
		}
#pragma warning restore 0169

		static IntPtr id_getFlavorParamsId;
		public virtual unsafe string FlavorParamsId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getFlavorParamsId' and count(parameter)=0]"
			[Register ("getFlavorParamsId", "()Ljava/lang/String;", "GetGetFlavorParamsIdHandler")]
			get {
				if (id_getFlavorParamsId == IntPtr.Zero)
					id_getFlavorParamsId = JNIEnv.GetMethodID (class_ref, "getFlavorParamsId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFlavorParamsId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFlavorParamsId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static IntPtr id_getHeight;
		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
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
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static IntPtr id_getWidth;
		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMemberValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMemberValue_Ljava_lang_String_Handler ()
		{
			if (cb_getMemberValue_Ljava_lang_String_ == null)
				cb_getMemberValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMemberValue_Ljava_lang_String_);
			return cb_getMemberValue_Ljava_lang_String_;
		}

		static IntPtr n_GetMemberValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.KalturaFlavorAsset> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMemberValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMemberValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='KalturaFlavorAsset']/method[@name='getMemberValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMemberValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetMemberValue_Ljava_lang_String_Handler")]
		public virtual unsafe string GetMemberValue (string p0)
		{
			if (id_getMemberValue_Ljava_lang_String_ == IntPtr.Zero)
				id_getMemberValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMemberValue", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMemberValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMemberValue", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

        Java.Lang.Object FlavorAssetsFilter.IFilterable.GetMemberValue(string p0)
        {
            throw new NotImplementedException();
        }
    }
}

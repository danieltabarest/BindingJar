using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Ovp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='APIDefines']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/APIDefines", DoNotGenerateAcw=true)]
	public partial class APIDefines : global::Java.Lang.Object {

		[Register ("com/kaltura/playkit/api/ovp/APIDefines$ResponseProfileType", DoNotGenerateAcw=true)]
		public abstract class ResponseProfileType : Java.Lang.Object {

			internal ResponseProfileType ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/interface[@name='APIDefines.ResponseProfileType']/field[@name='ExcludeFields']"
			[Register ("ExcludeFields")]
			public const int ExcludeFields = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/interface[@name='APIDefines.ResponseProfileType']/field[@name='IncludeFields']"
			[Register ("IncludeFields")]
			public const int IncludeFields = (int) 1;

			// The following are fields from: java.lang.annotation.Annotation

			// The following are fields from: Android.Runtime.IJavaObject

			// The following are fields from: System.IDisposable
		}

		[Register ("com/kaltura/playkit/api/ovp/APIDefines$ResponseProfileType", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ResponseProfileType' type. This type will be removed in a future release.")]
		public abstract class ResponseProfileTypeConsts : ResponseProfileType {

			private ResponseProfileTypeConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/interface[@name='APIDefines.ResponseProfileType']"
		[Register ("com/kaltura/playkit/api/ovp/APIDefines$ResponseProfileType", "", "Com.Kaltura.Playkit.Api.Ovp.APIDefines/IResponseProfileTypeInvoker")]
		public partial interface IResponseProfileType : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/APIDefines$ResponseProfileType", DoNotGenerateAcw=true)]
		internal class IResponseProfileTypeInvoker : global::Java.Lang.Object, IResponseProfileType {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/APIDefines$ResponseProfileType");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IResponseProfileTypeInvoker); }
			}

			IntPtr class_ref;

			public static IResponseProfileType GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResponseProfileType> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.api.ovp.APIDefines.ResponseProfileType"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResponseProfileTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (obj);
				global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.APIDefines.IResponseProfileType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/APIDefines", ref java_class_handle);
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.ovp']/class[@name='APIDefines']/constructor[@name='APIDefines' and count(parameter)=0]"
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

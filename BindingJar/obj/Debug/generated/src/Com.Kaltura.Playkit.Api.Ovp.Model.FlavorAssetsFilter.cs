using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Api.Ovp.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='FlavorAssetsFilter']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/model/FlavorAssetsFilter", DoNotGenerateAcw=true)]
	public partial class FlavorAssetsFilter : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/interface[@name='FlavorAssetsFilter.Filterable']"
		[Register ("com/kaltura/playkit/api/ovp/model/FlavorAssetsFilter$Filterable", "", "Com.Kaltura.Playkit.Api.Ovp.Model.FlavorAssetsFilter/IFilterableInvoker")]
		public partial interface IFilterable : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/interface[@name='FlavorAssetsFilter.Filterable']/method[@name='getMemberValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getMemberValue", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetMemberValue_Ljava_lang_String_Handler:Com.Kaltura.Playkit.Api.Ovp.Model.FlavorAssetsFilter/IFilterableInvoker, BindingJar")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"V"})]
			global::Java.Lang.Object GetMemberValue (string p0);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/api/ovp/model/FlavorAssetsFilter$Filterable", DoNotGenerateAcw=true)]
		internal class IFilterableInvoker : global::Java.Lang.Object, IFilterable {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/model/FlavorAssetsFilter$Filterable");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IFilterableInvoker); }
			}

			IntPtr class_ref;

			public static IFilterable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFilterable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.api.ovp.model.FlavorAssetsFilter.Filterable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFilterableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
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
				global::Com.Kaltura.Playkit.Api.Ovp.Model.FlavorAssetsFilter.IFilterable __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Api.Ovp.Model.FlavorAssetsFilter.IFilterable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMemberValue (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getMemberValue_Ljava_lang_String_;
			public unsafe global::Java.Lang.Object GetMemberValue (string p0)
			{
				if (id_getMemberValue_Ljava_lang_String_ == IntPtr.Zero)
					id_getMemberValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMemberValue", "(Ljava/lang/String;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMemberValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/api/ovp/model/FlavorAssetsFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlavorAssetsFilter); }
		}

		protected FlavorAssetsFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='FlavorAssetsFilter']/constructor[@name='FlavorAssetsFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlavorAssetsFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FlavorAssetsFilter)) {
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

		static IntPtr id_filter_Ljava_util_List_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='FlavorAssetsFilter']/method[@name='filter' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String...']]"
		[Register ("filter", "(Ljava/util/List;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.kaltura.playkit.api.ovp.model.FlavorAssetsFilter.Filterable"})]
		public static unsafe global::System.Collections.IList Filter (global::System.Collections.IList p0, string p1, params  string[] p2)
		{
			if (id_filter_Ljava_util_List_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_filter_Ljava_util_List_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "filter", "(Ljava/util/List;Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_filter_Ljava_util_List_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_filter_Ljava_util_List_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.api.ovp.model']/class[@name='FlavorAssetsFilter']/method[@name='filter' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filter", "(Ljava/util/List;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.kaltura.playkit.api.ovp.model.FlavorAssetsFilter.Filterable"})]
		public static unsafe global::System.Collections.IList Filter (global::System.Collections.IList p0, string p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_filter_Ljava_util_List_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_filter_Ljava_util_List_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filter", "(Ljava/util/List;Ljava/lang/String;Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_filter_Ljava_util_List_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}

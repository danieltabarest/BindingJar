using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalDataStore']"
	[Register ("com/kaltura/playkit/LocalDataStore", "", "Com.Kaltura.Playkit.ILocalDataStoreInvoker")]
	public partial interface ILocalDataStore : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalDataStore']/method[@name='load' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("load", "(Ljava/lang/String;)[B", "GetLoad_Ljava_lang_String_Handler:Com.Kaltura.Playkit.ILocalDataStoreInvoker, BindingJar")]
		byte[] Load (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalDataStore']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Handler:Com.Kaltura.Playkit.ILocalDataStoreInvoker, BindingJar")]
		void Remove (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='LocalDataStore']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("save", "(Ljava/lang/String;[B)V", "GetSave_Ljava_lang_String_arrayBHandler:Com.Kaltura.Playkit.ILocalDataStoreInvoker, BindingJar")]
		void Save (string p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/LocalDataStore", DoNotGenerateAcw=true)]
	internal class ILocalDataStoreInvoker : global::Java.Lang.Object, ILocalDataStore {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/LocalDataStore");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILocalDataStoreInvoker); }
		}

		IntPtr class_ref;

		public static ILocalDataStore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocalDataStore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.LocalDataStore"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocalDataStoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_load_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoad_Ljava_lang_String_Handler ()
		{
			if (cb_load_Ljava_lang_String_ == null)
				cb_load_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_Ljava_lang_String_);
			return cb_load_Ljava_lang_String_;
		}

		static IntPtr n_Load_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.ILocalDataStore __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.ILocalDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Load (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_load_Ljava_lang_String_;
		public unsafe byte[] Load (string p0)
		{
			if (id_load_Ljava_lang_String_ == IntPtr.Zero)
				id_load_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "load", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_load_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_remove_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.ILocalDataStore __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.ILocalDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		IntPtr id_remove_Ljava_lang_String_;
		public unsafe void Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_save_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_save_Ljava_lang_String_arrayB == null)
				cb_save_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_Ljava_lang_String_arrayB);
			return cb_save_Ljava_lang_String_arrayB;
		}

		static void n_Save_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.ILocalDataStore __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.ILocalDataStore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Save (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_save_Ljava_lang_String_arrayB;
		public unsafe void Save (string p0, byte[] p1)
		{
			if (id_save_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_save_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "save", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_save_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Drm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicCompat']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/drm/WidevineClassicCompat", DoNotGenerateAcw=true)]
	public partial class WidevineClassicCompat : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/drm/WidevineClassicCompat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WidevineClassicCompat); }
		}

		protected WidevineClassicCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicCompat']/constructor[@name='WidevineClassicCompat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WidevineClassicCompat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (WidevineClassicCompat)) {
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

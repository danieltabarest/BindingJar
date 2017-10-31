using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player.Metadata {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/interface[@name='PKMetadata']"
	[Register ("com/kaltura/playkit/player/metadata/PKMetadata", "", "Com.Kaltura.Playkit.Player.Metadata.IPKMetadataInvoker")]
	public partial interface IPKMetadata : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/player/metadata/PKMetadata", DoNotGenerateAcw=true)]
	internal class IPKMetadataInvoker : global::Java.Lang.Object, IPKMetadata {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/player/metadata/PKMetadata");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPKMetadataInvoker); }
		}

		IntPtr class_ref;

		public static IPKMetadata GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPKMetadata> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.player.metadata.PKMetadata"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPKMetadataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}

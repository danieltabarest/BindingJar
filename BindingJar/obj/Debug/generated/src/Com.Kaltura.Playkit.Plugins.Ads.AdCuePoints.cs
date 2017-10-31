using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdCuePoints']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdCuePoints", DoNotGenerateAcw=true)]
	public partial class AdCuePoints : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdCuePoints", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdCuePoints); }
		}

		protected AdCuePoints (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdCuePoints']/constructor[@name='AdCuePoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Long&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe AdCuePoints (global::System.Collections.Generic.IList<global::Java.Lang.Long> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (AdCuePoints)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasMidRoll;
#pragma warning disable 0169
		static Delegate GetHasMidRollHandler ()
		{
			if (cb_hasMidRoll == null)
				cb_hasMidRoll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMidRoll);
			return cb_hasMidRoll;
		}

		static bool n_HasMidRoll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMidRoll;
		}
#pragma warning restore 0169

		static IntPtr id_hasMidRoll;
		public virtual unsafe bool HasMidRoll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdCuePoints']/method[@name='hasMidRoll' and count(parameter)=0]"
			[Register ("hasMidRoll", "()Z", "GetHasMidRollHandler")]
			get {
				if (id_hasMidRoll == IntPtr.Zero)
					id_hasMidRoll = JNIEnv.GetMethodID (class_ref, "hasMidRoll", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasMidRoll);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasMidRoll", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasPostRoll;
#pragma warning disable 0169
		static Delegate GetHasPostRollHandler ()
		{
			if (cb_hasPostRoll == null)
				cb_hasPostRoll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPostRoll);
			return cb_hasPostRoll;
		}

		static bool n_HasPostRoll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPostRoll;
		}
#pragma warning restore 0169

		static IntPtr id_hasPostRoll;
		public virtual unsafe bool HasPostRoll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdCuePoints']/method[@name='hasPostRoll' and count(parameter)=0]"
			[Register ("hasPostRoll", "()Z", "GetHasPostRollHandler")]
			get {
				if (id_hasPostRoll == IntPtr.Zero)
					id_hasPostRoll = JNIEnv.GetMethodID (class_ref, "hasPostRoll", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPostRoll);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasPostRoll", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasPreRoll;
#pragma warning disable 0169
		static Delegate GetHasPreRollHandler ()
		{
			if (cb_hasPreRoll == null)
				cb_hasPreRoll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPreRoll);
			return cb_hasPreRoll;
		}

		static bool n_HasPreRoll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPreRoll;
		}
#pragma warning restore 0169

		static IntPtr id_hasPreRoll;
		public virtual unsafe bool HasPreRoll {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdCuePoints']/method[@name='hasPreRoll' and count(parameter)=0]"
			[Register ("hasPreRoll", "()Z", "GetHasPreRollHandler")]
			get {
				if (id_hasPreRoll == IntPtr.Zero)
					id_hasPreRoll = JNIEnv.GetMethodID (class_ref, "hasPreRoll", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasPreRoll);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasPreRoll", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdCuePoints;
#pragma warning disable 0169
		static Delegate GetGetAdCuePointsHandler ()
		{
			if (cb_getAdCuePoints == null)
				cb_getAdCuePoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdCuePoints);
			return cb_getAdCuePoints;
		}

		static IntPtr n_GetAdCuePoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdCuePoints> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (__this.GetAdCuePoints ());
		}
#pragma warning restore 0169

		static IntPtr id_getAdCuePoints;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdCuePoints']/method[@name='getAdCuePoints' and count(parameter)=0]"
		[Register ("getAdCuePoints", "()Ljava/util/List;", "GetGetAdCuePointsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Long> GetAdCuePoints ()
		{
			if (id_getAdCuePoints == IntPtr.Zero)
				id_getAdCuePoints = JNIEnv.GetMethodID (class_ref, "getAdCuePoints", "()Ljava/util/List;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdCuePoints), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdCuePoints", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

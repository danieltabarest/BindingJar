using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ads/AdInfo", DoNotGenerateAcw=true)]
	public partial class AdInfo : global::Java.Lang.Object, global::Com.Kaltura.Playkit.Ads.IPKAdInfo {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ads/AdInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdInfo); }
		}

		protected AdInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAdContentType;
#pragma warning disable 0169
		static Delegate GetGetAdContentTypeHandler ()
		{
			if (cb_getAdContentType == null)
				cb_getAdContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdContentType);
			return cb_getAdContentType;
		}

		static IntPtr n_GetAdContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdContentType;
		public virtual unsafe string AdContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdContentType' and count(parameter)=0]"
			[Register ("getAdContentType", "()Ljava/lang/String;", "GetGetAdContentTypeHandler")]
			get {
				if (id_getAdContentType == IntPtr.Zero)
					id_getAdContentType = JNIEnv.GetMethodID (class_ref, "getAdContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdContnentType;
#pragma warning disable 0169
		static Delegate GetGetAdContnentTypeHandler ()
		{
			if (cb_getAdContnentType == null)
				cb_getAdContnentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdContnentType);
			return cb_getAdContnentType;
		}

		static IntPtr n_GetAdContnentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdContnentType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdContnentType;
		public virtual unsafe string AdContnentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdContnentType' and count(parameter)=0]"
			[Register ("getAdContnentType", "()Ljava/lang/String;", "GetGetAdContnentTypeHandler")]
			get {
				if (id_getAdContnentType == IntPtr.Zero)
					id_getAdContnentType = JNIEnv.GetMethodID (class_ref, "getAdContnentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdContnentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdContnentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdDescription;
#pragma warning disable 0169
		static Delegate GetGetAdDescriptionHandler ()
		{
			if (cb_getAdDescription == null)
				cb_getAdDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdDescription);
			return cb_getAdDescription;
		}

		static IntPtr n_GetAdDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdDescription);
		}
#pragma warning restore 0169

		static IntPtr id_getAdDescription;
		public virtual unsafe string AdDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdDescription' and count(parameter)=0]"
			[Register ("getAdDescription", "()Ljava/lang/String;", "GetGetAdDescriptionHandler")]
			get {
				if (id_getAdDescription == IntPtr.Zero)
					id_getAdDescription = JNIEnv.GetMethodID (class_ref, "getAdDescription", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdDescription), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdDescription", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdDuration;
#pragma warning disable 0169
		static Delegate GetGetAdDurationHandler ()
		{
			if (cb_getAdDuration == null)
				cb_getAdDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAdDuration);
			return cb_getAdDuration;
		}

		static long n_GetAdDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getAdDuration;
		public virtual unsafe long AdDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdDuration' and count(parameter)=0]"
			[Register ("getAdDuration", "()J", "GetGetAdDurationHandler")]
			get {
				if (id_getAdDuration == IntPtr.Zero)
					id_getAdDuration = JNIEnv.GetMethodID (class_ref, "getAdDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdHeight;
#pragma warning disable 0169
		static Delegate GetGetAdHeightHandler ()
		{
			if (cb_getAdHeight == null)
				cb_getAdHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdHeight);
			return cb_getAdHeight;
		}

		static int n_GetAdHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getAdHeight;
		public virtual unsafe int AdHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdHeight' and count(parameter)=0]"
			[Register ("getAdHeight", "()I", "GetGetAdHeightHandler")]
			get {
				if (id_getAdHeight == IntPtr.Zero)
					id_getAdHeight = JNIEnv.GetMethodID (class_ref, "getAdHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdId;
#pragma warning disable 0169
		static Delegate GetGetAdIdHandler ()
		{
			if (cb_getAdId == null)
				cb_getAdId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdId);
			return cb_getAdId;
		}

		static IntPtr n_GetAdId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdId);
		}
#pragma warning restore 0169

		static IntPtr id_getAdId;
		public virtual unsafe string AdId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdId' and count(parameter)=0]"
			[Register ("getAdId", "()Ljava/lang/String;", "GetGetAdIdHandler")]
			get {
				if (id_getAdId == IntPtr.Zero)
					id_getAdId = JNIEnv.GetMethodID (class_ref, "getAdId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdIndexInPod;
#pragma warning disable 0169
		static Delegate GetGetAdIndexInPodHandler ()
		{
			if (cb_getAdIndexInPod == null)
				cb_getAdIndexInPod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdIndexInPod);
			return cb_getAdIndexInPod;
		}

		static int n_GetAdIndexInPod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdIndexInPod;
		}
#pragma warning restore 0169

		static IntPtr id_getAdIndexInPod;
		public virtual unsafe int AdIndexInPod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdIndexInPod' and count(parameter)=0]"
			[Register ("getAdIndexInPod", "()I", "GetGetAdIndexInPodHandler")]
			get {
				if (id_getAdIndexInPod == IntPtr.Zero)
					id_getAdIndexInPod = JNIEnv.GetMethodID (class_ref, "getAdIndexInPod", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdIndexInPod);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdIndexInPod", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdPlayHead;
#pragma warning disable 0169
		static Delegate GetGetAdPlayHeadHandler ()
		{
			if (cb_getAdPlayHead == null)
				cb_getAdPlayHead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAdPlayHead);
			return cb_getAdPlayHead;
		}

		static long n_GetAdPlayHead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdPlayHead;
		}
#pragma warning restore 0169

		static Delegate cb_setAdPlayHead_J;
#pragma warning disable 0169
		static Delegate GetSetAdPlayHead_JHandler ()
		{
			if (cb_setAdPlayHead_J == null)
				cb_setAdPlayHead_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAdPlayHead_J);
			return cb_setAdPlayHead_J;
		}

		static void n_SetAdPlayHead_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdPlayHead = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdPlayHead;
		static IntPtr id_setAdPlayHead_J;
		public virtual unsafe long AdPlayHead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdPlayHead' and count(parameter)=0]"
			[Register ("getAdPlayHead", "()J", "GetGetAdPlayHeadHandler")]
			get {
				if (id_getAdPlayHead == IntPtr.Zero)
					id_getAdPlayHead = JNIEnv.GetMethodID (class_ref, "getAdPlayHead", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdPlayHead);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPlayHead", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='setAdPlayHead' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAdPlayHead", "(J)V", "GetSetAdPlayHead_JHandler")]
			set {
				if (id_setAdPlayHead_J == IntPtr.Zero)
					id_setAdPlayHead_J = JNIEnv.GetMethodID (class_ref, "setAdPlayHead", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdPlayHead_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdPlayHead", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAdPodTimeOffset;
#pragma warning disable 0169
		static Delegate GetGetAdPodTimeOffsetHandler ()
		{
			if (cb_getAdPodTimeOffset == null)
				cb_getAdPodTimeOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAdPodTimeOffset);
			return cb_getAdPodTimeOffset;
		}

		static long n_GetAdPodTimeOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdPodTimeOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getAdPodTimeOffset;
		public virtual unsafe long AdPodTimeOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdPodTimeOffset' and count(parameter)=0]"
			[Register ("getAdPodTimeOffset", "()J", "GetGetAdPodTimeOffsetHandler")]
			get {
				if (id_getAdPodTimeOffset == IntPtr.Zero)
					id_getAdPodTimeOffset = JNIEnv.GetMethodID (class_ref, "getAdPodTimeOffset", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdPodTimeOffset);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPodTimeOffset", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getAdPositionType;
#pragma warning disable 0169
		static Delegate GetGetAdPositionTypeHandler ()
		{
			if (cb_getAdPositionType == null)
				cb_getAdPositionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPositionType);
			return cb_getAdPositionType;
		}

		static IntPtr n_GetAdPositionType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPositionType);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPositionType;
		public virtual unsafe global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType AdPositionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdPositionType' and count(parameter)=0]"
			[Register ("getAdPositionType", "()Lcom/kaltura/playkit/plugins/ads/AdPositionType;", "GetGetAdPositionTypeHandler")]
			get {
				if (id_getAdPositionType == IntPtr.Zero)
					id_getAdPositionType = JNIEnv.GetMethodID (class_ref, "getAdPositionType", "()Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPositionType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPositionType", "()Lcom/kaltura/playkit/plugins/ads/AdPositionType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdSystem;
#pragma warning disable 0169
		static Delegate GetGetAdSystemHandler ()
		{
			if (cb_getAdSystem == null)
				cb_getAdSystem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdSystem);
			return cb_getAdSystem;
		}

		static IntPtr n_GetAdSystem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdSystem);
		}
#pragma warning restore 0169

		static IntPtr id_getAdSystem;
		public virtual unsafe string AdSystem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdSystem' and count(parameter)=0]"
			[Register ("getAdSystem", "()Ljava/lang/String;", "GetGetAdSystemHandler")]
			get {
				if (id_getAdSystem == IntPtr.Zero)
					id_getAdSystem = JNIEnv.GetMethodID (class_ref, "getAdSystem", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdSystem), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdSystem", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdTitle;
#pragma warning disable 0169
		static Delegate GetGetAdTitleHandler ()
		{
			if (cb_getAdTitle == null)
				cb_getAdTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdTitle);
			return cb_getAdTitle;
		}

		static IntPtr n_GetAdTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getAdTitle;
		public virtual unsafe string AdTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdTitle' and count(parameter)=0]"
			[Register ("getAdTitle", "()Ljava/lang/String;", "GetGetAdTitleHandler")]
			get {
				if (id_getAdTitle == IntPtr.Zero)
					id_getAdTitle = JNIEnv.GetMethodID (class_ref, "getAdTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdWidth;
#pragma warning disable 0169
		static Delegate GetGetAdWidthHandler ()
		{
			if (cb_getAdWidth == null)
				cb_getAdWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdWidth);
			return cb_getAdWidth;
		}

		static int n_GetAdWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getAdWidth;
		public virtual unsafe int AdWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getAdWidth' and count(parameter)=0]"
			[Register ("getAdWidth", "()I", "GetGetAdWidthHandler")]
			get {
				if (id_getAdWidth == IntPtr.Zero)
					id_getAdWidth = JNIEnv.GetMethodID (class_ref, "getAdWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isAdSkippable;
#pragma warning disable 0169
		static Delegate GetIsAdSkippableHandler ()
		{
			if (cb_isAdSkippable == null)
				cb_isAdSkippable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAdSkippable);
			return cb_isAdSkippable;
		}

		static bool n_IsAdSkippable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAdSkippable;
		}
#pragma warning restore 0169

		static IntPtr id_isAdSkippable;
		public virtual unsafe bool IsAdSkippable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='isAdSkippable' and count(parameter)=0]"
			[Register ("isAdSkippable", "()Z", "GetIsAdSkippableHandler")]
			get {
				if (id_isAdSkippable == IntPtr.Zero)
					id_isAdSkippable = JNIEnv.GetMethodID (class_ref, "isAdSkippable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAdSkippable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAdSkippable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isBumper;
#pragma warning disable 0169
		static Delegate GetIsBumperHandler ()
		{
			if (cb_isBumper == null)
				cb_isBumper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBumper);
			return cb_isBumper;
		}

		static bool n_IsBumper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBumper;
		}
#pragma warning restore 0169

		static IntPtr id_isBumper;
		public virtual unsafe bool IsBumper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='isBumper' and count(parameter)=0]"
			[Register ("isBumper", "()Z", "GetIsBumperHandler")]
			get {
				if (id_isBumper == IntPtr.Zero)
					id_isBumper = JNIEnv.GetMethodID (class_ref, "isBumper", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBumper);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBumper", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getPodCount;
#pragma warning disable 0169
		static Delegate GetGetPodCountHandler ()
		{
			if (cb_getPodCount == null)
				cb_getPodCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPodCount);
			return cb_getPodCount;
		}

		static int n_GetPodCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PodCount;
		}
#pragma warning restore 0169

		static IntPtr id_getPodCount;
		public virtual unsafe int PodCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getPodCount' and count(parameter)=0]"
			[Register ("getPodCount", "()I", "GetGetPodCountHandler")]
			get {
				if (id_getPodCount == IntPtr.Zero)
					id_getPodCount = JNIEnv.GetMethodID (class_ref, "getPodCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPodCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPodCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getPodIndex;
#pragma warning disable 0169
		static Delegate GetGetPodIndexHandler ()
		{
			if (cb_getPodIndex == null)
				cb_getPodIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPodIndex);
			return cb_getPodIndex;
		}

		static int n_GetPodIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PodIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getPodIndex;
		public virtual unsafe int PodIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getPodIndex' and count(parameter)=0]"
			[Register ("getPodIndex", "()I", "GetGetPodIndexHandler")]
			get {
				if (id_getPodIndex == IntPtr.Zero)
					id_getPodIndex = JNIEnv.GetMethodID (class_ref, "getPodIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPodIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPodIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalAdsInPod;
#pragma warning disable 0169
		static Delegate GetGetTotalAdsInPodHandler ()
		{
			if (cb_getTotalAdsInPod == null)
				cb_getTotalAdsInPod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalAdsInPod);
			return cb_getTotalAdsInPod;
		}

		static int n_GetTotalAdsInPod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalAdsInPod;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalAdsInPod;
		public virtual unsafe int TotalAdsInPod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ads']/class[@name='AdInfo']/method[@name='getTotalAdsInPod' and count(parameter)=0]"
			[Register ("getTotalAdsInPod", "()I", "GetGetTotalAdsInPodHandler")]
			get {
				if (id_getTotalAdsInPod == IntPtr.Zero)
					id_getTotalAdsInPod = JNIEnv.GetMethodID (class_ref, "getTotalAdsInPod", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalAdsInPod);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalAdsInPod", "()I"));
				} finally {
				}
			}
		}

	}
}

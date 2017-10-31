using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Ads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']"
	[Register ("com/kaltura/playkit/ads/PKAdInfo", "", "Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker")]
	public partial interface IPKAdInfo : IJavaObject {

		string AdContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdContentType' and count(parameter)=0]"
			[Register ("getAdContentType", "()Ljava/lang/String;", "GetGetAdContentTypeHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		string AdDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdDescription' and count(parameter)=0]"
			[Register ("getAdDescription", "()Ljava/lang/String;", "GetGetAdDescriptionHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		long AdDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdDuration' and count(parameter)=0]"
			[Register ("getAdDuration", "()J", "GetGetAdDurationHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		int AdHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdHeight' and count(parameter)=0]"
			[Register ("getAdHeight", "()I", "GetGetAdHeightHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		string AdId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdId' and count(parameter)=0]"
			[Register ("getAdId", "()Ljava/lang/String;", "GetGetAdIdHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		int AdIndexInPod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdIndexInPod' and count(parameter)=0]"
			[Register ("getAdIndexInPod", "()I", "GetGetAdIndexInPodHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		long AdPlayHead {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdPlayHead' and count(parameter)=0]"
			[Register ("getAdPlayHead", "()J", "GetGetAdPlayHeadHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		long AdPodTimeOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdPodTimeOffset' and count(parameter)=0]"
			[Register ("getAdPodTimeOffset", "()J", "GetGetAdPodTimeOffsetHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType AdPositionType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdPositionType' and count(parameter)=0]"
			[Register ("getAdPositionType", "()Lcom/kaltura/playkit/plugins/ads/AdPositionType;", "GetGetAdPositionTypeHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		string AdSystem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdSystem' and count(parameter)=0]"
			[Register ("getAdSystem", "()Ljava/lang/String;", "GetGetAdSystemHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		string AdTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdTitle' and count(parameter)=0]"
			[Register ("getAdTitle", "()Ljava/lang/String;", "GetGetAdTitleHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		int AdWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getAdWidth' and count(parameter)=0]"
			[Register ("getAdWidth", "()I", "GetGetAdWidthHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		bool IsAdSkippable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='isAdSkippable' and count(parameter)=0]"
			[Register ("isAdSkippable", "()Z", "GetIsAdSkippableHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		bool IsBumper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='isBumper' and count(parameter)=0]"
			[Register ("isBumper", "()Z", "GetIsBumperHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		int PodCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getPodCount' and count(parameter)=0]"
			[Register ("getPodCount", "()I", "GetGetPodCountHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		int PodIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getPodIndex' and count(parameter)=0]"
			[Register ("getPodIndex", "()I", "GetGetPodIndexHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

		int TotalAdsInPod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.ads']/interface[@name='PKAdInfo']/method[@name='getTotalAdsInPod' and count(parameter)=0]"
			[Register ("getTotalAdsInPod", "()I", "GetGetTotalAdsInPodHandler:Com.Kaltura.Playkit.Ads.IPKAdInfoInvoker, BindingJar")] get;
		}

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/ads/PKAdInfo", DoNotGenerateAcw=true)]
	internal class IPKAdInfoInvoker : global::Java.Lang.Object, IPKAdInfo {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/ads/PKAdInfo");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPKAdInfoInvoker); }
		}

		IntPtr class_ref;

		public static IPKAdInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPKAdInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.ads.PKAdInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPKAdInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdContentType);
		}
#pragma warning restore 0169

		IntPtr id_getAdContentType;
		public unsafe string AdContentType {
			get {
				if (id_getAdContentType == IntPtr.Zero)
					id_getAdContentType = JNIEnv.GetMethodID (class_ref, "getAdContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdContentType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdDescription);
		}
#pragma warning restore 0169

		IntPtr id_getAdDescription;
		public unsafe string AdDescription {
			get {
				if (id_getAdDescription == IntPtr.Zero)
					id_getAdDescription = JNIEnv.GetMethodID (class_ref, "getAdDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdDescription), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdDuration;
		}
#pragma warning restore 0169

		IntPtr id_getAdDuration;
		public unsafe long AdDuration {
			get {
				if (id_getAdDuration == IntPtr.Zero)
					id_getAdDuration = JNIEnv.GetMethodID (class_ref, "getAdDuration", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdDuration);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdHeight;
		}
#pragma warning restore 0169

		IntPtr id_getAdHeight;
		public unsafe int AdHeight {
			get {
				if (id_getAdHeight == IntPtr.Zero)
					id_getAdHeight = JNIEnv.GetMethodID (class_ref, "getAdHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdHeight);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdId);
		}
#pragma warning restore 0169

		IntPtr id_getAdId;
		public unsafe string AdId {
			get {
				if (id_getAdId == IntPtr.Zero)
					id_getAdId = JNIEnv.GetMethodID (class_ref, "getAdId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdId), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdIndexInPod;
		}
#pragma warning restore 0169

		IntPtr id_getAdIndexInPod;
		public unsafe int AdIndexInPod {
			get {
				if (id_getAdIndexInPod == IntPtr.Zero)
					id_getAdIndexInPod = JNIEnv.GetMethodID (class_ref, "getAdIndexInPod", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdIndexInPod);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdPlayHead;
		}
#pragma warning restore 0169

		IntPtr id_getAdPlayHead;
		public unsafe long AdPlayHead {
			get {
				if (id_getAdPlayHead == IntPtr.Zero)
					id_getAdPlayHead = JNIEnv.GetMethodID (class_ref, "getAdPlayHead", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdPlayHead);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdPodTimeOffset;
		}
#pragma warning restore 0169

		IntPtr id_getAdPodTimeOffset;
		public unsafe long AdPodTimeOffset {
			get {
				if (id_getAdPodTimeOffset == IntPtr.Zero)
					id_getAdPodTimeOffset = JNIEnv.GetMethodID (class_ref, "getAdPodTimeOffset", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAdPodTimeOffset);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPositionType);
		}
#pragma warning restore 0169

		IntPtr id_getAdPositionType;
		public unsafe global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType AdPositionType {
			get {
				if (id_getAdPositionType == IntPtr.Zero)
					id_getAdPositionType = JNIEnv.GetMethodID (class_ref, "getAdPositionType", "()Lcom/kaltura/playkit/plugins/ads/AdPositionType;");
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ads.AdPositionType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPositionType), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdSystem);
		}
#pragma warning restore 0169

		IntPtr id_getAdSystem;
		public unsafe string AdSystem {
			get {
				if (id_getAdSystem == IntPtr.Zero)
					id_getAdSystem = JNIEnv.GetMethodID (class_ref, "getAdSystem", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdSystem), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdTitle);
		}
#pragma warning restore 0169

		IntPtr id_getAdTitle;
		public unsafe string AdTitle {
			get {
				if (id_getAdTitle == IntPtr.Zero)
					id_getAdTitle = JNIEnv.GetMethodID (class_ref, "getAdTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdTitle), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdWidth;
		}
#pragma warning restore 0169

		IntPtr id_getAdWidth;
		public unsafe int AdWidth {
			get {
				if (id_getAdWidth == IntPtr.Zero)
					id_getAdWidth = JNIEnv.GetMethodID (class_ref, "getAdWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdWidth);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAdSkippable;
		}
#pragma warning restore 0169

		IntPtr id_isAdSkippable;
		public unsafe bool IsAdSkippable {
			get {
				if (id_isAdSkippable == IntPtr.Zero)
					id_isAdSkippable = JNIEnv.GetMethodID (class_ref, "isAdSkippable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAdSkippable);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBumper;
		}
#pragma warning restore 0169

		IntPtr id_isBumper;
		public unsafe bool IsBumper {
			get {
				if (id_isBumper == IntPtr.Zero)
					id_isBumper = JNIEnv.GetMethodID (class_ref, "isBumper", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBumper);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PodCount;
		}
#pragma warning restore 0169

		IntPtr id_getPodCount;
		public unsafe int PodCount {
			get {
				if (id_getPodCount == IntPtr.Zero)
					id_getPodCount = JNIEnv.GetMethodID (class_ref, "getPodCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPodCount);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PodIndex;
		}
#pragma warning restore 0169

		IntPtr id_getPodIndex;
		public unsafe int PodIndex {
			get {
				if (id_getPodIndex == IntPtr.Zero)
					id_getPodIndex = JNIEnv.GetMethodID (class_ref, "getPodIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPodIndex);
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
			global::Com.Kaltura.Playkit.Ads.IPKAdInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Ads.IPKAdInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalAdsInPod;
		}
#pragma warning restore 0169

		IntPtr id_getTotalAdsInPod;
		public unsafe int TotalAdsInPod {
			get {
				if (id_getTotalAdsInPod == IntPtr.Zero)
					id_getTotalAdsInPod = JNIEnv.GetMethodID (class_ref, "getTotalAdsInPod", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalAdsInPod);
			}
		}

	}

}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PlaybackInfo", DoNotGenerateAcw=true)]
	public partial class PlaybackInfo : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PlaybackInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlaybackInfo); }
		}

		protected PlaybackInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJJJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']/constructor[@name='PlaybackInfo' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='long']]"
		[Register (".ctor", "(JJJJJ)V", "")]
		public unsafe PlaybackInfo (long p0, long p1, long p2, long p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (PlaybackInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JJJJJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJJJJ)V", __args);
					return;
				}

				if (id_ctor_JJJJJ == IntPtr.Zero)
					id_ctor_JJJJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJJJJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJJJJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJJJJ, __args);
			} finally {
			}
		}

		static Delegate cb_getAudioBitrate;
#pragma warning disable 0169
		static Delegate GetGetAudioBitrateHandler ()
		{
			if (cb_getAudioBitrate == null)
				cb_getAudioBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAudioBitrate);
			return cb_getAudioBitrate;
		}

		static long n_GetAudioBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PlaybackInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlaybackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioBitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getAudioBitrate;
		public virtual unsafe long AudioBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']/method[@name='getAudioBitrate' and count(parameter)=0]"
			[Register ("getAudioBitrate", "()J", "GetGetAudioBitrateHandler")]
			get {
				if (id_getAudioBitrate == IntPtr.Zero)
					id_getAudioBitrate = JNIEnv.GetMethodID (class_ref, "getAudioBitrate", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAudioBitrate);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioBitrate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoBitrate;
#pragma warning disable 0169
		static Delegate GetGetVideoBitrateHandler ()
		{
			if (cb_getVideoBitrate == null)
				cb_getVideoBitrate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVideoBitrate);
			return cb_getVideoBitrate;
		}

		static long n_GetVideoBitrate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PlaybackInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlaybackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoBitrate;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoBitrate;
		public virtual unsafe long VideoBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']/method[@name='getVideoBitrate' and count(parameter)=0]"
			[Register ("getVideoBitrate", "()J", "GetGetVideoBitrateHandler")]
			get {
				if (id_getVideoBitrate == IntPtr.Zero)
					id_getVideoBitrate = JNIEnv.GetMethodID (class_ref, "getVideoBitrate", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoBitrate);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoBitrate", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoHeight;
#pragma warning disable 0169
		static Delegate GetGetVideoHeightHandler ()
		{
			if (cb_getVideoHeight == null)
				cb_getVideoHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVideoHeight);
			return cb_getVideoHeight;
		}

		static long n_GetVideoHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PlaybackInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlaybackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoHeight;
		public virtual unsafe long VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()J", "GetGetVideoHeightHandler")]
			get {
				if (id_getVideoHeight == IntPtr.Zero)
					id_getVideoHeight = JNIEnv.GetMethodID (class_ref, "getVideoHeight", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoHeight);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoHeight", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoThroughput;
#pragma warning disable 0169
		static Delegate GetGetVideoThroughputHandler ()
		{
			if (cb_getVideoThroughput == null)
				cb_getVideoThroughput = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVideoThroughput);
			return cb_getVideoThroughput;
		}

		static long n_GetVideoThroughput (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PlaybackInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlaybackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoThroughput;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoThroughput;
		public virtual unsafe long VideoThroughput {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']/method[@name='getVideoThroughput' and count(parameter)=0]"
			[Register ("getVideoThroughput", "()J", "GetGetVideoThroughputHandler")]
			get {
				if (id_getVideoThroughput == IntPtr.Zero)
					id_getVideoThroughput = JNIEnv.GetMethodID (class_ref, "getVideoThroughput", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoThroughput);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoThroughput", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getVideoWidth;
#pragma warning disable 0169
		static Delegate GetGetVideoWidthHandler ()
		{
			if (cb_getVideoWidth == null)
				cb_getVideoWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetVideoWidth);
			return cb_getVideoWidth;
		}

		static long n_GetVideoWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PlaybackInfo __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlaybackInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoWidth;
		public virtual unsafe long VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlaybackInfo']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()J", "GetGetVideoWidthHandler")]
			get {
				if (id_getVideoWidth == IntPtr.Zero)
					id_getVideoWidth = JNIEnv.GetMethodID (class_ref, "getVideoWidth", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getVideoWidth);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoWidth", "()J"));
				} finally {
				}
			}
		}

	}
}

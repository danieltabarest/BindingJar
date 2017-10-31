using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/PKTracks", DoNotGenerateAcw=true)]
	public partial class PKTracks : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/PKTracks", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKTracks); }
		}

		protected PKTracks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Ljava_util_List_Ljava_util_List_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/constructor[@name='PKTracks' and count(parameter)=6 and parameter[1][@type='java.util.List&lt;com.kaltura.playkit.player.VideoTrack&gt;'] and parameter[2][@type='java.util.List&lt;com.kaltura.playkit.player.AudioTrack&gt;'] and parameter[3][@type='java.util.List&lt;com.kaltura.playkit.player.TextTrack&gt;'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;III)V", "")]
		public unsafe PKTracks (global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.VideoTrack> p0, global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.AudioTrack> p1, global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.TextTrack> p2, int p3, int p4, int p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.VideoTrack>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.AudioTrack>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.TextTrack>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (((object) this).GetType () != typeof (PKTracks)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;Ljava/util/List;Ljava/util/List;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;Ljava/util/List;Ljava/util/List;III)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_Ljava_util_List_Ljava_util_List_III == IntPtr.Zero)
					id_ctor_Ljava_util_List_Ljava_util_List_Ljava_util_List_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Ljava_util_List_Ljava_util_List_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_Ljava_util_List_Ljava_util_List_III, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAudioTracks;
#pragma warning disable 0169
		static Delegate GetGetAudioTracksHandler ()
		{
			if (cb_getAudioTracks == null)
				cb_getAudioTracks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioTracks);
			return cb_getAudioTracks;
		}

		static IntPtr n_GetAudioTracks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PKTracks __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.AudioTrack>.ToLocalJniHandle (__this.AudioTracks);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.AudioTrack> AudioTracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/method[@name='getAudioTracks' and count(parameter)=0]"
			[Register ("getAudioTracks", "()Ljava/util/List;", "GetGetAudioTracksHandler")]
			get {
				if (id_getAudioTracks == IntPtr.Zero)
					id_getAudioTracks = JNIEnv.GetMethodID (class_ref, "getAudioTracks", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.AudioTrack>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.AudioTrack>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultAudioTrackIndex;
#pragma warning disable 0169
		static Delegate GetGetDefaultAudioTrackIndexHandler ()
		{
			if (cb_getDefaultAudioTrackIndex == null)
				cb_getDefaultAudioTrackIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultAudioTrackIndex);
			return cb_getDefaultAudioTrackIndex;
		}

		static int n_GetDefaultAudioTrackIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PKTracks __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultAudioTrackIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultAudioTrackIndex;
		public virtual unsafe int DefaultAudioTrackIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/method[@name='getDefaultAudioTrackIndex' and count(parameter)=0]"
			[Register ("getDefaultAudioTrackIndex", "()I", "GetGetDefaultAudioTrackIndexHandler")]
			get {
				if (id_getDefaultAudioTrackIndex == IntPtr.Zero)
					id_getDefaultAudioTrackIndex = JNIEnv.GetMethodID (class_ref, "getDefaultAudioTrackIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultAudioTrackIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultAudioTrackIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultTextTrackIndex;
#pragma warning disable 0169
		static Delegate GetGetDefaultTextTrackIndexHandler ()
		{
			if (cb_getDefaultTextTrackIndex == null)
				cb_getDefaultTextTrackIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultTextTrackIndex);
			return cb_getDefaultTextTrackIndex;
		}

		static int n_GetDefaultTextTrackIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PKTracks __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultTextTrackIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultTextTrackIndex;
		public virtual unsafe int DefaultTextTrackIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/method[@name='getDefaultTextTrackIndex' and count(parameter)=0]"
			[Register ("getDefaultTextTrackIndex", "()I", "GetGetDefaultTextTrackIndexHandler")]
			get {
				if (id_getDefaultTextTrackIndex == IntPtr.Zero)
					id_getDefaultTextTrackIndex = JNIEnv.GetMethodID (class_ref, "getDefaultTextTrackIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultTextTrackIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultTextTrackIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultVideoTrackIndex;
#pragma warning disable 0169
		static Delegate GetGetDefaultVideoTrackIndexHandler ()
		{
			if (cb_getDefaultVideoTrackIndex == null)
				cb_getDefaultVideoTrackIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultVideoTrackIndex);
			return cb_getDefaultVideoTrackIndex;
		}

		static int n_GetDefaultVideoTrackIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PKTracks __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultVideoTrackIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultVideoTrackIndex;
		public virtual unsafe int DefaultVideoTrackIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/method[@name='getDefaultVideoTrackIndex' and count(parameter)=0]"
			[Register ("getDefaultVideoTrackIndex", "()I", "GetGetDefaultVideoTrackIndexHandler")]
			get {
				if (id_getDefaultVideoTrackIndex == IntPtr.Zero)
					id_getDefaultVideoTrackIndex = JNIEnv.GetMethodID (class_ref, "getDefaultVideoTrackIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultVideoTrackIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultVideoTrackIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTextTracks;
#pragma warning disable 0169
		static Delegate GetGetTextTracksHandler ()
		{
			if (cb_getTextTracks == null)
				cb_getTextTracks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextTracks);
			return cb_getTextTracks;
		}

		static IntPtr n_GetTextTracks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PKTracks __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.TextTrack>.ToLocalJniHandle (__this.TextTracks);
		}
#pragma warning restore 0169

		static IntPtr id_getTextTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.TextTrack> TextTracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/method[@name='getTextTracks' and count(parameter)=0]"
			[Register ("getTextTracks", "()Ljava/util/List;", "GetGetTextTracksHandler")]
			get {
				if (id_getTextTracks == IntPtr.Zero)
					id_getTextTracks = JNIEnv.GetMethodID (class_ref, "getTextTracks", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.TextTrack>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTextTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.TextTrack>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoTracks;
#pragma warning disable 0169
		static Delegate GetGetVideoTracksHandler ()
		{
			if (cb_getVideoTracks == null)
				cb_getVideoTracks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoTracks);
			return cb_getVideoTracks;
		}

		static IntPtr n_GetVideoTracks (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Player.PKTracks __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.VideoTrack>.ToLocalJniHandle (__this.VideoTracks);
		}
#pragma warning restore 0169

		static IntPtr id_getVideoTracks;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.VideoTrack> VideoTracks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.player']/class[@name='PKTracks']/method[@name='getVideoTracks' and count(parameter)=0]"
			[Register ("getVideoTracks", "()Ljava/util/List;", "GetGetVideoTracksHandler")]
			get {
				if (id_getVideoTracks == IntPtr.Zero)
					id_getVideoTracks = JNIEnv.GetMethodID (class_ref, "getVideoTracks", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.VideoTrack>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoTracks), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.VideoTrack>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoTracks", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}

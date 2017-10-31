using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent", DoNotGenerateAcw=true)]
	public partial class PlayerEvent : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPKEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.AudioTrackChanged']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$AudioTrackChanged", DoNotGenerateAcw=true)]
		public partial class AudioTrackChanged : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr newTrack_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.AudioTrackChanged']/field[@name='newTrack']"
			[Register ("newTrack")]
			public global::Com.Kaltura.Playkit.Player.AudioTrack NewTrack {
				get {
					if (newTrack_jfieldId == IntPtr.Zero)
						newTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "newTrack", "Lcom/kaltura/playkit/player/AudioTrack;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, newTrack_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.AudioTrack> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (newTrack_jfieldId == IntPtr.Zero)
						newTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "newTrack", "Lcom/kaltura/playkit/player/AudioTrack;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newTrack_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$AudioTrackChanged", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AudioTrackChanged); }
			}

			protected AudioTrackChanged (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_player_AudioTrack_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.AudioTrackChanged']/constructor[@name='PlayerEvent.AudioTrackChanged' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.player.AudioTrack']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/player/AudioTrack;)V", "")]
			public unsafe AudioTrackChanged (global::Com.Kaltura.Playkit.Player.AudioTrack p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (AudioTrackChanged)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/player/AudioTrack;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/player/AudioTrack;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_player_AudioTrack_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_player_AudioTrack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/player/AudioTrack;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_player_AudioTrack_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_player_AudioTrack_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.DurationChanged']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$DurationChanged", DoNotGenerateAcw=true)]
		public partial class DurationChanged : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr duration_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.DurationChanged']/field[@name='duration']"
			[Register ("duration")]
			public long Duration {
				get {
					if (duration_jfieldId == IntPtr.Zero)
						duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, duration_jfieldId);
				}
				set {
					if (duration_jfieldId == IntPtr.Zero)
						duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, duration_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$DurationChanged", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DurationChanged); }
			}

			protected DurationChanged (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.DurationChanged']/constructor[@name='PlayerEvent.DurationChanged' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe DurationChanged (long p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (DurationChanged)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
						return;
					}

					if (id_ctor_J == IntPtr.Zero)
						id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Error']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$Error", DoNotGenerateAcw=true)]
		public partial class Error : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr error_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Error']/field[@name='error']"
			[Register ("error")]
			public  global::Com.Kaltura.Playkit.PKError PlayerEventError
            {
				get {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lcom/kaltura/playkit/PKError;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, error_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKError> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (error_jfieldId == IntPtr.Zero)
						error_jfieldId = JNIEnv.GetFieldID (class_ref, "error", "Lcom/kaltura/playkit/PKError;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, error_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$Error", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Error); }
			}

			protected Error (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_PKError_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Error']/constructor[@name='PlayerEvent.Error' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKError']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/PKError;)V", "")]
			public unsafe Error (global::Com.Kaltura.Playkit.PKError p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Error)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PKError;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PKError;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_PKError_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_PKError_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PKError;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PKError_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PKError_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Generic']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$Generic", DoNotGenerateAcw=true)]
		public partial class Generic : global::Com.Kaltura.Playkit.PlayerEvent {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$Generic", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Generic); }
			}

			protected Generic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Generic']/constructor[@name='PlayerEvent.Generic' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PlayerEvent.Type']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/PlayerEvent$Type;)V", "")]
			public unsafe Generic (global::Com.Kaltura.Playkit.PlayerEvent.Type p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Generic)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PlayerEvent$Type;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PlayerEvent$Type;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PlayerEvent$Type;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PlayerEvent.Listener']"
		[Register ("com/kaltura/playkit/PlayerEvent$Listener", "", "Com.Kaltura.Playkit.PlayerEvent/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PlayerEvent.Listener']/method[@name='onPlayerEvent' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.Player'] and parameter[2][@type='com.kaltura.playkit.PlayerEvent.Type']]"
			[Register ("onPlayerEvent", "(Lcom/kaltura/playkit/Player;Lcom/kaltura/playkit/PlayerEvent$Type;)V", "GetOnPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_Handler:Com.Kaltura.Playkit.PlayerEvent/IListenerInvoker, BindingJar")]
			void OnPlayerEvent (global::Com.Kaltura.Playkit.IPlayer p0, global::Com.Kaltura.Playkit.PlayerEvent.Type p1);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$Listener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.PlayerEvent.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_;
#pragma warning disable 0169
			static Delegate GetOnPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_Handler ()
			{
				if (cb_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_ == null)
					cb_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_);
				return cb_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_;
			}

			static void n_OnPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Kaltura.Playkit.PlayerEvent.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.IPlayer p0 = (global::Com.Kaltura.Playkit.IPlayer)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPlayer> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Kaltura.Playkit.PlayerEvent.Type p1 = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnPlayerEvent (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_;
			public unsafe void OnPlayerEvent (global::Com.Kaltura.Playkit.IPlayer p0, global::Com.Kaltura.Playkit.PlayerEvent.Type p1)
			{
				if (id_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_ == IntPtr.Zero)
					id_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_ = JNIEnv.GetMethodID (class_ref, "onPlayerEvent", "(Lcom/kaltura/playkit/Player;Lcom/kaltura/playkit/PlayerEvent$Type;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlayerEvent_Lcom_kaltura_playkit_Player_Lcom_kaltura_playkit_PlayerEvent_Type_, __args);
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (global::Com.Kaltura.Playkit.IPlayer p0, global::Com.Kaltura.Playkit.PlayerEvent.Type p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Kaltura.Playkit.IPlayer p0;
			public global::Com.Kaltura.Playkit.IPlayer P0 {
				get { return p0; }
			}

			global::Com.Kaltura.Playkit.PlayerEvent.Type p1;
			public global::Com.Kaltura.Playkit.PlayerEvent.Type P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/kaltura/playkit/PlayerEvent_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/PlayerEvent_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnPlayerEvent (global::Com.Kaltura.Playkit.IPlayer p0, global::Com.Kaltura.Playkit.PlayerEvent.Type p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.MetadataAvailable']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$MetadataAvailable", DoNotGenerateAcw=true)]
		public partial class MetadataAvailable : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr metadataList_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.MetadataAvailable']/field[@name='metadataList']"
			[Register ("metadataList")]
			public global::System.Collections.IList MetadataList {
				get {
					if (metadataList_jfieldId == IntPtr.Zero)
						metadataList_jfieldId = JNIEnv.GetFieldID (class_ref, "metadataList", "Ljava/util/List;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, metadataList_jfieldId);
					return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (metadataList_jfieldId == IntPtr.Zero)
						metadataList_jfieldId = JNIEnv.GetFieldID (class_ref, "metadataList", "Ljava/util/List;");
					IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, metadataList_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$MetadataAvailable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MetadataAvailable); }
			}

			protected MetadataAvailable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_List_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.MetadataAvailable']/constructor[@name='PlayerEvent.MetadataAvailable' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.kaltura.playkit.player.metadata.PKMetadata&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe MetadataAvailable (global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata> p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata>.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (MetadataAvailable)) {
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlaybackInfoUpdated']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$PlaybackInfoUpdated", DoNotGenerateAcw=true)]
		public partial class PlaybackInfoUpdated : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr playbackInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlaybackInfoUpdated']/field[@name='playbackInfo']"
			[Register ("playbackInfo")]
			public global::Com.Kaltura.Playkit.PlaybackInfo PlaybackInfo {
				get {
					if (playbackInfo_jfieldId == IntPtr.Zero)
						playbackInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "playbackInfo", "Lcom/kaltura/playkit/PlaybackInfo;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, playbackInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlaybackInfo> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (playbackInfo_jfieldId == IntPtr.Zero)
						playbackInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "playbackInfo", "Lcom/kaltura/playkit/PlaybackInfo;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, playbackInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$PlaybackInfoUpdated", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PlaybackInfoUpdated); }
			}

			protected PlaybackInfoUpdated (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_PlaybackInfo_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlaybackInfoUpdated']/constructor[@name='PlayerEvent.PlaybackInfoUpdated' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PlaybackInfo']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/PlaybackInfo;)V", "")]
			public unsafe PlaybackInfoUpdated (global::Com.Kaltura.Playkit.PlaybackInfo p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (PlaybackInfoUpdated)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PlaybackInfo;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PlaybackInfo;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_PlaybackInfo_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_PlaybackInfo_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PlaybackInfo;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PlaybackInfo_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PlaybackInfo_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlayheadUpdated']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$PlayheadUpdated", DoNotGenerateAcw=true)]
		public partial class PlayheadUpdated : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr duration_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlayheadUpdated']/field[@name='duration']"
			[Register ("duration")]
			public long Duration {
				get {
					if (duration_jfieldId == IntPtr.Zero)
						duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, duration_jfieldId);
				}
				set {
					if (duration_jfieldId == IntPtr.Zero)
						duration_jfieldId = JNIEnv.GetFieldID (class_ref, "duration", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, duration_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr position_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlayheadUpdated']/field[@name='position']"
			[Register ("position")]
			public long Position {
				get {
					if (position_jfieldId == IntPtr.Zero)
						position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, position_jfieldId);
				}
				set {
					if (position_jfieldId == IntPtr.Zero)
						position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, position_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$PlayheadUpdated", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PlayheadUpdated); }
			}

			protected PlayheadUpdated (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_JJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.PlayheadUpdated']/constructor[@name='PlayerEvent.PlayheadUpdated' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe PlayheadUpdated (long p0, long p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (PlayheadUpdated)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(JJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJ)V", __args);
						return;
					}

					if (id_ctor_JJ == IntPtr.Zero)
						id_ctor_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJ, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Seeking']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$Seeking", DoNotGenerateAcw=true)]
		public partial class Seeking : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr targetPosition_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Seeking']/field[@name='targetPosition']"
			[Register ("targetPosition")]
			public long TargetPosition {
				get {
					if (targetPosition_jfieldId == IntPtr.Zero)
						targetPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "targetPosition", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, targetPosition_jfieldId);
				}
				set {
					if (targetPosition_jfieldId == IntPtr.Zero)
						targetPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "targetPosition", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetPosition_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$Seeking", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Seeking); }
			}

			protected Seeking (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Seeking']/constructor[@name='PlayerEvent.Seeking' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe Seeking (long p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Seeking)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
						return;
					}

					if (id_ctor_J == IntPtr.Zero)
						id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.SourceSelected']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$SourceSelected", DoNotGenerateAcw=true)]
		public partial class SourceSelected : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr source_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.SourceSelected']/field[@name='source']"
			[Register ("source")]
			public global::Com.Kaltura.Playkit.PKMediaSource Source {
				get {
					if (source_jfieldId == IntPtr.Zero)
						source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Lcom/kaltura/playkit/PKMediaSource;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, source_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PKMediaSource> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (source_jfieldId == IntPtr.Zero)
						source_jfieldId = JNIEnv.GetFieldID (class_ref, "source", "Lcom/kaltura/playkit/PKMediaSource;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, source_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$SourceSelected", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SourceSelected); }
			}

			protected SourceSelected (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_PKMediaSource_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.SourceSelected']/constructor[@name='PlayerEvent.SourceSelected' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKMediaSource']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/PKMediaSource;)V", "")]
			public unsafe SourceSelected (global::Com.Kaltura.Playkit.PKMediaSource p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (SourceSelected)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PKMediaSource;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PKMediaSource;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_PKMediaSource_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_PKMediaSource_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PKMediaSource;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PKMediaSource_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PKMediaSource_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.StateChanged']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$StateChanged", DoNotGenerateAcw=true)]
		public partial class StateChanged : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr newState_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.StateChanged']/field[@name='newState']"
			[Register ("newState")]
			public global::Com.Kaltura.Playkit.PlayerState NewState {
				get {
					if (newState_jfieldId == IntPtr.Zero)
						newState_jfieldId = JNIEnv.GetFieldID (class_ref, "newState", "Lcom/kaltura/playkit/PlayerState;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, newState_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (newState_jfieldId == IntPtr.Zero)
						newState_jfieldId = JNIEnv.GetFieldID (class_ref, "newState", "Lcom/kaltura/playkit/PlayerState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newState_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr oldState_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.StateChanged']/field[@name='oldState']"
			[Register ("oldState")]
			public global::Com.Kaltura.Playkit.PlayerState OldState {
				get {
					if (oldState_jfieldId == IntPtr.Zero)
						oldState_jfieldId = JNIEnv.GetFieldID (class_ref, "oldState", "Lcom/kaltura/playkit/PlayerState;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, oldState_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (oldState_jfieldId == IntPtr.Zero)
						oldState_jfieldId = JNIEnv.GetFieldID (class_ref, "oldState", "Lcom/kaltura/playkit/PlayerState;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, oldState_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$StateChanged", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (StateChanged); }
			}

			protected StateChanged (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_PlayerState_Lcom_kaltura_playkit_PlayerState_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.StateChanged']/constructor[@name='PlayerEvent.StateChanged' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.PlayerState'] and parameter[2][@type='com.kaltura.playkit.PlayerState']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/PlayerState;Lcom/kaltura/playkit/PlayerState;)V", "")]
			public unsafe StateChanged (global::Com.Kaltura.Playkit.PlayerState p0, global::Com.Kaltura.Playkit.PlayerState p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (StateChanged)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PlayerState;Lcom/kaltura/playkit/PlayerState;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PlayerState;Lcom/kaltura/playkit/PlayerState;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_PlayerState_Lcom_kaltura_playkit_PlayerState_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_PlayerState_Lcom_kaltura_playkit_PlayerState_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PlayerState;Lcom/kaltura/playkit/PlayerState;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PlayerState_Lcom_kaltura_playkit_PlayerState_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PlayerState_Lcom_kaltura_playkit_PlayerState_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.TextTrackChanged']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$TextTrackChanged", DoNotGenerateAcw=true)]
		public partial class TextTrackChanged : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr newTrack_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.TextTrackChanged']/field[@name='newTrack']"
			[Register ("newTrack")]
			public global::Com.Kaltura.Playkit.Player.TextTrack NewTrack {
				get {
					if (newTrack_jfieldId == IntPtr.Zero)
						newTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "newTrack", "Lcom/kaltura/playkit/player/TextTrack;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, newTrack_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.TextTrack> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (newTrack_jfieldId == IntPtr.Zero)
						newTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "newTrack", "Lcom/kaltura/playkit/player/TextTrack;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newTrack_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$TextTrackChanged", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TextTrackChanged); }
			}

			protected TextTrackChanged (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_player_TextTrack_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.TextTrackChanged']/constructor[@name='PlayerEvent.TextTrackChanged' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.player.TextTrack']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/player/TextTrack;)V", "")]
			public unsafe TextTrackChanged (global::Com.Kaltura.Playkit.Player.TextTrack p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (TextTrackChanged)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/player/TextTrack;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/player/TextTrack;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_player_TextTrack_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_player_TextTrack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/player/TextTrack;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_player_TextTrack_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_player_TextTrack_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.TracksAvailable']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$TracksAvailable", DoNotGenerateAcw=true)]
		public partial class TracksAvailable : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr tracksInfo_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.TracksAvailable']/field[@name='tracksInfo']"
			[Register ("tracksInfo")]
			public global::Com.Kaltura.Playkit.Player.PKTracks TracksInfo {
				get {
					if (tracksInfo_jfieldId == IntPtr.Zero)
						tracksInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "tracksInfo", "Lcom/kaltura/playkit/player/PKTracks;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, tracksInfo_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.PKTracks> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (tracksInfo_jfieldId == IntPtr.Zero)
						tracksInfo_jfieldId = JNIEnv.GetFieldID (class_ref, "tracksInfo", "Lcom/kaltura/playkit/player/PKTracks;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tracksInfo_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$TracksAvailable", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TracksAvailable); }
			}

			protected TracksAvailable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_player_PKTracks_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.TracksAvailable']/constructor[@name='PlayerEvent.TracksAvailable' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.player.PKTracks']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/player/PKTracks;)V", "")]
			public unsafe TracksAvailable (global::Com.Kaltura.Playkit.Player.PKTracks p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (TracksAvailable)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/player/PKTracks;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/player/PKTracks;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_player_PKTracks_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_player_PKTracks_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/player/PKTracks;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_player_PKTracks_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_player_PKTracks_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr AUDIO_TRACK_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='AUDIO_TRACK_CHANGED']"
			[Register ("AUDIO_TRACK_CHANGED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type AudioTrackChanged {
				get {
					if (AUDIO_TRACK_CHANGED_jfieldId == IntPtr.Zero)
						AUDIO_TRACK_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUDIO_TRACK_CHANGED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUDIO_TRACK_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CAN_PLAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='CAN_PLAY']"
			[Register ("CAN_PLAY")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type CanPlay {
				get {
					if (CAN_PLAY_jfieldId == IntPtr.Zero)
						CAN_PLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAN_PLAY", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAN_PLAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DURATION_CHANGE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='DURATION_CHANGE']"
			[Register ("DURATION_CHANGE")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type DurationChange {
				get {
					if (DURATION_CHANGE_jfieldId == IntPtr.Zero)
						DURATION_CHANGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DURATION_CHANGE", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DURATION_CHANGE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ENDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='ENDED']"
			[Register ("ENDED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Ended {
				get {
					if (ENDED_jfieldId == IntPtr.Zero)
						ENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENDED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ERROR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='ERROR']"
			[Register ("ERROR")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Error {
				get {
					if (ERROR_jfieldId == IntPtr.Zero)
						ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ERROR", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ERROR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOADED_METADATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='LOADED_METADATA']"
			[Register ("LOADED_METADATA")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type LoadedMetadata {
				get {
					if (LOADED_METADATA_jfieldId == IntPtr.Zero)
						LOADED_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED_METADATA", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_METADATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr METADATA_AVAILABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='METADATA_AVAILABLE']"
			[Register ("METADATA_AVAILABLE")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type MetadataAvailable {
				get {
					if (METADATA_AVAILABLE_jfieldId == IntPtr.Zero)
						METADATA_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "METADATA_AVAILABLE", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, METADATA_AVAILABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PAUSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='PAUSE']"
			[Register ("PAUSE")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Pause {
				get {
					if (PAUSE_jfieldId == IntPtr.Zero)
						PAUSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSE", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='PLAY']"
			[Register ("PLAY")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Play {
				get {
					if (PLAY_jfieldId == IntPtr.Zero)
						PLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAY", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYBACK_INFO_UPDATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='PLAYBACK_INFO_UPDATED']"
			[Register ("PLAYBACK_INFO_UPDATED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type PlaybackInfoUpdated {
				get {
					if (PLAYBACK_INFO_UPDATED_jfieldId == IntPtr.Zero)
						PLAYBACK_INFO_UPDATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYBACK_INFO_UPDATED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYBACK_INFO_UPDATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYHEAD_UPDATED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='PLAYHEAD_UPDATED']"
			[Register ("PLAYHEAD_UPDATED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type PlayheadUpdated {
				get {
					if (PLAYHEAD_UPDATED_jfieldId == IntPtr.Zero)
						PLAYHEAD_UPDATED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYHEAD_UPDATED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYHEAD_UPDATED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PLAYING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='PLAYING']"
			[Register ("PLAYING")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Playing {
				get {
					if (PLAYING_jfieldId == IntPtr.Zero)
						PLAYING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr REPLAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='REPLAY']"
			[Register ("REPLAY")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Replay {
				get {
					if (REPLAY_jfieldId == IntPtr.Zero)
						REPLAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPLAY", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPLAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SEEKED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='SEEKED']"
			[Register ("SEEKED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Seeked {
				get {
					if (SEEKED_jfieldId == IntPtr.Zero)
						SEEKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEEKED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEEKED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SEEKING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='SEEKING']"
			[Register ("SEEKING")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Seeking {
				get {
					if (SEEKING_jfieldId == IntPtr.Zero)
						SEEKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SEEKING", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SEEKING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SOURCE_SELECTED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='SOURCE_SELECTED']"
			[Register ("SOURCE_SELECTED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type SourceSelected {
				get {
					if (SOURCE_SELECTED_jfieldId == IntPtr.Zero)
						SOURCE_SELECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOURCE_SELECTED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOURCE_SELECTED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STATE_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='STATE_CHANGED']"
			[Register ("STATE_CHANGED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type StateChanged {
				get {
					if (STATE_CHANGED_jfieldId == IntPtr.Zero)
						STATE_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STATE_CHANGED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STATE_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STOPPED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type Stopped {
				get {
					if (STOPPED_jfieldId == IntPtr.Zero)
						STOPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STOPPED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STOPPED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TEXT_TRACK_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='TEXT_TRACK_CHANGED']"
			[Register ("TEXT_TRACK_CHANGED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type TextTrackChanged {
				get {
					if (TEXT_TRACK_CHANGED_jfieldId == IntPtr.Zero)
						TEXT_TRACK_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXT_TRACK_CHANGED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TEXT_TRACK_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TRACKS_AVAILABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='TRACKS_AVAILABLE']"
			[Register ("TRACKS_AVAILABLE")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type TracksAvailable {
				get {
					if (TRACKS_AVAILABLE_jfieldId == IntPtr.Zero)
						TRACKS_AVAILABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TRACKS_AVAILABLE", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TRACKS_AVAILABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VIDEO_TRACK_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='VIDEO_TRACK_CHANGED']"
			[Register ("VIDEO_TRACK_CHANGED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type VideoTrackChanged {
				get {
					if (VIDEO_TRACK_CHANGED_jfieldId == IntPtr.Zero)
						VIDEO_TRACK_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_TRACK_CHANGED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_TRACK_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr VOLUME_CHANGED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/field[@name='VOLUME_CHANGED']"
			[Register ("VOLUME_CHANGED")]
			public static global::Com.Kaltura.Playkit.PlayerEvent.Type VolumeChanged {
				get {
					if (VOLUME_CHANGED_jfieldId == IntPtr.Zero)
						VOLUME_CHANGED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VOLUME_CHANGED", "Lcom/kaltura/playkit/PlayerEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VOLUME_CHANGED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$Type", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Type); }
			}

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PlayerEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PlayerEvent.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/PlayerEvent$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.PlayerEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/PlayerEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.PlayerEvent.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/PlayerEvent$Type;");
				try {
					return (global::Com.Kaltura.Playkit.PlayerEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.PlayerEvent.Type));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.VideoTrackChanged']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$VideoTrackChanged", DoNotGenerateAcw=true)]
		public partial class VideoTrackChanged : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr newTrack_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.VideoTrackChanged']/field[@name='newTrack']"
			[Register ("newTrack")]
			public global::Com.Kaltura.Playkit.Player.VideoTrack NewTrack {
				get {
					if (newTrack_jfieldId == IntPtr.Zero)
						newTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "newTrack", "Lcom/kaltura/playkit/player/VideoTrack;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, newTrack_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Player.VideoTrack> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (newTrack_jfieldId == IntPtr.Zero)
						newTrack_jfieldId = JNIEnv.GetFieldID (class_ref, "newTrack", "Lcom/kaltura/playkit/player/VideoTrack;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, newTrack_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$VideoTrackChanged", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VideoTrackChanged); }
			}

			protected VideoTrackChanged (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_kaltura_playkit_player_VideoTrack_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.VideoTrackChanged']/constructor[@name='PlayerEvent.VideoTrackChanged' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.player.VideoTrack']]"
			[Register (".ctor", "(Lcom/kaltura/playkit/player/VideoTrack;)V", "")]
			public unsafe VideoTrackChanged (global::Com.Kaltura.Playkit.Player.VideoTrack p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (VideoTrackChanged)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/player/VideoTrack;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/player/VideoTrack;)V", __args);
						return;
					}

					if (id_ctor_Lcom_kaltura_playkit_player_VideoTrack_ == IntPtr.Zero)
						id_ctor_Lcom_kaltura_playkit_player_VideoTrack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/player/VideoTrack;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_player_VideoTrack_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_player_VideoTrack_, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.VolumeChanged']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/PlayerEvent$VolumeChanged", DoNotGenerateAcw=true)]
		public partial class VolumeChanged : global::Com.Kaltura.Playkit.PlayerEvent {


			static IntPtr volume_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.VolumeChanged']/field[@name='volume']"
			[Register ("volume")]
			public float Volume {
				get {
					if (volume_jfieldId == IntPtr.Zero)
						volume_jfieldId = JNIEnv.GetFieldID (class_ref, "volume", "F");
					return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, volume_jfieldId);
				}
				set {
					if (volume_jfieldId == IntPtr.Zero)
						volume_jfieldId = JNIEnv.GetFieldID (class_ref, "volume", "F");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, volume_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent$VolumeChanged", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VolumeChanged); }
			}

			protected VolumeChanged (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_F;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent.VolumeChanged']/constructor[@name='PlayerEvent.VolumeChanged' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register (".ctor", "(F)V", "")]
			public unsafe VolumeChanged (float p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (VolumeChanged)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F)V", __args);
						return;
					}

					if (id_ctor_F == IntPtr.Zero)
						id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_F, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/PlayerEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerEvent); }
		}

		protected PlayerEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent']/constructor[@name='PlayerEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PlayerEvent.Type']]"
		[Register (".ctor", "(Lcom/kaltura/playkit/PlayerEvent$Type;)V", "")]
		public unsafe PlayerEvent (global::Com.Kaltura.Playkit.PlayerEvent.Type p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PlayerEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/PlayerEvent$Type;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/PlayerEvent$Type;)V", __args);
					return;
				}

				if (id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_ == IntPtr.Zero)
					id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/PlayerEvent$Type;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_PlayerEvent_Type_, __args);
			} finally {
			}
		}

		static Delegate cb_eventType;
#pragma warning disable 0169
		static Delegate GetEventTypeHandler ()
		{
			if (cb_eventType == null)
				cb_eventType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EventType);
			return cb_eventType;
		}

		static IntPtr n_EventType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.PlayerEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.PlayerEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		static IntPtr id_eventType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='PlayerEvent']/method[@name='eventType' and count(parameter)=0]"
		[Register ("eventType", "()Ljava/lang/Enum;", "GetEventTypeHandler")]
		public virtual unsafe global::Java.Lang.Enum EventType ()
		{
			if (id_eventType == IntPtr.Zero)
				id_eventType = JNIEnv.GetMethodID (class_ref, "eventType", "()Ljava/lang/Enum;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventType), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "eventType", "()Ljava/lang/Enum;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='MessageBus']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/MessageBus", DoNotGenerateAcw=true)]
	public partial class MessageBus : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/MessageBus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageBus); }
		}

		protected MessageBus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='MessageBus']/constructor[@name='MessageBus' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageBus ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageBus)) {
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

		static Delegate cb_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetListen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler ()
		{
			if (cb_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == null)
				cb_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_);
			return cb_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		}

		static void n_Listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.MessageBus __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.MessageBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Enum[] p1 = (global::Java.Lang.Enum[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Enum));
			__this.Listen (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='MessageBus']/method[@name='listen' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener'] and parameter[2][@type='java.lang.Enum...']]"
		[Register ("listen", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V", "GetListen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler")]
		public virtual unsafe void Listen (global::Com.Kaltura.Playkit.IPKEventListener p0, params global:: Java.Lang.Enum[] p1)
		{
			if (id_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "listen", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_listen_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "listen", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_post_Lcom_kaltura_playkit_PKEvent_;
#pragma warning disable 0169
		static Delegate GetPost_Lcom_kaltura_playkit_PKEvent_Handler ()
		{
			if (cb_post_Lcom_kaltura_playkit_PKEvent_ == null)
				cb_post_Lcom_kaltura_playkit_PKEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Post_Lcom_kaltura_playkit_PKEvent_);
			return cb_post_Lcom_kaltura_playkit_PKEvent_;
		}

		static void n_Post_Lcom_kaltura_playkit_PKEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.MessageBus __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.MessageBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEvent p0 = (global::Com.Kaltura.Playkit.IPKEvent)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Post (p0);
		}
#pragma warning restore 0169

		static IntPtr id_post_Lcom_kaltura_playkit_PKEvent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='MessageBus']/method[@name='post' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKEvent']]"
		[Register ("post", "(Lcom/kaltura/playkit/PKEvent;)V", "GetPost_Lcom_kaltura_playkit_PKEvent_Handler")]
		public virtual unsafe void Post (global::Com.Kaltura.Playkit.IPKEvent p0)
		{
			if (id_post_Lcom_kaltura_playkit_PKEvent_ == IntPtr.Zero)
				id_post_Lcom_kaltura_playkit_PKEvent_ = JNIEnv.GetMethodID (class_ref, "post", "(Lcom/kaltura/playkit/PKEvent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_post_Lcom_kaltura_playkit_PKEvent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "post", "(Lcom/kaltura/playkit/PKEvent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler ()
		{
			if (cb_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == null)
				cb_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_);
			return cb_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		}

		static void n_Remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.MessageBus __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.MessageBus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEventListener p0 = (global::Com.Kaltura.Playkit.IPKEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Enum[] p1 = (global::Java.Lang.Enum[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Enum));
			__this.Remove (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/class[@name='MessageBus']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='com.kaltura.playkit.PKEvent.Listener'] and parameter[2][@type='java.lang.Enum...']]"
		[Register ("remove", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V", "GetRemove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_Handler")]
		public virtual unsafe void Remove (global::Com.Kaltura.Playkit.IPKEventListener p0, params global:: Java.Lang.Enum[] p1)
		{
			if (id_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ == IntPtr.Zero)
				id_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_kaltura_playkit_PKEvent_Listener_arrayLjava_lang_Enum_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Lcom/kaltura/playkit/PKEvent$Listener;[Ljava/lang/Enum;)V"), __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}

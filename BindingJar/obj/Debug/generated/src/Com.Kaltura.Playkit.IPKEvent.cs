using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKEvent.Listener']"
	[Register ("com/kaltura/playkit/PKEvent$Listener", "", "Com.Kaltura.Playkit.IPKEventListenerInvoker")]
	public partial interface IPKEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKEvent.Listener']/method[@name='onEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.PKEvent']]"
		[Register ("onEvent", "(Lcom/kaltura/playkit/PKEvent;)V", "GetOnEvent_Lcom_kaltura_playkit_PKEvent_Handler:Com.Kaltura.Playkit.IPKEventListenerInvoker, BindingJar")]
		void OnEvent (global::Com.Kaltura.Playkit.IPKEvent p0);

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/PKEvent$Listener", DoNotGenerateAcw=true)]
	internal class IPKEventListenerInvoker : global::Java.Lang.Object, IPKEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/PKEvent$Listener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPKEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static IPKEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPKEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.PKEvent.Listener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPKEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEvent_Lcom_kaltura_playkit_PKEvent_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Lcom_kaltura_playkit_PKEvent_Handler ()
		{
			if (cb_onEvent_Lcom_kaltura_playkit_PKEvent_ == null)
				cb_onEvent_Lcom_kaltura_playkit_PKEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEvent_Lcom_kaltura_playkit_PKEvent_);
			return cb_onEvent_Lcom_kaltura_playkit_PKEvent_;
		}

		static void n_OnEvent_Lcom_kaltura_playkit_PKEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.IPKEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.IPKEvent p0 = (global::Com.Kaltura.Playkit.IPKEvent)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Lcom_kaltura_playkit_PKEvent_;
		public unsafe void OnEvent (global::Com.Kaltura.Playkit.IPKEvent p0)
		{
			if (id_onEvent_Lcom_kaltura_playkit_PKEvent_ == IntPtr.Zero)
				id_onEvent_Lcom_kaltura_playkit_PKEvent_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Lcom/kaltura/playkit/PKEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Lcom_kaltura_playkit_PKEvent_, __args);
		}

	}

	public partial class PKEventEventArgs : global::System.EventArgs {

		public PKEventEventArgs (global::Com.Kaltura.Playkit.IPKEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Kaltura.Playkit.IPKEvent p0;
		public global::Com.Kaltura.Playkit.IPKEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/kaltura/playkit/PKEvent_ListenerImplementor")]
	internal sealed partial class IPKEventListenerImplementor : global::Java.Lang.Object, IPKEventListener {

		object sender;

		public IPKEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/PKEvent_ListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<PKEventEventArgs> Handler;
#pragma warning restore 0649

		public void OnEvent (global::Com.Kaltura.Playkit.IPKEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new PKEventEventArgs (p0));
		}

		internal static bool __IsEmpty (IPKEventListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKEvent']"
	[Register ("com/kaltura/playkit/PKEvent", "", "Com.Kaltura.Playkit.IPKEventInvoker")]
	public partial interface IPKEvent : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit']/interface[@name='PKEvent']/method[@name='eventType' and count(parameter)=0]"
		[Register ("eventType", "()Ljava/lang/Enum;", "GetEventTypeHandler:Com.Kaltura.Playkit.IPKEventInvoker, BindingJar")]
		global::Java.Lang.Enum EventType ();

	}

	[global::Android.Runtime.Register ("com/kaltura/playkit/PKEvent", DoNotGenerateAcw=true)]
	internal class IPKEventInvoker : global::Java.Lang.Object, IPKEvent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/PKEvent");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPKEventInvoker); }
		}

		IntPtr class_ref;

		public static IPKEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPKEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.PKEvent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPKEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Kaltura.Playkit.IPKEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.IPKEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		IntPtr id_eventType;
		public unsafe global::Java.Lang.Enum EventType ()
		{
			if (id_eventType == IntPtr.Zero)
				id_eventType = JNIEnv.GetMethodID (class_ref, "eventType", "()Ljava/lang/Enum;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_eventType), JniHandleOwnership.TransferLocalRef);
		}

	}

}

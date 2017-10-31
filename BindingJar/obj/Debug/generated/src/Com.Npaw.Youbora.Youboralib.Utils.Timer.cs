using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Timer']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/utils/Timer", DoNotGenerateAcw=true)]
	public partial class Timer : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/interface[@name='Timer.TimerEventListener']"
		[Register ("com/npaw/youbora/youboralib/utils/Timer$TimerEventListener", "", "Com.Npaw.Youbora.Youboralib.Utils.Timer/ITimerEventListenerInvoker")]
		public partial interface ITimerEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/interface[@name='Timer.TimerEventListener']/method[@name='onTimerEvent' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("onTimerEvent", "(J)V", "GetOnTimerEvent_JHandler:Com.Npaw.Youbora.Youboralib.Utils.Timer/ITimerEventListenerInvoker, BindingJar")]
			void OnTimerEvent (long p0);

		}

		[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/utils/Timer$TimerEventListener", DoNotGenerateAcw=true)]
		internal class ITimerEventListenerInvoker : global::Java.Lang.Object, ITimerEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/npaw/youbora/youboralib/utils/Timer$TimerEventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ITimerEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static ITimerEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ITimerEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.npaw.youbora.youboralib.utils.Timer.TimerEventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ITimerEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTimerEvent_J;
#pragma warning disable 0169
			static Delegate GetOnTimerEvent_JHandler ()
			{
				if (cb_onTimerEvent_J == null)
					cb_onTimerEvent_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnTimerEvent_J);
				return cb_onTimerEvent_J;
			}

			static void n_OnTimerEvent_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Npaw.Youbora.Youboralib.Utils.Timer.ITimerEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Timer.ITimerEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnTimerEvent (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTimerEvent_J;
			public unsafe void OnTimerEvent (long p0)
			{
				if (id_onTimerEvent_J == IntPtr.Zero)
					id_onTimerEvent_J = JNIEnv.GetMethodID (class_ref, "onTimerEvent", "(J)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTimerEvent_J, __args);
			}

		}

		public partial class TimerEventEventArgs : global::System.EventArgs {

			public TimerEventEventArgs (long p0)
			{
				this.p0 = p0;
			}

			long p0;
			public long P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/npaw/youbora/youboralib/utils/Timer_TimerEventListenerImplementor")]
		internal sealed partial class ITimerEventListenerImplementor : global::Java.Lang.Object, ITimerEventListener {

			object sender;

			public ITimerEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/npaw/youbora/youboralib/utils/Timer_TimerEventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<TimerEventEventArgs> Handler;
#pragma warning restore 0649

			public void OnTimerEvent (long p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new TimerEventEventArgs (p0));
			}

			internal static bool __IsEmpty (ITimerEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/utils/Timer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Timer); }
		}

		protected Timer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Timer']/constructor[@name='Timer' and count(parameter)=1 and parameter[1][@type='com.npaw.youbora.youboralib.utils.Timer.TimerEventListener']]"
		[Register (".ctor", "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;)V", "")]
		public unsafe Timer (global::Com.Npaw.Youbora.Youboralib.Utils.Timer.ITimerEventListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Timer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_ == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Timer']/constructor[@name='Timer' and count(parameter)=2 and parameter[1][@type='com.npaw.youbora.youboralib.utils.Timer.TimerEventListener'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;J)V", "")]
		public unsafe Timer (global::Com.Npaw.Youbora.Youboralib.Utils.Timer.ITimerEventListener p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (Timer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;J)V", __args);
					return;
				}

				if (id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_J == IntPtr.Zero)
					id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/npaw/youbora/youboralib/utils/Timer$TimerEventListener;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_npaw_youbora_youboralib_utils_Timer_TimerEventListener_J, __args);
			} finally {
			}
		}

		static Delegate cb_getChrono;
#pragma warning disable 0169
		static Delegate GetGetChronoHandler ()
		{
			if (cb_getChrono == null)
				cb_getChrono = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChrono);
			return cb_getChrono;
		}

		static IntPtr n_GetChrono (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Timer __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Timer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Chrono);
		}
#pragma warning restore 0169

		static IntPtr id_getChrono;
		public virtual unsafe global::Com.Npaw.Youbora.Youboralib.Utils.Chrono Chrono {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Timer']/method[@name='getChrono' and count(parameter)=0]"
			[Register ("getChrono", "()Lcom/npaw/youbora/youboralib/utils/Chrono;", "GetGetChronoHandler")]
			get {
				if (id_getChrono == IntPtr.Zero)
					id_getChrono = JNIEnv.GetMethodID (class_ref, "getChrono", "()Lcom/npaw/youbora/youboralib/utils/Chrono;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChrono), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChrono", "()Lcom/npaw/youbora/youboralib/utils/Chrono;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Timer __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Timer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Timer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Timer __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Timer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Timer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}

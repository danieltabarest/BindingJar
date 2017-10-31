using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Npaw.Youbora.Youboralib.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']"
	[global::Android.Runtime.Register ("com/npaw/youbora/youboralib/utils/Chrono", DoNotGenerateAcw=true)]
	public partial class Chrono : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/npaw/youbora/youboralib/utils/Chrono", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Chrono); }
		}

		protected Chrono (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/constructor[@name='Chrono' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Chrono ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Chrono)) {
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

		static Delegate cb_getDeltaTime;
#pragma warning disable 0169
		static Delegate GetGetDeltaTimeHandler ()
		{
			if (cb_getDeltaTime == null)
				cb_getDeltaTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDeltaTime);
			return cb_getDeltaTime;
		}

		static long n_GetDeltaTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeltaTime;
		}
#pragma warning restore 0169

		static IntPtr id_getDeltaTime;
		public virtual unsafe long DeltaTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='getDeltaTime' and count(parameter)=0]"
			[Register ("getDeltaTime", "()J", "GetGetDeltaTimeHandler")]
			get {
				if (id_getDeltaTime == IntPtr.Zero)
					id_getDeltaTime = JNIEnv.GetMethodID (class_ref, "getDeltaTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDeltaTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeltaTime", "()J"));
				} finally {
				}
			}
		}

		static IntPtr id_getNow;
		public static unsafe long Now {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='getNow' and count(parameter)=0]"
			[Register ("getNow", "()J", "GetGetNowHandler")]
			get {
				if (id_getNow == IntPtr.Zero)
					id_getNow = JNIEnv.GetStaticMethodID (class_ref, "getNow", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getNow);
				} finally {
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStartTime);
			return cb_getStartTime;
		}

		static IntPtr n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartTime);
		}
#pragma warning restore 0169

		static Delegate cb_setStartTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetStartTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setStartTime_Ljava_lang_Long_ == null)
				cb_setStartTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStartTime_Ljava_lang_Long_);
			return cb_setStartTime_Ljava_lang_Long_;
		}

		static void n_SetStartTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStartTime;
		static IntPtr id_setStartTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()Ljava/lang/Long;", "GetGetStartTimeHandler")]
			get {
				if (id_getStartTime == IntPtr.Zero)
					id_getStartTime = JNIEnv.GetMethodID (class_ref, "getStartTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStartTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStartTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='setStartTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setStartTime", "(Ljava/lang/Long;)V", "GetSetStartTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setStartTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setStartTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setStartTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStartTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStartTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStopTime;
#pragma warning disable 0169
		static Delegate GetGetStopTimeHandler ()
		{
			if (cb_getStopTime == null)
				cb_getStopTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStopTime);
			return cb_getStopTime;
		}

		static IntPtr n_GetStopTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StopTime);
		}
#pragma warning restore 0169

		static Delegate cb_setStopTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetStopTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setStopTime_Ljava_lang_Long_ == null)
				cb_setStopTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStopTime_Ljava_lang_Long_);
			return cb_setStopTime_Ljava_lang_Long_;
		}

		static void n_SetStopTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StopTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStopTime;
		static IntPtr id_setStopTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long StopTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='getStopTime' and count(parameter)=0]"
			[Register ("getStopTime", "()Ljava/lang/Long;", "GetGetStopTimeHandler")]
			get {
				if (id_getStopTime == IntPtr.Zero)
					id_getStopTime = JNIEnv.GetMethodID (class_ref, "getStopTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStopTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStopTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='setStopTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setStopTime", "(Ljava/lang/Long;)V", "GetSetStopTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setStopTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setStopTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setStopTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStopTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStopTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeltaTime_Z;
#pragma warning disable 0169
		static Delegate GetGetDeltaTime_ZHandler ()
		{
			if (cb_getDeltaTime_Z == null)
				cb_getDeltaTime_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, long>) n_GetDeltaTime_Z);
			return cb_getDeltaTime_Z;
		}

		static long n_GetDeltaTime_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDeltaTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDeltaTime_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='getDeltaTime' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getDeltaTime", "(Z)J", "GetGetDeltaTime_ZHandler")]
		public virtual unsafe long GetDeltaTime (bool p0)
		{
			if (id_getDeltaTime_Z == IntPtr.Zero)
				id_getDeltaTime_Z = JNIEnv.GetMethodID (class_ref, "getDeltaTime", "(Z)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDeltaTime_Z, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeltaTime", "(Z)J"), __args);
			} finally {
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
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='start' and count(parameter)=0]"
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
				cb_stop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Stop);
			return cb_stop;
		}

		static long n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Npaw.Youbora.Youboralib.Utils.Chrono __this = global::Java.Lang.Object.GetObject<global::Com.Npaw.Youbora.Youboralib.Utils.Chrono> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.npaw.youbora.youboralib.utils']/class[@name='Chrono']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()J", "GetStopHandler")]
		public virtual unsafe long Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()J"));
			} finally {
			}
		}

	}
}

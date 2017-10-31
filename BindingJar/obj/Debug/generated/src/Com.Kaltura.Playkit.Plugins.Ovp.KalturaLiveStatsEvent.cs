using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ovp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent", DoNotGenerateAcw=true)]
	public partial class KalturaLiveStatsEvent : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPKEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.KalturaLiveStatsReport']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$KalturaLiveStatsReport", DoNotGenerateAcw=true)]
		public partial class KalturaLiveStatsReport : global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent {


			static IntPtr bufferTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.KalturaLiveStatsReport']/field[@name='bufferTime']"
			[Register ("bufferTime")]
			public long BufferTime {
				get {
					if (bufferTime_jfieldId == IntPtr.Zero)
						bufferTime_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferTime", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, bufferTime_jfieldId);
				}
				set {
					if (bufferTime_jfieldId == IntPtr.Zero)
						bufferTime_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferTime", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bufferTime_jfieldId, value);
					} finally {
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$KalturaLiveStatsReport", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KalturaLiveStatsReport); }
			}

			protected KalturaLiveStatsReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_J;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.KalturaLiveStatsReport']/constructor[@name='KalturaLiveStatsEvent.KalturaLiveStatsReport' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register (".ctor", "(J)V", "")]
			public unsafe KalturaLiveStatsReport (long p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (KalturaLiveStatsReport)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.Type']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr REPORT_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.Type']/field[@name='REPORT_SENT']"
			[Register ("REPORT_SENT")]
			public static global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type ReportSent {
				get {
					if (REPORT_SENT_jfieldId == IntPtr.Zero)
						REPORT_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_SENT", "Lcom/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent$Type;");
				try {
					return (global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KalturaLiveStatsEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KalturaLiveStatsEvent); }
		}

		protected KalturaLiveStatsEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent']/constructor[@name='KalturaLiveStatsEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KalturaLiveStatsEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KalturaLiveStatsEvent)) {
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
			global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KalturaLiveStatsEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		static IntPtr id_eventType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KalturaLiveStatsEvent']/method[@name='eventType' and count(parameter)=0]"
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

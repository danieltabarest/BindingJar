using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ovp {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent", DoNotGenerateAcw=true)]
	public partial class KavaAnalyticsEvent : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPKEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.KavaAnalyticsReport']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$KavaAnalyticsReport", DoNotGenerateAcw=true)]
		public partial class KavaAnalyticsReport : global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent {


			static IntPtr reportedEventName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.KavaAnalyticsReport']/field[@name='reportedEventName']"
			[Register ("reportedEventName")]
			public string ReportedEventName {
				get {
					if (reportedEventName_jfieldId == IntPtr.Zero)
						reportedEventName_jfieldId = JNIEnv.GetFieldID (class_ref, "reportedEventName", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, reportedEventName_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (reportedEventName_jfieldId == IntPtr.Zero)
						reportedEventName_jfieldId = JNIEnv.GetFieldID (class_ref, "reportedEventName", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, reportedEventName_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$KavaAnalyticsReport", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (KavaAnalyticsReport); }
			}

			protected KavaAnalyticsReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.KavaAnalyticsReport']/constructor[@name='KavaAnalyticsEvent.KavaAnalyticsReport' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe KavaAnalyticsReport (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (KavaAnalyticsReport)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.Type']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr REPORT_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.Type']/field[@name='REPORT_SENT']"
			[Register ("REPORT_SENT")]
			public static global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type ReportSent {
				get {
					if (REPORT_SENT_jfieldId == IntPtr.Zero)
						REPORT_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_SENT", "Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent$Type;");
				try {
					return (global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ovp/KavaAnalyticsEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (KavaAnalyticsEvent); }
		}

		protected KavaAnalyticsEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent']/constructor[@name='KavaAnalyticsEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KavaAnalyticsEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (KavaAnalyticsEvent)) {
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
			global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ovp.KavaAnalyticsEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		static IntPtr id_eventType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ovp']/class[@name='KavaAnalyticsEvent']/method[@name='eventType' and count(parameter)=0]"
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

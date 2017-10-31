using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ott {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent", DoNotGenerateAcw=true)]
	public partial class PhoenixAnalyticsEvent : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPKEvent {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.PhoenixAnalyticsReport']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$PhoenixAnalyticsReport", DoNotGenerateAcw=true)]
		public partial class PhoenixAnalyticsReport : global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent {


			static IntPtr reportedEventName_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.PhoenixAnalyticsReport']/field[@name='reportedEventName']"
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
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$PhoenixAnalyticsReport", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PhoenixAnalyticsReport); }
			}

			protected PhoenixAnalyticsReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.PhoenixAnalyticsReport']/constructor[@name='PhoenixAnalyticsEvent.PhoenixAnalyticsReport' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe PhoenixAnalyticsReport (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (((object) this).GetType () != typeof (PhoenixAnalyticsReport)) {
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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.Type']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {


			static IntPtr REPORT_SENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.Type']/field[@name='REPORT_SENT']"
			[Register ("REPORT_SENT")]
			public static global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type ReportSent {
				get {
					if (REPORT_SENT_jfieldId == IntPtr.Zero)
						REPORT_SENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REPORT_SENT", "Lcom/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REPORT_SENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type", ref java_class_handle);
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent$Type;");
				try {
					return (global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent.Type));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ott/PhoenixAnalyticsEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhoenixAnalyticsEvent); }
		}

		protected PhoenixAnalyticsEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent']/constructor[@name='PhoenixAnalyticsEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PhoenixAnalyticsEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PhoenixAnalyticsEvent)) {
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
			global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.PhoenixAnalyticsEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		static IntPtr id_eventType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='PhoenixAnalyticsEvent']/method[@name='eventType' and count(parameter)=0]"
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

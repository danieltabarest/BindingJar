using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Plugins.Ott {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ott/OttEvent", DoNotGenerateAcw=true)]
	public partial class OttEvent : global::Java.Lang.Object, global::Com.Kaltura.Playkit.IPKEvent {


		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent']/field[@name='type']"
		[Register ("type")]
		public global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent.OttEventType']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/plugins/ott/OttEvent$OttEventType", DoNotGenerateAcw=true)]
		public sealed partial class OttEventType : global::Java.Lang.Enum {


			static IntPtr Concurrency_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent.OttEventType']/field[@name='Concurrency']"
			[Register ("Concurrency")]
			public static global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType Concurrency {
				get {
					if (Concurrency_jfieldId == IntPtr.Zero)
						Concurrency_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Concurrency", "Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Concurrency_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ott/OttEvent$OttEventType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OttEventType); }
			}

			internal OttEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent.OttEventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent.OttEventType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;", "")]
			public static unsafe global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;");
				try {
					return (global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/plugins/ott/OttEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OttEvent); }
		}

		protected OttEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_kaltura_playkit_plugins_ott_OttEvent_OttEventType_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent']/constructor[@name='OttEvent' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.plugins.ott.OttEvent.OttEventType']]"
		[Register (".ctor", "(Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;)V", "")]
		public unsafe OttEvent (global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent.OttEventType p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (OttEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;)V", __args);
					return;
				}

				if (id_ctor_Lcom_kaltura_playkit_plugins_ott_OttEvent_OttEventType_ == IntPtr.Zero)
					id_ctor_Lcom_kaltura_playkit_plugins_ott_OttEvent_OttEventType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/kaltura/playkit/plugins/ott/OttEvent$OttEventType;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ott_OttEvent_OttEventType_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_kaltura_playkit_plugins_ott_OttEvent_OttEventType_, __args);
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
			global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Plugins.Ott.OttEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventType ());
		}
#pragma warning restore 0169

		static IntPtr id_eventType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.plugins.ott']/class[@name='OttEvent']/method[@name='eventType' and count(parameter)=0]"
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

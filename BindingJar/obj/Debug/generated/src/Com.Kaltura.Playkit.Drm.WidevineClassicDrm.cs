using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Drm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/drm/WidevineClassicDrm", DoNotGenerateAcw=true)]
	public partial class WidevineClassicDrm : global::Java.Lang.Object {


		static IntPtr PORTAL_NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/field[@name='PORTAL_NAME']"
		[Register ("PORTAL_NAME")]
		public static string PortalName {
			get {
				if (PORTAL_NAME_jfieldId == IntPtr.Zero)
					PORTAL_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORTAL_NAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PORTAL_NAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PORTAL_NAME_jfieldId == IntPtr.Zero)
					PORTAL_NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PORTAL_NAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PORTAL_NAME_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WIDEVINE_MIME_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/field[@name='WIDEVINE_MIME_TYPE']"
		[Register ("WIDEVINE_MIME_TYPE")]
		public static string WidevineMimeType {
			get {
				if (WIDEVINE_MIME_TYPE_jfieldId == IntPtr.Zero)
					WIDEVINE_MIME_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIDEVINE_MIME_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WIDEVINE_MIME_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WIDEVINE_MIME_TYPE_jfieldId == IntPtr.Zero)
					WIDEVINE_MIME_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WIDEVINE_MIME_TYPE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WIDEVINE_MIME_TYPE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.kaltura.playkit.drm']/interface[@name='WidevineClassicDrm.EventListener']"
		[Register ("com/kaltura/playkit/drm/WidevineClassicDrm$EventListener", "", "Com.Kaltura.Playkit.Drm.WidevineClassicDrm/IEventListenerInvoker")]
		public partial interface IEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/interface[@name='WidevineClassicDrm.EventListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='android.drm.DrmErrorEvent']]"
			[Register ("onError", "(Landroid/drm/DrmErrorEvent;)V", "GetOnError_Landroid_drm_DrmErrorEvent_Handler:Com.Kaltura.Playkit.Drm.WidevineClassicDrm/IEventListenerInvoker, BindingJar")]
			void OnError (global::Android.Drm.DrmErrorEvent p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/interface[@name='WidevineClassicDrm.EventListener']/method[@name='onEvent' and count(parameter)=1 and parameter[1][@type='android.drm.DrmEvent']]"
			[Register ("onEvent", "(Landroid/drm/DrmEvent;)V", "GetOnEvent_Landroid_drm_DrmEvent_Handler:Com.Kaltura.Playkit.Drm.WidevineClassicDrm/IEventListenerInvoker, BindingJar")]
			void OnEvent (global::Android.Drm.DrmEvent p0);

		}

		[global::Android.Runtime.Register ("com/kaltura/playkit/drm/WidevineClassicDrm$EventListener", DoNotGenerateAcw=true)]
		internal class IEventListenerInvoker : global::Java.Lang.Object, IEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/kaltura/playkit/drm/WidevineClassicDrm$EventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.kaltura.playkit.drm.WidevineClassicDrm.EventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onError_Landroid_drm_DrmErrorEvent_;
#pragma warning disable 0169
			static Delegate GetOnError_Landroid_drm_DrmErrorEvent_Handler ()
			{
				if (cb_onError_Landroid_drm_DrmErrorEvent_ == null)
					cb_onError_Landroid_drm_DrmErrorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Landroid_drm_DrmErrorEvent_);
				return cb_onError_Landroid_drm_DrmErrorEvent_;
			}

			static void n_OnError_Landroid_drm_DrmErrorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Drm.DrmErrorEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Drm.DrmErrorEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Landroid_drm_DrmErrorEvent_;
			public unsafe void OnError (global::Android.Drm.DrmErrorEvent p0)
			{
				if (id_onError_Landroid_drm_DrmErrorEvent_ == IntPtr.Zero)
					id_onError_Landroid_drm_DrmErrorEvent_ = JNIEnv.GetMethodID (class_ref, "onError", "(Landroid/drm/DrmErrorEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Landroid_drm_DrmErrorEvent_, __args);
			}

			static Delegate cb_onEvent_Landroid_drm_DrmEvent_;
#pragma warning disable 0169
			static Delegate GetOnEvent_Landroid_drm_DrmEvent_Handler ()
			{
				if (cb_onEvent_Landroid_drm_DrmEvent_ == null)
					cb_onEvent_Landroid_drm_DrmEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEvent_Landroid_drm_DrmEvent_);
				return cb_onEvent_Landroid_drm_DrmEvent_;
			}

			static void n_OnEvent_Landroid_drm_DrmEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Drm.DrmEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Drm.DrmEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnEvent (p0);
			}
#pragma warning restore 0169

			IntPtr id_onEvent_Landroid_drm_DrmEvent_;
			public unsafe void OnEvent (global::Android.Drm.DrmEvent p0)
			{
				if (id_onEvent_Landroid_drm_DrmEvent_ == IntPtr.Zero)
					id_onEvent_Landroid_drm_DrmEvent_ = JNIEnv.GetMethodID (class_ref, "onEvent", "(Landroid/drm/DrmEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEvent_Landroid_drm_DrmEvent_, __args);
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Android.Drm.DrmErrorEvent p0)
			{
				this.p0 = p0;
			}

			global::Android.Drm.DrmErrorEvent p0;
			public global::Android.Drm.DrmErrorEvent P0 {
				get { return p0; }
			}
		}

		public partial class EventEventArgs : global::System.EventArgs {

			public EventEventArgs (global::Android.Drm.DrmEvent p0)
			{
				this.p0 = p0;
			}

			global::Android.Drm.DrmEvent p0;
			public global::Android.Drm.DrmEvent P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/kaltura/playkit/drm/WidevineClassicDrm_EventListenerImplementor")]
		internal sealed partial class IEventListenerImplementor : global::Java.Lang.Object, IEventListener {

			object sender;

			public IEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/kaltura/playkit/drm/WidevineClassicDrm_EventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

			public void OnError (global::Android.Drm.DrmErrorEvent p0)
			{
				var __h = OnErrorHandler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<EventEventArgs> OnEventHandler;
#pragma warning restore 0649

			public void OnEvent (global::Android.Drm.DrmEvent p0)
			{
				var __h = OnEventHandler;
				if (__h != null)
					__h (sender, new EventEventArgs (p0));
			}

			internal static bool __IsEmpty (IEventListenerImplementor value)
			{
				return value.OnErrorHandler == null && value.OnEventHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo']"
		[global::Android.Runtime.Register ("com/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo", DoNotGenerateAcw=true)]
		public partial class RightsInfo : global::Java.Lang.Object {


			static IntPtr availableTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo']/field[@name='availableTime']"
			[Register ("availableTime")]
			public int AvailableTime {
				get {
					if (availableTime_jfieldId == IntPtr.Zero)
						availableTime_jfieldId = JNIEnv.GetFieldID (class_ref, "availableTime", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, availableTime_jfieldId);
				}
				set {
					if (availableTime_jfieldId == IntPtr.Zero)
						availableTime_jfieldId = JNIEnv.GetFieldID (class_ref, "availableTime", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, availableTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr expiryTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo']/field[@name='expiryTime']"
			[Register ("expiryTime")]
			public int ExpiryTime {
				get {
					if (expiryTime_jfieldId == IntPtr.Zero)
						expiryTime_jfieldId = JNIEnv.GetFieldID (class_ref, "expiryTime", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, expiryTime_jfieldId);
				}
				set {
					if (expiryTime_jfieldId == IntPtr.Zero)
						expiryTime_jfieldId = JNIEnv.GetFieldID (class_ref, "expiryTime", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, expiryTime_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr rawConstraints_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo']/field[@name='rawConstraints']"
			[Register ("rawConstraints")]
			public global::Android.Content.ContentValues RawConstraints {
				get {
					if (rawConstraints_jfieldId == IntPtr.Zero)
						rawConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "rawConstraints", "Landroid/content/ContentValues;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, rawConstraints_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (rawConstraints_jfieldId == IntPtr.Zero)
						rawConstraints_jfieldId = JNIEnv.GetFieldID (class_ref, "rawConstraints", "Landroid/content/ContentValues;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, rawConstraints_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr startTime_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo']/field[@name='startTime']"
			[Register ("startTime")]
			public int StartTime {
				get {
					if (startTime_jfieldId == IntPtr.Zero)
						startTime_jfieldId = JNIEnv.GetFieldID (class_ref, "startTime", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, startTime_jfieldId);
				}
				set {
					if (startTime_jfieldId == IntPtr.Zero)
						startTime_jfieldId = JNIEnv.GetFieldID (class_ref, "startTime", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTime_jfieldId, value);
					} finally {
					}
				}
			}
			// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']"
			[global::Android.Runtime.Register ("com/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status", DoNotGenerateAcw=true)]
			public sealed partial class Status : global::Java.Lang.Enum {


				static IntPtr EXPIRED_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']/field[@name='EXPIRED']"
				[Register ("EXPIRED")]
				public static global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status Expired {
					get {
						if (EXPIRED_jfieldId == IntPtr.Zero)
							EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRED", "Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRED_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr INVALID_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']/field[@name='INVALID']"
				[Register ("INVALID")]
				public static global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status Invalid {
					get {
						if (INVALID_jfieldId == IntPtr.Zero)
							INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INVALID", "Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INVALID_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr NOT_ACQUIRED_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']/field[@name='NOT_ACQUIRED']"
				[Register ("NOT_ACQUIRED")]
				public static global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status NotAcquired {
					get {
						if (NOT_ACQUIRED_jfieldId == IntPtr.Zero)
							NOT_ACQUIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_ACQUIRED", "Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_ACQUIRED_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}

				static IntPtr VALID_jfieldId;

				// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']/field[@name='VALID']"
				[Register ("VALID")]
				public static global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status Valid {
					get {
						if (VALID_jfieldId == IntPtr.Zero)
							VALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VALID", "Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;");
						IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VALID_jfieldId);
						return global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status> (__ret, JniHandleOwnership.TransferLocalRef);
					}
				}
				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (Status); }
				}

				internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static IntPtr id_valueOf_Ljava_lang_String_;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;", "")]
				public static unsafe global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status ValueOf (string p0)
				{
					if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
						id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;");
					IntPtr native_p0 = JNIEnv.NewString (p0);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_p0);
						global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status __ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
						return __ret;
					} finally {
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}

				static IntPtr id_values;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm.RightsInfo.Status']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;", "")]
				public static unsafe global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status[] Values ()
				{
					if (id_values == IntPtr.Zero)
						id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo$Status;");
					try {
						return (global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo.Status));
					} finally {
					}
				}

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RightsInfo); }
			}

			protected RightsInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/drm/WidevineClassicDrm", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WidevineClassicDrm); }
		}

		protected WidevineClassicDrm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/constructor[@name='WidevineClassicDrm' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WidevineClassicDrm (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (WidevineClassicDrm)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_AcquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_);
			return cb_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_AcquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AcquireLocalAssetRights (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='acquireLocalAssetRights' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("acquireLocalAssetRights", "(Ljava/lang/String;Ljava/lang/String;)I", "GetAcquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int AcquireLocalAssetRights (string p0, string p1)
		{
			if (id_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acquireLocalAssetRights", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_acquireLocalAssetRights_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acquireLocalAssetRights", "(Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_acquireRights_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcquireRights_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_acquireRights_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_acquireRights_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_AcquireRights_Ljava_lang_String_Ljava_lang_String_);
			return cb_acquireRights_Ljava_lang_String_Ljava_lang_String_;
		}

		static int n_AcquireRights_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.AcquireRights (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_acquireRights_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='acquireRights' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("acquireRights", "(Ljava/lang/String;Ljava/lang/String;)I", "GetAcquireRights_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int AcquireRights (string p0, string p1)
		{
			if (id_acquireRights_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_acquireRights_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acquireRights", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_acquireRights_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acquireRights", "(Ljava/lang/String;Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getRightsInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRightsInfo_Ljava_lang_String_Handler ()
		{
			if (cb_getRightsInfo_Ljava_lang_String_ == null)
				cb_getRightsInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRightsInfo_Ljava_lang_String_);
			return cb_getRightsInfo_Ljava_lang_String_;
		}

		static IntPtr n_GetRightsInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRightsInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRightsInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='getRightsInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRightsInfo", "(Ljava/lang/String;)Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo;", "GetGetRightsInfo_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo GetRightsInfo (string p0)
		{
			if (id_getRightsInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_getRightsInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRightsInfo", "(Ljava/lang/String;)Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRightsInfo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.RightsInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRightsInfo", "(Ljava/lang/String;)Lcom/kaltura/playkit/drm/WidevineClassicDrm$RightsInfo;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_needToAcquireRights_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNeedToAcquireRights_Ljava_lang_String_Handler ()
		{
			if (cb_needToAcquireRights_Ljava_lang_String_ == null)
				cb_needToAcquireRights_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NeedToAcquireRights_Ljava_lang_String_);
			return cb_needToAcquireRights_Ljava_lang_String_;
		}

		static bool n_NeedToAcquireRights_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NeedToAcquireRights (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_needToAcquireRights_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='needToAcquireRights' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("needToAcquireRights", "(Ljava/lang/String;)Z", "GetNeedToAcquireRights_Ljava_lang_String_Handler")]
		public virtual unsafe bool NeedToAcquireRights (string p0)
		{
			if (id_needToAcquireRights_Ljava_lang_String_ == IntPtr.Zero)
				id_needToAcquireRights_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "needToAcquireRights", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needToAcquireRights_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "needToAcquireRights", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerPortal;
#pragma warning disable 0169
		static Delegate GetRegisterPortalHandler ()
		{
			if (cb_registerPortal == null)
				cb_registerPortal = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterPortal);
			return cb_registerPortal;
		}

		static void n_RegisterPortal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterPortal ();
		}
#pragma warning restore 0169

		static IntPtr id_registerPortal;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='registerPortal' and count(parameter)=0]"
		[Register ("registerPortal", "()V", "GetRegisterPortalHandler")]
		public virtual unsafe void RegisterPortal ()
		{
			if (id_registerPortal == IntPtr.Zero)
				id_registerPortal = JNIEnv.GetMethodID (class_ref, "registerPortal", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerPortal);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerPortal", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllRights;
#pragma warning disable 0169
		static Delegate GetRemoveAllRightsHandler ()
		{
			if (cb_removeAllRights == null)
				cb_removeAllRights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RemoveAllRights);
			return cb_removeAllRights;
		}

		static int n_RemoveAllRights (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveAllRights ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllRights;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='removeAllRights' and count(parameter)=0]"
		[Register ("removeAllRights", "()I", "GetRemoveAllRightsHandler")]
		public virtual unsafe int RemoveAllRights ()
		{
			if (id_removeAllRights == IntPtr.Zero)
				id_removeAllRights = JNIEnv.GetMethodID (class_ref, "removeAllRights", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_removeAllRights);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllRights", "()I"));
			} finally {
			}
		}

		static Delegate cb_removeRights_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveRights_Ljava_lang_String_Handler ()
		{
			if (cb_removeRights_Ljava_lang_String_ == null)
				cb_removeRights_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_RemoveRights_Ljava_lang_String_);
			return cb_removeRights_Ljava_lang_String_;
		}

		static int n_RemoveRights_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RemoveRights (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeRights_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='removeRights' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeRights", "(Ljava/lang/String;)I", "GetRemoveRights_Ljava_lang_String_Handler")]
		public virtual unsafe int RemoveRights (string p0)
		{
			if (id_removeRights_Ljava_lang_String_ == IntPtr.Zero)
				id_removeRights_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeRights", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_removeRights_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeRights", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_;
#pragma warning disable 0169
		static Delegate GetSetEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_Handler ()
		{
			if (cb_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_ == null)
				cb_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_);
			return cb_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_;
		}

		static void n_SetEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm __this = global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener p0 = (global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener)global::Java.Lang.Object.GetObject<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEventListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.kaltura.playkit.drm']/class[@name='WidevineClassicDrm']/method[@name='setEventListener' and count(parameter)=1 and parameter[1][@type='com.kaltura.playkit.drm.WidevineClassicDrm.EventListener']]"
		[Register ("setEventListener", "(Lcom/kaltura/playkit/drm/WidevineClassicDrm$EventListener;)V", "GetSetEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_Handler")]
		public virtual unsafe void SetEventListener (global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener p0)
		{
			if (id_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_ == IntPtr.Zero)
				id_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_ = JNIEnv.GetMethodID (class_ref, "setEventListener", "(Lcom/kaltura/playkit/drm/WidevineClassicDrm$EventListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventListener_Lcom_kaltura_playkit_drm_WidevineClassicDrm_EventListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventListener", "(Lcom/kaltura/playkit/drm/WidevineClassicDrm$EventListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener"
		public event EventHandler<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.ErrorEventArgs> Error {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener, global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor>(
						ref weak_implementor_SetEventListener,
						__CreateIEventListenerImplementor,
						SetEventListener,
						__h => __h.OnErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener, global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor>(
						ref weak_implementor_SetEventListener,
						global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor.__IsEmpty,
						__v => SetEventListener (null),
						__h => __h.OnErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.EventEventArgs> Event {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener, global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor>(
						ref weak_implementor_SetEventListener,
						__CreateIEventListenerImplementor,
						SetEventListener,
						__h => __h.OnEventHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListener, global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor>(
						ref weak_implementor_SetEventListener,
						global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor.__IsEmpty,
						__v => SetEventListener (null),
						__h => __h.OnEventHandler -= value);
			}
		}

		WeakReference weak_implementor_SetEventListener;

		global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor __CreateIEventListenerImplementor ()
		{
			return new global::Com.Kaltura.Playkit.Drm.WidevineClassicDrm.IEventListenerImplementor (this);
		}
#endregion
	}
}

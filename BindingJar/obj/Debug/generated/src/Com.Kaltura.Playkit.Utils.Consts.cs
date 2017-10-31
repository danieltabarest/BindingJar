using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/utils/Consts", DoNotGenerateAcw=true)]
	public partial class Consts : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='DEFAULT_ANALYTICS_TIMER_INTERVAL_HIGH']"
		[Register ("DEFAULT_ANALYTICS_TIMER_INTERVAL_HIGH")]
		public const int DefaultAnalyticsTimerIntervalHigh = (int) 30000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='DEFAULT_ANALYTICS_TIMER_INTERVAL_HIGH_SEC']"
		[Register ("DEFAULT_ANALYTICS_TIMER_INTERVAL_HIGH_SEC")]
		public const int DefaultAnalyticsTimerIntervalHighSec = (int) 30;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='DEFAULT_ANALYTICS_TIMER_INTERVAL_LOW']"
		[Register ("DEFAULT_ANALYTICS_TIMER_INTERVAL_LOW")]
		public const int DefaultAnalyticsTimerIntervalLow = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='DEFAULT_ANALYTICS_TIMER_INTERVAL_LOW_SEC']"
		[Register ("DEFAULT_ANALYTICS_TIMER_INTERVAL_LOW_SEC")]
		public const int DefaultAnalyticsTimerIntervalLowSec = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='DEFAULT_PLAYHEAD_UPDATE_MILI']"
		[Register ("DEFAULT_PLAYHEAD_UPDATE_MILI")]
		public const int DefaultPlayheadUpdateMili = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='DEFAULT_TRACK_SELECTION_FLAG']"
		[Register ("DEFAULT_TRACK_SELECTION_FLAG")]
		public const int DefaultTrackSelectionFlag = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='KALTURA']"
		[Register ("KALTURA")]
		public const string Kaltura = (string) "Kaltura";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='MILLISECONDS_MULTIPLIER']"
		[Register ("MILLISECONDS_MULTIPLIER")]
		public const long MillisecondsMultiplier = (long) 1000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='NO_VALUE']"
		[Register ("NO_VALUE")]
		public const long NoValue = (long) -1L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='PERCENT_FACTOR']"
		[Register ("PERCENT_FACTOR")]
		public const double PercentFactor = (double) 100.000000000000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='POSITION_UNSET']"
		[Register ("POSITION_UNSET")]
		public const int PositionUnset = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='TIME_UNSET']"
		[Register ("TIME_UNSET")]
		public const long TimeUnset = (long) -9223372036854775807L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='TRACK_TYPE_AUDIO']"
		[Register ("TRACK_TYPE_AUDIO")]
		public const int TrackTypeAudio = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='TRACK_TYPE_TEXT']"
		[Register ("TRACK_TYPE_TEXT")]
		public const int TrackTypeText = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='TRACK_TYPE_UNKNOWN']"
		[Register ("TRACK_TYPE_UNKNOWN")]
		public const int TrackTypeUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='TRACK_TYPE_VIDEO']"
		[Register ("TRACK_TYPE_VIDEO")]
		public const int TrackTypeVideo = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/field[@name='VOLUME_UNKNOWN']"
		[Register ("VOLUME_UNKNOWN")]
		public const float VolumeUnknown = (float) -1.000000;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/utils/Consts", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Consts); }
		}

		protected Consts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.utils']/class[@name='Consts']/constructor[@name='Consts' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Consts ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Consts)) {
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

	}
}

using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player.Metadata {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/metadata/PKChapterFrame", DoNotGenerateAcw=true)]
	public partial class PKChapterFrame : global::Java.Lang.Object, global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata {


		static IntPtr chapterId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='chapterId']"
		[Register ("chapterId")]
		public string ChapterId {
			get {
				if (chapterId_jfieldId == IntPtr.Zero)
					chapterId_jfieldId = JNIEnv.GetFieldID (class_ref, "chapterId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, chapterId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (chapterId_jfieldId == IntPtr.Zero)
					chapterId_jfieldId = JNIEnv.GetFieldID (class_ref, "chapterId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, chapterId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr endOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='endOffset']"
		[Register ("endOffset")]
		public long EndOffset {
			get {
				if (endOffset_jfieldId == IntPtr.Zero)
					endOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "endOffset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, endOffset_jfieldId);
			}
			set {
				if (endOffset_jfieldId == IntPtr.Zero)
					endOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "endOffset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr endTimeMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='endTimeMs']"
		[Register ("endTimeMs")]
		public int EndTimeMs {
			get {
				if (endTimeMs_jfieldId == IntPtr.Zero)
					endTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "endTimeMs", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, endTimeMs_jfieldId);
			}
			set {
				if (endTimeMs_jfieldId == IntPtr.Zero)
					endTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "endTimeMs", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endTimeMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr startOffset_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='startOffset']"
		[Register ("startOffset")]
		public long StartOffset {
			get {
				if (startOffset_jfieldId == IntPtr.Zero)
					startOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "startOffset", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, startOffset_jfieldId);
			}
			set {
				if (startOffset_jfieldId == IntPtr.Zero)
					startOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "startOffset", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startOffset_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr startTimeMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='startTimeMs']"
		[Register ("startTimeMs")]
		public int StartTimeMs {
			get {
				if (startTimeMs_jfieldId == IntPtr.Zero)
					startTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTimeMs", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, startTimeMs_jfieldId);
			}
			set {
				if (startTimeMs_jfieldId == IntPtr.Zero)
					startTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTimeMs", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTimeMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr subFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/field[@name='subFrames']"
		[Register ("subFrames")]
		public global::System.Collections.IList SubFrames {
			get {
				if (subFrames_jfieldId == IntPtr.Zero)
					subFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "subFrames", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, subFrames_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (subFrames_jfieldId == IntPtr.Zero)
					subFrames_jfieldId = JNIEnv.GetFieldID (class_ref, "subFrames", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, subFrames_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/kaltura/playkit/player/metadata/PKChapterFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKChapterFrame); }
		}

		protected PKChapterFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IIJJLjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterFrame']/constructor[@name='PKChapterFrame' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='long'] and parameter[6][@type='long'] and parameter[7][@type='java.util.List&lt;com.kaltura.playkit.player.metadata.PKMetadata&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;IIJJLjava/util/List;)V", "")]
		public unsafe PKChapterFrame (string p0, string p1, int p2, int p3, long p4, long p5, global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata> p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p6 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata>.ToLocalJniHandle (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (native_p6);
				if (((object) this).GetType () != typeof (PKChapterFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;IIJJLjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;IIJJLjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_IIJJLjava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_IIJJLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIJJLjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIJJLjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIJJLjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

	}
}

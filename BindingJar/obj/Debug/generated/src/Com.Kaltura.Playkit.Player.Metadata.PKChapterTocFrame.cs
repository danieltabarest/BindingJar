using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Kaltura.Playkit.Player.Metadata {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']"
	[global::Android.Runtime.Register ("com/kaltura/playkit/player/metadata/PKChapterTocFrame", DoNotGenerateAcw=true)]
	public partial class PKChapterTocFrame : global::Java.Lang.Object, global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata {


		static IntPtr children_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/field[@name='children']"
		[Register ("children")]
		public global::System.Collections.IList Children {
			get {
				if (children_jfieldId == IntPtr.Zero)
					children_jfieldId = JNIEnv.GetFieldID (class_ref, "children", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, children_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (children_jfieldId == IntPtr.Zero)
					children_jfieldId = JNIEnv.GetFieldID (class_ref, "children", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, children_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr elementId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/field[@name='elementId']"
		[Register ("elementId")]
		public string ElementId {
			get {
				if (elementId_jfieldId == IntPtr.Zero)
					elementId_jfieldId = JNIEnv.GetFieldID (class_ref, "elementId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, elementId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (elementId_jfieldId == IntPtr.Zero)
					elementId_jfieldId = JNIEnv.GetFieldID (class_ref, "elementId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, elementId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/field[@name='id']"
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

		static IntPtr isOrdered_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/field[@name='isOrdered']"
		[Register ("isOrdered")]
		public bool IsOrdered {
			get {
				if (isOrdered_jfieldId == IntPtr.Zero)
					isOrdered_jfieldId = JNIEnv.GetFieldID (class_ref, "isOrdered", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isOrdered_jfieldId);
			}
			set {
				if (isOrdered_jfieldId == IntPtr.Zero)
					isOrdered_jfieldId = JNIEnv.GetFieldID (class_ref, "isOrdered", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isOrdered_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isRoot_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/field[@name='isRoot']"
		[Register ("isRoot")]
		public bool IsRoot {
			get {
				if (isRoot_jfieldId == IntPtr.Zero)
					isRoot_jfieldId = JNIEnv.GetFieldID (class_ref, "isRoot", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isRoot_jfieldId);
			}
			set {
				if (isRoot_jfieldId == IntPtr.Zero)
					isRoot_jfieldId = JNIEnv.GetFieldID (class_ref, "isRoot", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isRoot_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr subFrames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/field[@name='subFrames']"
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
				return JNIEnv.FindClass ("com/kaltura/playkit/player/metadata/PKChapterTocFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PKChapterTocFrame); }
		}

		protected PKChapterTocFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_ZZLjava_util_List_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.kaltura.playkit.player.metadata']/class[@name='PKChapterTocFrame']/constructor[@name='PKChapterTocFrame' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[6][@type='java.util.List&lt;com.kaltura.playkit.player.metadata.PKMetadata&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;ZZLjava/util/List;Ljava/util/List;)V", "")]
		public unsafe PKChapterTocFrame (string p0, string p1, bool p2, bool p3, global::System.Collections.Generic.IList<string> p4, global::System.Collections.Generic.IList<global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata> p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p4);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Com.Kaltura.Playkit.Player.Metadata.IPKMetadata>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (PKChapterTocFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;ZZLjava/util/List;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;ZZLjava/util/List;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ZZLjava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ZZLjava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZLjava/util/List;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZZLjava_util_List_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_ZZLjava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

	}
}

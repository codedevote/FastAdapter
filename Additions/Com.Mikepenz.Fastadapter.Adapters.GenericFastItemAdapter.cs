using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mikepenz.Fastadapter.Adapters {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']"
	[global::Android.Runtime.Register ("com/mikepenz/fastadapter/adapters/GenericFastItemAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"Model", "Item extends com.mikepenz.fastadapter.items.GenericAbstractItem<Model, Item, ?>"})]
	public partial class GenericFastItemAdapter : global::Com.Mikepenz.Fastadapter.FastAdapter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mikepenz/fastadapter/adapters/GenericFastItemAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GenericFastItemAdapter); }
		}

		protected GenericFastItemAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Class_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/constructor[@name='GenericFastItemAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;? extends Item&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends Model&gt;']]"
		[Register (".ctor", "(Ljava/lang/Class;Ljava/lang/Class;)V", "")]
		public unsafe GenericFastItemAdapter (global::Java.Lang.Class p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (GenericFastItemAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Class;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Class_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Class_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mikepenz_fastadapter_utils_Function_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/constructor[@name='GenericFastItemAdapter' and count(parameter)=1 and parameter[1][@type='com.mikepenz.fastadapter.utils.Function&lt;Model, Item&gt;']]"
		[Register (".ctor", "(Lcom/mikepenz/fastadapter/utils/Function;)V", "")]
		public unsafe GenericFastItemAdapter (global::Com.Mikepenz.Fastadapter.Utils.IFunction p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (GenericFastItemAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mikepenz/fastadapter/utils/Function;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/mikepenz/fastadapter/utils/Function;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mikepenz_fastadapter_utils_Function_ == IntPtr.Zero)
					id_ctor_Lcom_mikepenz_fastadapter_utils_Function_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mikepenz/fastadapter/utils/Function;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mikepenz_fastadapter_utils_Function_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_mikepenz_fastadapter_utils_Function_, __args);
			} finally {
			}
		}

		static Delegate cb_getGenericItemAdapter;
#pragma warning disable 0169
		static Delegate GetGetGenericItemAdapterHandler ()
		{
			if (cb_getGenericItemAdapter == null)
				cb_getGenericItemAdapter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGenericItemAdapter);
			return cb_getGenericItemAdapter;
		}

		static IntPtr n_GetGenericItemAdapter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GenericItemAdapter);
		}
#pragma warning restore 0169

		static IntPtr id_getGenericItemAdapter;
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericItemAdapter GenericItemAdapter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='getGenericItemAdapter' and count(parameter)=0]"
			[Register ("getGenericItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/GenericItemAdapter;", "GetGetGenericItemAdapterHandler")]
			get {
				if (id_getGenericItemAdapter == IntPtr.Zero)
					id_getGenericItemAdapter = JNIEnv.GetMethodID (class_ref, "getGenericItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/GenericItemAdapter;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGenericItemAdapter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGenericItemAdapter", "()Lcom/mikepenz/fastadapter/adapters/GenericItemAdapter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getModels;
#pragma warning disable 0169
		static Delegate GetGetModelsHandler ()
		{
			if (cb_getModels == null)
				cb_getModels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModels);
			return cb_getModels;
		}

		static IntPtr n_GetModels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Models);
		}
#pragma warning restore 0169

		static IntPtr id_getModels;
		public virtual unsafe global::System.Collections.IList Models {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='getModels' and count(parameter)=0]"
			[Register ("getModels", "()Ljava/util/List;", "GetGetModelsHandler")]
			get {
				if (id_getModels == IntPtr.Zero)
					id_getModels = JNIEnv.GetMethodID (class_ref, "getModels", "()Ljava/util/List;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModels), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModels", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addModel_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='addModel' and count(parameter)=1 and parameter[1][@type='Model...']]"
		[Register ("addModel", "([Ljava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "")]
		public unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter AddModel (params global:: Java.Lang.Object[] p0)
		{
			if (id_addModel_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_addModel_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addModel", "([Ljava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addModel_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_addModel_IarrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='addModel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Model...']]"
		[Register ("addModel", "(I[Ljava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "")]
		public unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter AddModel (int p0, params global:: Java.Lang.Object[] p1)
		{
			if (id_addModel_IarrayLjava_lang_Object_ == IntPtr.Zero)
				id_addModel_IarrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "addModel", "(I[Ljava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addModel_IarrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_addModel_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddModel_ILjava_util_List_Handler ()
		{
			if (cb_addModel_ILjava_util_List_ == null)
				cb_addModel_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AddModel_ILjava_util_List_);
			return cb_addModel_ILjava_util_List_;
		}

		static IntPtr n_AddModel_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddModel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addModel_ILjava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='addModel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;Model&gt;']]"
		[Register ("addModel", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetAddModel_ILjava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter AddModel (int p0, global::System.Collections.IList p1)
		{
			if (id_addModel_ILjava_util_List_ == IntPtr.Zero)
				id_addModel_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "addModel", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addModel_ILjava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addModel", "(ILjava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addModel_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddModel_Ljava_util_List_Handler ()
		{
			if (cb_addModel_Ljava_util_List_ == null)
				cb_addModel_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddModel_Ljava_util_List_);
			return cb_addModel_Ljava_util_List_;
		}

		static IntPtr n_AddModel_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddModel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addModel_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='addModel' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Model&gt;']]"
		[Register ("addModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetAddModel_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter AddModel (global::System.Collections.IList p0)
		{
			if (id_addModel_Ljava_util_List_ == IntPtr.Zero)
				id_addModel_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addModel_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_clearModel;
#pragma warning disable 0169
		static Delegate GetClearModelHandler ()
		{
			if (cb_clearModel == null)
				cb_clearModel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClearModel);
			return cb_clearModel;
		}

		static IntPtr n_ClearModel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClearModel ());
		}
#pragma warning restore 0169

		static IntPtr id_clearModel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='clearModel' and count(parameter)=0]"
		[Register ("clearModel", "()Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetClearModelHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter ClearModel ()
		{
			if (id_clearModel == IntPtr.Zero)
				id_clearModel = JNIEnv.GetMethodID (class_ref, "clearModel", "()Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clearModel), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearModel", "()Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_moveModel_II;
#pragma warning disable 0169
		static Delegate GetMoveModel_IIHandler ()
		{
			if (cb_moveModel_II == null)
				cb_moveModel_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_MoveModel_II);
			return cb_moveModel_II;
		}

		static IntPtr n_MoveModel_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MoveModel (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_moveModel_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='moveModel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("moveModel", "(II)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetMoveModel_IIHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter MoveModel (int p0, int p1)
		{
			if (id_moveModel_II == IntPtr.Zero)
				id_moveModel_II = JNIEnv.GetMethodID (class_ref, "moveModel", "(II)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_moveModel_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveModel", "(II)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeModel_I;
#pragma warning disable 0169
		static Delegate GetRemoveModel_IHandler ()
		{
			if (cb_removeModel_I == null)
				cb_removeModel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveModel_I);
			return cb_removeModel_I;
		}

		static IntPtr n_RemoveModel_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveModel (p0));
		}
#pragma warning restore 0169

		static IntPtr id_removeModel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='removeModel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeModel", "(I)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetRemoveModel_IHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter RemoveModel (int p0)
		{
			if (id_removeModel_I == IntPtr.Zero)
				id_removeModel_I = JNIEnv.GetMethodID (class_ref, "removeModel", "(I)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeModel_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeModel", "(I)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeModelRange_II;
#pragma warning disable 0169
		static Delegate GetRemoveModelRange_IIHandler ()
		{
			if (cb_removeModelRange_II == null)
				cb_removeModelRange_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_RemoveModelRange_II);
			return cb_removeModelRange_II;
		}

		static IntPtr n_RemoveModelRange_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveModelRange (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_removeModelRange_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='removeModelRange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("removeModelRange", "(II)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetRemoveModelRange_IIHandler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter RemoveModelRange (int p0, int p1)
		{
			if (id_removeModelRange_II == IntPtr.Zero)
				id_removeModelRange_II = JNIEnv.GetMethodID (class_ref, "removeModelRange", "(II)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeModelRange_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeModelRange", "(II)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setModel_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetModel_ILjava_lang_Object_Handler ()
		{
			if (cb_setModel_ILjava_lang_Object_ == null)
				cb_setModel_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetModel_ILjava_lang_Object_);
			return cb_setModel_ILjava_lang_Object_;
		}

		static IntPtr n_SetModel_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetModel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setModel_ILjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='setModel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='Model']]"
		[Register ("setModel", "(ILjava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetSetModel_ILjava_lang_Object_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter SetModel (int p0, global::Java.Lang.Object p1)
		{
			if (id_setModel_ILjava_lang_Object_ == IntPtr.Zero)
				id_setModel_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setModel", "(ILjava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setModel_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModel", "(ILjava/lang/Object;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setModel_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetModel_Ljava_util_List_Handler ()
		{
			if (cb_setModel_Ljava_util_List_ == null)
				cb_setModel_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetModel_Ljava_util_List_);
			return cb_setModel_Ljava_util_List_;
		}

		static IntPtr n_SetModel_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetModel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setModel_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='setModel' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Model&gt;']]"
		[Register ("setModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetSetModel_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter SetModel (global::System.Collections.IList p0)
		{
			if (id_setModel_Ljava_util_List_ == IntPtr.Zero)
				id_setModel_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setModel_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setNewModel_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetNewModel_Ljava_util_List_Handler ()
		{
			if (cb_setNewModel_Ljava_util_List_ == null)
				cb_setNewModel_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetNewModel_Ljava_util_List_);
			return cb_setNewModel_Ljava_util_List_;
		}

		static IntPtr n_SetNewModel_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetNewModel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setNewModel_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mikepenz.fastadapter.adapters']/class[@name='GenericFastItemAdapter']/method[@name='setNewModel' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;Model&gt;']]"
		[Register ("setNewModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;", "GetSetNewModel_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter SetNewModel (global::System.Collections.IList p0)
		{
			if (id_setNewModel_Ljava_util_List_ == IntPtr.Zero)
				id_setNewModel_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setNewModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setNewModel_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mikepenz.Fastadapter.Adapters.GenericFastItemAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewModel", "(Ljava/util/List;)Lcom/mikepenz/fastadapter/adapters/GenericFastItemAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}

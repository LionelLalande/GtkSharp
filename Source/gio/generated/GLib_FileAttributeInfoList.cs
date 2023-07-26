// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class FileAttributeInfoList : GLib.Opaque {

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_attribute_info_list_add(IntPtr raw, IntPtr name, int type, int flags);

		public void Add(string name, GLib.FileAttributeType type, GLib.FileAttributeInfoFlags flags) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			g_file_attribute_info_list_add(Handle, native_name, (int) type, (int) flags);
			GLib.Marshaller.Free (native_name);
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_info_list_dup(IntPtr raw);

		public GLib.FileAttributeInfoList Dup() {
			IntPtr raw_ret = g_file_attribute_info_list_dup(Handle);
			GLib.FileAttributeInfoList ret = raw_ret == IntPtr.Zero ? null : (GLib.FileAttributeInfoList) GLib.Opaque.GetOpaque (raw_ret, typeof (GLib.FileAttributeInfoList), false);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_info_list_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = g_file_attribute_info_list_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_info_list_lookup(IntPtr raw, IntPtr name);

		public GLib.FileAttributeInfo Lookup(string name) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr raw_ret = g_file_attribute_info_list_lookup(Handle, native_name);
			GLib.FileAttributeInfo ret = GLib.FileAttributeInfo.New (raw_ret);
			GLib.Marshaller.Free (native_name);
			return ret;
		}

		public FileAttributeInfoList(IntPtr raw) : base(raw) {}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_info_list_new();

		public FileAttributeInfoList () 
		{
			Raw = g_file_attribute_info_list_new();
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_file_attribute_info_list_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				g_file_attribute_info_list_ref (raw);
				Owned = true;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void g_file_attribute_info_list_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				g_file_attribute_info_list_unref (raw);
				Owned = false;
			}
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return g_file_attribute_info_list_unref;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("infos"
							, 0
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // infos
							, null
							, "n_infos"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("n_infos"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // n_infos
							, "infos"
							, null
							, (long) Marshal.OffsetOf(typeof(GFileAttributeInfoList_n_infosAlign), "n_infos")
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GFileAttributeInfoList_n_infosAlign
		{
			sbyte f1;
			private int n_infos;
		}


		// End of the ABI representation.

#endregion
	}
}

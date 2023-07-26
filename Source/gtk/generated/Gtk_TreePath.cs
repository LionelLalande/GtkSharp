// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class TreePath : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_path_append_index(IntPtr raw, int index_);

		public void AppendIndex(int index_) {
			gtk_tree_path_append_index(Handle, index_);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_path_compare(IntPtr raw, IntPtr b);

		public int Compare(Gtk.TreePath b) {
			int raw_ret = gtk_tree_path_compare(Handle, b == null ? IntPtr.Zero : b.Handle);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_copy(IntPtr raw);

		public Gtk.TreePath Copy() {
			IntPtr raw_ret = gtk_tree_path_copy(Handle);
			Gtk.TreePath ret = raw_ret == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TreePath), true);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_path_down(IntPtr raw);

		public void Down() {
			gtk_tree_path_down(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_path_get_depth(IntPtr raw);

		public int Depth { 
			get {
				int raw_ret = gtk_tree_path_get_depth(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_path_get_indices_with_depth(IntPtr raw, out int depth);

		public int GetIndicesWithDepth(out int depth) {
			int raw_ret = gtk_tree_path_get_indices_with_depth(Handle, out depth);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_tree_path_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_path_is_ancestor(IntPtr raw, IntPtr descendant);

		public bool IsAncestor(Gtk.TreePath descendant) {
			bool raw_ret = gtk_tree_path_is_ancestor(Handle, descendant == null ? IntPtr.Zero : descendant.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_path_is_descendant(IntPtr raw, IntPtr ancestor);

		public bool IsDescendant(Gtk.TreePath ancestor) {
			bool raw_ret = gtk_tree_path_is_descendant(Handle, ancestor == null ? IntPtr.Zero : ancestor.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_path_next(IntPtr raw);

		public void Next() {
			gtk_tree_path_next(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_path_prepend_index(IntPtr raw, int index_);

		public void PrependIndex(int index_) {
			gtk_tree_path_prepend_index(Handle, index_);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_path_prev(IntPtr raw);

		public bool Prev() {
			bool raw_ret = gtk_tree_path_prev(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_to_string(IntPtr raw);

		public override string ToString() {
			IntPtr raw_ret = gtk_tree_path_to_string(Handle);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_path_up(IntPtr raw);

		public bool Up() {
			bool raw_ret = gtk_tree_path_up(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public TreePath(IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_new();

		public TreePath () 
		{
			Raw = gtk_tree_path_new();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_new_first();

		public static TreePath NewFirst()
		{
			TreePath result = new TreePath (gtk_tree_path_new_first());
			return result;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_new_from_indicesv(out int indices, UIntPtr length);

		public TreePath (out int indices, ulong length) 
		{
			Raw = gtk_tree_path_new_from_indicesv(out indices, new UIntPtr (length));
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_path_new_from_string(IntPtr path);

		public TreePath (string path) 
		{
			IntPtr native_path = GLib.Marshaller.StringToPtrGStrdup (path);
			Raw = gtk_tree_path_new_from_string(native_path);
			GLib.Marshaller.Free (native_path);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_path_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gtk_tree_path_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gtk_tree_path_free;
			}
		}

		[Obsolete("Gtk.TreePath is now freed automatically")]
		public void Free () {}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}

// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SelectionData : GLib.Opaque {

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_copy(IntPtr raw);

		public Gtk.SelectionData Copy() {
			IntPtr raw_ret = gtk_selection_data_copy(Handle);
			Gtk.SelectionData ret = raw_ret == IntPtr.Zero ? null : (Gtk.SelectionData) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.SelectionData), true);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_data_type(IntPtr raw);

		public Gdk.Atom DataType { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_data_type(Handle);
				Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern byte gtk_selection_data_get_data_with_length(IntPtr raw, out int length);

		public byte GetDataWithLength(out int length) {
			byte raw_ret = gtk_selection_data_get_data_with_length(Handle, out length);
			byte ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_display(IntPtr raw);

		public Gdk.Display Display { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_display(Handle);
				Gdk.Display ret = GLib.Object.GetObject(raw_ret) as Gdk.Display;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_selection_data_get_format(IntPtr raw);

		public int Format { 
			get {
				int raw_ret = gtk_selection_data_get_format(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_selection_data_get_length(IntPtr raw);

		public int Length { 
			get {
				int raw_ret = gtk_selection_data_get_length(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_pixbuf(IntPtr raw);

		public Gdk.Pixbuf Pixbuf { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_pixbuf(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_selection(IntPtr raw);

		public Gdk.Atom Selection { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_selection(Handle);
				Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_target(IntPtr raw);

		public Gdk.Atom Target { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_target(Handle);
				Gdk.Atom ret = raw_ret == IntPtr.Zero ? null : (Gdk.Atom) GLib.Opaque.GetOpaque (raw_ret, typeof (Gdk.Atom), false);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_selection_data_get_uris(IntPtr raw);

		public string Uris { 
			get {
				IntPtr raw_ret = gtk_selection_data_get_uris(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_selection_data_set(IntPtr raw, IntPtr type, int format, byte[] data, int length);

		public void Set(Gdk.Atom type, int format, byte[] data, int length) {
			gtk_selection_data_set(Handle, type == null ? IntPtr.Zero : type.Handle, format, data, length);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_set_pixbuf(IntPtr raw, IntPtr pixbuf);

		public bool SetPixbuf(Gdk.Pixbuf pixbuf) {
			bool raw_ret = gtk_selection_data_set_pixbuf(Handle, pixbuf == null ? IntPtr.Zero : pixbuf.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_set_uris(IntPtr raw, IntPtr uris);

		public bool SetUris(string uris) {
			bool raw_ret = gtk_selection_data_set_uris(Handle, GLib.Marshaller.StringToPtrGStrdup(uris));
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_targets_include_image(IntPtr raw, bool writable);

		public bool TargetsIncludeImage(bool writable) {
			bool raw_ret = gtk_selection_data_targets_include_image(Handle, writable);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_targets_include_rich_text(IntPtr raw, IntPtr buffer);

		public bool TargetsIncludeRichText(Gtk.TextBuffer buffer) {
			bool raw_ret = gtk_selection_data_targets_include_rich_text(Handle, buffer == null ? IntPtr.Zero : buffer.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_targets_include_text(IntPtr raw);

		public bool TargetsIncludeText() {
			bool raw_ret = gtk_selection_data_targets_include_text(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_selection_data_targets_include_uri(IntPtr raw);

		public bool TargetsIncludeUri() {
			bool raw_ret = gtk_selection_data_targets_include_uri(Handle);
			bool ret = raw_ret;
			return ret;
		}

		public SelectionData(IntPtr raw) : base(raw) {}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_selection_data_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gtk_selection_data_free (raw);
		}

		protected override Action<IntPtr> DisposeUnmanagedFunc {
			get {
				return gtk_selection_data_free;
			}
		}

		[Obsolete("Gtk.SelectionData is now freed automatically")]
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

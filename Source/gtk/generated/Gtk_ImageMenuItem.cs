// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ImageMenuItem : Gtk.MenuItem {

		public ImageMenuItem (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new();

		public ImageMenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImageMenuItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_image_menu_item_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_new_from_stock(IntPtr stock_id, IntPtr accel_group);

		public ImageMenuItem (string stock_id, Gtk.AccelGroup accel_group) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (ImageMenuItem)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("accel_group");
				vals.Add (new GLib.Value (accel_group));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_stock_id = GLib.Marshaller.StringToPtrGStrdup (stock_id);
			Raw = gtk_image_menu_item_new_from_stock(native_stock_id, accel_group == null ? IntPtr.Zero : accel_group.Handle);
			GLib.Marshaller.Free (native_stock_id);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_image(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_image(IntPtr raw, IntPtr image);

		[Obsolete]
		[GLib.Property ("image")]
		public Gtk.Widget Image {
			get  {
				IntPtr raw_ret = gtk_image_menu_item_get_image(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_image_menu_item_set_image(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_image_menu_item_get_use_stock(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_use_stock(IntPtr raw, bool use_stock);

		[Obsolete]
		[GLib.Property ("use-stock")]
		public bool UseStock {
			get  {
				bool raw_ret = gtk_image_menu_item_get_use_stock(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_image_menu_item_set_use_stock(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_image_menu_item_get_always_show_image(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_always_show_image(IntPtr raw, bool always_show);

		[Obsolete]
		[GLib.Property ("always-show-image")]
		public bool AlwaysShowImage {
			get  {
				bool raw_ret = gtk_image_menu_item_get_always_show_image(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_image_menu_item_set_always_show_image(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_image_menu_item_set_accel_group(IntPtr raw, IntPtr accel_group);

		[Obsolete]
		[GLib.Property ("accel-group")]
		public Gtk.AccelGroup AccelGroup {
			set  {
				gtk_image_menu_item_set_accel_group(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.MenuItem.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_image_menu_item_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_image_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.MenuItem.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gtk.ButtonBoxStyleGType))]
	public enum ButtonBoxStyle {

		Spread = 1,
		Edge,
		Start,
		End,
		Center,
		Expand,
	}

	internal class ButtonBoxStyleGType {
		[DllImport ("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_button_box_style_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_button_box_style_get_type ());
			}
		}
	}
#endregion
}
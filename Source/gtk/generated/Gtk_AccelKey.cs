// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct AccelKey : IEquatable<AccelKey> {

		public Gdk.Key Key;
		public Gdk.ModifierType AccelMods;
		public ushort AccelFlags;

		public static Gtk.AccelKey Zero = new Gtk.AccelKey ();

		public static Gtk.AccelKey New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gtk.AccelKey.Zero;
			return (Gtk.AccelKey) Marshal.PtrToStructure (raw, typeof (Gtk.AccelKey));
		}

		public bool Equals (AccelKey other)
		{
			return true && Key.Equals (other.Key) && AccelMods.Equals (other.AccelMods) && AccelFlags.Equals (other.AccelFlags);
		}

		public override bool Equals (object other)
		{
			return other is AccelKey && Equals ((AccelKey) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Key.GetHashCode () ^ AccelMods.GetHashCode () ^ AccelFlags.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
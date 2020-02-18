// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FileAttributeInfo : IEquatable<FileAttributeInfo> {

		public string Name;
		public GLib.FileAttributeType Type;
		public GLib.FileAttributeInfoFlags Flags;

		public static GLib.FileAttributeInfo Zero = new GLib.FileAttributeInfo ();

		public static GLib.FileAttributeInfo New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return GLib.FileAttributeInfo.Zero;
			return (GLib.FileAttributeInfo) Marshal.PtrToStructure (raw, typeof (GLib.FileAttributeInfo));
		}

		public bool Equals (FileAttributeInfo other)
		{
			return true && Name.Equals (other.Name) && Type.Equals (other.Type) && Flags.Equals (other.Flags);
		}

		public override bool Equals (object other)
		{
			return other is FileAttributeInfo && Equals ((FileAttributeInfo) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Name.GetHashCode () ^ Type.GetHashCode () ^ Flags.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
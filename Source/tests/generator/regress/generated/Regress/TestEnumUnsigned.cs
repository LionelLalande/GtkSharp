// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Regress.TestEnumUnsignedGType))]
	public enum TestEnumUnsigned : uint {

		Value1 = 1,
		Value2 = 2147483648,
	}

	internal class TestEnumUnsignedGType {
		[DllImport ("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_test_enum_unsigned_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (regress_test_enum_unsigned_get_type ());
			}
		}
	}
#endregion
}
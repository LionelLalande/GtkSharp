// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FooEventExpose : IEquatable<FooEventExpose> {

		public sbyte SendEvent;
		public int Count;

		public static Regress.FooEventExpose Zero = new Regress.FooEventExpose ();

		public static Regress.FooEventExpose New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.FooEventExpose.Zero;
			return (Regress.FooEventExpose) Marshal.PtrToStructure (raw, typeof (Regress.FooEventExpose));
		}

		public bool Equals (FooEventExpose other)
		{
			return true && SendEvent.Equals (other.SendEvent) && Count.Equals (other.Count);
		}

		public override bool Equals (object other)
		{
			return other is FooEventExpose && Equals ((FooEventExpose) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ SendEvent.GetHashCode () ^ Count.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
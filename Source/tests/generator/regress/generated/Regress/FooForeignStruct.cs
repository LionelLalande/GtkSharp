// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct FooForeignStruct : IEquatable<FooForeignStruct> {

		public int RegressFoo;

		public static Regress.FooForeignStruct Zero = new Regress.FooForeignStruct ();

		public static Regress.FooForeignStruct New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Regress.FooForeignStruct.Zero;
			return (Regress.FooForeignStruct) Marshal.PtrToStructure (raw, typeof (Regress.FooForeignStruct));
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_foreign_struct_new();

		public static FooForeignStruct New()
		{
			FooForeignStruct result = FooForeignStruct.New (regress_foo_foreign_struct_new());
			return result;
		}

		[DllImport("regress-1.0", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr regress_foo_foreign_struct_copy(IntPtr raw);

		public Regress.FooForeignStruct Copy() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = regress_foo_foreign_struct_copy(this_as_native);
			Regress.FooForeignStruct ret = Regress.FooForeignStruct.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Regress.FooForeignStruct target)
		{
			target = New (native);
		}

		public bool Equals (FooForeignStruct other)
		{
			return true && RegressFoo.Equals (other.RegressFoo);
		}

		public override bool Equals (object other)
		{
			return other is FooForeignStruct && Equals ((FooForeignStruct) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ RegressFoo.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Regress {

	using System;

	public delegate void SignalHandler(object o, SignalArgs args);

	public class SignalArgs : GLib.SignalArgs {
		public GLib.Object Object{
			get {
				return (GLib.Object) Args [0];
			}
		}

		public IntPtr P0{
			get {
				return (IntPtr) Args [1];
			}
		}

	}
}
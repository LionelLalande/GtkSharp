// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void FromEmbedderHandler(object o, FromEmbedderArgs args);

	public class FromEmbedderArgs : GLib.SignalArgs {
		public double EmbedderX{
			get {
				return (double) Args [0];
			}
		}

		public double EmbedderY{
			get {
				return (double) Args [1];
			}
		}

		public double OffscreenX{
			set {
				Args[2] = (double)value;
			}
		}

		public double OffscreenY{
			set {
				Args[3] = (double)value;
			}
		}

	}
}

// This file has been generated by the GUI designer. Do not modify.
namespace FloydPink.Flickr.Downloadr.UI.Widgets
{
	public partial class PhotoWidget
	{
		private global::Gtk.VBox vboxContainer;
		
		private global::Gtk.HBox hboxContainer;
		
		private global::Gtk.Frame frameMain;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.EventBox eventboxMain;
		
		private global::Gtk.Image imageMain;
		
		private global::Gtk.Label frameLabel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget FloydPink.Flickr.Downloadr.UI.Widgets.PhotoWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "FloydPink.Flickr.Downloadr.UI.Widgets.PhotoWidget";
			// Container child FloydPink.Flickr.Downloadr.UI.Widgets.PhotoWidget.Gtk.Container+ContainerChild
			this.vboxContainer = new global::Gtk.VBox ();
			this.vboxContainer.Name = "vboxContainer";
			this.vboxContainer.Spacing = 10;
			// Container child vboxContainer.Gtk.Box+BoxChild
			this.hboxContainer = new global::Gtk.HBox ();
			this.hboxContainer.Name = "hboxContainer";
			this.hboxContainer.Spacing = 10;
			// Container child hboxContainer.Gtk.Box+BoxChild
			this.frameMain = new global::Gtk.Frame ();
			this.frameMain.Name = "frameMain";
			this.frameMain.LabelXalign = 0.95F;
			// Container child frameMain.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.BottomPadding = ((uint)(5));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.eventboxMain = new global::Gtk.EventBox ();
			this.eventboxMain.Name = "eventboxMain";
			// Container child eventboxMain.Gtk.Container+ContainerChild
			this.imageMain = new global::Gtk.Image ();
			this.imageMain.Name = "imageMain";
			this.eventboxMain.Add (this.imageMain);
			this.GtkAlignment.Add (this.eventboxMain);
			this.frameMain.Add (this.GtkAlignment);
			this.frameLabel = new global::Gtk.Label ();
			this.frameLabel.Name = "frameLabel";
			this.frameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<span color=\"silver\" size=\"x-large\"><b><big> ☆ </big></b></span>");
			this.frameLabel.UseMarkup = true;
			this.frameMain.LabelWidget = this.frameLabel;
			this.hboxContainer.Add (this.frameMain);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hboxContainer [this.frameMain]));
			w4.Position = 0;
			w4.Padding = ((uint)(5));
			this.vboxContainer.Add (this.hboxContainer);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxContainer [this.hboxContainer]));
			w5.Position = 0;
			this.Add (this.vboxContainer);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.eventboxMain.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.imageClick);
		}
	}
}

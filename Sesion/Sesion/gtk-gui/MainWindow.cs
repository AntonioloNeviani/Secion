
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Button button2;
	private global::Gtk.Entry entry2;
	private global::Gtk.Label label6;
	private global::Gtk.Entry entry1;
	private global::Gtk.Label label5;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Contraseña Usuario");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		// Container child button2.Gtk.Container+ContainerChild
		global::Gtk.Alignment w1 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w2 = new global::Gtk.HBox ();
		w2.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w3 = new global::Gtk.Image ();
		w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_about", global::Gtk.IconSize.Menu);
		w2.Add (w3);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w5 = new global::Gtk.Label ();
		w5.LabelProp = global::Mono.Unix.Catalog.GetString ("Entrar");
		w5.UseUnderline = true;
		w2.Add (w5);
		w1.Add (w2);
		this.button2.Add (w1);
		this.fixed1.Add (this.button2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
		w9.X = 161;
		w9.Y = 182;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.Visibility = false;
		this.entry2.InvisibleChar = '•';
		this.fixed1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry2]));
		w10.X = 56;
		w10.Y = 128;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Contraseña");
		this.fixed1.Add (this.label6);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label6]));
		w11.X = 37;
		w11.Y = 95;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.fixed1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.entry1]));
		w12.X = 56;
		w12.Y = 57;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Nombre");
		this.fixed1.Add (this.label5);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label5]));
		w13.X = 36;
		w13.Y = 26;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 268;
		this.DefaultHeight = 269;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler (this.OnButton2Clicked);
	}
}

using System;
using Gtk; 
using GtkSharp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnButton2Clicked (object sender, System.EventArgs e)
	{
		if(entry1.Text == "usuario" && entry2.Text == "contraseña")
		{
			MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Bienvenido!");
			md.Show();
			Console.WriteLine("Bienvenido!");
		}
		else {
			MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Info, ButtonsType.None,"Datos incorrectos");
			md.Show();
			Console.WriteLine("Datos incorrectos");
		} 
	}
}

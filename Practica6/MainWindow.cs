using System;
using Gtk;

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

	protected void OnBtnfactClicked (object sender, EventArgs e)
	{
		double p1= double.Parse (this.txt1.Text);
		double p2= double.Parse (this.txt2.Text);
		double p3= double.Parse (this.txt3.Text);

		double Subt= p1+p2+p3;
		double Iva= Subt*.16;
		double Total= Subt+Iva;

		this.txtsubt.Text= Subt.ToString ();
		this.txtiva.Text= Iva.ToString ();
		this.txttotal.Text= Total.ToString ();

	}

	protected void OnBtnlimpClicked (object sender, EventArgs e)
	{
		this.txt1.Text="";
		this.txt2.Text="";
		this.txt3.Text="";
		this.txtiva.Text="";
		this.txtsubt.Text="";
		this.txttotal.Text="";
	}
}


// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Entry txtsubt;
	private global::Gtk.Entry txtiva;
	private global::Gtk.Entry txt1;
	private global::Gtk.Entry txt2;
	private global::Gtk.Entry txt3;
	private global::Gtk.Entry txttotal;
	private global::Gtk.Label lblp1;
	private global::Gtk.Label lblp3;
	private global::Gtk.Label lblp2;
	private global::Gtk.Label lblsubt;
	private global::Gtk.Label lbliva;
	private global::Gtk.Label lbltotal;
	private global::Gtk.Button Btnfact;
	private global::Gtk.Button btnlimp;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtsubt = new global::Gtk.Entry ();
		this.txtsubt.CanFocus = true;
		this.txtsubt.Name = "txtsubt";
		this.txtsubt.IsEditable = true;
		this.txtsubt.InvisibleChar = '●';
		this.fixed1.Add (this.txtsubt);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtsubt]));
		w1.X = 200;
		w1.Y = 128;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtiva = new global::Gtk.Entry ();
		this.txtiva.CanFocus = true;
		this.txtiva.Name = "txtiva";
		this.txtiva.IsEditable = true;
		this.txtiva.InvisibleChar = '●';
		this.fixed1.Add (this.txtiva);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtiva]));
		w2.X = 198;
		w2.Y = 165;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txt1 = new global::Gtk.Entry ();
		this.txt1.CanFocus = true;
		this.txt1.Name = "txt1";
		this.txt1.IsEditable = true;
		this.txt1.InvisibleChar = '●';
		this.fixed1.Add (this.txt1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txt1]));
		w3.X = 201;
		w3.Y = 3;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txt2 = new global::Gtk.Entry ();
		this.txt2.CanFocus = true;
		this.txt2.Name = "txt2";
		this.txt2.IsEditable = true;
		this.txt2.InvisibleChar = '●';
		this.fixed1.Add (this.txt2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txt2]));
		w4.X = 200;
		w4.Y = 36;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txt3 = new global::Gtk.Entry ();
		this.txt3.CanFocus = true;
		this.txt3.Name = "txt3";
		this.txt3.IsEditable = true;
		this.txt3.InvisibleChar = '●';
		this.fixed1.Add (this.txt3);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txt3]));
		w5.X = 200;
		w5.Y = 70;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txttotal = new global::Gtk.Entry ();
		this.txttotal.CanFocus = true;
		this.txttotal.Name = "txttotal";
		this.txttotal.IsEditable = true;
		this.txttotal.InvisibleChar = '●';
		this.fixed1.Add (this.txttotal);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txttotal]));
		w6.X = 199;
		w6.Y = 197;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp1 = new global::Gtk.Label ();
		this.lblp1.Name = "lblp1";
		this.lblp1.LabelProp = global::Mono.Unix.Catalog.GetString ("Producto 1");
		this.fixed1.Add (this.lblp1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp1]));
		w7.X = 49;
		w7.Y = 8;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp3 = new global::Gtk.Label ();
		this.lblp3.Name = "lblp3";
		this.lblp3.LabelProp = global::Mono.Unix.Catalog.GetString ("Producto 3");
		this.fixed1.Add (this.lblp3);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp3]));
		w8.X = 48;
		w8.Y = 72;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblp2 = new global::Gtk.Label ();
		this.lblp2.Name = "lblp2";
		this.lblp2.LabelProp = global::Mono.Unix.Catalog.GetString ("Producto 2");
		this.fixed1.Add (this.lblp2);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblp2]));
		w9.X = 48;
		w9.Y = 38;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblsubt = new global::Gtk.Label ();
		this.lblsubt.Name = "lblsubt";
		this.lblsubt.LabelProp = global::Mono.Unix.Catalog.GetString ("Subtotal");
		this.fixed1.Add (this.lblsubt);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblsubt]));
		w10.X = 122;
		w10.Y = 133;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lbliva = new global::Gtk.Label ();
		this.lbliva.Name = "lbliva";
		this.lbliva.LabelProp = global::Mono.Unix.Catalog.GetString ("Iva");
		this.fixed1.Add (this.lbliva);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lbliva]));
		w11.X = 122;
		w11.Y = 166;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lbltotal = new global::Gtk.Label ();
		this.lbltotal.Name = "lbltotal";
		this.lbltotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Total");
		this.fixed1.Add (this.lbltotal);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lbltotal]));
		w12.X = 122;
		w12.Y = 204;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.Btnfact = new global::Gtk.Button ();
		this.Btnfact.CanFocus = true;
		this.Btnfact.Name = "Btnfact";
		this.Btnfact.UseUnderline = true;
		this.Btnfact.Label = global::Mono.Unix.Catalog.GetString ("Facturar");
		this.fixed1.Add (this.Btnfact);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.Btnfact]));
		w13.X = 56;
		w13.Y = 272;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnlimp = new global::Gtk.Button ();
		this.btnlimp.CanFocus = true;
		this.btnlimp.Name = "btnlimp";
		this.btnlimp.UseUnderline = true;
		this.btnlimp.Label = global::Mono.Unix.Catalog.GetString ("Limpiar");
		this.fixed1.Add (this.btnlimp);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnlimp]));
		w14.X = 243;
		w14.Y = 272;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 389;
		this.DefaultHeight = 394;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.Btnfact.Clicked += new global::System.EventHandler (this.OnBtnfactClicked);
		this.btnlimp.Clicked += new global::System.EventHandler (this.OnBtnlimpClicked);
	}
}

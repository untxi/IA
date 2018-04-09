using System;
using Gtk;
using Cairo;

public class SharpApp : Window
{
    public SharpApp(): base("Simple drawing")
    {
        

        SetDefaultSize(230, 150);
        SetPosition(WindowPosition.Center);
        DeleteEvent += delegate { Application.Quit(); }; ;

        DrawingArea darea = new DrawingArea();
        darea.ExposeEvent += OnExpose;

        Add(darea);

        ShowAll();
    }

    void OnExpose(object sender, ExposeEventArgs args)
    {
        DrawingArea area = (DrawingArea)sender;
        Cairo.Context cr = Gdk.CairoHelper.Create(area.GdkWindow);

        cr.LineWidth = 9;
        cr.SetSourceRGB(0.7, 0.2, 0.0);

        int width, height;
        width = Allocation.Width;
        height = Allocation.Height;

        cr.Translate(width / 2, height / 2);
        cr.Arc(0, 0, (width < height ? width : height) / 2 - 10, 0, 2 * Math.PI);
        cr.StrokePreserve();

        cr.SetSourceRGB(0.3, 0.4, 0.6);
        cr.Fill();

        ((IDisposable)cr.Target).Dispose();
        ((IDisposable)cr).Dispose();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}

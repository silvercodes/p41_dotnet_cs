
#region Notifier

//const string message = "Hello Vasia";

////AbstractNotifier a = new Notifier();
////// a.Send(message);

////AbstractNotifier b = new SmsNotifierDecorator(a);
////// b.Send(message);

////AbstractNotifier c = new TelegramNotifierDecorator(b);
////c.Send(message);


//AbstractNotifier notifier = new SmsNotifierDecorator(new Notifier());
//notifier.Send(message);

//abstract class AbstractNotifier
//{
//    public abstract void Send(string message);
//}

//class Notifier: AbstractNotifier
//{
//    public override void Send(string message)
//    {
//        Console.WriteLine($"Email: {message}");
//    }
//}

//abstract class NotifierDecorator: AbstractNotifier
//{
//    protected AbstractNotifier? wrappee;
//    public NotifierDecorator(AbstractNotifier wrappee)
//    {
//        this.wrappee = wrappee;
//    }
//    public override void Send(string message)
//    {
//        wrappee?.Send(message);
//    }
//}

//class SmsNotifierDecorator: NotifierDecorator
//{
//    public SmsNotifierDecorator(AbstractNotifier wrappee):
//        base(wrappee)
//    { }

//    public override void Send(string message)
//    {
//        base.Send(message);
//        Console.WriteLine($"Sms: {message}");
//    }
//}

//class TelegramNotifierDecorator : NotifierDecorator
//{
//    public TelegramNotifierDecorator(AbstractNotifier wrappee) :
//        base(wrappee)
//    { }

//    public override void Send(string message)
//    {
//        base.Send(message);
//        Console.WriteLine($"Telegram: {message}");
//    }
//}

#endregion


#region TextBox


//using System.Drawing;


////TextBox tb = new TextBox(160, 60);
////tb.Render();

////IRenderable tb = new TextBox(160, 60);
////tb.Render();

////TextBox tb = new TextBox(160, 60);
////// tb.Render();
////IRenderable decorator = new BorderDecorator(tb);
////decorator.Render();


//IRenderable elem = new ColoredBorderDecorator(
//    new ColoredBorderDecorator(
//        new TextBox(160, 60), 
//    Color.Azure, 4), 
//Color.Aqua, 2);

//elem.Render();



//abstract class IRenderable
//{
//    public abstract void Render();
//}

//class TextBox: IRenderable
//{
//    public int W { get; set; }
//    public int H { get; set; }
//    public TextBox(int w, int h)
//    {
//        W = w;
//        H = h;
//    }
//    public override void Render()
//    {
//        Console.WriteLine($"TextBox: w: {W}, h: {H}");
//    }
//}

//abstract class Decorator: IRenderable
//{
//    private IRenderable item;
//    public Decorator(IRenderable item)
//    {
//        this.item = item;
//    }
//    public override void Render()
//    {
//        item.Render();
//    }
//}

//class BorderDecorator: Decorator
//{
//    public BorderDecorator(IRenderable item):
//        base(item)
//    { }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine("Border decorator");
//    }
//}
//class ColoredBorderDecorator: Decorator
//{
//    private Color color;
//    private int thikness;
//    public ColoredBorderDecorator(IRenderable item, Color color, int thikness) :
//        base(item)
//    { 
//        this.color = color;
//        this.thikness = thikness;
//    }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine($"ColoredBorderDecorator: color: {color}, thikness: {thikness}");
//    }
//}
//class WithScrollDecorator: Decorator
//{
//    public WithScrollDecorator(IRenderable item) :
//        base(item)
//    {}
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine("WithScrollDecorator");
//    }
//}


#endregion



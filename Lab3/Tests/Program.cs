using Adapter;
using Bridge.Shapes;
using Bridge.Rendering;
using Decorator.InvetoryItems;
using Decorator.Characters;
using Composite;
using Proxy;
using System.Diagnostics;
using Flyweight;

//Task 1
var fileLogger = new FileLogger(new Logger(), "text.txt");
fileLogger.Write("This is a message that uses Write method");
fileLogger.WriteLine("This is a message that uses WriteLine method");
//Task2
var MageTom = new MagicCloack(new Sword(new Mage()));
Console.WriteLine("Strength:" + MageTom.GetStrength());
Console.WriteLine("Armoredness:" + MageTom.GetArmoredness());
//Task3
Shape circle = new Circle(new VectorGraphics());
Shape square = new Square(new VectorGraphics());
Shape triangle = new Triangle(new RasterGraphics());
circle.Draw();
circle.SetRender(new RasterGraphics());
circle.Draw();
square.Draw();
triangle.Draw();
//Task4
SmartTextReader reader = new SmartTextReader();
SmartTextChecker checker = new SmartTextChecker(reader);
SmartTextReaderLocker locker = new SmartTextReaderLocker(reader, @"^(?!.*K).*");
checker.ReadText("../../../../Bejeweled Lyrics.txt");
locker.ReadText("../../../../Bejeweled Lyrics.txt");
//Task5
LightElementNode div = new LightElementNode("div", "block", "closed", new List<string> { "container" });
div.AddChild(new LightTextNode("Hello"));
var p = new LightElementNode("p", "block", "closed", new List<string> { "paragraph" });
div.AddChild(p);
p.AddChild(new LightTextNode("Molly"));
p.AddChild(new LightElementNode("img", "inline", "open", new List<string> { "img-fluid" }));
div.outerHTML();
div.RemoveChild(p);
div.outerHTML();
//Task6
DocumentReader.FilePath = "../../../../pg1513.txt";
DocumentReader.ReaderWithFly();
//DocumentReader.ReaderWithoutFly();
Process proc = Process.GetCurrentProcess();
//double memoryUsedInMB = proc.WorkingSet64 / (1024.0 * 1024.0); 
Console.WriteLine($"Allocated Physical Memory: {proc.WorkingSet64:F2} MB");


using Adapter;
using Bridge.Shapes;
using Bridge.Rendering;
using Decorator.InvetoryItems;
using Decorator.Characters;
using Proxy;

//Task 1
var fileLogger = new FileLogger(new Logger(), "text.txt");
fileLogger.Write("This is a message that uses Write method");
fileLogger.WriteLine("This is a message that uses WriteLine method");
//Task2
var MageTom = new MagicCloack(new Sword(new Mage()));
Console.WriteLine("Strength:"+MageTom.GetStrength());
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


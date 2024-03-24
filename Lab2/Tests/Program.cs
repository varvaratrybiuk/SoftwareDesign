using Abstract_Factory.Factories;
using Builder;
using FactoryMethod;
using FactoryMethod.Creators;
using Prototype;
using Singleton;
//Task 1
Console.WriteLine("Task 1");
CreateSubscription(new MobileApp(), "Premium");
//Task 2
Console.WriteLine("Task 2");
CreateDevices(new Galaxy());
//Task 3
Console.WriteLine("Task 3");
var instance1 = Authenticator.GetInstance();
var instance2 = Authenticator.GetInstance();
Task<Authenticator> task = Task.Run(() =>
{
    var instance3 = Authenticator.GetInstance();
    return instance3;

});
Console.WriteLine(instance1 == instance2 && instance1 == task.Result && instance2 == task.Result);
//Task 4
Console.WriteLine("Task 4");
Virus grandChild = new Virus(10, 1, "GrandChildVirus", "Type1", null);
Virus child = new Virus(20, 2, "ChildVirus", "Type2", grandChild);
Virus parent = new Virus(30, 3, "ParentVirus", "Type3", child);
Virus original = new Virus(40, 4, "OriginalVirus", "Type4", parent);
Virus clone = (Virus)original.Clone();
Console.WriteLine("Original Virus:");
DisplayVirus(original);
Console.WriteLine("Cloned Virus:");
DisplayVirus(clone);
Console.WriteLine("Original Virus Children:");
foreach (var childVirus in original.Children)
{
    DisplayVirus(childVirus);
}
Console.WriteLine("Cloned Virus Children:");
foreach (var childVirus in clone.Children)
{
    DisplayVirus(childVirus);
}
//Task 5
Console.WriteLine("Task 5");
Director director = new Director(new HeroBuilder());
var cat = director.WizardCat().AddTasks("Collect some rocks").AddTasks("Get a spoon of holy water");
director.SetBuilder(new EnemyBuilder());
var frog = director.WizardFrog().AddTasks("Find the crystal of life").AddTasks("");
Console.WriteLine("Good:\n" + $"Cat: {cat.Good}\n" + $"Frog: {frog.Good}");
Console.WriteLine($"Frog task: {frog.Tasks[0]}");




static void CreateDevices(IAbstractFactory factory)
{
    var Smartphone = factory.CreateSmartphone();
    Console.WriteLine("Screen type: "+Smartphone.ScreenType);
    var Laptop = factory.CreateLaptop();
    Console.WriteLine("Graphics Card: "+Laptop.GraphicsCard);
    var Notebook = factory.CreateNotebook();
    Console.WriteLine("Processor type: "+Notebook.ProcessorType);
    var EBook = factory.Ebook();
    Console.WriteLine("Backlight: "+EBook.Backlight);
}
static void CreateSubscription(CreateSubscription creator, string name)
{
    var my_sub = creator.BuySubcription(name);
    my_sub.GetInfo();

}
static void DisplayVirus(Virus virus)
{
    Console.WriteLine($"Name: {virus.Name}, Weight: {virus.Weight}, Age: {virus.Age}, Type: {virus.Type}");
}

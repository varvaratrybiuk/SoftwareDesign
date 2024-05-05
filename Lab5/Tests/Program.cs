using Command;
using Composite;
//Task 1
var div1 = new LightElementNode("div", "block", "closed", new List<string>() { "div1" });
var div2 = new LightElementNode("div", "block", "closed", new List<string>() { "div2" });
var div3 = new LightElementNode("div", "block", "closed", new List<string>() { "div3" });
var div4 = new LightElementNode("div", "block", "closed", new List<string>() { "div4" });
var div5 = new LightElementNode("div", "block", "closed", new List<string>() { "div5" });
var div6 = new LightElementNode("div", "block", "closed", new List<string>() { "div6" });
var div7 = new LightElementNode("div", "block", "closed", new List<string>() { "div7" });
var textindiv1 = new LightTextNode("Hello");
var textindiv7 = new LightTextNode("Kate");
div1.AddChild(div2);
div1.AddChild(textindiv1);
div1.AddChild(div3);
div2.AddChild(div4);
div2.AddChild(div5);
div3.AddChild(div6);
div3.AddChild(div7);
div7.AddChild(textindiv7);
Console.WriteLine("--------------------------");
Console.WriteLine("Depth: ");
var depthFirstIterator = div1.GetDepthIterator();
while (!depthFirstIterator.IsDone())
{
    Console.WriteLine("------");
    ILightNode currentNode = (ILightNode)depthFirstIterator.Next();
    currentNode.outerHTML();
  
}
Console.WriteLine("-------------------------------------");
Console.WriteLine("Breadth: ");
var breadsFirstIterator = div1.GetBreadIterator();
while (!breadsFirstIterator.IsDone())
{
    Console.WriteLine("------");
    ILightNode currentNode = (ILightNode)breadsFirstIterator.Next();
    currentNode.outerHTML();

}
//Task 2
var addtext1 = new AddTextInNode(div3, "Amy");
var addtext2 = new AddTextInNode(div4, "Mary");
var cssClass = new AddCssClass(div5, "some class");
var invoker = new Invoker([addtext1, addtext2, cssClass]);
invoker.ExecAllCommand();
div1.innerHTML();
invoker.UndoAllCommand();
Console.WriteLine("-------------------------------------");
div1.innerHTML();
//Task 3
Console.WriteLine("-------------------------------------");
div1.MouseOut();
div1.MouseOver();
div1.MouseOver();
div1.MouseOut();
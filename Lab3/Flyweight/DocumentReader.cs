using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public static class DocumentReader
    {
        public static string FilePath { get; set; }
        public static void ReaderWithFly()
        {
            var Root = new LightElementNodeUpdated("html", "block", "closed", new List<string>());
            var body = new LightElementNodeUpdated("body", "block", "closed", new List<string>());
            var lines = File.ReadAllLines(FilePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                LightElementNodeUpdated node;
                if (line.Length < 20)
                {
                    node = new LightElementNodeUpdated("h2", "block", "closed", new List<string>());
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = new LightElementNodeUpdated("blockquote", "block", "closed", new List<string>());
                }
                else
                {
                    node = new LightElementNodeUpdated("p", "block", "closed", new List<string>());
                }

                node.AddChild(new LightTextNode(line));
                body.AddChild(node);
            }
            Root.AddChild(body);

        }
        public static void ReaderWithoutFly()
        {
            var Root = new LightElementNode("html", "block", "closed", new List<string>());
            var body = new LightElementNode("body", "block", "closed", new List<string>());
            var lines = File.ReadAllLines(FilePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                LightElementNode node;
                if (line.Length < 20)
                {
                    node = new LightElementNode("h2", "block", "closed", new List<string>());
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = new LightElementNode("blockquote", "block", "closed", new List<string>());
                }
                else
                {
                    node = new LightElementNode("p", "block", "closed", new List<string>());
                }

                node.AddChild(new LightTextNode(line));
                body.AddChild(node);
            }
            Root.AddChild(body);

        }
    }
}

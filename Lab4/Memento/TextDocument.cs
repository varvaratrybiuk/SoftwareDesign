using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocument
    {

        private string Content;
        public TextDocument(string content) => Content = content;

        public void AddContent(string newContent) => Content += newContent;
        
        public IDocumentSnapshot Save()
        {
            return new TextDocumentSnapshot(Content);
        }
        public void Restore(IDocumentSnapshot snapshot)
        {
            if (snapshot is TextDocumentSnapshot)
            {
                var memento = (TextDocumentSnapshot)snapshot;
                Content = memento.GetContent();
            }
            else
            {
                throw new ArgumentException("The snapshot is not of type TextDocumentSnapshot");
            }
        }
        public override string ToString()
        {
            return "Document now: " + Content;
        }
    }
}

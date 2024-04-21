using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocumentSnapshot : IDocumentSnapshot
    {
        private string Content;
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime Date { get; } = DateTime.Now;
        public TextDocumentSnapshot(string content) => Content = content;
        public void Restore(string content)
        {
            Content = content;
        }
        public string GetContent()
        {
            return Content;
        }
       
    }
}

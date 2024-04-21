using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private TextDocument _document;
        private List<IDocumentSnapshot> _documentHistory = new List<IDocumentSnapshot>();
        public TextEditor(TextDocument document) => _document = document;
        public void Save() => this._documentHistory.Add(_document.Save());

        public void Undo()
        {
            var snapshot = _documentHistory.LastOrDefault();
            if (snapshot != null)
            {
                _document.Restore(snapshot);
                _documentHistory.Remove(snapshot);
            }
            
        }
        public void DocumentHistory()
        {
            foreach (var item in _documentHistory)
            {
                Console.WriteLine($"Id: {item.Id}, Date: {item.Date}");
            }
        }
      

    }
}

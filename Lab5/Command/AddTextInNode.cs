using Composite;
using System.Linq;

namespace Command
{
    public class AddTextInNode : ICommand
    {
        private LightElementNode _lastNode;
        private LightTextNode _lastmessage;
        public AddTextInNode(LightElementNode lastNode, string lastmessage)
        {
            this._lastNode = lastNode;
            this._lastmessage = new LightTextNode(lastmessage);
        }
        public void Execute()
        {
            if (_lastmessage != null)
            {
               _lastNode.AddChild(_lastmessage);
            }
        }
        public void Undo()
        {
            if (_lastmessage != null && _lastNode != null)
            {
                _lastNode.RemoveChild(_lastmessage);
            }
        }
    }
}

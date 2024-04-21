using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strategy
{
    public class Image
    {
        private ILoadType _loader;
        private string pattern = @"\b(?:https?|ftp):\/\/[-A-Z0-9+&@#\/%?=~_|!:,.;]*[A-Z0-9+&@#\/%=~_|]";
        private void SetStrategy(ILoadType loader)
        {
            this._loader = loader;
        }
        public void LoadImg(string href)
        {
            
            bool isMatch = Regex.IsMatch(href, pattern, RegexOptions.IgnoreCase);
            SetStrategy(isMatch ? new Network() : new FileSystem());
            this._loader.Load(href);
        }
    }
}

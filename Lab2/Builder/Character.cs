using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string? Name { get; set; }
        public string? Appearance { get; set; }
        public List<string> Clothes { get; set; } = new List<string>();
        public List<string> Inventory { get; set; } = new List<string>();
        public bool? Good { get; set; }
        public List<string> Tasks { get; set; } = new List<string>();
        public Character AddTasks(string task)
        {
            Tasks.Add(task);
            return this;
        }
    }
}

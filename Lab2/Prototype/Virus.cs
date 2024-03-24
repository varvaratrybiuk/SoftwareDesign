namespace Prototype
{
    public class Virus : IClone
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(int weight, int age, string name, string type, Virus child)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children.Add(child);
        }
        public Virus(Virus virus)
        {
            Weight = virus.Weight;
            Age = virus.Age;
            Name = virus.Name;
            Type = virus.Type;
            Children = new List<Virus>(virus.Children);
        }
        public IClone Clone()
        {
            return new Virus(this);
        }
    }
}

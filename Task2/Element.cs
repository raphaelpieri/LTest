namespace Task2
{
    public class Element
    {
        public int Num { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Element(int num, string name, int age)
        {
            Num = num;
            Name = name;
            Age = age;
        }
    }
}

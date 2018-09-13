using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class ElementService : IElementService
    {
        public ICollection<Element> GetElement(ICollection<Element> elements)
        {
            return elements
                .GroupBy(g => g.Num)
                .Select(x => x.First())
                .Where(x => x.Age > 20).ToList();
        }
    }
}

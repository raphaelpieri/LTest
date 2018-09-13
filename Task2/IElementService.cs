using System.Collections.Generic;

namespace Task2
{
    public interface IElementService
    {
        ICollection<Element> GetElement(ICollection<Element> elements);
    }
}

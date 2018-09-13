using System.Collections.Generic;
using Task2;
using Xunit;

namespace Task2Test
{
    public class ElementServiceUnitTest
    {
        private readonly IElementService service;
        public ElementServiceUnitTest()
        {
            service = new ElementService();
        }

        [Fact]
        public void ElementService_PassCollectionWithDistinctValuesAndAllElementsHaveAgeIsGreaterThan20_ShouldReturn3Elements()
        {
            var collection = new List<Element>()
            {
                CreateNewElement(1,"Raphael", 30),
                CreateNewElement(2,"Rodrigo", 22),
                CreateNewElement(3, "Arthur", 40)
            };

            var newCollection = service.GetElement(collection);
            Assert.Equal(3, newCollection.Count);
        }

        [Fact]
        public void ElementService_PassCollectionWithAnyValuesAreEqualAndAllElementsHaveAgeAreGreaterThan20_ShouldReturn2Elements()
        {
            var collection = new List<Element>()
            {
                CreateNewElement(1,"Raphael", 30),
                CreateNewElement(2,"Rodrigo", 22),
                CreateNewElement(2, "Arthur", 40)
            };

            var newCollection = service.GetElement(collection);
            Assert.Equal(2, newCollection.Count);
        }

        [Fact]
        public void ElementService_PassCollectionWithAnyValuesAreEqualAndAnyElementsHaveAgeAreLessThan20_ShouldReturn2Elements()
        {
            var collection = new List<Element>()
            {
                CreateNewElement(1,"Raphael", 30),
                CreateNewElement(2,"Rodrigo", 22),
                CreateNewElement(2, "Arthur", 40),
                CreateNewElement(3, "João", 10)
            };

            var newCollection = service.GetElement(collection);
            Assert.Equal(2, newCollection.Count);
        }

        [Fact]
        public void ElementService_PassCollectionWithDistinctValuesAndAnyElementsHaveAgeAreLessThan20_ShouldReturn1Elements()
        {
            var collection = new List<Element>()
            {
                CreateNewElement(1,"Raphael", 30),
                CreateNewElement(2,"Rodrigo", 12),
                CreateNewElement(3, "Arthur", 5)
            };

            var newCollection = service.GetElement(collection);
            Assert.Equal(1, newCollection.Count);
        }

        private Element CreateNewElement(int num, string name, int age) => new Element(num, name, age);

    }
}

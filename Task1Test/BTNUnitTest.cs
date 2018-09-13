using System;
using Task1;
using Xunit;

namespace Task1Test
{
    public class BTNUnitTest
    {
        [Fact]
        public void BTN_CompareTwoObjectWithDifferentType_ShouldReturnFalse()
        {
            var obj1 = new BTN(1, null, null);
            var obj2 = "Teste";

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectWithDifferentValue_ShouldReturnFalse()
        {
            var obj1 = new BTN(1, null, null);
            var obj2 = new BTN(2, null, null);

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectsThat1ObjectHasNullLeftValueAnd2ObjectHasLeftValue_ShouldReturnFalse()
        {
            var left = new BTN(1, null, null);
            var obj1 = new BTN(1, null, null);
            var obj2 = new BTN(1, left, null);

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectsThat1ObjectHasLeftValueAnd2ObjectHasNullValueLeft_ShouldReturnFalse()
        {
            var left = new BTN(1, null, null);
            var obj1 = new BTN(1, left, null);
            var obj2 = new BTN(1, null, null);

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectsThat1ObjectHasNullRightValueAnd2ObjectHasRightValue_ShouldReturnFalse()
        {
            var right = new BTN(1, null, null);
            var obj1 = new BTN(1, null, null);
            var obj2 = new BTN(1, null, right);

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectsThat1ObjectHasRightValueAnd2ObjectHasNullValueRight_ShouldReturnFalse()
        {
            var right = new BTN(1, null, null);
            var obj1 = new BTN(1, null, right);
            var obj2 = new BTN(1, null, null);

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectsThatBothRightAndLeftAreNull_ShouldReturnTrue()
        {
            var obj1 = new BTN(1, null, null);
            var obj2 = new BTN(1, null, null);

            Assert.True(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectWithValueButLeftValueIsDifferent_ShouldReturnFalse()
        {
            var left1 = new BTN(2, null, null);
            var left2 = new BTN(3, null, null);
            var obj1 = new BTN(1, left1, null);
            var obj2 = new BTN(1, left2, null);

            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectWithValueButRightValueIsDifferent_ShouldReturnFalse()
        {
            var right1 = new BTN(2, null, null);
            var right2 = new BTN(3, null, null);
            var obj1 = new BTN(1, null, right1);
            var obj2 = new BTN(1, null, right2);
            Assert.False(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectWithValueButLeftValueIsEqual_ShouldReturnTrue()
        {
            var left1 = new BTN(2, null, null);
            var left2 = new BTN(2, null, null);
            var obj1 = new BTN(1, left1, null);
            var obj2 = new BTN(1, left2, null);

            Assert.True(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectWithValueButRightValueIsEqual_ShouldReturnTrue()
        {
            var right1 = new BTN(2, null, null);
            var right2 = new BTN(2, null, null);
            var obj1 = new BTN(1, null, right1);
            var obj2 = new BTN(1, null, right2);

            Assert.True(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectWithValueAndBothLeftAndRightValuesAreEqual_ShouldReturnTrue()
        {
            var left1 = new BTN(3, null, null);
            var left2 = new BTN(3, null, null);
            var right1 = new BTN(2, null, null);
            var right2 = new BTN(2, null, null);
            var obj1 = new BTN(1, left1, right1);
            var obj2 = new BTN(1, left2, right2);

            Assert.True(obj1.Equals(obj2));
        }

        [Fact]
        public void BTN_CompareTwoObjectHaveManyLevelsEqual_ShouldReturnTrue()
        {
            var left1_3 = new BTN(20, null, null);
            var right2_3 = new BTN(20, null, null);

            var left1_1 = new BTN(10, left1_3, right2_3);
            var right2_2 = new BTN(10, left1_3, right2_3);

            var left1 = new BTN(3, left1_1, right2_2);
            var left2 = new BTN(3, left1_1, right2_2);
            var right1 = new BTN(2, left1_1, right2_2);
            var right2 = new BTN(2, left1_1, right2_2);
            var obj1 = new BTN(1, left1, right1);
            var obj2 = new BTN(1, left2, right2);

            Assert.True(obj1.Equals(obj2));
        }

    }
}

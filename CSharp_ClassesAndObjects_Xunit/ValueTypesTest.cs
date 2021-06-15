using System;
using Xunit;
namespace CSharp_ClassesAndObjects_Xunit
{
    public class ValueTypesTest
    {
        // values types are constructed by strucs


        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }
    }
}

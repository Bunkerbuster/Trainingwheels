using System;
using System.Reflection.Metadata;
using Xunit;

namespace CSharp_ClassesAndObjects_Xunit
{
    public class StringValues
    {
        // een string kan niet muteren als deze eenmaal gedefinieerd is
        // dus als je een string  een waarde geeft en deze
        // wil je veranderen door bv een uppercase van te maken
        // dan blijft deze onveranderd indien je dit niet aanpast, 
        // het eindresultaat veranderd.

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            var upper = MakeUpperCase(name);

            Assert.Equal("Scott", name);
            Assert.Equal("SCOTT", upper);
        }

        private string MakeUpperCase(string parameter)
        {
            return parameter.ToUpper();
        }
    }
}

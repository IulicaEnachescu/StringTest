using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringReverse;
using NUnit.Framework;

namespace StringReverseTest
{
    [TestFixture]
    public class Class1
    {
        
        [Test]
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        public void Should_Reverse_A_Valid_String(string input, string expected)
        {
            //arrange
            //string input = "ab-cd";
            //string expected = "dc-ba";

            //act
            string actual = Program.ReverseString(input);

            //assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Should_Throw_Exception_When_Empty()
        {//arrange
            string input = null;
            //act

            //assert
            Assert.Throws<ArgumentException>(() => Program.ReverseString(input));

        }
       

    }
}

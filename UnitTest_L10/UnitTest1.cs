using ClassMassiv8;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_L10
{
    [TestClass]
    public class UnitTest1
    {
        [Fact]
        public void UnTest1()
        {
            int[] massTest1 = new int[] { 62, 193, -59, 0, 31 };
            int expected = 193;

            Massiv masTesting = new Massiv(massTest1);
            int actual = masTesting.maxNumberOfMas(massTest1);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }
        
        [Fact]
        public void UnTest2()
        {
            int[] massTest1 = new int[] { 0, 0, 0, 0, 0 };
            int expected = 0;

            Massiv masTesting = new Massiv(massTest1);
            int actual = masTesting.maxNumberOfMas(massTest1);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Fact]
        public void UnTest3()
        {
            int[] massTest1 = new int[] { 62, 193, -59, 0, 31 };
            int expected = 193;
            int sIndex = 1;
            int eIndex = 1;

            Massiv masTesting = new Massiv(massTest1);
            int actual = masTesting.MaxNumberOfMas(sIndex, eIndex);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }

        [Fact]
        public void UnTest4()
        {
            int[] massTest1 = new int[] { 0, 402, -312, 0, 31 };
            int expected = 402; 
            int sIndex = 1;
            int eIndex = 2;
            Massiv masTesting = new Massiv(massTest1);
            int actual = masTesting.maxNumberOfMas(massTest1);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, actual);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodPlus()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(3.14, 5396.4895, "plus");
            double expected = 5399.6295;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMethodMinus()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(8000, 1563.111, "minus");
            double expected = 6436.889;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethodMul()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(60, 2.85, "multiple");
            double expected = 171;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethodDiv()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(15698.5, 50.125, "divide");
            double expected = 313.18703241895261845386533665835;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethodExp()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(11.5, 2, "exp");
            double expected = 132.25;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethodFac()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(20, 0, "fac");
            double expected = 2432902008176640000;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethodSqrt()
        {
            ClassLibrary1.Class1 obj = new ClassLibrary1.Class1();
            double actual = obj.Function(256, 0, "sqrt");
            double expected = 16;
            Assert.AreEqual(actual, expected);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace mathematicFunctionsXUnit
{
    public class tests
    {
        [Fact]
        public void minTest()
        {
            mathFuncs func = new mathFuncs() {a=4, b=8};
            double expected = 4;
            double result = func.min();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void maxTest()
        {
            mathFuncs func = new mathFuncs() { a = 4, b = 8 };
            double expected = 8;
            double result = func.max();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void minArrTest()
        {
            mathFuncs func = new mathFuncs() { c = new double[] { 4, 5, 6, 7, 8 } };
            double expected = 4;
            double result = func.minArr();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void maxArrTest()
        {
            mathFuncs func = new mathFuncs() { c = new double[] {4,5,6,7,8} };
            double expected = 8;
            double result = func.maxArr();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void sumTest()
        {
            mathFuncs func = new mathFuncs() { c = new double[] { 4, 5, 6, 7, 8 } };
            double expected = 30;
            double result = func.sum();

            Assert.Equal(expected, result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace testynumero6586785697599698579
{
    public class testy
    {
        [Fact]
        public void poleTest() {
            funkcje funkcja = new funkcje() { a = 5, b = 7, c = 10 };
            double expected = 11;
            double result = funkcja.pole();

            Assert.Equal(expected, result); 
        }

        [Fact]
        public void obwodTest()
        {
            funkcje funkcja = new funkcje() { a = 5, b = 10, c = 15 };
            double expected = 30;
            double result = funkcja.obwod();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void czyMoznaTest()
        {
            funkcje funkcja = new funkcje() { a = 3, b = 4, c = 5 };
            bool expected = true;
            bool result = funkcja.czyMozna();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void czyRownobocnzyTest()
        {
            funkcje funkcja = new funkcje() { a = 3, b = 4, c = 5 };
            bool expected = false;
            bool result = funkcja.czyRownoboczny();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void czyRownoramiennyTest()
        {
            funkcje funkcja = new funkcje() { a = 3, b = 4, c = 5 };
            bool expected = false;
            bool result = funkcja.czyRownoramienny();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void czyProstokatnyTest()
        {
            funkcje funkcja = new funkcje() { a = 3, b = 4, c = 5 };
            bool expected = true;
            bool result = funkcja.czyProstokatny();

            Assert.Equal(expected, result);
        }
    }
}

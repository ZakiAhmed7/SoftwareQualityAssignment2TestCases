using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestCase
{
    public class Class1 {
        // Test case for Equal lateral triangle
        [Test]
        public void equalLaterailTriangle()
        {
            // Assign
            var angle1 = 60;
            var angle2 = 60;
            var angle3 = 60;
            //Act

            //Assert
            String expected = "Equilateral triangle";
            
            string actual = Triangle.AnalyzeTriangle(angle1, angle2, angle3);
            Assert.That(expected, Is.EqualTo(actual));
        }
        // Test case for Isosceles triangle
        [TestCase(5, 5, 7)]
        [TestCase(7, 5, 5)]
        [TestCase(5, 7, 5)]
        public void validIsoscelesTriangle(int x, int y, int z) {

            string actual = Triangle.AnalyzeTriangle(x, y, z);

            Assert.That("Isosceles triangle", Is.EqualTo(actual));
        }
        // Test case for valid triangle
        [TestCase(0, 5, 7)]
        [TestCase(7, 0, 5)]
        [TestCase(5, 7, 0)]
        public void validTriangle(int x, int y, int z)
        {

            string actual = Triangle.AnalyzeTriangle(x, y, z);

            Assert.That("Invalid Triangle - a zero has been detected", Is.EqualTo(actual));
        }
        // Test case for some Invaild use cases triangle
        [TestCase(-1, 5, 7)]
        [TestCase(7, -1, 5)]
        [TestCase(5, 7, -1)]
        public void checkForInvalidTriangle(int x, int y, int z)
        {

            string actual = Triangle.AnalyzeTriangle(x, y, z);

            Assert.That("INVALID!!", Is.EqualTo(actual));
        }

        // Test case for scalence triangle
        [TestCase(3, 4, 5)]
        [TestCase(10, 9, 8)]
        [TestCase(8, 15, 17)]
        [TestCase(7, 10, 12)]
        [TestCase(8, 11, 13)]
        public void validScaleneTriangle(int x, int y, int z)
        {

            string actual = Triangle.AnalyzeTriangle(x, y, z);

            Assert.That("Scalene triangle", Is.EqualTo(actual));
        }
    }


}

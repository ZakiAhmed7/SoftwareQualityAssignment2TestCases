using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;

namespace TestCase
{
    public class Class1 {

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

        
    }


}

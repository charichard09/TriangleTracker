// Create a method in the Triangle class that takes these 3 numbers and returns what type of triangle (if any) they form:
// If any side is longer than the other two sides combined, the lengths cannot form a triangle. For example, 2, 2, and 8 does not make a triangle. Make sure to account for this.
// Equilateral: All sides are equal;
// Isosceles: Exactly 2 sides are equal;
// Scalene: No sides are equal.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace Shapes.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsNotATriangle_Takes3Inputs_Our3Inputs()
    {
      Triangle testTriangle = new Triangle(1, 2, 3);

      Assert.AreEqual(1, testTriangle.SideA);
      Assert.AreEqual(2, testTriangle.SideB);
      Assert.AreEqual(3, testTriangle.SideC);
    }

    [TestMethod]
    public void TraingleCheck_CheckIfNotATriangle_String()
    {
      Triangle testTriangle = new Triangle(5, 2, 2);

      Assert.AreEqual("not a triangle", testTriangle.TriangleCheck());
  
    }

    [TestMethod]
    public void TriangleCheck_ChecksIfEquilateral_StringYes()
    {
      Triangle testTriangle = new Triangle(2, 2, 2);

      Assert.AreEqual("triangle is Equilateral", testTriangle.TriangleCheck());
    }
  }
}
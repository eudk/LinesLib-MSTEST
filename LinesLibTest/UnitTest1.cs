namespace LinesLibTest;
using LinesLib;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void ToStringTest()
    {
        LinesLib c = new LinesLib() { x1 = 1, y1 = 50 };
        string expected = "1,50";
        string actual = c.ToString();

        Assert.AreEqual(expected, actual);

    }

    [TestMethod]
    public void ContainTest()
    {
        LinesLib c = new LinesLib() { x1 = 1, y1 = 50 };
        bool expected = true;
        bool actual = c.Contain(25);
        Assert.AreEqual(expected, actual);
        Assert.IsFalse(c.Contain(0));
        Assert.IsFalse(c.Contain(51));
        Assert.IsTrue(c.Contain(2));
        Assert.IsTrue(c.Contain(49));
        Assert.IsTrue(c.Contain(1));
        Assert.IsTrue(c.Contain(50));
    }

    [TestMethod]
    public void ContainsTest()
    {
        LinesLib c = new LinesLib() { x1 = 1, y1 = 50 };
        bool expected = true;
        bool actual = c.Contains(25, 40);
        Assert.AreEqual(expected, actual);
        Assert.IsFalse(c.Contains(0, 0));
        Assert.IsFalse(c.Contains(1, 51));
        Assert.IsFalse(c.Contains(0, 50));
        Assert.IsTrue(c.Contains(1, 50));
    }

    [TestMethod]
    public void EqualTest()
    {
        LinesLib c = new LinesLib() { x1 = 1, y1 = 49 };
        LinesLib line50 = new LinesLib() { x1 = 1, y1 = 50 };
        Assert.IsFalse(c.Equals(line50));
        Assert.IsFalse(c.Equals(""));
        Assert.IsFalse(c.Equals(0));
        Assert.IsFalse(c.Equals(null));
        // Assert.AreEqual(c ,line50);
        Assert.IsFalse(c.Equals(line50));
        LinesLib line57 = new LinesLib() { x1 = 23, y1 = 50 };
        Assert.IsFalse(c.Equals(line57));
    }
    [TestMethod]
    public void LineSegmentTest()
    {
        LinesLib line38 = new LinesLib() { x1 = 3, y1 = 8 };
        LinesLib line15 = new LinesLib() { x1 = 1, y1 = 5 };
        LinesLib line1023 = new LinesLib() { x1 = 10, y1 = 23 };

        LinesLib line35 = line38.Intersection(line15);
        Assert.AreEqual(3, line35.x1);
        Assert.AreEqual(5, line35.y1);

        Assert.ThrowsException < ArgumentException > (() => line38.Intersection(line1023));
    }
}

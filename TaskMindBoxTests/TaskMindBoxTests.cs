using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace TaskMindBox
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSquareTest1()
        {
            //arrange
            IFigure circle = new Circle(10);
            //act
            var result = circle.GetSquare();
            //assert
            Assert.AreEqual(314, result);
        }

        [Test]
        public void GetSquareTest2()
        {
            //arrange
            IFigure circle = new Circle(5);
            //act
            var result = circle.GetSquare();
            //assert
            Assert.AreEqual(78.5, result);
        }

        [Test]
        public void GetSquareTest3()
        {
            //arrange
            IFigure triang = new Triang(30, 30, 52);
            //act
            var result = triang.GetSquare();
            //assert
            Assert.AreEqual(389.132, result);
        }

        [Test]
        public void GetSquareTest4()
        {
            //arrange
            IFigure triang = new Triang(4.5, 6, 7.5);
            //act
            var result = triang.GetSquare();
            //assert
            Assert.AreEqual(13.5, result);
        }

        [Test]
        public void GetSquareTest5()
        {
            //arrange
            IFigure triang = new Triang(40, 40, 40);
            //act
            var result = triang.GetSquare();
            //assert
            Assert.AreEqual(692.820, result);
        }

        [Test]
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetSquareTest6()
        {
            //arrange
            IFigure triang = new Triang(40, 40, 30);
            //act
            var result = triang.GetSquare();
            //assert
        }


        [Test]
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetSquareTest7()
        {
            //arrange
            IFigure triang = new Triang(40, 30, 40);
            //act
            var result = triang.GetSquare();
            //assert
        }

        [Test]
        [ExpectedException(typeof(System.ArgumentException))]
        public void GetSquareTest8()
        {
            //arrange
            IFigure triang = new Triang(30, 40, 40);
            //act
            var result = triang.GetSquare();
            //assert
        }
    }
}
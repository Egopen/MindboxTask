using FigureLib.Exceptions;
using FigureLib.Figures;
using FigureSpace;

namespace LibTest
{
    public class AreaCounterTests
    {
        [Fact]
        public void CircleTest()
        {
            //Arrange
            Circle circle = new Circle(10);
            //Act
            double S=AreaCounter.Count(circle);
            //Assert
            Assert.Equal(98.7,S,2);
        }
        [Fact]
        public void WrongTriangleThrowsExc()
        {
            //Assert
            Assert.Throws<WrongDataForFigureExc>(() =>
            {
                Triangle triangle = new Triangle(1, 1, 4);
            });
        }
        [Fact]
        public void WrongCircleThrowsExc()
        {
            //Assert
            Assert.Throws<WrongDataForFigureExc>(() =>
            {
                Circle c = new Circle(0);
            });
        }
        [Fact]
        public void DefaultTriangleTest()
        {
            //Arrange
            Triangle triangle = new Triangle(13, 19, 8);
            //Act
            double S=AreaCounter.Count(triangle);
            //Assert
            Assert.Equal(41, S,0);
        }
        [Fact]
        public void RectangularTriangleTest()
        {
            //Arrange
            Triangle rectangulartriangle = new Triangle(5,12,13);
            //Act
            double S = AreaCounter.Count(rectangulartriangle);
            //Assert
            Assert.Equal(30, S);
        }
        [Fact]
        public void NullTest()
        {
            //Arrange
            //Act
            double S = AreaCounter.Count(null);
            //Assert
            Assert.Equal(0,S);
        }
    }
}

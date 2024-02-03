using JANCAssignment2;

namespace JANCAssignment2Tests
{
    public class RectangleTests
    {
        private Rectangle _rectangle { get; set; } = null;

        [SetUp]
        public void SetUp()
        {
            _rectangle = new Rectangle(4, 5);
        }

        [Test]
        public void GetLength_EqualsTest()
        {
            // Assign 
            int expectedLength = 4;

            // Act
            int length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(expectedLength,  length); 


        }

        [Test]
        public void GetLength_PositiveTest()
        {
            //Assign
            int expectedLength = 4;

            // Act
            int length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(true, length > 0); 
        }

        [Test]
        public void GetLength_NotZero()
        {
            //Assign
            int expectedLength = 4;

            // Act
            int length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(true, length != 0);
        }

        [Test]
        public void SetLength_EqualsTest()
        {
            // Arrange
            int expectedLength = 6;

            // Act
            int length = _rectangle.SetLength(6);

            // Assert
            Assert.AreEqual(expectedLength, length); 
        }

        [Test]
        public void SetLength_PositiveTest()
        {
            // Arrange
            int expectedLength = 6;

            // Act
            int length = _rectangle.SetLength(6);

            // Assert
            Assert.AreEqual(true, length > 0);
        }

        [Test]
        public void SetLength_NotZero()
        {
            // Arrange
            int expectedLength = 6;

            // Act
            int length = _rectangle.SetLength(6);

            // Assert
            Assert.AreEqual(true, length != 0); 
        }

        [Test]
        public void GetWidth_EqualsTest()
        {
            // Arrange
            int expectedWidth = 5;

            // Act
            int width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(expectedWidth, width); 
        }

        [Test]
        public void GetWidth_PositiveTest()
        {
            // Arrange
            int expectedWidth = 6;

            // Act
            int width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(true, width > 0); 
        }

        [Test]
        public void GetWidth_NotZeroTest()
        {
            // Arrange
            int expectedWidth = 6;

            // Act
            int width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(true, width !=0); 
        }

        [Test]
        public void SetWidth_EqualsTest()
        {
            // Arrange
            int expectedWidth = 7;

            // Act
            int width = _rectangle.SetWidth(7);

            // Assert
            Assert.AreEqual(expectedWidth, width);
        }

        [Test]
        public void SetWidth_PositiveTest()
        {
            // Arrange
            int expectedWidth = 7;

            // Act
            int width = _rectangle.SetWidth(7);

            // Assert
            Assert.AreEqual(true, width > 0);
        }

        [Test]
        public void SetWidth_NotZeroTest()
        {
            // Arrange
            int expectedWidth = 7;

            // Act
            int width = _rectangle.SetWidth(7);

            // Assert
            Assert.AreEqual(true, width !=0);
        }

        [Test]
        public void GetPerimeter_EqualsTest()
        {
            // Assign
            int expectedPermimeter = 18;

            // Act
            int perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(expectedPermimeter, perimeter);
        }

        [Test]
        public void GetPerimeter_PositiveTest()
        {
            // Assign
            int expectedPermimeter = 18;

            // Act
            int perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(true, perimeter > 0);
        }

        [Test]
        public void GetPerimeter_NotZeroTest()
        {
            // Assign
            int expectedPermimeter = 18;

            // Act
            int perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(true, perimeter != 0);
        }

        [Test]
        public void GetArea_EqualsTest()
        {
            // Assign
            int expectedPermimeter = 20;

            // Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(expectedPermimeter, area);
        }

        [Test]
        public void GetArea_PositiveTest()
        {
            // Assign
            int expectedPermimeter = 20;

            // Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(true, area >0);
        }

        [Test]
        public void GetArea_NotZeroTest()
        {
            // Assign
            int expectedPermimeter = 20;

            // Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(true, area != 0);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Reversi
{
    public class AIUnitTest {
        public static readonly int N = 8;
        public static readonly int N_temp = N/2;
        public static Board B_White = new Board(8);
        public static Board B_Black = new Board(8);

        static AIUnitTest(){
            B_Black.PlaceDisk(new Vector(N_temp - 2, N_temp), false, true);
            B_White.PlaceDisk(new Vector(N_temp - 2, N_temp - 1), true, true);
        }

        [Fact]
        public void AIMove_VevtorMove_CalculatedCorrectly() {
            // Arrange
            Vector expected = new Vector(N_temp - 3, N_temp);

            // Act
            Vector AImove = B_Black.AINextMove(true);

            // Assert
            Assert.Equal(expected, AImove);
        }

        [Fact]
        public void AddNumbers_Test() {
            int a = 10;
            int b = 20;
            int expected = 30;

            int result = Eredmeny.AddNumbers(10, 20);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(true,4 - 3, 4)]
        [InlineData(false, 4 - 3, 3)]
        public void AIMove_Vector_WithInLineData(bool WhiteMove, int expected_y, int expected_x) {
            // Arrange
            Board board = WhiteMove ? B_Black : B_White;
            Vector expected = new Vector(expected_y, expected_x);

            // Act
            Vector actual = board.AINextMove(WhiteMove);
            

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}

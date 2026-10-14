namespace Lab3test
{
    [TestClass]
    public sealed class BlueTest
    {
        Lab3.Blue _main = new Lab3.Blue();

        [TestMethod]
        public void Test5()
        {
            // Arrange
            var input = new int[,] {
                { 0, 1, 2, 3, 5, 10, 10, 10, 12, 25 },
                { 0, 1, 2, 3, 5, 10, 10, 10, 12, 25 },
                { 0, 1, 2, 3, 5, 10, 10, 10, 12, 25 },
                { 0, 1, 2, 3, 5,  1,  2,  3,  1,  0 }
            };
            var answer = new (int, int, int)[] {
                (0, 0, 0),
                (11, 1, 0),
                (0, 7, 0),
                (13, 3, 0),
                (0, 5, 12),
                (20, 10, 5),
                (5, 15, 5),
                (20, 10, 5),
                (22, 12, 7),
                (25, 25, 25)
            };
            var test = new (int, int, int)[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[0, i], input[1, i], input[2, i], input[3, i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i]);
            }
        }
    }
}

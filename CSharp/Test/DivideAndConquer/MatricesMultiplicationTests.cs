using System.Text;
using Algorithm.DivideAndConquer;
using Xunit.Abstractions;

namespace TestProject1.DivideAndConquer;

public class MatricesMultiplicationTests(ITestOutputHelper testOutputHelper)
{
    [Fact]
    public void MultiplyTest()
    {
        int[,] matrixA =
        {
            {1, 1, 1, 1}, 
            {2, 2, 2, 2},
            {3, 3, 3, 3},
            {4, 4, 4, 4},
        };
        int[,] matrixB =
        {
            {1, 1, 1, 1}, 
            {2, 2, 2, 2},
            {3, 3, 3, 3},
            {4, 4, 4, 4},
        };
        int[,] expected =
        {
            {10, 10, 10, 10}, 
            {20, 20, 20, 20},
            {30, 30, 30, 30},
            {40, 40, 40, 40},
        };
        
        var matrixC = new int[4, 4];
        new MatricesMultiplication().Multiply(matrixA, matrixB, matrixC, 4);
        
        Assert.Equal(matrixC, expected);


        var sb = new StringBuilder();
        for (var i = 0; i < matrixC.GetLength(0); i++)
        {
            for (var j = 0; j < matrixC.GetLength(1); j++)
            {
                if (j != 0)
                {
                    sb.Append(',');
                }
                sb.Append(matrixC[i, j]);
            }
            sb.AppendLine();
        }
        testOutputHelper.WriteLine(sb.ToString());
    }
    
    [Fact]
    public void MultiplyArray()
    {
        int[,] matrixA =
        {
            {1, 1, 1, 1}, 
            {2, 2, 2, 2},
            {3, 3, 3, 3},
            {4, 4, 4, 4},
        };
        int[,] matrixB =
        {
            {1, 1, 1, 1}, 
            {2, 2, 2, 2},
            {3, 3, 3, 3},
            {4, 4, 4, 4},
        };
        int[,] expected =
        {
            {10, 10, 10, 10}, 
            {20, 20, 20, 20},
            {30, 30, 30, 30},
            {40, 40, 40, 40},
        };
        
        var matrixC = new int[4, 4];
        new MatricesMultiplication().MultiplyArray(
            matrixA, 0, 0,
            matrixB, 0, 0,
            matrixC, 0, 0,
            4);
        
        Assert.Equal(matrixC, expected);


        var sb = new StringBuilder();
        for (var i = 0; i < matrixC.GetLength(0); i++)
        {
            for (var j = 0; j < matrixC.GetLength(1); j++)
            {
                if (j != 0)
                {
                    sb.Append(',');
                }
                sb.Append(matrixC[i, j]);
            }
            sb.AppendLine();
        }
        testOutputHelper.WriteLine(sb.ToString());
    }
    
    [Fact]
    public void StrassenMultiplyTest()
    {
        int[,] matrixA =
        {
            {1, 1, 1, 1}, 
            {2, 2, 2, 2},
            {3, 3, 3, 3},
            {4, 4, 4, 4},
        };
        int[,] matrixB =
        {
            {1, 1, 1, 1}, 
            {2, 2, 2, 2},
            {3, 3, 3, 3},
            {4, 4, 4, 4},
        };
        int[,] expected =
        {
            {10, 10, 10, 10}, 
            {20, 20, 20, 20},
            {30, 30, 30, 30},
            {40, 40, 40, 40},
        };
        
        var matrixC = new int[4, 4];
        new MatricesMultiplication().StrassenMultiply(matrixA, matrixB, matrixC, 4);
        
        Assert.Equal(matrixC, expected);


        var sb = new StringBuilder();
        for (var i = 0; i < matrixC.GetLength(0); i++)
        {
            for (var j = 0; j < matrixC.GetLength(1); j++)
            {
                if (j != 0)
                {
                    sb.Append(',');
                }
                sb.Append(matrixC[i, j]);
            }
            sb.AppendLine();
        }
        testOutputHelper.WriteLine(sb.ToString());
    }
}
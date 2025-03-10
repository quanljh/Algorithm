using CommunityToolkit.HighPerformance;

namespace Algorithm.DivideAndConquer;

public class MatricesMultiplication
{
    /// <summary>
    /// C = A * B, A and B is n x n matrices 
    /// </summary>
    public void Multiply(Span2D<int> matrixA, Span2D<int> matrixB, Span2D<int> matrixC, int n)
    {
        // Base case
        if (n == 1)
        {
            matrixC[0, 0] += matrixA[0, 0] * matrixB[0, 0];
            return;
        }
        
        // Divide
        // Partition A, B, and C into n / 2 x n / 2 sub-matrices
        var matrixA11 = matrixA[0..(n / 2), 0..(n / 2)];
        var matrixA12 = matrixA[0..(n / 2), (n / 2)..n];
        var matrixA21 = matrixA[(n / 2)..n, 0..(n / 2)];
        var matrixA22 = matrixA[(n / 2)..n, (n / 2)..n];
        var matrixB11 = matrixB[0..(n / 2), 0..(n / 2)];
        var matrixB12 = matrixB[0..(n / 2), (n / 2)..n];
        var matrixB21 = matrixB[(n / 2)..n, 0..(n / 2)];
        var matrixB22 = matrixB[(n / 2)..n, (n / 2)..n];
        var matrixC11 = matrixC[0..(n / 2), 0..(n / 2)];
        var matrixC12 = matrixC[0..(n / 2), (n / 2)..n];
        var matrixC21 = matrixC[(n / 2)..n, 0..(n / 2)];
        var matrixC22 = matrixC[(n / 2)..n, (n / 2)..n];
        
        // C11 = A11 * B11 + A12 * B21
        // C12 = A11 * B12 + A12 * B22
        // C21 = A21 * B11 + A22 * B21
        // C22 = A21 * B12 + A22 * B22
        Multiply(matrixA11, matrixB11, matrixC11, n / 2);
        Multiply(matrixA11, matrixB12, matrixC12, n / 2);
        Multiply(matrixA21, matrixB11, matrixC21, n / 2);
        Multiply(matrixA21, matrixB12, matrixC22, n / 2);
        Multiply(matrixA12, matrixB21, matrixC11, n / 2);
        Multiply(matrixA12, matrixB22, matrixC12, n / 2);
        Multiply(matrixA22, matrixB21, matrixC21, n / 2);
        Multiply(matrixA22, matrixB22, matrixC22, n / 2);
    }
    
    /// <summary>
    /// C = A * B, A and B is n x n matrices 
    /// </summary>
    public void MultiplyArray(
        int[,] matrixA, int aRowStart, int aColumnStart, 
        int[,] matrixB, int bRowStart, int bColumnStart, 
        int[,] matrixC, int cRowStart, int cColumnStart,
        int n)
    {
        // Base case
        if (n == 1)
        {
            matrixC[cRowStart, cColumnStart] += matrixA[aRowStart, aColumnStart] * matrixB[bRowStart, bColumnStart];
            return;
        }
        
        // Divide
        // Partition A, B, and C into n / 2 x n / 2 sub-matrices
        var matrixA11RowStart = aRowStart;
        var matrixA11ColumnStart = aColumnStart;
        var matrixA12RowStart = aRowStart;
        var matrixA12ColumnStart = aColumnStart + n / 2;
        var matrixA21RowStart = aRowStart + n / 2;
        var matrixA21ColumnStart = aColumnStart;
        var matrixA22RowStart = aRowStart + n / 2;
        var matrixA22ColumnStart = aColumnStart + n / 2;
        var matrixB11RowStart = bRowStart;
        var matrixB11ColumnStart = bColumnStart;
        var matrixB12RowStart = bRowStart;
        var matrixB12ColumnStart = bColumnStart + n / 2;
        var matrixB21RowStart = bRowStart + n / 2;
        var matrixB21ColumnStart = bColumnStart;
        var matrixB22RowStart = bRowStart + n / 2;
        var matrixB22ColumnStart = bColumnStart + n / 2;
        var matrixC11RowStart = cRowStart;
        var matrixC11ColumnStart = cColumnStart;
        var matrixC12RowStart = cRowStart;
        var matrixC12ColumnStart = cColumnStart + n / 2;
        var matrixC21RowStart = cRowStart + n / 2;
        var matrixC21ColumnStart = cColumnStart;
        var matrixC22RowStart = cRowStart + n / 2;
        var matrixC22ColumnStart = cColumnStart + n / 2;
        // C11 = A11 * B11 + A12 * B21
        // C12 = A11 * B12 + A12 * B22
        // C21 = A21 * B11 + A22 * B21
        // C22 = A21 * B12 + A22 * B22
        MultiplyArray(
            matrixA, matrixA11RowStart, matrixA11ColumnStart,
            matrixB, matrixB11RowStart, matrixB11ColumnStart,
            matrixC, matrixC11RowStart, matrixC11ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA11RowStart, matrixA11ColumnStart,
            matrixB, matrixB12RowStart, matrixB12ColumnStart,
            matrixC, matrixC12RowStart, matrixC12ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA21RowStart, matrixA21ColumnStart,
            matrixB, matrixB11RowStart, matrixB11ColumnStart,
            matrixC, matrixC21RowStart, matrixC21ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA21RowStart, matrixA21ColumnStart,
            matrixB, matrixB12RowStart, matrixB12ColumnStart,
            matrixC, matrixC22RowStart, matrixC22ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA12RowStart, matrixA12ColumnStart,
            matrixB, matrixB21RowStart, matrixB21ColumnStart,
            matrixC, matrixC11RowStart, matrixC11ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA12RowStart, matrixA12ColumnStart,
            matrixB, matrixB22RowStart, matrixB22ColumnStart,
            matrixC, matrixC12RowStart, matrixC12ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA22RowStart, matrixA22ColumnStart,
            matrixB, matrixB21RowStart, matrixB21ColumnStart,
            matrixC, matrixC21RowStart, matrixC21ColumnStart,
            n / 2);
        MultiplyArray(
            matrixA, matrixA22RowStart, matrixA22ColumnStart,
            matrixB, matrixB22RowStart, matrixB22ColumnStart,
            matrixC, matrixC22RowStart, matrixC22ColumnStart,
            n / 2);
    }
}
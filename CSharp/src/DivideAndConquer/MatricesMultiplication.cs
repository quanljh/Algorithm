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


    public void StrassenMultiply(Span2D<int> matrixA, Span2D<int> matrixB, Span2D<int> matrixC, int n)
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
        
        var matrixS1 = MatrixSubtraction(matrixB12, matrixB22); 
        var matrixS2 = MatrixAddition(matrixA11, matrixA12); 
        var matrixS3 = MatrixAddition(matrixA21, matrixA22); 
        var matrixS4 = MatrixSubtraction(matrixB21, matrixB11); 
        var matrixS5 = MatrixAddition(matrixA11, matrixA22); 
        var matrixS6 = MatrixAddition(matrixB11, matrixB22); 
        var matrixS7 = MatrixSubtraction(matrixA12, matrixA22); 
        var matrixS8 = MatrixAddition(matrixB21, matrixB22); 
        var matrixS9 = MatrixSubtraction(matrixA11, matrixA21); 
        var matrixS10 = MatrixAddition(matrixB11, matrixB12); 
        
        // P1 = A11 * S1 = (A11 * B12 - A11 * B12)
        // P2 = S2 * B22 = (A11 * B22 + A12 * B22)
        // P3 = S3 * B11 = (A21 * B11 + A22 * B11)
        // P4 = A22 * S4 = (A22 * B21 - A22 * B11)
        // P5 = S5 * S6 = (A11 * B11 + A11 * B22 + A22 * B11 + A22 * B22)
        // P6 = S7 * S8 = (A12 * B21 + A12 * B22 - A22 * B21 - A22 * B22)
        // P7 = S9 * S10 = (A11 * B11 + A11 * B12 - A21 * B11 - A21 * B12)
        var p1 = new int[n / 2, n / 2];
        StrassenMultiply(matrixA11, matrixS1, p1, n / 2);
        var p2 = new int[n / 2, n / 2];
        StrassenMultiply(matrixS2, matrixB22, p2, n / 2);
        var p3 = new int[n / 2, n / 2];
        StrassenMultiply(matrixS3, matrixB11, p3, n / 2);
        var p4 = new int[n / 2, n / 2];
        StrassenMultiply(matrixA22, matrixS4, p4, n / 2);
        var p5 = new int[n / 2, n / 2];
        StrassenMultiply(matrixS5, matrixS6, p5, n / 2);
        var p6 = new int[n / 2, n / 2];
        StrassenMultiply(matrixS7, matrixS8, p6, n / 2);
        var p7 = new int[n / 2, n / 2];
        StrassenMultiply(matrixS9, matrixS10, p7, n / 2);
        
        // C11 = C11 + P5 + P4 - P2 + P6 = A11 * B11 + A12 * B21
        // C12 = C12 + P1 + P2 = A11 * B12 + A12 * B22
        // C21 = C21 + P3 + P4 = A21 * B11 + A22 * B21
        // C22 = C22 + P5 + P1 - P3 - P7 = A21 * B12 + A22 * B22
        matrixC11.Add(p5).Add(p4).Subtract(p2).Add(p6);
        matrixC12.Add(p1).Add(p2);
        matrixC21.Add(p3).Add(p4);
        matrixC22.Add(p5).Add(p1).Subtract(p3).Subtract(p7);
    }
    
    private Span2D<int> MatrixAddition(Span2D<int> matrixA, Span2D<int> matrixB)
    {
        var result = new int[matrixA.Width, matrixA.Height];
        for (var i = 0; i < matrixA.Width; i++)
        {
            for (var j = 0; j < matrixA.Height; j++)
            {
                result[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }
        return result;
    }
    
    private Span2D<int> MatrixSubtraction(Span2D<int> matrixA, Span2D<int> matrixB)
    {
        var result = new int[matrixA.Width, matrixA.Height];
        for (var i = 0; i < matrixA.Width; i++)
        {
            for (var j = 0; j < matrixA.Height; j++)
            {
                result[i, j] = matrixA[i, j] - matrixB[i, j];
            }
        }
        return result;
    }
}
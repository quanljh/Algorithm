using CommunityToolkit.HighPerformance;

namespace Algorithm.DivideAndConquer;

public static class Span2DExtensions
{
    public static Span2D<int> Add(this Span2D<int> x, Span2D<int> y)
    {
        for (var i = 0; i < x.Width; i++)
        {
            for (var j = 0; j < x.Height; j++)
            {
                x[i, j] += y[i, j];
            }
        }

        return x;
    }
    
    public static Span2D<int> Subtract(this Span2D<int> x, Span2D<int> y)
    {
        for (var i = 0; i < x.Width; i++)
        {
            for (var j = 0; j < x.Height; j++)
            {
                x[i, j] -= y[i, j];
            }
        }

        return x;
    }
}
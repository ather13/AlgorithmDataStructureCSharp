/// <summary>
/// In linear algebra, the identity matrix, or sometimes ambiguously called a unit matrix, 
/// of size n is the n × n square matrix with ones on the main diagonal and zeros elsewhere.
/// Hint : When we multiple any matrix with identity matrix we should get same matrix back (I.X => X)
/// 2X2 =>  [1,0]
///         [0,1]
/// 3X3 =>  [1,0,0]
///         [0,1,0]
///         [0,0,1]
/// </summary>

namespace AlgonDS
{
    public class IdentityMatrix
    {
        public bool IsIdentityMatrix(int[,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if((i==j && arr[i,j] ==0) || (i!=j && arr[i, j] == 1)){
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}

using System.Numerics;

namespace app
{
    public class CryptoTest
    {
        public double CryptoTestFunction(BigInteger beta, double alpha, BigInteger rho) {
            double resPos = 1.1;
            while(resPos % 1 != 0){
                resPos = BigInteger.Log(beta, alpha);
                beta += rho;
            }
            return resPos;
        }
    }
}
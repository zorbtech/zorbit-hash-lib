using NBitcoin;

namespace ZorbitHashLibTest
{
    public interface IHashProvider
    {
        uint256 Hash(byte[] data);
    }
}
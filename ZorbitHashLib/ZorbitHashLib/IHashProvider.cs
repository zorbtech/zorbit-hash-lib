using NBitcoin;

namespace ZorbitHashLib
{
    public interface IHashProvider
    {
        uint256 Hash(byte[] data);
    }
}
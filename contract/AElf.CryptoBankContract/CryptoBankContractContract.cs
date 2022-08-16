using Google.Protobuf.WellKnownTypes;

namespace AElf.CryptoBankContract
{
    
    public class CryptoBankContractContract : CryptoBankContractContractContainer.CryptoBankContractContractBase
    {
        public override Empty Set(CryptoBankMessage input)
        {
            Assert(asserted: input.Value.Length < 10, message: "CryptoBank message is too  Large.");
            State.CryptoBankMessage.Value = input.Value;
            return new Empty();
        }

        public override CryptoBankMessage Get(Empty input)
        {
            return new CryptoBankMessage
            {
                Value = State.CryptoBankMessage.Value
            };
        }

        // public override int GetHashCode()
        // {
        //     return base.GetHashCode();
        // }
    }
}
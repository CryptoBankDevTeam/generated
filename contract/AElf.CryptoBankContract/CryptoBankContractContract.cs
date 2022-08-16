using AElf.Sdk.CSharp;
using Google.Protobuf.WellKnownTypes;

namespace AElf.CryptoBankContract
{
    
    public class CryptoBankContractContract : CryptoBankContractContractContainer.CryptoBankContractContractBase
    {
        public override Empty Initialize(InitializeInput input)
        {

            Assert(State.Owner.Value == null, "Already initialized.");
            State.TaxPoint.Value = 100;
            State.Owner.Value = input.Owner ?? Context.Sender;

            State.TokenContract.Value =
                Context.GetContractAddressByName(SmartContractConstants.TokenContractSystemName);
            return new Empty();
        }

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
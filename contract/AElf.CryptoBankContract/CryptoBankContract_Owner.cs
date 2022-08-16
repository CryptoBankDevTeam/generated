
using AElf.Sdk.CSharp;
using AElf.Types;
using Google.Protobuf.WellKnownTypes;

namespace AElf.CryptoBankContract
{
    public partial class CryptoBankContract_Owner
    {
        public override Empty ChangeOwner(Address input)
        {
            AssertSenderIsOwner();
            State.Owner.Value = input;
            return new Empty();


        }

        public override Empty SetTaxPoint(Int64Value input)
        {
            AssertSenderIsOwner();
            Assert(input.Value >= 0, "Input value should be positive.");
            Assert(input.Value <= MaxTaxPoint, $"Exceeded max tax point: {MaxTaxPoint}");
            State.TaxPoint.Value = input.Value;
            Context.Fire(new TaxPointChanged
            {
                TaxPoint = input.Value
            });
            return new Empty();
        }

        
    }
}


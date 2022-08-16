using AElf.Sdk.CSharp.State;
using AElf.Types;

namespace AElf.CryptoBankContract
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public class CryptoBankContractContractState : ContractState
    {
        // state definitions go here.
        public SingletonState<string> CryptoBankMessage { get; set; }
        public SingletonState<Address> FeeSetter { get; set; }
        public SingletonState<Address> Owner { get; set; }

        public Int64State TaxPoint { get; set; }
        public MappedState<string, bool> BanMap { get; set; }
        public Int64State Tax { get; set; }
        public SingletonState<Address> TokenContract { get; internal set; }
    }
}
using AElf.Sdk.CSharp.State;

namespace AElf.CryptoBankContract
{
    /// <summary>
    /// The state class of the contract, it inherits from the AElf.Sdk.CSharp.State.ContractState type. 
    /// </summary>
    public class CryptoBankContractContractState : ContractState
    {
        // state definitions go here.
        public SingletonState<string> CryptoBankMessage { get; set; }
    }
}
using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.CryptoBankContract
{
    public class CryptoBankContractContractTestBase : DAppContractTestBase<CryptoBankContractContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal CryptoBankContractContractContainer.CryptoBankContractContractStub GetCryptoBankContractContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<CryptoBankContractContractContainer.CryptoBankContractContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}
using AElf.Sdk.CSharp.State;
using AElf.Types;
using Org.BouncyCastle.Tsp;

namespace AElf.Contracts.DigitalIDContract
{
    public class DigitalIDContractState : ContractState
    {
        public MappedState<Hash, Stuff> Stuffs {get;  set;}
    }
}
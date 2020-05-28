using System.Collections.Generic;
using System.Linq;
using Acs0;
using AElf.OS.Node.Application;
using AElf.Types;

namespace AElf.Blockchains.MainChain
{
    public partial class GenesisSmartContractDtoProvider
    {
        public IEnumerable<GenesisSmartContractDto>GetGenesisSmartContractDtosForDigitalID()
        {
            var l = new List<GenesisSmartContractDto>();
            l.AddGenesisSmartContract(
                _codes.Single(kv => kv.Key.Contains("DigitalID")).Value,
                Hash.FromString("AElf.ContractNames.DigitalID"),
                GenerateDigitalIDInitializationCallList());
            return l;
        }
        
        private SystemContractDeploymentInput.Types.SystemTransactionMethodCallList GenerateDigitalIDInitializationCallList()
        {
            var digitalIDContractMethodCallList = new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList();

            return digitalIDContractMethodCallList;
        }
    }
}
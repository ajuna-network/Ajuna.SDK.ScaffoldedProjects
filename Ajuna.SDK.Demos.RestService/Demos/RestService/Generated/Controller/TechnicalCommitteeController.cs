//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.SDK.Demos.RestService.Generated.Storage;
using Ajuna.ServiceLayer.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// TechnicalCommitteeController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class TechnicalCommitteeController : ControllerBase
    {
        
        private ITechnicalCommitteeStorage _technicalCommitteeStorage;
        
        /// <summary>
        /// TechnicalCommitteeController constructor.
        /// </summary>
        public TechnicalCommitteeController(ITechnicalCommitteeStorage technicalCommitteeStorage)
        {
            _technicalCommitteeStorage = technicalCommitteeStorage;
        }
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        [HttpGet("Proposals")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT14), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.TechnicalCommitteeStorage), "ProposalsParams")]
        public IActionResult GetProposals()
        {
            return this.Ok(_technicalCommitteeStorage.GetProposals());
        }
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        [HttpGet("ProposalOf")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.TechnicalCommitteeStorage), "ProposalOfParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetProposalOf(string key)
        {
            return this.Ok(_technicalCommitteeStorage.GetProposalOf(key));
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        [HttpGet("Voting")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.TechnicalCommitteeStorage), "VotingParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetVoting(string key)
        {
            return this.Ok(_technicalCommitteeStorage.GetVoting(key));
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        [HttpGet("ProposalCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.TechnicalCommitteeStorage), "ProposalCountParams")]
        public IActionResult GetProposalCount()
        {
            return this.Ok(_technicalCommitteeStorage.GetProposalCount());
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.TechnicalCommitteeStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_technicalCommitteeStorage.GetMembers());
        }
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of absentations.
        /// </summary>
        [HttpGet("Prime")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.TechnicalCommitteeStorage), "PrimeParams")]
        public IActionResult GetPrime()
        {
            return this.Ok(_technicalCommitteeStorage.GetPrime());
        }
    }
}

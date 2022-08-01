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
    /// ElectionsController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ElectionsController : ControllerBase
    {
        
        private IElectionsStorage _electionsStorage;
        
        /// <summary>
        /// ElectionsController constructor.
        /// </summary>
        public ElectionsController(IElectionsStorage electionsStorage)
        {
            _electionsStorage = electionsStorage;
        }
        
        /// <summary>
        /// >> Members
        ///  The current elected members.
        /// 
        ///  Invariant: Always sorted based on account id.
        /// </summary>
        [HttpGet("Members")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ElectionsStorage), "MembersParams")]
        public IActionResult GetMembers()
        {
            return this.Ok(_electionsStorage.GetMembers());
        }
        
        /// <summary>
        /// >> RunnersUp
        ///  The current reserved runners-up.
        /// 
        ///  Invariant: Always sorted based on rank (worse to best). Upon removal of a member, the
        ///  last (i.e. _best_) runner-up will be replaced.
        /// </summary>
        [HttpGet("RunnersUp")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ElectionsStorage), "RunnersUpParams")]
        public IActionResult GetRunnersUp()
        {
            return this.Ok(_electionsStorage.GetRunnersUp());
        }
        
        /// <summary>
        /// >> Candidates
        ///  The present candidate list. A current member or runner-up can never enter this vector
        ///  and is always implicitly assumed to be a candidate.
        /// 
        ///  Second element is the deposit.
        /// 
        ///  Invariant: Always sorted based on account id.
        /// </summary>
        [HttpGet("Candidates")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ElectionsStorage), "CandidatesParams")]
        public IActionResult GetCandidates()
        {
            return this.Ok(_electionsStorage.GetCandidates());
        }
        
        /// <summary>
        /// >> ElectionRounds
        ///  The total number of vote rounds that have happened, excluding the upcoming one.
        /// </summary>
        [HttpGet("ElectionRounds")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ElectionsStorage), "ElectionRoundsParams")]
        public IActionResult GetElectionRounds()
        {
            return this.Ok(_electionsStorage.GetElectionRounds());
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes and locked stake of a particular voter.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId` is a crypto hash.
        /// </summary>
        [HttpGet("Voting")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ElectionsStorage), "VotingParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetVoting(string key)
        {
            return this.Ok(_electionsStorage.GetVoting(key));
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// ICouncilStorage interface definition.
    /// </summary>
    public interface ICouncilStorage : IStorage
    {
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT13 GetProposals();
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall GetProposalOf(string key);
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes GetVoting(string key);
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetProposalCount();
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> GetMembers();
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of absentations.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetPrime();
    }
    
    /// <summary>
    /// CouncilStorage class definition.
    /// </summary>
    public sealed class CouncilStorage : ICouncilStorage
    {
        
        /// <summary>
        /// _proposalsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT13> _proposalsTypedStorage;
        
        /// <summary>
        /// _proposalOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall> _proposalOfTypedStorage;
        
        /// <summary>
        /// _votingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes> _votingTypedStorage;
        
        /// <summary>
        /// _proposalCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _proposalCountTypedStorage;
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>> _membersTypedStorage;
        
        /// <summary>
        /// _primeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> _primeTypedStorage;
        
        /// <summary>
        /// CouncilStorage constructor.
        /// </summary>
        public CouncilStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.ProposalsTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT13>("Council.Proposals", storageDataProvider, storageChangeDelegates);
            this.ProposalOfTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall>("Council.ProposalOf", storageDataProvider, storageChangeDelegates);
            this.VotingTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes>("Council.Voting", storageDataProvider, storageChangeDelegates);
            this.ProposalCountTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Council.ProposalCount", storageDataProvider, storageChangeDelegates);
            this.MembersTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>>("Council.Members", storageDataProvider, storageChangeDelegates);
            this.PrimeTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>("Council.Prime", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _proposalsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT13> ProposalsTypedStorage
        {
            get
            {
                return _proposalsTypedStorage;
            }
            set
            {
                _proposalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall> ProposalOfTypedStorage
        {
            get
            {
                return _proposalOfTypedStorage;
            }
            set
            {
                _proposalOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votingTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes> VotingTypedStorage
        {
            get
            {
                return _votingTypedStorage;
            }
            set
            {
                _votingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proposalCountTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ProposalCountTypedStorage
        {
            get
            {
                return _proposalCountTypedStorage;
            }
            set
            {
                _proposalCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>> MembersTypedStorage
        {
            get
            {
                return _membersTypedStorage;
            }
            set
            {
                _membersTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _primeTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> PrimeTypedStorage
        {
            get
            {
                return _primeTypedStorage;
            }
            set
            {
                _primeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await ProposalsTypedStorage.InitializeAsync("Council", "Proposals");
            await ProposalOfTypedStorage.InitializeAsync("Council", "ProposalOf");
            await VotingTypedStorage.InitializeAsync("Council", "Voting");
            await ProposalCountTypedStorage.InitializeAsync("Council", "ProposalCount");
            await MembersTypedStorage.InitializeAsync("Council", "Members");
            await PrimeTypedStorage.InitializeAsync("Council", "Prime");
        }
        
        /// <summary>
        /// Implements any storage change for Council.Proposals
        /// </summary>
        [StorageChange("Council", "Proposals")]
        public void OnUpdateProposals(string data)
        {
            ProposalsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Proposals
        ///  The hashes of the active proposals.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT13 GetProposals()
        {
            return ProposalsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Council.ProposalOf
        /// </summary>
        [StorageChange("Council", "ProposalOf")]
        public void OnUpdateProposalOf(string key, string data)
        {
            ProposalOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ProposalOf
        ///  Actual proposal for a given hash, if it's current.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall GetProposalOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProposalOfTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Council.Voting
        /// </summary>
        [StorageChange("Council", "Voting")]
        public void OnUpdateVoting(string key, string data)
        {
            VotingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes GetVoting(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotingTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_collective.Votes result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Council.ProposalCount
        /// </summary>
        [StorageChange("Council", "ProposalCount")]
        public void OnUpdateProposalCount(string data)
        {
            ProposalCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ProposalCount
        ///  Proposals so far.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetProposalCount()
        {
            return ProposalCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Council.Members
        /// </summary>
        [StorageChange("Council", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective. This is stored sorted (just by value).
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Council.Prime
        /// </summary>
        [StorageChange("Council", "Prime")]
        public void OnUpdatePrime(string data)
        {
            PrimeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Prime
        ///  The prime member that helps determine the default vote behavior in case of absentations.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetPrime()
        {
            return PrimeTypedStorage.Get();
        }
    }
}

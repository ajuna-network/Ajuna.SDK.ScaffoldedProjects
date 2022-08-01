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
    /// IElectionsStorage interface definition.
    /// </summary>
    public interface IElectionsStorage : IStorage
    {
        
        /// <summary>
        /// >> Members
        ///  The current elected members.
        /// 
        ///  Invariant: Always sorted based on account id.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder> GetMembers();
        
        /// <summary>
        /// >> RunnersUp
        ///  The current reserved runners-up.
        /// 
        ///  Invariant: Always sorted based on rank (worse to best). Upon removal of a member, the
        ///  last (i.e. _best_) runner-up will be replaced.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder> GetRunnersUp();
        
        /// <summary>
        /// >> Candidates
        ///  The present candidate list. A current member or runner-up can never enter this vector
        ///  and is always implicitly assumed to be a candidate.
        /// 
        ///  Second element is the deposit.
        /// 
        ///  Invariant: Always sorted based on account id.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>> GetCandidates();
        
        /// <summary>
        /// >> ElectionRounds
        ///  The total number of vote rounds that have happened, excluding the upcoming one.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetElectionRounds();
        
        /// <summary>
        /// >> Voting
        ///  Votes and locked stake of a particular voter.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId` is a crypto hash.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter GetVoting(string key);
    }
    
    /// <summary>
    /// ElectionsStorage class definition.
    /// </summary>
    public sealed class ElectionsStorage : IElectionsStorage
    {
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>> _membersTypedStorage;
        
        /// <summary>
        /// _runnersUpTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>> _runnersUpTypedStorage;
        
        /// <summary>
        /// _candidatesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>> _candidatesTypedStorage;
        
        /// <summary>
        /// _electionRoundsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _electionRoundsTypedStorage;
        
        /// <summary>
        /// _votingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter> _votingTypedStorage;
        
        /// <summary>
        /// ElectionsStorage constructor.
        /// </summary>
        public ElectionsStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MembersTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>>("Elections.Members", storageDataProvider, storageChangeDelegates);
            this.RunnersUpTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>>("Elections.RunnersUp", storageDataProvider, storageChangeDelegates);
            this.CandidatesTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>>("Elections.Candidates", storageDataProvider, storageChangeDelegates);
            this.ElectionRoundsTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Elections.ElectionRounds", storageDataProvider, storageChangeDelegates);
            this.VotingTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter>("Elections.Voting", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>> MembersTypedStorage
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
        /// _runnersUpTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder>> RunnersUpTypedStorage
        {
            get
            {
                return _runnersUpTypedStorage;
            }
            set
            {
                _runnersUpTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _candidatesTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>> CandidatesTypedStorage
        {
            get
            {
                return _candidatesTypedStorage;
            }
            set
            {
                _candidatesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _electionRoundsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ElectionRoundsTypedStorage
        {
            get
            {
                return _electionRoundsTypedStorage;
            }
            set
            {
                _electionRoundsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votingTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter> VotingTypedStorage
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
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MembersTypedStorage.InitializeAsync("Elections", "Members");
            await RunnersUpTypedStorage.InitializeAsync("Elections", "RunnersUp");
            await CandidatesTypedStorage.InitializeAsync("Elections", "Candidates");
            await ElectionRoundsTypedStorage.InitializeAsync("Elections", "ElectionRounds");
            await VotingTypedStorage.InitializeAsync("Elections", "Voting");
        }
        
        /// <summary>
        /// Implements any storage change for Elections.Members
        /// </summary>
        [StorageChange("Elections", "Members")]
        public void OnUpdateMembers(string data)
        {
            MembersTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Members
        ///  The current elected members.
        /// 
        ///  Invariant: Always sorted based on account id.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder> GetMembers()
        {
            return MembersTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Elections.RunnersUp
        /// </summary>
        [StorageChange("Elections", "RunnersUp")]
        public void OnUpdateRunnersUp(string data)
        {
            RunnersUpTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> RunnersUp
        ///  The current reserved runners-up.
        /// 
        ///  Invariant: Always sorted based on rank (worse to best). Upon removal of a member, the
        ///  last (i.e. _best_) runner-up will be replaced.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.SeatHolder> GetRunnersUp()
        {
            return RunnersUpTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Elections.Candidates
        /// </summary>
        [StorageChange("Elections", "Candidates")]
        public void OnUpdateCandidates(string data)
        {
            CandidatesTypedStorage.Update(data);
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
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>> GetCandidates()
        {
            return CandidatesTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Elections.ElectionRounds
        /// </summary>
        [StorageChange("Elections", "ElectionRounds")]
        public void OnUpdateElectionRounds(string data)
        {
            ElectionRoundsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ElectionRounds
        ///  The total number of vote rounds that have happened, excluding the upcoming one.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetElectionRounds()
        {
            return ElectionRoundsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Elections.Voting
        /// </summary>
        [StorageChange("Elections", "Voting")]
        public void OnUpdateVoting(string key, string data)
        {
            VotingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes and locked stake of a particular voter.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId` is a crypto hash.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter GetVoting(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotingTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen.Voter result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}

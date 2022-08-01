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
    /// IAllianceStorage interface definition.
    /// </summary>
    public interface IAllianceStorage : IStorage
    {
        
        /// <summary>
        /// >> Rule
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Cid GetRule();
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT39 GetAnnouncements();
        
        /// <summary>
        /// >> DepositOf
        ///  Maps members to their candidacy deposit.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetDepositOf(string key);
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT40 GetMembers(string key);
        
        /// <summary>
        /// >> UpForKicking
        ///  A set of members that are (potentially) being kicked out. They cannot retire until the
        ///  motion is settled.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetUpForKicking(string key);
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT41 GetUnscrupulousAccounts();
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT42 GetUnscrupulousWebsites();
    }
    
    /// <summary>
    /// AllianceStorage class definition.
    /// </summary>
    public sealed class AllianceStorage : IAllianceStorage
    {
        
        /// <summary>
        /// _ruleTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Cid> _ruleTypedStorage;
        
        /// <summary>
        /// _announcementsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT39> _announcementsTypedStorage;
        
        /// <summary>
        /// _depositOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _depositOfTypedStorage;
        
        /// <summary>
        /// _membersTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT40> _membersTypedStorage;
        
        /// <summary>
        /// _upForKickingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _upForKickingTypedStorage;
        
        /// <summary>
        /// _unscrupulousAccountsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT41> _unscrupulousAccountsTypedStorage;
        
        /// <summary>
        /// _unscrupulousWebsitesTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT42> _unscrupulousWebsitesTypedStorage;
        
        /// <summary>
        /// AllianceStorage constructor.
        /// </summary>
        public AllianceStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.RuleTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Cid>("Alliance.Rule", storageDataProvider, storageChangeDelegates);
            this.AnnouncementsTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT39>("Alliance.Announcements", storageDataProvider, storageChangeDelegates);
            this.DepositOfTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("Alliance.DepositOf", storageDataProvider, storageChangeDelegates);
            this.MembersTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT40>("Alliance.Members", storageDataProvider, storageChangeDelegates);
            this.UpForKickingTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("Alliance.UpForKicking", storageDataProvider, storageChangeDelegates);
            this.UnscrupulousAccountsTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT41>("Alliance.UnscrupulousAccounts", storageDataProvider, storageChangeDelegates);
            this.UnscrupulousWebsitesTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT42>("Alliance.UnscrupulousWebsites", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _ruleTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Cid> RuleTypedStorage
        {
            get
            {
                return _ruleTypedStorage;
            }
            set
            {
                _ruleTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _announcementsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT39> AnnouncementsTypedStorage
        {
            get
            {
                return _announcementsTypedStorage;
            }
            set
            {
                _announcementsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _depositOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> DepositOfTypedStorage
        {
            get
            {
                return _depositOfTypedStorage;
            }
            set
            {
                _depositOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _membersTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT40> MembersTypedStorage
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
        /// _upForKickingTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> UpForKickingTypedStorage
        {
            get
            {
                return _upForKickingTypedStorage;
            }
            set
            {
                _upForKickingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _unscrupulousAccountsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT41> UnscrupulousAccountsTypedStorage
        {
            get
            {
                return _unscrupulousAccountsTypedStorage;
            }
            set
            {
                _unscrupulousAccountsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _unscrupulousWebsitesTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT42> UnscrupulousWebsitesTypedStorage
        {
            get
            {
                return _unscrupulousWebsitesTypedStorage;
            }
            set
            {
                _unscrupulousWebsitesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await RuleTypedStorage.InitializeAsync("Alliance", "Rule");
            await AnnouncementsTypedStorage.InitializeAsync("Alliance", "Announcements");
            await DepositOfTypedStorage.InitializeAsync("Alliance", "DepositOf");
            await MembersTypedStorage.InitializeAsync("Alliance", "Members");
            await UpForKickingTypedStorage.InitializeAsync("Alliance", "UpForKicking");
            await UnscrupulousAccountsTypedStorage.InitializeAsync("Alliance", "UnscrupulousAccounts");
            await UnscrupulousWebsitesTypedStorage.InitializeAsync("Alliance", "UnscrupulousWebsites");
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.Rule
        /// </summary>
        [StorageChange("Alliance", "Rule")]
        public void OnUpdateRule(string data)
        {
            RuleTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Rule
        ///  The IPFS CID of the alliance rule.
        ///  Founders and fellows can propose a new rule with a super-majority.
        /// 
        ///  Any founder has a special one-vote veto right to the rule setting.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Cid GetRule()
        {
            return RuleTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.Announcements
        /// </summary>
        [StorageChange("Alliance", "Announcements")]
        public void OnUpdateAnnouncements(string data)
        {
            AnnouncementsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Announcements
        ///  The current IPFS CIDs of any announcements.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT39 GetAnnouncements()
        {
            return AnnouncementsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.DepositOf
        /// </summary>
        [StorageChange("Alliance", "DepositOf")]
        public void OnUpdateDepositOf(string key, string data)
        {
            DepositOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Maps members to their candidacy deposit.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetDepositOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DepositOfTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.Members
        /// </summary>
        [StorageChange("Alliance", "Members")]
        public void OnUpdateMembers(string key, string data)
        {
            MembersTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Members
        ///  Maps member type to members of each type.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT40 GetMembers(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MembersTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT40 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.UpForKicking
        /// </summary>
        [StorageChange("Alliance", "UpForKicking")]
        public void OnUpdateUpForKicking(string key, string data)
        {
            UpForKickingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> UpForKicking
        ///  A set of members that are (potentially) being kicked out. They cannot retire until the
        ///  motion is settled.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetUpForKicking(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (UpForKickingTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.UnscrupulousAccounts
        /// </summary>
        [StorageChange("Alliance", "UnscrupulousAccounts")]
        public void OnUpdateUnscrupulousAccounts(string data)
        {
            UnscrupulousAccountsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> UnscrupulousAccounts
        ///  The current list of accounts deemed unscrupulous. These accounts non grata cannot submit
        ///  candidacy.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT41 GetUnscrupulousAccounts()
        {
            return UnscrupulousAccountsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Alliance.UnscrupulousWebsites
        /// </summary>
        [StorageChange("Alliance", "UnscrupulousWebsites")]
        public void OnUpdateUnscrupulousWebsites(string data)
        {
            UnscrupulousWebsitesTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> UnscrupulousWebsites
        ///  The current list of websites deemed unscrupulous.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT42 GetUnscrupulousWebsites()
        {
            return UnscrupulousWebsitesTypedStorage.Get();
        }
    }
}

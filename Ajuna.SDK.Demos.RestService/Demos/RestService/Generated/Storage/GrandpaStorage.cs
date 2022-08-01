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
    /// IGrandpaStorage interface definition.
    /// </summary>
    public interface IGrandpaStorage : IStorage
    {
        
        /// <summary>
        /// >> State
        ///  State of the current authority set.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.EnumStoredState GetState();
        
        /// <summary>
        /// >> PendingChange
        ///  Pending change: (signaled at, scheduled change).
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.StoredPendingChange GetPendingChange();
        
        /// <summary>
        /// >> NextForced
        ///  next block number where we can force a change.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetNextForced();
        
        /// <summary>
        /// >> Stalled
        ///  `true` if we are currently stalled.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetStalled();
        
        /// <summary>
        /// >> CurrentSetId
        ///  The number of changes (both in terms of keys and underlying economic responsibilities)
        ///  in the "set" of Grandpa validators from genesis.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U64 GetCurrentSetId();
        
        /// <summary>
        /// >> SetIdSession
        ///  A mapping from grandpa set ID to the index of the *most recent* session for which its
        ///  members were responsible.
        /// 
        ///  TWOX-NOTE: `SetId` is not under user control.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetSetIdSession(string key);
    }
    
    /// <summary>
    /// GrandpaStorage class definition.
    /// </summary>
    public sealed class GrandpaStorage : IGrandpaStorage
    {
        
        /// <summary>
        /// _stateTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.EnumStoredState> _stateTypedStorage;
        
        /// <summary>
        /// _pendingChangeTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.StoredPendingChange> _pendingChangeTypedStorage;
        
        /// <summary>
        /// _nextForcedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _nextForcedTypedStorage;
        
        /// <summary>
        /// _stalledTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> _stalledTypedStorage;
        
        /// <summary>
        /// _currentSetIdTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64> _currentSetIdTypedStorage;
        
        /// <summary>
        /// _setIdSessionTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _setIdSessionTypedStorage;
        
        /// <summary>
        /// GrandpaStorage constructor.
        /// </summary>
        public GrandpaStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.StateTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.EnumStoredState>("Grandpa.State", storageDataProvider, storageChangeDelegates);
            this.PendingChangeTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.StoredPendingChange>("Grandpa.PendingChange", storageDataProvider, storageChangeDelegates);
            this.NextForcedTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Grandpa.NextForced", storageDataProvider, storageChangeDelegates);
            this.StalledTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>("Grandpa.Stalled", storageDataProvider, storageChangeDelegates);
            this.CurrentSetIdTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64>("Grandpa.CurrentSetId", storageDataProvider, storageChangeDelegates);
            this.SetIdSessionTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Grandpa.SetIdSession", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _stateTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.EnumStoredState> StateTypedStorage
        {
            get
            {
                return _stateTypedStorage;
            }
            set
            {
                _stateTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _pendingChangeTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.StoredPendingChange> PendingChangeTypedStorage
        {
            get
            {
                return _pendingChangeTypedStorage;
            }
            set
            {
                _pendingChangeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextForcedTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> NextForcedTypedStorage
        {
            get
            {
                return _nextForcedTypedStorage;
            }
            set
            {
                _nextForcedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _stalledTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> StalledTypedStorage
        {
            get
            {
                return _stalledTypedStorage;
            }
            set
            {
                _stalledTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _currentSetIdTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U64> CurrentSetIdTypedStorage
        {
            get
            {
                return _currentSetIdTypedStorage;
            }
            set
            {
                _currentSetIdTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _setIdSessionTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U32> SetIdSessionTypedStorage
        {
            get
            {
                return _setIdSessionTypedStorage;
            }
            set
            {
                _setIdSessionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await StateTypedStorage.InitializeAsync("Grandpa", "State");
            await PendingChangeTypedStorage.InitializeAsync("Grandpa", "PendingChange");
            await NextForcedTypedStorage.InitializeAsync("Grandpa", "NextForced");
            await StalledTypedStorage.InitializeAsync("Grandpa", "Stalled");
            await CurrentSetIdTypedStorage.InitializeAsync("Grandpa", "CurrentSetId");
            await SetIdSessionTypedStorage.InitializeAsync("Grandpa", "SetIdSession");
        }
        
        /// <summary>
        /// Implements any storage change for Grandpa.State
        /// </summary>
        [StorageChange("Grandpa", "State")]
        public void OnUpdateState(string data)
        {
            StateTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> State
        ///  State of the current authority set.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.EnumStoredState GetState()
        {
            return StateTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Grandpa.PendingChange
        /// </summary>
        [StorageChange("Grandpa", "PendingChange")]
        public void OnUpdatePendingChange(string data)
        {
            PendingChangeTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PendingChange
        ///  Pending change: (signaled at, scheduled change).
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_grandpa.StoredPendingChange GetPendingChange()
        {
            return PendingChangeTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Grandpa.NextForced
        /// </summary>
        [StorageChange("Grandpa", "NextForced")]
        public void OnUpdateNextForced(string data)
        {
            NextForcedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextForced
        ///  next block number where we can force a change.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetNextForced()
        {
            return NextForcedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Grandpa.Stalled
        /// </summary>
        [StorageChange("Grandpa", "Stalled")]
        public void OnUpdateStalled(string data)
        {
            StalledTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Stalled
        ///  `true` if we are currently stalled.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetStalled()
        {
            return StalledTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Grandpa.CurrentSetId
        /// </summary>
        [StorageChange("Grandpa", "CurrentSetId")]
        public void OnUpdateCurrentSetId(string data)
        {
            CurrentSetIdTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CurrentSetId
        ///  The number of changes (both in terms of keys and underlying economic responsibilities)
        ///  in the "set" of Grandpa validators from genesis.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U64 GetCurrentSetId()
        {
            return CurrentSetIdTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Grandpa.SetIdSession
        /// </summary>
        [StorageChange("Grandpa", "SetIdSession")]
        public void OnUpdateSetIdSession(string key, string data)
        {
            SetIdSessionTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> SetIdSession
        ///  A mapping from grandpa set ID to the index of the *most recent* session for which its
        ///  members were responsible.
        /// 
        ///  TWOX-NOTE: `SetId` is not under user control.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetSetIdSession(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (SetIdSessionTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U32 result))
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

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
    /// IGiltStorage interface definition.
    /// </summary>
    public interface IGiltStorage : IStorage
    {
        
        /// <summary>
        /// >> QueueTotals
        ///  The totals of items and balances within each queue. Saves a lot of storage reads in the
        ///  case of sparsely packed queues.
        /// 
        ///  The vector is indexed by duration in `Period`s, offset by one, so information on the queue
        ///  whose duration is one `Period` would be storage `0`.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT32 GetQueueTotals();
        
        /// <summary>
        /// >> Queues
        ///  The queues of bids ready to become gilts. Indexed by duration (in `Period`s).
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT33 GetQueues(string key);
        
        /// <summary>
        /// >> ActiveTotal
        ///  Information relating to the gilts currently active.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGiltsTotal GetActiveTotal();
        
        /// <summary>
        /// >> Active
        ///  The currently active gilts, indexed according to the order of creation.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt GetActive(string key);
    }
    
    /// <summary>
    /// GiltStorage class definition.
    /// </summary>
    public sealed class GiltStorage : IGiltStorage
    {
        
        /// <summary>
        /// _queueTotalsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT32> _queueTotalsTypedStorage;
        
        /// <summary>
        /// _queuesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT33> _queuesTypedStorage;
        
        /// <summary>
        /// _activeTotalTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGiltsTotal> _activeTotalTypedStorage;
        
        /// <summary>
        /// _activeTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt> _activeTypedStorage;
        
        /// <summary>
        /// GiltStorage constructor.
        /// </summary>
        public GiltStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.QueueTotalsTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT32>("Gilt.QueueTotals", storageDataProvider, storageChangeDelegates);
            this.QueuesTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT33>("Gilt.Queues", storageDataProvider, storageChangeDelegates);
            this.ActiveTotalTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGiltsTotal>("Gilt.ActiveTotal", storageDataProvider, storageChangeDelegates);
            this.ActiveTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt>("Gilt.Active", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _queueTotalsTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT32> QueueTotalsTypedStorage
        {
            get
            {
                return _queueTotalsTypedStorage;
            }
            set
            {
                _queueTotalsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queuesTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT33> QueuesTypedStorage
        {
            get
            {
                return _queuesTypedStorage;
            }
            set
            {
                _queuesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _activeTotalTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGiltsTotal> ActiveTotalTypedStorage
        {
            get
            {
                return _activeTotalTypedStorage;
            }
            set
            {
                _activeTotalTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _activeTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt> ActiveTypedStorage
        {
            get
            {
                return _activeTypedStorage;
            }
            set
            {
                _activeTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await QueueTotalsTypedStorage.InitializeAsync("Gilt", "QueueTotals");
            await QueuesTypedStorage.InitializeAsync("Gilt", "Queues");
            await ActiveTotalTypedStorage.InitializeAsync("Gilt", "ActiveTotal");
            await ActiveTypedStorage.InitializeAsync("Gilt", "Active");
        }
        
        /// <summary>
        /// Implements any storage change for Gilt.QueueTotals
        /// </summary>
        [StorageChange("Gilt", "QueueTotals")]
        public void OnUpdateQueueTotals(string data)
        {
            QueueTotalsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> QueueTotals
        ///  The totals of items and balances within each queue. Saves a lot of storage reads in the
        ///  case of sparsely packed queues.
        /// 
        ///  The vector is indexed by duration in `Period`s, offset by one, so information on the queue
        ///  whose duration is one `Period` would be storage `0`.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT32 GetQueueTotals()
        {
            return QueueTotalsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Gilt.Queues
        /// </summary>
        [StorageChange("Gilt", "Queues")]
        public void OnUpdateQueues(string key, string data)
        {
            QueuesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Queues
        ///  The queues of bids ready to become gilts. Indexed by duration (in `Period`s).
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT33 GetQueues(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (QueuesTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT33 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Gilt.ActiveTotal
        /// </summary>
        [StorageChange("Gilt", "ActiveTotal")]
        public void OnUpdateActiveTotal(string data)
        {
            ActiveTotalTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ActiveTotal
        ///  Information relating to the gilts currently active.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGiltsTotal GetActiveTotal()
        {
            return ActiveTotalTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Gilt.Active
        /// </summary>
        [StorageChange("Gilt", "Active")]
        public void OnUpdateActive(string key, string data)
        {
            ActiveTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Active
        ///  The currently active gilts, indexed according to the order of creation.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt GetActive(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ActiveTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet.ActiveGilt result))
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

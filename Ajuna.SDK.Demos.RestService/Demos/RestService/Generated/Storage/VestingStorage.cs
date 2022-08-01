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
    /// IVestingStorage interface definition.
    /// </summary>
    public interface IVestingStorage : IStorage
    {
        
        /// <summary>
        /// >> Vesting
        ///  Information regarding the vesting of a given account.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT26 GetVesting(string key);
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with latest version, as determined by the genesis build.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_vesting.EnumReleases GetStorageVersion();
    }
    
    /// <summary>
    /// VestingStorage class definition.
    /// </summary>
    public sealed class VestingStorage : IVestingStorage
    {
        
        /// <summary>
        /// _vestingTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT26> _vestingTypedStorage;
        
        /// <summary>
        /// _storageVersionTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_vesting.EnumReleases> _storageVersionTypedStorage;
        
        /// <summary>
        /// VestingStorage constructor.
        /// </summary>
        public VestingStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.VestingTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT26>("Vesting.Vesting", storageDataProvider, storageChangeDelegates);
            this.StorageVersionTypedStorage = new TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_vesting.EnumReleases>("Vesting.StorageVersion", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _vestingTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT26> VestingTypedStorage
        {
            get
            {
                return _vestingTypedStorage;
            }
            set
            {
                _vestingTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _storageVersionTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_vesting.EnumReleases> StorageVersionTypedStorage
        {
            get
            {
                return _storageVersionTypedStorage;
            }
            set
            {
                _storageVersionTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await VestingTypedStorage.InitializeAsync("Vesting", "Vesting");
            await StorageVersionTypedStorage.InitializeAsync("Vesting", "StorageVersion");
        }
        
        /// <summary>
        /// Implements any storage change for Vesting.Vesting
        /// </summary>
        [StorageChange("Vesting", "Vesting")]
        public void OnUpdateVesting(string key, string data)
        {
            VestingTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Vesting
        ///  Information regarding the vesting of a given account.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT26 GetVesting(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VestingTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT26 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Vesting.StorageVersion
        /// </summary>
        [StorageChange("Vesting", "StorageVersion")]
        public void OnUpdateStorageVersion(string data)
        {
            StorageVersionTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with latest version, as determined by the genesis build.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_vesting.EnumReleases GetStorageVersion()
        {
            return StorageVersionTypedStorage.Get();
        }
    }
}

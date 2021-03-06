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
    /// IMultisigStorage interface definition.
    /// </summary>
    public interface IMultisigStorage : IStorage
    {
        
        /// <summary>
        /// >> Multisigs
        ///  The set of open multisig operations.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_multisig.Multisig GetMultisigs(string key);
        
        /// <summary>
        /// >> Calls
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc.WrapperKeepOpaque, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> GetCalls(string key);
    }
    
    /// <summary>
    /// MultisigStorage class definition.
    /// </summary>
    public sealed class MultisigStorage : IMultisigStorage
    {
        
        /// <summary>
        /// _multisigsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_multisig.Multisig> _multisigsTypedStorage;
        
        /// <summary>
        /// _callsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc.WrapperKeepOpaque, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>> _callsTypedStorage;
        
        /// <summary>
        /// MultisigStorage constructor.
        /// </summary>
        public MultisigStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.MultisigsTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_multisig.Multisig>("Multisig.Multisigs", storageDataProvider, storageChangeDelegates);
            this.CallsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc.WrapperKeepOpaque, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>("Multisig.Calls", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _multisigsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_multisig.Multisig> MultisigsTypedStorage
        {
            get
            {
                return _multisigsTypedStorage;
            }
            set
            {
                _multisigsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _callsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc.WrapperKeepOpaque, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>> CallsTypedStorage
        {
            get
            {
                return _callsTypedStorage;
            }
            set
            {
                _callsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await MultisigsTypedStorage.InitializeAsync("Multisig", "Multisigs");
            await CallsTypedStorage.InitializeAsync("Multisig", "Calls");
        }
        
        /// <summary>
        /// Implements any storage change for Multisig.Multisigs
        /// </summary>
        [StorageChange("Multisig", "Multisigs")]
        public void OnUpdateMultisigs(string key, string data)
        {
            MultisigsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Multisigs
        ///  The set of open multisig operations.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_multisig.Multisig GetMultisigs(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (MultisigsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_multisig.Multisig result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Multisig.Calls
        /// </summary>
        [StorageChange("Multisig", "Calls")]
        public void OnUpdateCalls(string key, string data)
        {
            CallsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Calls
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc.WrapperKeepOpaque, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> GetCalls(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CallsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc.WrapperKeepOpaque, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128> result))
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

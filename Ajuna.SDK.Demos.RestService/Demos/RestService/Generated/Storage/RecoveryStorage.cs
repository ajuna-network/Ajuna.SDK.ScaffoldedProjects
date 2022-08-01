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
    /// IRecoveryStorage interface definition.
    /// </summary>
    public interface IRecoveryStorage : IStorage
    {
        
        /// <summary>
        /// >> Recoverable
        ///  The set of recoverable accounts and their recovery configuration.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.RecoveryConfig GetRecoverable(string key);
        
        /// <summary>
        /// >> ActiveRecoveries
        ///  Active recovery attempts.
        /// 
        ///  First account is the account to be recovered, and the second account
        ///  is the user trying to recover the account.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.ActiveRecovery GetActiveRecoveries(string key);
        
        /// <summary>
        /// >> Proxy
        ///  The list of allowed proxy accounts.
        /// 
        ///  Map from the user who can access it to the recovered account.
        /// </summary>
        Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetProxy(string key);
    }
    
    /// <summary>
    /// RecoveryStorage class definition.
    /// </summary>
    public sealed class RecoveryStorage : IRecoveryStorage
    {
        
        /// <summary>
        /// _recoverableTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.RecoveryConfig> _recoverableTypedStorage;
        
        /// <summary>
        /// _activeRecoveriesTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.ActiveRecovery> _activeRecoveriesTypedStorage;
        
        /// <summary>
        /// _proxyTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> _proxyTypedStorage;
        
        /// <summary>
        /// RecoveryStorage constructor.
        /// </summary>
        public RecoveryStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.RecoverableTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.RecoveryConfig>("Recovery.Recoverable", storageDataProvider, storageChangeDelegates);
            this.ActiveRecoveriesTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.ActiveRecovery>("Recovery.ActiveRecoveries", storageDataProvider, storageChangeDelegates);
            this.ProxyTypedStorage = new TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>("Recovery.Proxy", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _recoverableTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.RecoveryConfig> RecoverableTypedStorage
        {
            get
            {
                return _recoverableTypedStorage;
            }
            set
            {
                _recoverableTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _activeRecoveriesTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.ActiveRecovery> ActiveRecoveriesTypedStorage
        {
            get
            {
                return _activeRecoveriesTypedStorage;
            }
            set
            {
                _activeRecoveriesTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _proxyTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> ProxyTypedStorage
        {
            get
            {
                return _proxyTypedStorage;
            }
            set
            {
                _proxyTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await RecoverableTypedStorage.InitializeAsync("Recovery", "Recoverable");
            await ActiveRecoveriesTypedStorage.InitializeAsync("Recovery", "ActiveRecoveries");
            await ProxyTypedStorage.InitializeAsync("Recovery", "Proxy");
        }
        
        /// <summary>
        /// Implements any storage change for Recovery.Recoverable
        /// </summary>
        [StorageChange("Recovery", "Recoverable")]
        public void OnUpdateRecoverable(string key, string data)
        {
            RecoverableTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Recoverable
        ///  The set of recoverable accounts and their recovery configuration.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.RecoveryConfig GetRecoverable(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (RecoverableTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.RecoveryConfig result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Recovery.ActiveRecoveries
        /// </summary>
        [StorageChange("Recovery", "ActiveRecoveries")]
        public void OnUpdateActiveRecoveries(string key, string data)
        {
            ActiveRecoveriesTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ActiveRecoveries
        ///  Active recovery attempts.
        /// 
        ///  First account is the account to be recovered, and the second account
        ///  is the user trying to recover the account.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.ActiveRecovery GetActiveRecoveries(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ActiveRecoveriesTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_recovery.ActiveRecovery result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Recovery.Proxy
        /// </summary>
        [StorageChange("Recovery", "Proxy")]
        public void OnUpdateProxy(string key, string data)
        {
            ProxyTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Proxy
        ///  The list of allowed proxy accounts.
        /// 
        ///  Map from the user who can access it to the recovered account.
        /// </summary>
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetProxy(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ProxyTypedStorage.Dictionary.TryGetValue(key, out Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 result))
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

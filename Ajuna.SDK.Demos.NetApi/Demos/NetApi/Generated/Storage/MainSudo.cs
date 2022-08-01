//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.NetApi.Generated.Storage
{
    
    
    public sealed class SudoStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SudoStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Sudo", "Key"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> KeyParams
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public static string KeyParams()
        {
            return RequestGenerator.GetStorage("Sudo", "Key", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public async Task<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> Key(CancellationToken token)
        {
            string parameters = SudoStorage.KeyParams();
            return await _client.GetStorageAsync<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
        }
    }
    
    public sealed class SudoCalls
    {
        
        /// <summary>
        /// >> sudo
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Sudo(Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(20, "Sudo", 0, "sudo", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_unchecked_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SudoUncheckedWeight(Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall call, Ajuna.NetApi.Model.Types.Primitive.U64 weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(weight.Encode());
            return new Method(20, "Sudo", 1, "sudo_unchecked_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_key
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetKey(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(20, "Sudo", 2, "set_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_as
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SudoAs(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(20, "Sudo", 3, "sudo_as", byteArray.ToArray());
        }
    }
    
    public enum SudoErrors
    {
        
        /// <summary>
        /// >> RequireSudo
        /// Sender must be the Sudo account
        /// </summary>
        RequireSudo,
    }
}

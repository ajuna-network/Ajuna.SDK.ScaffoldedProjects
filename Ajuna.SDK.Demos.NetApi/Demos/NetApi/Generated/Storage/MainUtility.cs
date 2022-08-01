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
    
    
    public sealed class UtilityStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public UtilityStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    public sealed class UtilityCalls
    {
        
        /// <summary>
        /// >> batch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Batch(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(1, "Utility", 0, "batch", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> as_derivative
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AsDerivative(Ajuna.NetApi.Model.Types.Primitive.U16 index, Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(index.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(1, "Utility", 1, "as_derivative", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> batch_all
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method BatchAll(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(1, "Utility", 2, "batch_all", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> dispatch_as
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DispatchAs(Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumOriginCaller as_origin, Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(as_origin.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(1, "Utility", 3, "dispatch_as", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_batch
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceBatch(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumCall> calls)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(calls.Encode());
            return new Method(1, "Utility", 4, "force_batch", byteArray.ToArray());
        }
    }
    
    public enum UtilityErrors
    {
        
        /// <summary>
        /// >> TooManyCalls
        /// Too many calls batched.
        /// </summary>
        TooManyCalls,
    }
}

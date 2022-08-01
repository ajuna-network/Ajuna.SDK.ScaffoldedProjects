//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.offchain
{
    
    
    /// <summary>
    /// >> 269 - Composite[sp_core.offchain.OpaqueNetworkState]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class OpaqueNetworkState : BaseType
    {
        
        /// <summary>
        /// >> peer_id
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.OpaquePeerId _peerId;
        
        /// <summary>
        /// >> external_addresses
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.offchain.OpaqueMultiaddr> _externalAddresses;
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.OpaquePeerId PeerId
        {
            get
            {
                return this._peerId;
            }
            set
            {
                this._peerId = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.offchain.OpaqueMultiaddr> ExternalAddresses
        {
            get
            {
                return this._externalAddresses;
            }
            set
            {
                this._externalAddresses = value;
            }
        }
        
        public override string TypeName()
        {
            return "OpaqueNetworkState";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PeerId.Encode());
            result.AddRange(ExternalAddresses.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PeerId = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.OpaquePeerId();
            PeerId.Decode(byteArray, ref p);
            ExternalAddresses = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.offchain.OpaqueMultiaddr>();
            ExternalAddresses.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

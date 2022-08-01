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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types
{
    
    
    /// <summary>
    /// >> 117 - Composite[pallet_alliance.types.Cid]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Cid : BaseType
    {
        
        /// <summary>
        /// >> version
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.EnumVersion _version;
        
        /// <summary>
        /// >> codec
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _codec;
        
        /// <summary>
        /// >> hash
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Multihash _hash;
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.EnumVersion Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Codec
        {
            get
            {
                return this._codec;
            }
            set
            {
                this._codec = value;
            }
        }
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Multihash Hash
        {
            get
            {
                return this._hash;
            }
            set
            {
                this._hash = value;
            }
        }
        
        public override string TypeName()
        {
            return "Cid";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Version.Encode());
            result.AddRange(Codec.Encode());
            result.AddRange(Hash.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Version = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.EnumVersion();
            Version.Decode(byteArray, ref p);
            Codec = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Codec.Decode(byteArray, ref p);
            Hash = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_alliance.types.Multihash();
            Hash.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

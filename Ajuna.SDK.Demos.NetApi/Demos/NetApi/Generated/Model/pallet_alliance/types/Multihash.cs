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
    /// >> 119 - Composite[pallet_alliance.types.Multihash]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Multihash : BaseType
    {
        
        /// <summary>
        /// >> code
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _code;
        
        /// <summary>
        /// >> digest
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4 _digest;
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4 Digest
        {
            get
            {
                return this._digest;
            }
            set
            {
                this._digest = value;
            }
        }
        
        public override string TypeName()
        {
            return "Multihash";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Code.Encode());
            result.AddRange(Digest.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Code = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Code.Decode(byteArray, ref p);
            Digest = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT4();
            Digest.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}

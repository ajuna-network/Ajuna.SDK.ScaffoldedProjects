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
using Ajuna.SDK.Demos.NetApi.Generated.Model.SpConsensusAura;
using System.Collections.Generic;


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 70 - Composite[frame_support.storage.weak_bounded_vec.WeakBoundedVecT1]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class WeakBoundedVecT1 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.SpConsensusAura.Public> _value;
        
        public BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.SpConsensusAura.Public> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "WeakBoundedVecT1";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.SpConsensusAura.Public>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
